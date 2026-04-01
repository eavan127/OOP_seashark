using System;
using System.Windows.Forms;
#pragma warning disable CA1416


namespace OOP_GroupProject
{
    public partial class BeginnerGame : Level  // level is parent class
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
        //beginner quiz object with quiz interface reference type

        public BeginnerGame()
        {
            InitializeComponent();
            this.KeyPreview = true;

            // keyboard inputs for
            this.KeyDown += (s, e) => HandleKeyDown(e); //key press down
            this.KeyUp += (s, e) => HandleKeyUp(e); // key release up 

            //button event handler inputs 
            btnLeftBeginner.MouseDown += (s, e) => { this.Focus(); moveLeft = true; };
            btnRightBeginner.MouseDown += (s, e) => { this.Focus(); moveRight = true; };
            btnLeftBeginner.MouseUp += (s, e) => moveLeft = false;
            btnRightBeginner.MouseUp += (s, e) => moveRight = false;
            btnLeftBeginner.MouseLeave += (s, e) => moveLeft = false;
            btnRightBeginner.MouseLeave += (s, e) => moveRight = false;
            btnUpBeginner.Click += (s, e) => { this.Focus(); if (isGrounded) velY = -24; };
            //moving up negative, moving down positive

            gameManager.StartGame();
            totalSeconds = 300; //5 minutes 
            GameState.KeysCollected = 0; //setter method
            UpdateTimerLabel();   // base method
            SetupGame();
        }

        //game setup
        private void SetupGame()
        {
            //take the character position
            playerX = picFishBeginner.Left;
            playerY = picFishBeginner.Top;

            //timer for the movement , game engine itself
            gameTimer.Interval = 20; //every 20 milliseconds
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            // timer for the overall game countdown
            countdownTimer.Interval = 1000; //every 1 second
            countdownTimer.Tick += Countdown_Tick;  // base method
            countdownTimer.Start();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            MovePlayer();           // use inherited base method
            ApplyGravity();         // use inherited base method
            CheckObstacleCollision();
            CheckDoorReached();
        }

        // obstacle collision 
        private void CheckObstacleCollision()
        {
            PictureBox[] obstacles = { picObstacle1, picObstacle2, picObstacle3 };
            // 3 picturebox object

            for (int i = 0; i < obstacles.Length; i++)
            {
                //only process the obstacle that have not been unanswered yet
                if (!obstacleCleared[i] && obstacles[i].Visible)
                {
                    //model the character and player as rectangle // using the coordinates
                    Rectangle fishRect = new Rectangle(playerX, playerY,
                        picFishBeginner.Width, picFishBeginner.Height);
                    Rectangle obsRect = new Rectangle(obstacles[i].Left, obstacles[i].Top,
                        obstacles[i].Width, obstacles[i].Height);

                    //if they touches
                    if (fishRect.IntersectsWith(obsRect))
                    {
                        gameTimer.Stop(); //pause, stop the character movement 
                        // count down timer does not stop
                        // pop up quizz appear
                        PopQuiz quiz = new PopQuiz(i, totalSeconds, currentQuiz);
                        quiz.ShowDialog();
                        if (quiz.AnsweredCorrectly)
                        {
                            correctAnswers++;
                        }
                        obstacles[i].Visible = false; // make the answered obstacle as unvisible
                        obstacleCleared[i] = true; // clear it 
                        moveLeft = false; //stop movement 
                        moveRight = false;
                        gameTimer.Start(); // start again
                        return;
                    }
                }
            }
        }

        // reached door
        private void CheckDoorReached()
        {
            // all obstacles are answered
            if (obstacleCleared[0] && obstacleCleared[1] && obstacleCleared[2])
            {
                //create rectangle for door and character as well
                Rectangle fishRect = new Rectangle(playerX, playerY,
                    picFishBeginner.Width, picFishBeginner.Height);
                Rectangle doorRect = new Rectangle(picDoorBeginner.Left, picDoorBeginner.Top,
                    picDoorBeginner.Width, picDoorBeginner.Height);

                // if the rectangle of character and door touch
                if (fishRect.IntersectsWith(doorRect))
                {
                    gameTimer.Stop(); 
                    countdownTimer.Stop(); // count down also stop
                    // indiciate that the beginner level finishes
                    GameState.BeginnerCompleted = true; //setter
                    GameState.KeysCollected = correctAnswers; //setter
                    new BeginnerCompleteForm(totalSeconds, correctAnswers).Show();
                    //navigate to complete form
                    this.Close();
                }
            }
        }
    }
}