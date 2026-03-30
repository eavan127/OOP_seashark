using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public partial class AdvancedGame : Form
    {
        private AdvancedLevel level = new AdvancedLevel();
        private GameManager gameManager = new GameManager();
        private int totalSeconds;
        private IQuiz currentQuiz = new AdvancedQuiz();
        private bool[] obstacleCleared = { false, false, false };
        private int correctAnswers = 0;

        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer countdownTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer anchorTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer piranhaTimer = new System.Windows.Forms.Timer();

        // Shark movement
        private int playerX, playerY;
        private int velY = 0;
        private bool isGrounded = false;
        private bool moveLeft = false, moveRight = false;

        // Anchor movement
        private int anchorDirection = 2;

        // Piranha movement
        private int piranha1Direction = 3;
        private int piranha2Direction = 2;

        public AdvancedGame()
        {
            InitializeComponent();
            this.KeyPreview = true;

            // Wire up keyboard events
            this.KeyDown += AdvancedGame_KeyDown;
            this.KeyUp += AdvancedGame_KeyUp;

            // Wire up button events manually (they're inside panel42)
            btnLeftAdvanced.MouseDown += (s, e) => { moveLeft = true; };
            btnLeftAdvanced.MouseUp += (s, e) => { moveLeft = false; };
            btnLeftAdvanced.MouseLeave += (s, e) => { moveLeft = false; };

            btnRightAdvanced.MouseDown += (s, e) => { moveRight = true; };
            btnRightAdvanced.MouseUp += (s, e) => { moveRight = false; };
            btnRightAdvanced.MouseLeave += (s, e) => { moveRight = false; };

            btnUpAdvanced.Click += (s, e) => { if (isGrounded) velY = -24; };

            btnLeftAdvanced.TabStop = false;
            btnRightAdvanced.TabStop = false;
            btnUpAdvanced.TabStop = false;

            gameManager.currentLvl = level;
            gameManager.StartGame();
            totalSeconds = (int)level.GetTimeLimit();
            this.DoubleBuffered = true;
            UpdateTimerLabel();
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

            // Countdown timer
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += Countdown_Tick;
            countdownTimer.Start();

            // Anchor movement
            anchorTimer.Interval = 20;
            // anchorTimer.Tick += AnchorMovement;
            // anchorTimer.Start();

            // Piranha movement
            piranhaTimer.Interval = 20;
            // piranhaTimer.Tick += PiranhaMovement;
            // piranhaTimer.Start();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            try
            {
                MoveShark();
                ApplyGravity();
                CheckObstacleCollision();
                CheckDoorReached();
            }
            catch (Exception ex)
            {
                gameTimer.Stop();
                MessageBox.Show("Game error: " + ex.Message);
            }
        }

        // --- SHARK MOVEMENT ---
        private void MoveShark()
        {
            if (moveLeft) playerX -= 5;
            if (moveRight) playerX += 5;
            playerX = Math.Max(0, Math.Min(playerX, this.ClientSize.Width - picFishAdvanced.Width));
            picFishAdvanced.Left = playerX;
        }

        private void ApplyGravity()
        {
            isGrounded = false;
            velY += 2;
            playerY += velY;

            // Hardcode all platform panels directly
            Panel[] platforms = { panel1, panel2, panel3, panel4, panel5, panel6 };
            foreach (Panel p in platforms)
            {
                Rectangle fishRect = new Rectangle(playerX, playerY, picFishAdvanced.Width, picFishAdvanced.Height);
                Rectangle platRect = new Rectangle(p.Left, p.Top, p.Width, p.Height);

                if (fishRect.IntersectsWith(platRect))
                {
                    // Simple landing: if falling and overlapping with top part of panel
                    if (velY >= 0 && playerY + picFishAdvanced.Height <= p.Top + 25)
                    {
                        playerY = p.Top - picFishAdvanced.Height;
                        velY = 0;
                        isGrounded = true;
                    }
                }
            }

            // Floor
            int floorY = this.ClientSize.Height - picFishAdvanced.Height;
            if (playerY >= floorY)
            {
                playerY = floorY;
                velY = 0;
                isGrounded = true;
            }

            picFishAdvanced.Left = playerX;
            picFishAdvanced.Top = playerY;
        }


        // --- KEYBOARD CONTROLS ---
        private void AdvancedGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = true;
            if (e.KeyCode == Keys.Right) moveRight = true;
            if (e.KeyCode == Keys.Up && isGrounded) velY = -24;
        }

        private void AdvancedGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = false;
            if (e.KeyCode == Keys.Right) moveRight = false;
        }

        // --- OBSTACLE COLLISION ---
        private void CheckObstacleCollision()
        {
            Panel[] obstacles = { panelPiranha1, panelPiranha2, panelAnchor };

            for (int i = 0; i < obstacles.Length; i++)
            {
                if (!obstacleCleared[i] && obstacles[i].Visible)
                {
                    Rectangle fishRect = new Rectangle(playerX, playerY, picFishAdvanced.Width, picFishAdvanced.Height);
                    Rectangle obsRect = new Rectangle(obstacles[i].Left, obstacles[i].Top, obstacles[i].Width, obstacles[i].Height);

                    if (fishRect.IntersectsWith(obsRect))
                    {
                        // Stop everything
                        gameTimer.Stop();
                        countdownTimer.Stop();
                        anchorTimer.Stop();
                        piranhaTimer.Stop();

                        // Open quiz for this obstacle
                        PopQuiz quiz = new PopQuiz(i, totalSeconds, currentQuiz);
                        quiz.ShowDialog();

                        // After quiz closes - hide obstacle and mark as cleared
                        if (quiz.AnsweredCorrectly)
                        {
                            correctAnswers++;
                        }
                        obstacles[i].Visible = false;
                        obstacleCleared[i] = true;

                        // Reset movement flags
                        moveLeft = false;
                        moveRight = false;

                        // Resume game
                        gameTimer.Start();
                        countdownTimer.Start();
                        anchorTimer.Start();
                        piranhaTimer.Start();

                        // Only handle one obstacle per frame
                        return;
                    }
                }
            }
        }


        // --- DOOR = WIN ---
        private void CheckDoorReached()
        {
            // Only allow door if all 3 obstacles cleared
            if (obstacleCleared[0] && obstacleCleared[1] && obstacleCleared[2])
            {
                Rectangle fishRect = new Rectangle(playerX, playerY, picFishAdvanced.Width, picFishAdvanced.Height);
                Rectangle doorRect = new Rectangle(picDoorAdvanced.Left, picDoorAdvanced.Top, picDoorAdvanced.Width, picDoorAdvanced.Height);

                if (fishRect.IntersectsWith(doorRect))
                {
                    gameTimer.Stop();
                    countdownTimer.Stop();
                    anchorTimer.Stop();
                    piranhaTimer.Stop();

                    level.CompleteLevel();
                    GameState.KeysCollected = 3 + correctAnswers; // assuming 3 from beginner

                    AdvancedCompleteForm completed = new AdvancedCompleteForm(totalSeconds, GameState.KeysCollected);
                    completed.Show(); // Close instead of Hide
                    this.Hide();
                }
            }
        }

        // --- COUNTDOWN TIMER ---
        private void Countdown_Tick(object sender, EventArgs e)
        {
            totalSeconds--;
            UpdateTimerLabel();

            if (totalSeconds <= 0)
            {
                gameTimer.Stop();
                countdownTimer.Stop();
                anchorTimer.Stop();
                piranhaTimer.Stop();

                frmTimeUp timeUp = new frmTimeUp(this, "Advanced");
                timeUp.Show();
                this.Close(); // Close instead of Hide
            }
        }

        private void UpdateTimerLabel()
        {
            int mins = totalSeconds / 60;
            int secs = totalSeconds % 60;
            lblTimer2.Text = $"{mins:D2}:{secs:D2}";
        }

        // --- ANCHOR MOVEMENT ---
        private void AnchorMovement(object sender, EventArgs e)
        {
            panelAnchor.Top += anchorDirection;
            if (panelAnchor.Top <= 50 || panelAnchor.Top >= 400)
                anchorDirection = -anchorDirection;
        }

        // --- PIRANHA MOVEMENT ---
        private void PiranhaMovement(object sender, EventArgs e)
        {
            panelPiranha1.Left += piranha1Direction;
            if (panelPiranha1.Left <= 0 || panelPiranha1.Left >= this.ClientSize.Width - panelPiranha1.Width)
                piranha1Direction = -piranha1Direction;

            panelPiranha2.Left += piranha2Direction;
            if (panelPiranha2.Left <= 0 || panelPiranha2.Left >= this.ClientSize.Width - panelPiranha2.Width)
                piranha2Direction = -piranha2Direction;
        }

        private void panelPiranha2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdvancedGame_Load(object sender, EventArgs e)
        {

        }

        private void lblTimer2_Click(object sender, EventArgs e)
        {

        }

        private void picFishAdvanced_Click(object sender, EventArgs e)
        {

        }

        private void picDoorAdvanced_Click(object sender, EventArgs e)
        {

        }
    }
}