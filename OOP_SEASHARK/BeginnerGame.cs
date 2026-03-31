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
#pragma warning disable CA1416

// a container for all classes
// avoid same name class conflict
namespace OOP_GroupProject
{
    public partial class BeginnerGame : Form
    {
        private BeginnerLevel level = new BeginnerLevel();
        private GameManager gameManager = new GameManager();
        private int totalSeconds;
        private IQuiz currentQuiz = new BeginnerQuiz();
        //Quiz interface can achieve runtime polymorphism 
        private int correctAnswers = 0;
        public event Action TimeUpTriggered;
        private frmTimeUp timeUpForm;
        // timeup form reference

        // These timers keep the game world moving and the clock ticking
        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer countdownTimer = new System.Windows.Forms.Timer();

        // Player movement
        //player's coordinate 
        private int playerX, playerY;
        private int velY = 0;
        //zero velocity in Y direction for gravity and jumping (temporary)
        private bool isGrounded = false;
        //the player is touching the ground
        private bool moveLeft = false;
        private bool moveRight = false;

        // keep track of that obstacles that has already cleared
        private bool[] obstacleCleared = { false, false, false };
        public BeginnerGame()
        {
            InitializeComponent();

            // allow form to receive keyboard input first
            this.KeyPreview = true;

            // attach keyboard events
            this.KeyDown += BeginnerGame_KeyDown;
            this.KeyUp += BeginnerGame_KeyUp;

            // ensure no control holds focus initially
            this.ActiveControl = null;

            // button input (mouse)
            btnLeftBeginner.MouseDown += (s, e) =>
            {
                this.Focus();          // return focus to form buttons
                moveLeft = true;
            };

            btnRightBeginner.MouseDown += (s, e) =>
            {
                this.Focus();
                moveRight = true;
            };

            btnLeftBeginner.MouseUp += (s, e) => moveLeft = false; 
            //when our mouse hold up, then the method will stop
            btnRightBeginner.MouseUp += (s, e) => moveRight = false;

            // prevent stuck when mouse cursor leaves button
            btnLeftBeginner.MouseLeave += (s, ev) => moveLeft = false;
            btnRightBeginner.MouseLeave += (s, ev) => moveRight = false;

            // Jump button
            btnUpBeginner.Click += (s, e) =>
            {
                this.Focus();
                if (isGrounded) velY = -24; //leave from the gravity, mean going up 
            };

            // game setup
            gameManager.currentLvl = level;
            gameManager.StartGame(); //abstraction

            totalSeconds = (int)level.GetTimeLimit();
            //get timelimit from level class, and convert into int 
            //encapsulation, to use getter in the level class

            GameState.KeysCollected = 0;

            UpdateTimerLabel();
            SetupGame();
            //call the setup game method below

            timeUpForm = new frmTimeUp(this, "Beginner");
        }

        // setup the game
        private void SetupGame()
        {
            // store the starting position of shark
            playerX = picFishBeginner.Left;
            playerY = picFishBeginner.Top;

            // it runs and checks collisions 
            gameTimer.Interval = 20; // runs every 20 milliseconds
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            // Countdown every second
            countdownTimer.Interval = 1000; //every second
            countdownTimer.Tick += Countdown_Tick; //call Countdown_Tick()
            countdownTimer.Start();
        }

        // game loop
        private void GameLoop(object sender, EventArgs e)
        {
            MovePlayer();
            ApplyGravity();
            CheckObstacleCollision();
            CheckDoorReached();
        }

        // movement of the player
        private void MovePlayer()
        {
            if (moveLeft) playerX -= 5;
            if (moveRight) playerX += 5;

            // make sure shark doesn't swim right out of the window
            playerX = Math.Max(0, Math.Min(playerX, this.ClientSize.Width - picFishBeginner.Width));

            picFishBeginner.Left = playerX;
        }

        private void ApplyGravity()
        {
            isGrounded = false;
            velY += 2; // gravity pull down the shark (acceleration down)
            playerY += velY;

            // Check collision with each platform panel
            Panel[] platforms = { panel1, panel2, panel3 };
            foreach (Panel p in platforms)
            {
                // converts objects into rectangles for collision detection
                Rectangle fishRect = new Rectangle(playerX, playerY,picFishBeginner.Width, picFishBeginner.Height);
                Rectangle platRect = new Rectangle(p.Left, p.Top, p.Width, p.Height);

                if (fishRect.IntersectsWith(platRect) && velY > 0) //check if the fish meet the panel
                {
                    playerY = p.Top - picFishBeginner.Height;
                    velY = 0; //stop movement
                    isGrounded = true; //reach a the surface of the panel
                }
            }

            // if they are not fall on a platform, they will hit the sea floor
            int floorY = this.ClientSize.Height - picFishBeginner.Height;
            if (playerY >= floorY) 
            {
                playerY = floorY;
                velY = 0;
                isGrounded = true;
            }

            picFishBeginner.Top = playerY;
        }

        // keyboard controls
        private void BeginnerGame_KeyDown(object sender, KeyEventArgs e)
        {
            //e.KeyCode tell which code is pressed (for keyboard)
            if (e.KeyCode == Keys.Left) moveLeft = true;
            if (e.KeyCode == Keys.Right) moveRight = true;
            if (e.KeyCode == Keys.Up && isGrounded) velY = -24;
        }

        private void BeginnerGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = false;
            if (e.KeyCode == Keys.Right) moveRight = false;
        }

        // button conntrols
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

        // stop moving when the mouse move up from the button 
        private void btnLeftBeginner_MouseUp(object sender, MouseEventArgs e)
        {
            moveLeft = false;
        }

        private void btnRightBeginner_MouseUp(object sender, MouseEventArgs e)
        {
            moveRight = false;
        }

        // check if there is any obstacle collision
        private void CheckObstacleCollision()
        {
            // map each obstacle picture box to its index
            PictureBox[] obstacles = { picObstacle1, picObstacle2, picObstacle3 };

            for (int i = 0; i < obstacles.Length; i++)
            {
                //only process when it is not cleared and is still visible
                if (!obstacleCleared[i] && obstacles[i].Visible)
                {
                    Rectangle fishRect = new Rectangle(playerX, playerY,
                        picFishBeginner.Width, picFishBeginner.Height);
                    Rectangle obsRect = new Rectangle(obstacles[i].Left, obstacles[i].Top,
                        obstacles[i].Width, obstacles[i].Height);

                    if (fishRect.IntersectsWith(obsRect))
                    {
                        // pause game physic
                        gameTimer.Stop();

                        // open quiz for this obstacle
                        PopQuiz quiz = new PopQuiz(i, totalSeconds, currentQuiz);
                        quiz.ShowDialog();

                        // After quiz closes - increment if correct
                        if (quiz.AnsweredCorrectly)
                        {
                            correctAnswers++;
                        }
                        obstacles[i].Visible = false;
                        obstacleCleared[i] = true;

                        moveLeft = false;
                        moveRight = false; 

                        // Resume game
                        gameTimer.Start();

                        // only deal with one obstacle at a time
                        return;
                    }
                }
            }
        }

        // if reach door, then go to completed page
        private void CheckDoorReached()
        {
            // only allow door if all 3 obstacles cleared
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
                    level.CompleteLevel(); // encapsulation + abstraction

                    // persist completion state
                    GameState.BeginnerCompleted = true;
                    GameState.KeysCollected = correctAnswers;

                    //show the beginner completed page
                    BeginnerCompleteForm completed = new BeginnerCompleteForm(totalSeconds, correctAnswers);
                    completed.Show();
                    this.Close(); 
                }
            }
        }

        // countdown timer
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
            int mins = totalSeconds / 60; // take integer which is the minute
            int secs = totalSeconds % 60; //take remainder
            lblTimer.Text = $"{mins:D2}:{secs:D2}";
        }
    }
}