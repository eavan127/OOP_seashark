using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CA1416

namespace OOP_GroupProject
{
    public partial class frmHint : Form
    {
        public frmHint(string hintText)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Helpful Tips";

            label2.Text = hintText;

            // Fix layout after components are initialized
            SetupLayout();
        }

        private void SetupLayout()
        {
            // Ensure the main decorative background covers enough space
            pictureBox3.Size = new Size(this.ClientSize.Width - 80, this.ClientSize.Height - 160);
            pictureBox3.Location = new Point(40, 80);

            // Ensure the hint text fits perfectly within the blue box and wraps correctly
            label2.AutoSize = false;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Size = new Size(pictureBox3.Width - 40, pictureBox3.Height - 40);
            label2.Location = new Point(pictureBox3.Left + 20, pictureBox3.Top + 20);
            label2.BringToFront();

            // Center the "Got It" button
            button1.Location = new Point((this.ClientSize.Width - button1.Width) / 2, this.ClientSize.Height - 70);
            button1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
