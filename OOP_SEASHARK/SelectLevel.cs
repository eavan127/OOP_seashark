using System;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public partial class SelectLevel : Form
    {
        public SelectLevel()
        {
            InitializeComponent();
        }

        // Every time the player comes back to this screen, we'll refresh the stats to show their progress
        // (especially helpful when you just finished a level and come back here)
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RefreshState();
        }

        private void RefreshState()
        {
            // Let's show the player how many keys they've found so far
            lblKeys.Text = $"{GameState.KeysCollected} / 6";

            //// --- Beginner button ---
            //if (GameState.BeginnerCompleted)
            //{
            //    btnPlayBeginner.Text = "Completed ✓";
            //    btnPlayBeginner.Enabled = false;  // prevent replaying; remove this line to allow replay
            //}
            //else
            //{
            //    btnPlayBeginner.Text = "Play Level";
            //    btnPlayBeginner.Enabled = true;
            //}

            //// --- Advanced button: enabled only after Beginner is done ---
            //btnPlayAdvanced.Enabled = GameState.BeginnerCompleted;
        }

        private void btnPlayBeginner_Click(object sender, EventArgs e)
        {
            BeginnerGame beginnerGame = new BeginnerGame();
            beginnerGame.Show();
            this.Hide();
        }

        private void btnPlayAdvanced_Click(object sender, EventArgs e)
        {
            AdvancedGame advancedGame = new AdvancedGame();
            advancedGame.Show();
            this.Hide();
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void SelectLevel_Load(object sender, EventArgs e) { }
    }
}
