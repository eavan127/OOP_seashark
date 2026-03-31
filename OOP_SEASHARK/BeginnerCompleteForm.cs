using System;
using System.Windows.Forms;

#pragma warning disable CA1416

namespace OOP_GroupProject
{
    public partial class BeginnerCompleteForm : Form
    {
        private int keys;
        public BeginnerCompleteForm(int timeRemaining, int keysCollected)
        {
            InitializeComponent();
            lblTime.Text = FormatTime(timeRemaining);
            lblKey.Text = $"{keysCollected}/6";
            this.keys = keysCollected;

            // buttons navigation
            btnPlayAgain.Click += (s, e) =>
            {
                new BeginnerGame().Show();
                this.Close();
            };
            btnNextLevel.Click += (s, e) =>
            {
                if (keys < 3)
                {
                    MessageBox.Show("You have to complete all 3 keys to unlock next level", "Level Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                new AdvancedGame().Show();
                this.Close();
            };
        }

        private string FormatTime(int seconds)
        {
            int mins = seconds / 60;
            int secs = seconds % 60;
            return $"{mins:D2}:{secs:D2}";
        }

        //back to select level button navigaton
        private void btnBackSelect_Click(object sender, EventArgs e)
        {
            SelectLevel selectLevel = new SelectLevel();
            this.Hide();
            selectLevel.Show();
        }
    }
}
