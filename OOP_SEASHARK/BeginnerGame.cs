using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    
    public partial class BeginnerGame : Form
    {
        private BeginnerLevel level = new BeginnerLevel();
        private GameManager gameManager = new GameManager();
        private int totalSeconds;
        private IQuiz currentQuiz = new BeginnerQuiz();
        private int correctAnswers = 0;
        public event Action TimeUpTriggered;
        private frmTimeUp timeUpForm;

        // These timers keep the game world moving and the clock ticking
        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer countdownTimer = new System.Windows.Forms.Timer();

        // Player movement
        private int playerX, playerY;
        private int velY = 0;
        private bool isGrounded = false;
        private bool moveLeft = false;
        private bool moveRight = false;

        // We'll use this to keep track of which obstacles the player has already cleared
        private bool[] obstacleCleared = { false, false, false };


        public BeginnerGame()
        {
            InitializeComponent();

            // This ensures our keyboard events trigger even if a button has focus
            this.KeyPreview = true;

            // Wire up keyboard events manually to make sure they're always connected
            this.KeyDown += BeginnerGame_KeyDown;
            this.KeyUp += BeginnerGame_KeyUp;

            // We'll disable TabStop so the buttons don't capture keyboard focus
            btnLeftBeginner.TabStop = false;
            btnRightBeginner.TabStop = false;
            btnUpBeginner.TabStop = false;

            // Add MouseLeave events so movement stops if you slide your mouse off the button
            btnLeftBeginner.MouseLeave += (s, ev) => { moveLeft = false; };
            btnRightBeginner.MouseLeave += (s, ev) => { moveRight = false; };


            gameManager.currentLvl = level;
            gameManager.StartGame();
            totalSeconds = (int)level.GetTimeLimit();
            GameState.KeysCollected = 0; // Reset keys for new game
            UpdateTimerLabel();
            SetupGame();
            timeUpForm = new frmTimeUp(this, "Beginner");
        }



        // SETUP
        private void SetupGame()
        {
            // Store starting position of fish
            playerX = picFishBeginner.Left;
            playerY = picFishBeginner.Top;

            // This is the heartbeat of our game - it runs physics and checks collisions every 20ms
            gameTimer.Interval = 20;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            // Countdown every second
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += Countdown_Tick;
            countdownTimer.Start();

        }

        // GAME LOOP
        private void GameLoop(object sender, EventArgs e)
        {
            MovePlayer();
            ApplyGravity();
            CheckObstacleCollision();
            CheckDoorReached();
        }

        // MOVEMENT
        private void MovePlayer()
        {
            if (moveLeft) playerX -= 5;
            if (moveRight) playerX += 5;

            // We've got to make sure our fish doesn't swim right out of the window!
            playerX = Math.Max(0, Math.Min(playerX, this.ClientSize.Width - picFishBeginner.Width));

            picFishBeginner.Left = playerX;
        }

        private void ApplyGravity()
        {
            isGrounded = false;
            velY += 2; // gravity pull down
            playerY += velY;

            // Check collision with each platform panel
            Panel[] platforms = { panel1, panel2, panel3 };
            foreach (Panel p in platforms)
            {
                Rectangle fishRect = new Rectangle(playerX, playerY,
                    picFishBeginner.Width, picFishBeginner.Height);
                Rectangle platRect = new Rectangle(p.Left, p.Top, p.Width, p.Height);

                if (fishRect.IntersectsWith(platRect) && velY > 0)
                {
                    playerY = p.Top - picFishBeginner.Height;
                    velY = 0;
                    isGrounded = true;
                }
            }

            // If they aren't on a platform, they'll eventually hit the sea floor
            int floorY = this.ClientSize.Height - picFishBeginner.Height;
            if (playerY >= floorY)
            {
                playerY = floorY;
                velY = 0;
                isGrounded = true;
            }

            picFishBeginner.Top = playerY;
        }

        // KEYBOARD CONTROLS
        private void BeginnerGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = true;
            if (e.KeyCode == Keys.Right) moveRight = true;
            if (e.KeyCode == Keys.Up && isGrounded) velY = -24;
        }

        private void BeginnerGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = false;
            if (e.KeyCode == Keys.Right) moveRight = false;
        }

        // BUTTON CONTROLS
        private void btnLeftBeginner_MouseDown(object sender, MouseEventArgs e)
        {
            moveLeft = true;
        }

        private void btnRightBeginner_MouseDown(object sender, MouseEventArgs e)
        {
            moveRight = true;
        }

        private void btnUpBeginner_Click(object sender, EventArgs e)
        {
            if (isGrounded) velY = -24; // jump
        }

        // Mouse up = stop moving (for on-screen buttons)
        private void btnLeftBeginner_MouseUp(object sender, MouseEventArgs e)
        {
            moveLeft = false;
        }

        private void btnRightBeginner_MouseUp(object sender, MouseEventArgs e)
        {
            moveRight = false;
        }

        // OBSTACLE COLLISION
        private void CheckObstacleCollision()
        {
            // Map each obstacle PictureBox to its index
            PictureBox[] obstacles = { picObstacle1, picObstacle2, picObstacle3 };

            for (int i = 0; i < obstacles.Length; i++)
            {
                if (!obstacleCleared[i] && obstacles[i].Visible)
                {
                    Rectangle fishRect = new Rectangle(playerX, playerY,
                        picFishBeginner.Width, picFishBeginner.Height);
                    Rectangle obsRect = new Rectangle(obstacles[i].Left, obstacles[i].Top,
                        obstacles[i].Width, obstacles[i].Height);

                    if (fishRect.IntersectsWith(obsRect))
                    {
                        // Time for a quick breather while the player answers the quiz
                        gameTimer.Stop();
                        countdownTimer.Stop();

                        // Open quiz for this obstacle
                        PopQuiz quiz = new PopQuiz(i, totalSeconds, currentQuiz);
                        quiz.ShowDialog();

                        // After quiz closes - increment if correct
                        if (quiz.AnsweredCorrectly)
                        {
                            correctAnswers++;
                        }
                        obstacles[i].Visible = false;
                        obstacleCleared[i] = true;

                        // Reset movement flags (dialog steals mouse focus,
                        // so MouseUp events are lost on the on-screen buttons)
                        moveLeft = false;
                        moveRight = false;


                        // Resume game
                        gameTimer.Start();
                        countdownTimer.Start();

                        // We only want to deal with one obstacle at a time to keep things smooth
                        return;
                    }
                }
            }
        }

        // DOOR = WIN 
        private void CheckDoorReached()
        {
            // Only allow door if all 3 obstacles cleared
            if (obstacleCleared[0] && obstacleCleared[1] && obstacleCleared[2])
            {
                Rectangle fishRect = new Rectangle(playerX, playerY,
                    picFishBeginner.Width, picFishBeginner.Height);
                Rectangle doorRect = new Rectangle(picDoorBeginner.Left, picDoorBeginner.Top,
                    picDoorBeginner.Width, picDoorBeginner.Height);

                if (fishRect.IntersectsWith(doorRect))
                {
                    gameTimer.Stop();
                    countdownTimer.Stop();
                    level.CompleteLevel();

                    // Persist completion state
                    GameState.BeginnerCompleted = true;
                    GameState.KeysCollected = correctAnswers;

                    BeginnerCompleteForm completed = new BeginnerCompleteForm(totalSeconds, correctAnswers);
                    completed.Show();
                    this.Close(); // Close instead of Hide to prevent leaking previous game instances
                }
            }
        }

        // COUNTDOWN TIMER
        private void Countdown_Tick(object sender, EventArgs e)
        {
            totalSeconds--;
            UpdateTimerLabel();

            if (totalSeconds <= 0)
            {
                countdownTimer.Stop();
                gameTimer.Stop();

                frmTimeUp timeUp = new frmTimeUp(this, "Beginner");
                timeUp.Show();
                this.Hide();
            }
        }

        private void UpdateTimerLabel()
        {
            int mins = totalSeconds / 60;
            int secs = totalSeconds % 60;
            lblTimer.Text = $"{mins:D2}:{secs:D2}";
        }


        // These are just some empty event handlers we don't need right now

        private void BeginnerGame_Load(object sender, EventArgs e) { }
        private void picDoorBeginner_Click(object sender, EventArgs e) { }
        private void picAnchor_Click(object sender, EventArgs e) { }
        private void picRock_Click(object sender, EventArgs e) { }
        private void picCoral_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void picFishBeginner_Click(object sender, EventArgs e) { }
        private void lblTimer_Click(object sender, EventArgs e) { }

        // DEBUG ONLY — simulates completing the level instantly
        private void btnDebugComplete_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            countdownTimer.Stop();
            level.CompleteLevel();

            GameState.BeginnerCompleted = true;
            GameState.KeysCollected = 3;

            BeginnerCompleteForm completed = new BeginnerCompleteForm(totalSeconds, 3);
            completed.Show();
            this.Close();
        }
    }
}