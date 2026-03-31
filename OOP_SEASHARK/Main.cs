using System;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public partial class frmMain : Form //inheritance from the Form bass class
        //partial class is used to seperate this logic from the designer code, prevent accidental edit
    {
        public frmMain() //constructor method
        {
            InitializeComponent();
            // set up UI element
            // auto-generate deigner code
            // configure window size, button, title and others
        }

        //navigate to selectLevel page
        private void btnStart_Click(object sender, EventArgs e) //event handler function
        {
            SelectLevel selectLevel = new SelectLevel(); //association relationship
            selectLevel.Show(); // keep memory instead of .Close()
            this.Hide();
        }

        //exit button to exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}