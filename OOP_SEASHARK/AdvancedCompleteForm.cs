using System;
using System.Windows.Forms;
#pragma warning disable CA1416

namespace OOP_GroupProject
{
    public partial class AdvancedCompleteForm : CompleteFormBase  // inheritance
    {
        public AdvancedCompleteForm(int timeRemaining, int keysCollected)
        {
            InitializeComponent();
            LoadStats(timeRemaining, keysCollected); // use base method
        }

        protected override void OnPlayAgainClicked() //override method in parent class
        {
            new AdvancedGame().Show();
            this.Close();
        }

        protected override void OnExitOrBackClicked()
        {
            frmMain home = new frmMain();
            home.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnExitOrBackClicked();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            OnPlayAgainClicked();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}