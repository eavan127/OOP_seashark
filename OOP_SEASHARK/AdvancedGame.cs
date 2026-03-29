using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_SEASHARK
{
    public partial class AdvancedGame : Form
    {
        private AdvancedLevel level = new AdvancedLevel();
        private GameManager gameManager = new GameManager();
        private int totalSeconds;

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
            gameManager.currentLvl = level;
            gameManager.StartGame();
            totalSeconds = (int)level.GetTimeLimit();
            UpdateTimerLabel();
            SetupGame();
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
            anchorTimer.Tick += AnchorMovement;
            anchorTimer.Start();

            // Piranha movement
            piranhaTimer.Interval = 20;
            piranhaTimer.Tick += PiranhaMovement;
            piranhaTimer.Start();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            MoveShark();
            ApplyGravity();
            CheckHazardCollision();
            CheckDoorReached();
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
            velY += 2;
            playerY += velY;

            // Floor boundary
            int floorY = this.ClientSize.Height - picFishAdvanced.Height;
            if (playerY >= floorY)
            {
                playerY = floorY;
                velY = 0;
                isGrounded = true;
            }

            picFishAdvanced.Top = playerY;
        }

        // --- KEYBOARD CONTROLS ---
        private void AdvancedGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = true;
            if (e.KeyCode == Keys.Right) moveRight = true;
            if (e.KeyCode == Keys.Up && isGrounded) velY = -18;
        }

        private void AdvancedGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = false;
            if (e.KeyCode == Keys.Right) moveRight = false;
        }

        // --- HAZARD COLLISION ---
        private void CheckHazardCollision()
        {
            Panel[] hazards = { panelPiranha1, panelPiranha2, panelAnchor };
            foreach (var hazard in hazards)
            {
                Rectangle sharkRect = new Rectangle(playerX, playerY, picFishAdvanced.Width, picFishAdvanced.Height);
                Rectangle hazardRect = new Rectangle(hazard.Left, hazard.Top, hazard.Width, hazard.Height);
                if (sharkRect.IntersectsWith(hazardRect))
                {
                    ResetSharkPosition();
                    break;
                }
            }
        }

        private void ResetSharkPosition()
        {
            playerX = picFishAdvanced.Left = 50;
            playerY = picFishAdvanced.Top = 400;
            velY = 0;
        }

        // --- DOOR QUIZ ---
        private void CheckDoorReached()
        {
            Rectangle sharkRect = new Rectangle(playerX, playerY, picFishAdvanced.Width, picFishAdvanced.Height);
            Rectangle doorRect = new Rectangle(picDoorAdvanced.Left, picDoorAdvanced.Top, picDoorAdvanced.Width, picDoorAdvanced.Height);
            if (sharkRect.IntersectsWith(doorRect))
            {
                gameTimer.Stop();
                countdownTimer.Stop();
                anchorTimer.Stop();
                piranhaTimer.Stop();

                PopQuiz quiz = new PopQuiz(0, totalSeconds);
                quiz.ShowDialog();

                if (quiz.AnsweredCorrectly)
                {
                    level.CompleteLevel();
                    GameState.KeysCollected = 6; // All keys collected

                    AdvancedCompleted completed = new AdvancedCompleted();
                    completed.ShowDialog();

                    // Return to Select Level
                    SelectLevel selectLevel = new SelectLevel();
                    selectLevel.Show();
                    this.Close();
                }
                else
                {
                    // Wrong answer — resume game
                    gameTimer.Start();
                    countdownTimer.Start();
                    anchorTimer.Start();
                    piranhaTimer.Start();
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

                TimeUp timeUp = new TimeUp();
                timeUp.Show();
                this.Hide();
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

        // --- BUTTON CONTROLS ---
        private void btnLeftAdvanced_MouseDown(object sender, MouseEventArgs e) { moveLeft = true; }
        private void btnLeftAdvanced_MouseUp(object sender, MouseEventArgs e) { moveLeft = false; }

        private void btnRightAdvanced_MouseDown(object sender, MouseEventArgs e) { moveRight = true; }
        private void btnRightAdvanced_MouseUp(object sender, MouseEventArgs e) { moveRight = false; }

        private void btnUpAdvanced_Click(object sender, EventArgs e) { if (isGrounded) velY = -18; }
    }
}