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
    public partial class frmHint : Form
    {
        public frmHint(string hintText)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            label2.Text = hintText;

            // Make sure controls center themselves after maximizing
            this.Load += (s, e) => CenterControls();
        }

        private void CenterControls()
        {
            // Center label1 (Title)
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, 50);

            // Center pictureBox3 (the blue decorative background)
            pictureBox3.Size = new Size(this.ClientSize.Width - 100, this.ClientSize.Height - 150);
            pictureBox3.Location = new Point(50, 100);

            // Center label2 (Hint text) inside pictureBox3 or over it
            label2.AutoSize = false;
            label2.Size = new Size(pictureBox3.Width - 40, pictureBox3.Height - 100);
            label2.Location = new Point(pictureBox3.Left + 20, pictureBox3.Top + 20);

            // Center button1 (Got It)
            button1.Location = new Point((this.ClientSize.Width - button1.Width) / 2, pictureBox3.Bottom - 50);
            button1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
