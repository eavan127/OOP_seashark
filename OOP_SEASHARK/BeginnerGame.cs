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

        // Game loop timer 
        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer countdownTimer = new System.Windows.Forms.Timer();

        // Player movement
        private int playerX, playerY;
        private int velY = 0;
        private bool isGrounded = false;
        private bool moveLeft = false;
        private bool moveRight = false;

        // Obstacle state 
        private bool[] obstacleCleared = { false, false, false };

        public BeginnerGame()
        {
            InitializeComponent();
            gameManager.currentLvl = level;
            gameManager.StartGame();
            totalSeconds = (int)level.GetTimeLimit();
            UpdateTimerLabel();
            SetupGame();
        }

        // SETUP
        private void SetupGame()
        {
            // Store starting position of fish
            playerX = picFishBeginner.Left;
            playerY = picFishBeginner.Top;

            // Game loop - runs every 20ms (~50fps)
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

            // Keep fish inside form boundaries
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

            // Floor - bottom of the form
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
            if (e.KeyCode == Keys.Up && isGrounded) velY = -18;
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
            if (isGrounded) velY = -18; // jump
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
                        // Stop everything
                        gameTimer.Stop();
                        countdownTimer.Stop();

                        // Open quiz for this obstacle
                        PopQuiz quiz = new PopQuiz(i, totalSeconds, currentQuiz);
                        quiz.ShowDialog();

                        // After quiz closes - hide obstacle regardless
                        obstacles[i].Visible = false;
                        obstacleCleared[i] = true;

                        // Reset movement flags (dialog steals mouse focus,
                        // so MouseUp events are lost on the on-screen buttons)
                        moveLeft = false;
                        moveRight = false;


                        // Resume game
                        gameTimer.Start();
                        countdownTimer.Start();

                        // Only handle one obstacle per frame — don't
                        // let the loop continue into the next obstacle
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
                    GameState.KeysCollected = 3;

                    BeginnerCompleted completed = new BeginnerCompleted();
                    completed.ShowDialog(); // ShowDialog so we wait for it to close

                    // After the completed screen closes, go back to SelectLevel
                    SelectLevel selectLevel = new SelectLevel();
                    selectLevel.Show();
                    this.Close();
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

                TimeUp timeUp = new TimeUp();
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


        // UNUSED EVENTS (keep empty)

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

            BeginnerCompleted completed = new BeginnerCompleted();
            completed.ShowDialog();

            SelectLevel selectLevel = new SelectLevel();
            selectLevel.Show();
            this.Close();
        }
    }
}