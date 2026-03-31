using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public partial class AdvancedCompleteForm : Form
    {
        public AdvancedCompleteForm(int timeRemaining, int keysCollected)
        {
            InitializeComponent();
            lblTime.Text = FormatTime(timeRemaining);
            label5.Text = $"{keysCollected}/6";
        }

        private string FormatTime(int seconds)
        {
            int mins = seconds / 60;
            int secs = seconds % 60;
            return $"{mins:D2}:{secs:D2}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain home = new frmMain();
            home.Show();
            this.Close();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            AdvancedGame game = new AdvancedGame();
            game.Show();
            this.Close();
        }
    }
}
