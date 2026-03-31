using OOP_GroupProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CA1416

// Level becomes the base Form
public class Level : Form
{
    // shared fields
    protected int totalSeconds;
    protected int correctAnswers = 0;
    protected int playerX, playerY;
    protected int velY = 0;
    protected bool isGrounded = false;
    protected bool moveLeft = false, moveRight = false;
    protected bool[] obstacleCleared = { false, false, false };

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
        playerX = Math.Max(0, Math.Min(playerX, this.ClientSize.Width - PlayerPicture.Width));
        PlayerPicture.Left = playerX;
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
                playerY = p.Top - PlayerPicture.Height;
                velY = 0;
                isGrounded = true;
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
        if (TimerLabel != null)  //null check
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
    protected void HandleKeyDown(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) moveLeft = true;
        if (e.KeyCode == Keys.Right) moveRight = true;
        if (e.KeyCode == Keys.Up && isGrounded) velY = -24;
    }

    protected void HandleKeyUp(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) moveLeft = false;
        if (e.KeyCode == Keys.Right) moveRight = false;
    }
}