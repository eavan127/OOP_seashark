using System;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public partial class AdvancedCompleted : Form
    {
        public AdvancedCompleted()
        {
            InitializeComponent();
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Advanced Level Completed!";
            this.BackColor = System.Drawing.Color.FromArgb(10, 30, 70);
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            var lbl = new Label
            {
                Text = "🏆 Advanced Level Complete!\nAll 6 Keys Collected!",
                ForeColor = System.Drawing.Color.Gold,
                Font = new System.Drawing.Font("Californian FB", 16F, System.Drawing.FontStyle.Bold),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new System.Drawing.Size(380, 100),
                Location = new System.Drawing.Point(10, 40)
            };

            var btn = new Button
            {
                Text = "Back to Level Select",
                Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Navy,
                BackColor = System.Drawing.Color.LightCyan,
                Size = new System.Drawing.Size(200, 45),
                Location = new System.Drawing.Point(100, 170),
                FlatStyle = FlatStyle.Popup
            };
            btn.Click += (s, e) => this.Close(); // ShowDialog parent handles the rest

            this.Controls.Add(lbl);
            this.Controls.Add(btn);
        }
    }
}
