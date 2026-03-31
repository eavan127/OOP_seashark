using System;
using System.Windows.Forms;

#pragma warning disable CA1416
//just to disable the compatibility warning for Windows Forms

namespace OOP_GroupProject
{
    public partial class SelectLevel : Form
    {
        //constructor
        public SelectLevel()
        {
            InitializeComponent();
        }

        // every time the player comes back again, which reactivate this screen
        // it will refresh the state by calling the RefreshState method
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RefreshState();
        }

        // show the player how many keys they have gained
        private void RefreshState()
        {
            lblKeys.Text = $"{GameState.KeysCollected} / 6";
            // GameState is the class and KeysCollected is the field
        }

        // create beginner game instance and show then button is clicked
        private void btnPlayBeginner_Click(object sender, EventArgs e)
        {
            BeginnerGame beginnerGame = new BeginnerGame();
            beginnerGame.Show();
            this.Hide();
        }

        // create advanced game instance and show then button is clicked
        private void btnPlayAdvanced_Click(object sender, EventArgs e)
        {
            AdvancedGame advancedGame = new AdvancedGame();
            advancedGame.Show();
            this.Hide();
        }

        // create main page instance and navigate back then button is clicked
        private void btnBackMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
