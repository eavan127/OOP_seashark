namespace OOP_SEASHARK
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblTitle = new Label();
            picFish = new PictureBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picFish).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LightCyan;
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.Navy;
            btnStart.Location = new Point(153, 419);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(151, 60);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.ImageAlign = ContentAlignment.TopCenter;
            lblTitle.Location = new Point(212, 62);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(377, 54);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "C# Deep Sea Challenge";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picFish
            // 
            picFish.BackColor = Color.Transparent;
            picFish.Image = OOP_GroupProject.Properties.Resources.shark2;
            picFish.Location = new Point(262, 134);
            picFish.Margin = new Padding(3, 4, 3, 4);
            picFish.Name = "picFish";
            picFish.Size = new Size(277, 278);
            picFish.SizeMode = PictureBoxSizeMode.Zoom;
            picFish.TabIndex = 4;
            picFish.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCyan;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Navy;
            btnExit.Location = new Point(492, 419);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(151, 60);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = OOP_GroupProject.Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 562);
            Controls.Add(btnExit);
            Controls.Add(picFish);
            Controls.Add(lblTitle);
            Controls.Add(btnStart);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Screen";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)picFish).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picFish;
        private System.Windows.Forms.Button btnExit;
    }
}

