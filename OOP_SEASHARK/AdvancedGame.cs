using System;
using System.Windows.Forms;
#pragma warning disable CA1416


namespace OOP_GroupProject
{
    public partial class AdvancedGame : Level  // Level is parent
    {
        // override properties to connect base class 
        protected override PictureBox PlayerPicture => picFishAdvanced;
        protected override Label TimerLabel => lblTimer2;
        protected override Panel[] Platforms => new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6 };
        protected override string LevelName => "Advanced";

        // fields
        private GameManager gameManager = new GameManager();
        private IQuiz currentQuiz = new AdvancedQuiz();

        // advanced has extra timers 
        private System.Windows.Forms.Timer anchorTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer piranhaTimer = new System.Windows.Forms.Timer();
        private int anchorDirection = 2;
        private int piranha1Direction = 3;
        private int piranha2Direction = 2;

        public AdvancedGame()
        {
            InitializeComponent();
            this.KeyPreview = true;

            // use base class keyboard methods
            this.KeyDown += (s, e) => HandleKeyDown(e);
            this.KeyUp += (s, e) => HandleKeyUp(e);

            btnLeftAdvanced.MouseDown += (s, e) => { moveLeft = true; };
            btnRightAdvanced.MouseDown += (s, e) => { moveRight = true; };
            btnLeftAdvanced.MouseUp += (s, e) => { moveLeft = false; };
            btnRightAdvanced.MouseUp += (s, e) => { moveRight = false; };
            btnLeftAdvanced.MouseLeave += (s, e) => { moveLeft = false; };
            btnRightAdvanced.MouseLeave += (s, e) => { moveRight = false; };
            btnUpAdvanced.Click += (s, e) => { if (isGrounded) velY = -24; };

            btnLeftAdvanced.TabStop = false;
            btnRightAdvanced.TabStop = false;
            btnUpAdvanced.TabStop = false;

            gameManager.StartGame();
            totalSeconds = 420; // 7 minutes for advanced
            UpdateTimerLabel();  // base method
            SetupGame();
            picFishAdvanced.BringToFront();
        }

        private void SetupGame()
        {
            playerX = picFishAdvanced.Left;
            playerY = picFishAdvanced.Top;

            // Game loop
            gameTimer.Interval = 20;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            // Countdown
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += Countdown_Tick;  // base method
            countdownTimer.Start();

            // Advanced-only timers
            anchorTimer.Interval = 20;
            piranhaTimer.Interval = 20;
        }

        private void GameLoop(object sender, EventArgs e)
        {
            try
            {
                MovePlayer();           // base method
                ApplyGravity();         // base method
                CheckObstacleCollision();
                CheckDoorReached();
            }
            catch (Exception ex)
            {
                gameTimer.Stop();
                MessageBox.Show("Game error: " + ex.Message);
            }
        }
        //count down timer
        protected void Countdown_Tick(object sender, EventArgs e)
        {
            totalSeconds--;
            UpdateTimerLabel();

            if (totalSeconds <= 0)
            {
                gameTimer.Stop();
                countdownTimer.Stop();
                anchorTimer.Stop();
                piranhaTimer.Stop();
                frmTimeUp timeUp = new frmTimeUp(this, LevelName);
                timeUp.Show();
                this.Hide();
            }
        }

        // obstacle collision 
        private void CheckObstacleCollision()
        {
            Panel[] obstacles = { panelPiranha1, panelPiranha2, panelAnchor };

            for (int i = 0; i < obstacles.Length; i++)
            {
                if (!obstacleCleared[i] && obstacles[i].Visible)
                {
                    Rectangle fishRect = new Rectangle(playerX, playerY,
                        picFishAdvanced.Width, picFishAdvanced.Height);
                    Rectangle obsRect = new Rectangle(obstacles[i].Left, obstacles[i].Top,
                        obstacles[i].Width, obstacles[i].Height);

                    if (fishRect.IntersectsWith(obsRect))
                    {
                        // Pause all timers
                        gameTimer.Stop();
                        countdownTimer.Stop();
                        anchorTimer.Stop();
                        piranhaTimer.Stop();

                        PopQuiz quiz = new PopQuiz(i, totalSeconds, currentQuiz);
                        quiz.ShowDialog();

                        if (quiz.AnsweredCorrectly) correctAnswers++;
                        obstacles[i].Visible = false;
                        obstacleCleared[i] = true;
                        moveLeft = false;
                        moveRight = false;

                        // Resume all timers
                        gameTimer.Start();
                        countdownTimer.Start();
                        anchorTimer.Start();
                        piranhaTimer.Start();
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
                    picFishAdvanced.Width, picFishAdvanced.Height);
                Rectangle doorRect = new Rectangle(picDoorAdvanced.Left, picDoorAdvanced.Top,
                    picDoorAdvanced.Width, picDoorAdvanced.Height);

                if (fishRect.IntersectsWith(doorRect))
                {
                    // Stop ALL timers first
                    gameTimer.Stop();
                    countdownTimer.Stop();
                    anchorTimer.Stop();
                    piranhaTimer.Stop();

                    GameState.KeysCollected = 3 + correctAnswers;

                    // pass totalSeconds correctly
                    AdvancedCompleteForm completed = new AdvancedCompleteForm(totalSeconds, GameState.KeysCollected);
                    completed.Show();
                    this.Close();  // close not Hide
                }
            }
        }

        // anchor movement
        private void AnchorMovement(object sender, EventArgs e)
        {
            panelAnchor.Top += anchorDirection;
            if (panelAnchor.Top <= 50 || panelAnchor.Top >= 400)
                anchorDirection = -anchorDirection;
        }

        // piranha movement
        private void PiranhaMovement(object sender, EventArgs e)
        {
            panelPiranha1.Left += piranha1Direction;
            if (panelPiranha1.Left <= 0 || panelPiranha1.Left >= this.ClientSize.Width - panelPiranha1.Width)
                piranha1Direction = -piranha1Direction;

            panelPiranha2.Left += piranha2Direction;
            if (panelPiranha2.Left <= 0 || panelPiranha2.Left >= this.ClientSize.Width - panelPiranha2.Width)
                piranha2Direction = -piranha2Direction;
        }
    }
}