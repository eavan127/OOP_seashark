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
BeginnerGame gameForm;

namespace OOP_GroupProject
{
    public partial class frmTimeUp : Form
    {
        private BeginnerGame gameForm;
        public frmTimeUp(BeginnerGame game)
        {
            InitializeComponent();
            gameForm = game;

            gameForm.TimeUpTriggered += ShowTimeUp;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
