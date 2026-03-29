using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SEASHARK
{
    public partial class TimeUp : Form
    {
        GameTimer gameTimer = new GameTimer();
        public TimeUp()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            AutoSize = false;
        }

        private void label_Tittle_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Owner?.Close(); // close old game form (if set)

            BeginnerGame game = new BeginnerGame();
            game.Show();

            this.Close();
        }
    }
}
    