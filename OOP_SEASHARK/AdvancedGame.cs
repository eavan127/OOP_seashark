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

            btnUpAdvanced.Click += (s, e) => { velY = -20; };

            btnLeftAdvanced.TabStop = false;
            btnRightAdvanced.TabStop = false;
            btnUpAdvanced.TabStop = false;

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
            try
            {
                MoveShark();
                ApplyGravity();
                CheckHazardCollision();
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
            velY += 1;
            playerY += velY;

            // Hardcode all platform panels directly
            Panel[] platforms = { panel1, panel2, panel3, panel4, panel5, panel6 };
            foreach (Panel p in platforms)
            {
                Rectangle fishRect = new Rectangle(playerX, playerY, picFishAdvanced.Width, picFishAdvanced.Height);
                Rectangle platRect = new Rectangle(p.Left, p.Top, p.Width, p.Height);

                if (fishRect.IntersectsWith(platRect))
                {
                    // Landing on top
                    if (velY >= 0 && playerY + picFishAdvanced.Height - velY <= p.Top + 10)
                    {
                        playerY = p.Top - picFishAdvanced.Height;
                        velY = 0;
                        isGrounded = true;
                    }
                    // Hitting from below
                    else if (velY < 0 && playerY - velY >= p.Top + p.Height - 10)
                    {
                        playerY = p.Top + p.Height;
                        velY = 0;
                    }
                    // Side collision
                    else
                    {
                        int fishCenterX = playerX + picFishAdvanced.Width / 2;
                        int platCenterX = p.Left + p.Width / 2;
                        if (fishCenterX < platCenterX)
                            playerX = p.Left - picFishAdvanced.Width;
                        else
                            playerX = p.Left + p.Width;
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
            if (e.KeyCode == Keys.Up) velY = -20; // no isGrounded check = unlimited jumps
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
                    moveLeft = false;  // only reset when hit
                    moveRight = false;
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
                moveLeft = false;  // only reset when door reached
                moveRight = false;
                gameTimer.Stop();
                countdownTimer.Stop();
                anchorTimer.Stop();
                piranhaTimer.Stop();

                IQuiz levelQuiz = new AdvancedQuiz();
                PopQuiz quiz = new PopQuiz(0, totalSeconds, levelQuiz);
                quiz.ShowDialog();

                if (quiz.AnsweredCorrectly)
                {
                    level.CompleteLevel();
                    GameState.KeysCollected = 6;

                    AdvancedCompleteForm completed = new AdvancedCompleteForm(totalSeconds);
                    completed.Show();
                    this.Hide();
                }
                else
                {
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

                frmTimeUp timeUp = new frmTimeUp(this, "Advanced");
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
    }
}