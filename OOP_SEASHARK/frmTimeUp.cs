using OOP_GroupProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public partial class frmTimeUp : Form
    {
        private Form gameForm;
        private string levelType;

        public frmTimeUp(Form game, string level)
        {
            InitializeComponent();
            gameForm = game;
            levelType = level;
        }
        private void ShowTimeUp()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ShowTimeUp));
                return;
            }

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Restart Level: Close current game and start a new level based on type
            if (gameForm != null)
            {
                gameForm.Close();
            }

            Form newGame;
            if (levelType == "Advanced")
            {
                newGame = new AdvancedGame();
            }
            else
            {
                newGame = new BeginnerGame();
            }

            newGame.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exit To Home: Close current game and show frmMain
            if (gameForm != null)
            {
                gameForm.Close();
            }
            frmMain home = new frmMain();
            home.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
    }
}
