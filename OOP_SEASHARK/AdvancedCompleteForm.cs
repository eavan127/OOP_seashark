using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public partial class AdvancedCompleteForm : Form
    {
        // P/Invoke
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DeleteObject(IntPtr hObject);

        public AdvancedCompleteForm()
        {
            InitializeComponent();

            // keep regions up-to-date when sizes change
            this.Shown += (s, e) => UpdateRegions();
            panelMain.SizeChanged += (s, e) => UpdateRegions();
            btnPlayAgain.SizeChanged += (s, e) => UpdateRegions();
            btnExit.SizeChanged += (s, e) => UpdateRegions();
        }

        private void UpdateRegions()
        {
            // panel main rounded region
            if (panelMain.Width > 0 && panelMain.Height > 0)
            {
                var old = panelMain.Region;
                panelMain.Region = CreateRoundedRegion(panelMain.Width, panelMain.Height, 30, 30);
                old?.Dispose();
            }

            // Play Again button round
            if (btnPlayAgain.Width > 0 && btnPlayAgain.Height > 0)
            {
                var old = btnPlayAgain.Region;
                btnPlayAgain.Region = CreateRoundedRegion(btnPlayAgain.Width, btnPlayAgain.Height, 20, 20);
                old?.Dispose();
            }

            // Exit button round
            if (btnExit.Width > 0 && btnExit.Height > 0)
            {
                var old = btnExit.Region;
                btnExit.Region = CreateRoundedRegion(btnExit.Width, btnExit.Height, 20, 20);
                old?.Dispose();
            }
        }

        private Region CreateRoundedRegion(int width, int height, int ellipseWidth, int ellipseHeight)
        {
            IntPtr hrgn = CreateRoundRectRgn(0, 0, width, height, ellipseWidth, ellipseHeight);
            try
            {
                return Region.FromHrgn(hrgn);
            }
            finally
            {
                // Free native GDI object (Region.FromHrgn has already copied it into a managed Region)
                DeleteObject(hrgn);
            }
        }


        // Apply rounded regions to all panels (dispose previous Regions)
        private void UpdatePanelRegions()
        {
            // panel1: larger radius (original code used 40)
            if (panelMain.Width > 0 && panelMain.Height > 0)
            {
                var old = panelMain.Region;
                panelMain.Region = CreateRoundedRegion(panelMain.Width, panelMain.Height, 40, 40);
                old?.Dispose();
            }

            // panelKeys: smaller radius (20)
            if (panelKeys.Width > 0 && panelKeys.Height > 0)
            {
                var old = panelKeys.Region;
                panelKeys.Region = CreateRoundedRegion(panelKeys.Width, panelKeys.Height, 20, 20);
                old?.Dispose();
            }

            // panelTime: smaller radius (20)
            if (panelTime.Width > 0 && panelTime.Height > 0)
            {
                var old = panelTime.Region;
                panelTime.Region = CreateRoundedRegion(panelTime.Width, panelTime.Height, 20, 20);
                old?.Dispose();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            var newGame = new AdvancedCompleteForm();
            newGame.Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        // Add this method to the WinForm class to resolve CS1061
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // You can add any desired logic here, or leave it empty if no action is needed.
        }

        private void panelKeys_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTime_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
