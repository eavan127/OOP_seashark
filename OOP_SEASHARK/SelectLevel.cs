using System;
using System.Windows.Forms;

namespace OOP_SEASHARK
{
    public partial class SelectLevel : Form
    {
        public SelectLevel()
        {
            InitializeComponent();
        }

        // Re-check state every time the form becomes the active window
        // (covers the case where we return from BeginnerCompleted)
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RefreshState();
        }

        private void RefreshState()
        {
            // --- Keys label ---
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
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void SelectLevel_Load(object sender, EventArgs e) { }
    }
}
