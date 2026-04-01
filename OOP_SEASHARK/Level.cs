using System;
using System.Windows.Forms;
#pragma warning disable CA1416

namespace OOP_GroupProject
{
    public class Level : Form
    {
        // shared fields
        protected int totalSeconds; // countdown timer in seconds
        protected int correctAnswers = 0; // track score
        protected int playerX, playerY;
        protected int velY = 0; // vertical speed for gravity
        protected bool isGrounded = false;
        protected bool moveLeft = false, moveRight = false;
        protected bool[] obstacleCleared = { false, false, false };

        // Use UI Timer (avoid confusion with other Timer types)
        protected System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        protected System.Windows.Forms.Timer countdownTimer = new System.Windows.Forms.Timer();

        protected virtual PictureBox PlayerPicture { get; }
        protected virtual Label TimerLabel { get; }
        protected virtual Panel[] Platforms { get; }
        protected virtual string LevelName { get; }

        // shared movement
        protected void MovePlayer()
        {
            if (moveLeft) playerX -= 5;
            if (moveRight) playerX += 5;
            playerX = Math.Max(0, Math.Min(playerX, this.ClientSize.Width - PlayerPicture.Width)); // Clamp player position so it stays within the screen boundaries
            PlayerPicture.Left = playerX; // Update player position on screen (X-axis)
        }

        protected void ApplyGravity()
        {
            isGrounded = false;
            velY += 2;
            playerY += velY;

            foreach (Panel p in Platforms)
            {
                Rectangle fishRect = new Rectangle(playerX, playerY, PlayerPicture.Width, PlayerPicture.Height);
                Rectangle platRect = new Rectangle(p.Left, p.Top, p.Width, p.Height);

                if (fishRect.IntersectsWith(platRect) && velY > 0)
                {
                    playerY = p.Top - PlayerPicture.Height; // place player ON TOP of platform
                    velY = 0; // stop falling
                    isGrounded = true; // allow jumping again
                }
            }

            int floorY = this.ClientSize.Height - PlayerPicture.Height;
            if (playerY >= floorY)
            {
                playerY = floorY;
                velY = 0;
                isGrounded = true;
            }

            PlayerPicture.Left = playerX;
            PlayerPicture.Top = playerY;
        }

        // shared timer
        protected void UpdateTimerLabel()
        {
            int mins = totalSeconds / 60;
            int secs = totalSeconds % 60;
            if (TimerLabel != null)  // null check
                TimerLabel.Text = $"{mins:D2}:{secs:D2}";
        }

        protected void Countdown_Tick(object sender, EventArgs e)
        {
            totalSeconds--;
            UpdateTimerLabel();
            if (totalSeconds <= 0)
            {
                gameTimer.Stop();
                countdownTimer.Stop();
                OnTimeUp();
            }
        }

        protected virtual void OnTimeUp()
        {
            frmTimeUp timeUp = new frmTimeUp(this, LevelName);
            timeUp.Show();
            this.Hide();
        }

        // shared keyboard
        protected void HandleKeyDown(KeyEventArgs e) // key is pressed down
        {
            if (e.KeyCode == Keys.Left) moveLeft = true;
            if (e.KeyCode == Keys.Right) moveRight = true;
            if (e.KeyCode == Keys.Up && isGrounded) velY = -24;
        }

        protected void HandleKeyUp(KeyEventArgs e) // key is released
        {
            if (e.KeyCode == Keys.Left) moveLeft = false;
            if (e.KeyCode == Keys.Right) moveRight = false;
        }
    }
}