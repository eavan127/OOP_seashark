using System;
using System.Windows.Forms;
#pragma warning disable CA1416


namespace OOP_GroupProject
{
    public partial class BeginnerGame : Level  // Level is parent class
    // inheritance
    {
        //override properties that connecting the virual field in parent class
        protected override PictureBox PlayerPicture => picFishBeginner;
        protected override Label TimerLabel => lblTimer;
        protected override Panel[] Platforms => new Panel[] { panel1, panel2, panel3 };
        protected override string LevelName => "Beginner";

        // private fields that belongs to beginner level only
        private GameManager gameManager = new GameManager();
        private IQuiz currentQuiz = new BeginnerQuiz();

        public BeginnerGame()
        {
            InitializeComponent();
            this.KeyPreview = true;

            // use base class keyboard methods
            this.KeyDown += (s, e) => HandleKeyDown(e);
            this.KeyUp += (s, e) => HandleKeyUp(e);

            //button event handler
            btnLeftBeginner.MouseDown += (s, e) => { this.Focus(); moveLeft = true; };
            btnRightBeginner.MouseDown += (s, e) => { this.Focus(); moveRight = true; };
            btnLeftBeginner.MouseUp += (s, e) => moveLeft = false;
            btnRightBeginner.MouseUp += (s, e) => moveRight = false;
            btnLeftBeginner.MouseLeave += (s, e) => moveLeft = false;
            btnRightBeginner.MouseLeave += (s, e) => moveRight = false;
            btnUpBeginner.Click += (s, e) => { this.Focus(); if (isGrounded) velY = -24; };

            gameManager.StartGame();
            totalSeconds = 300; 
            GameState.KeysCollected = 0;
            UpdateTimerLabel();   // base method
            SetupGame();
        }

        //game setup
        private void SetupGame()
        {
            playerX = picFishBeginner.Left;
            playerY = picFishBeginner.Top;

            gameTimer.Interval = 20;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            countdownTimer.Interval = 1000;
            countdownTimer.Tick += Countdown_Tick;  // base method
            countdownTimer.Start();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            MovePlayer();           // base method
            ApplyGravity();         // base method
            CheckObstacleCollision();
            CheckDoorReached();
        }

        // obstacle collision 
        private void CheckObstacleCollision()
        {
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
                        gameTimer.Stop();
                        PopQuiz quiz = new PopQuiz(i, totalSeconds, currentQuiz);
                        quiz.ShowDialog();
                        if (quiz.AnsweredCorrectly) correctAnswers++;
                        obstacles[i].Visible = false;
                        obstacleCleared[i] = true;
                        moveLeft = false;
                        moveRight = false;
                        gameTimer.Start();
                        return;
                    }
                }
            }
        }

        // reached door
        private void CheckDoorReached()
        {
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
                    GameState.BeginnerCompleted = true;
                    GameState.KeysCollected = correctAnswers;
                    new BeginnerCompleteForm(totalSeconds, correctAnswers).Show();
                    this.Close();
                }
            }
        }
    }
}