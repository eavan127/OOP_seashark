namespace OOP_GroupProject
{
    partial class BeginnerGame
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
            lblTimer = new Label();
            lblBeginner = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            picDoorBeginner = new PictureBox();
            picObstacle3 = new PictureBox();
            picObstacle2 = new PictureBox();
            picObstacle1 = new PictureBox();
            picFishBeginner = new PictureBox();
            panel4 = new Panel();
            btnRightBeginner = new Button();
            btnLeftBeginner = new Button();
            btnUpBeginner = new Button();
            btnDebugComplete = new Button();
            ((System.ComponentModel.ISupportInitialize)picDoorBeginner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picObstacle3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picObstacle2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picObstacle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFishBeginner).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.IndianRed;
            lblTimer.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.Navy;
            lblTimer.Location = new Point(722, 9);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(66, 30);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "05:00";
            lblTimer.Click += lblTimer_Click;
            // 
            // lblBeginner
            // 
            lblBeginner.AutoSize = true;
            lblBeginner.BackColor = Color.YellowGreen;
            lblBeginner.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeginner.ForeColor = Color.Navy;
            lblBeginner.Location = new Point(12, 9);
            lblBeginner.Name = "lblBeginner";
            lblBeginner.Size = new Size(139, 30);
            lblBeginner.TabIndex = 1;
            lblBeginner.Text = "Beginner Level";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(-1, 282);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 46);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGoldenrod;
            panel2.Location = new Point(286, 225);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 51);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Beige;
            panel3.Location = new Point(536, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(266, 36);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // picDoorBeginner
            // 
            picDoorBeginner.BackColor = Color.Transparent;
            picDoorBeginner.Image = global::OOP_GroupProject.Properties.Resources.door;
            picDoorBeginner.Location = new Point(739, 87);
            picDoorBeginner.Name = "picDoorBeginner";
            picDoorBeginner.Size = new Size(78, 74);
            picDoorBeginner.SizeMode = PictureBoxSizeMode.StretchImage;
            picDoorBeginner.TabIndex = 9;
            picDoorBeginner.TabStop = false;
            picDoorBeginner.Click += picDoorBeginner_Click;
            // 
            // picObstacle3
            // 
            picObstacle3.Image = global::OOP_GroupProject.Properties.Resources.anchor;
            picObstacle3.Location = new Point(536, 77);
            picObstacle3.Name = "picObstacle3";
            picObstacle3.Size = new Size(99, 80);
            picObstacle3.SizeMode = PictureBoxSizeMode.StretchImage;
            picObstacle3.TabIndex = 8;
            picObstacle3.TabStop = false;
            picObstacle3.Click += picAnchor_Click;
            // 
            // picObstacle2
            // 
            picObstacle2.BackColor = Color.Transparent;
            picObstacle2.Image = global::OOP_GroupProject.Properties.Resources.rock;
            picObstacle2.Location = new Point(325, 154);
            picObstacle2.Name = "picObstacle2";
            picObstacle2.Size = new Size(100, 65);
            picObstacle2.SizeMode = PictureBoxSizeMode.StretchImage;
            picObstacle2.TabIndex = 7;
            picObstacle2.TabStop = false;
            picObstacle2.Click += picRock_Click;
            // 
            // picObstacle1
            // 
            picObstacle1.BackColor = Color.Transparent;
            picObstacle1.Image = global::OOP_GroupProject.Properties.Resources.coral;
            picObstacle1.Location = new Point(-1, 192);
            picObstacle1.Name = "picObstacle1";
            picObstacle1.Size = new Size(86, 84);
            picObstacle1.SizeMode = PictureBoxSizeMode.StretchImage;
            picObstacle1.TabIndex = 6;
            picObstacle1.TabStop = false;
            picObstacle1.Click += picCoral_Click;
            // 
            // picFishBeginner
            // 
            picFishBeginner.BackColor = Color.Transparent;
            picFishBeginner.Image = global::OOP_GroupProject.Properties.Resources.shark2;
            picFishBeginner.Location = new Point(12, 334);
            picFishBeginner.Name = "picFishBeginner";
            picFishBeginner.Size = new Size(132, 114);
            picFishBeginner.SizeMode = PictureBoxSizeMode.Zoom;
            picFishBeginner.TabIndex = 5;
            picFishBeginner.TabStop = false;
            picFishBeginner.Click += picFishBeginner_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(btnRightBeginner);
            panel4.Controls.Add(btnLeftBeginner);
            panel4.Controls.Add(btnUpBeginner);
            panel4.Location = new Point(559, 304);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 148);
            panel4.TabIndex = 10;
            // 
            // btnRightBeginner
            // 
            btnRightBeginner.BackColor = Color.LightBlue;
            btnRightBeginner.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRightBeginner.Location = new Point(142, 78);
            btnRightBeginner.Name = "btnRightBeginner";
            btnRightBeginner.Size = new Size(87, 56);
            btnRightBeginner.TabIndex = 2;
            btnRightBeginner.Text = "→";
            btnRightBeginner.UseVisualStyleBackColor = false;
            btnRightBeginner.MouseDown += btnRightBeginner_MouseDown;
            btnRightBeginner.MouseUp += btnRightBeginner_MouseUp;
            // 
            // btnLeftBeginner
            // 
            btnLeftBeginner.BackColor = Color.LightBlue;
            btnLeftBeginner.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeftBeginner.Location = new Point(13, 78);
            btnLeftBeginner.Name = "btnLeftBeginner";
            btnLeftBeginner.Size = new Size(95, 56);
            btnLeftBeginner.TabIndex = 1;
            btnLeftBeginner.Text = "←";
            btnLeftBeginner.UseVisualStyleBackColor = false;
            btnLeftBeginner.MouseDown += btnLeftBeginner_MouseDown;
            btnLeftBeginner.MouseUp += btnLeftBeginner_MouseUp;
            // 
            // btnUpBeginner
            // 
            btnUpBeginner.BackColor = Color.LightBlue;
            btnUpBeginner.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpBeginner.Location = new Point(83, 6);
            btnUpBeginner.Name = "btnUpBeginner";
            btnUpBeginner.Size = new Size(87, 69);
            btnUpBeginner.TabIndex = 0;
            btnUpBeginner.Text = "↑";
            btnUpBeginner.UseVisualStyleBackColor = false;
            btnUpBeginner.Click += btnUpBeginner_Click;
            // 
            // btnDebugComplete
            // 
            btnDebugComplete.BackColor = Color.Firebrick;
            btnDebugComplete.FlatStyle = FlatStyle.Flat;
            btnDebugComplete.Font = new Font("Segoe UI", 7.2F, FontStyle.Bold);
            btnDebugComplete.ForeColor = Color.White;
            btnDebugComplete.Location = new Point(560, 6);
            btnDebugComplete.Name = "btnDebugComplete";
            btnDebugComplete.Size = new Size(150, 28);
            btnDebugComplete.TabIndex = 20;
            btnDebugComplete.Text = "[DEBUG] Complete Level";
            btnDebugComplete.UseVisualStyleBackColor = false;
            btnDebugComplete.Click += btnDebugComplete_Click;
            // 
            // BeginnerGame
            // 
            BackgroundImage = global::OOP_GroupProject.Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picFishBeginner);
            Controls.Add(panel4);
            Controls.Add(picDoorBeginner);
            Controls.Add(picObstacle3);
            Controls.Add(picObstacle2);
            Controls.Add(picObstacle1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblBeginner);
            Controls.Add(lblTimer);
            Controls.Add(btnDebugComplete);
            Name = "BeginnerGame";
            StartPosition = FormStartPosition.CenterScreen;
            Load += BeginnerGame_Load;
            ((System.ComponentModel.ISupportInitialize)picDoorBeginner).EndInit();
            ((System.ComponentModel.ISupportInitialize)picObstacle3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picObstacle2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picObstacle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFishBeginner).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblBeginner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picFishBeginner;
        private System.Windows.Forms.PictureBox picObstacle1;
        private System.Windows.Forms.PictureBox picObstacle2;
        private System.Windows.Forms.PictureBox picObstacle3;
        private System.Windows.Forms.PictureBox picDoorBeginner;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRightBeginner;
        private System.Windows.Forms.Button btnLeftBeginner;
        private System.Windows.Forms.Button btnUpBeginner;
        private System.Windows.Forms.Button btnDebugComplete;
    }
}