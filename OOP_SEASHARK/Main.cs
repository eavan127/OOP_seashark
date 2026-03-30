using System;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SelectLevel selectLevel = new SelectLevel();
            selectLevel.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // We'll leave this empty method here so the Visual Studio Designer doesn't complain
        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}