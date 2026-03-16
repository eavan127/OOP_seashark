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
    public partial class SelectLevel : Form
    {
        public SelectLevel()
        {
            InitializeComponent();
        }

        private void btnPlayBeginner_Click(object sender, EventArgs e)
        {
            BeginnerGame beginnerGame = new BeginnerGame();
            beginnerGame.Show();
            this.Hide();
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            Main main = new Main();  
            main.Show();
            this.Hide();
        }
    }
}
