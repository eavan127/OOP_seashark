using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public partial class BeginnerCompleteForm : Form
    {
        // P/Invoke forcreating and releasing HRGN
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DeleteObject(IntPtr hObject);

        private int keys;
        public BeginnerCompleteForm(int timeRemaining, int keysCollected)
        {
            InitializeComponent();
            lblTime.Text = FormatTime(timeRemaining);
            label5.Text = $"{keysCollected}/6";
            this.keys = keysCollected;

            // Ensure regions are created once sizes are valid and kept up-to-date
            this.Shown += (s, e) => UpdatePanelRegions();
            this.Resize += (s, e) => UpdatePanelRegions();

            panel1.SizeChanged += (s, e) => UpdatePanelRegions();
            panelKeys.SizeChanged += (s, e) => UpdatePanelRegions();
            panelTime.SizeChanged += (s, e) => UpdatePanelRegions();

            // Wire up buttons
            btnPlayAgain.Click += (s, e) =>
            {
                new BeginnerGame().Show();
                this.Close();
            };
            btnNextLevel.Click += (s, e) =>
            {
                if (keys < 3)
                {
                    MessageBox.Show("You have to complete all 3 keys to unlock next level", "Level Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                new AdvancedGame().Show();
                this.Close();
            };
        }

        private string FormatTime(int seconds)
        {
            int mins = seconds / 60;
            int secs = seconds % 60;
            return $"{mins:D2}:{secs:D2}";
        }

        // Create/dispose managed Region objects safely using a native HRGN
        private Region CreateRoundedRegion(int width, int height, int ellipseWidth, int ellipseHeight)
        {
            if (width <= 0 || height <= 0)
                return null;

            IntPtr hrgn = CreateRoundRectRgn(0, 0, width, height, ellipseWidth, ellipseHeight);
            try
            {
                return Region.FromHrgn(hrgn);
            }
            finally
            {
                // Region.FromHrgn copies the native HRGN; free native resource to avoid GDI leaks
                DeleteObject(hrgn);
            }
        }

        // Apply rounded regions to all panels (dispose previous Regions)
        private void UpdatePanelRegions()
        {
            // panel1: larger radius (original code used 40)
            if (panel1.Width > 0 && panel1.Height > 0)
            {
                var old = panel1.Region;
                panel1.Region = CreateRoundedRegion(panel1.Width, panel1.Height, 40, 40);
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

        // Designer event handlers — keep them but avoid creating regions here
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // The designer wired panel1_Paint; leave empty to avoid heavy work in paint.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Regions are created in UpdatePanelRegions; do not create them on every paint.
        }

        private void panelKeys_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BeginnerCompleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
