using System;
using System.Windows.Forms;
#pragma warning disable CA1416

namespace OOP_GroupProject
{
    public partial class BeginnerCompleteForm : CompleteFormBase  // inheritance
    {
        private int keys;

        public BeginnerCompleteForm(int timeRemaining, int keysCollected)
        {
            InitializeComponent();
            LoadStats(timeRemaining, keysCollected);  // use base method
            this.keys = keysCollected;

            btnPlayAgain.Click += (s, e) =>
            {
                new BeginnerGame().Show();
                this.Close();
            };

            btnNextLevel.Click += (s, e) =>
            {
                if (keys < 3)
                {
                    MessageBox.Show("You have to complete all 3 keys to unlock next level",
                        "Level Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                new AdvancedGame().Show();
                this.Close();
            };
        }

        protected override void OnPlayAgainClicked()
        {
            new BeginnerGame().Show();
            this.Close();
        }

        protected override void OnExitOrBackClicked()
        {
            SelectLevel selectLevel = new SelectLevel();
            this.Hide();
            selectLevel.Show();
        }

        private void btnBackSelect_Click(object sender, EventArgs e)
        {
            OnExitOrBackClicked();
        }
    }
}