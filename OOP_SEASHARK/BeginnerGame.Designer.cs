namespace OOP_SEASHARK
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblBeginner = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picDoorBeginner = new System.Windows.Forms.PictureBox();
            this.picObstacle3 = new System.Windows.Forms.PictureBox();
            this.picObstacle2 = new System.Windows.Forms.PictureBox();
            this.picObstacle1 = new System.Windows.Forms.PictureBox();
            this.picFishBeginner = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRightBeginner = new System.Windows.Forms.Button();
            this.btnLeftBeginner = new System.Windows.Forms.Button();
            this.btnUpBeginner = new System.Windows.Forms.Button();
            this.btnDebugComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDoorBeginner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFishBeginner)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.IndianRed;
            this.lblTimer.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Navy;
            this.lblTimer.Location = new System.Drawing.Point(722, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(66, 30);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "05:00";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblBeginner
            // 
            this.lblBeginner.AutoSize = true;
            this.lblBeginner.BackColor = System.Drawing.Color.YellowGreen;
            this.lblBeginner.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeginner.ForeColor = System.Drawing.Color.Navy;
            this.lblBeginner.Location = new System.Drawing.Point(12, 9);
            this.lblBeginner.Name = "lblBeginner";
            this.lblBeginner.Size = new System.Drawing.Size(139, 30);
            this.lblBeginner.TabIndex = 1;
            this.lblBeginner.Text = "Beginner Level";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-1, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 46);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Location = new System.Drawing.Point(286, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 51);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Beige;
            this.panel3.Location = new System.Drawing.Point(536, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 36);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // picDoorBeginner
            // 
            this.picDoorBeginner.BackColor = System.Drawing.Color.Transparent;
            this.picDoorBeginner.Image = global::OOP_GroupProject.Properties.Resources.door;
            this.picDoorBeginner.Location = new System.Drawing.Point(739, 87);
            this.picDoorBeginner.Name = "picDoorBeginner";
            this.picDoorBeginner.Size = new System.Drawing.Size(78, 74);
            this.picDoorBeginner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoorBeginner.TabIndex = 9;
            this.picDoorBeginner.TabStop = false;
            this.picDoorBeginner.Click += new System.EventHandler(this.picDoorBeginner_Click);
            // 
            // picObstacle3
            // 
            this.picObstacle3.Image = global::OOP_GroupProject.Properties.Resources.anchor;
            this.picObstacle3.Location = new System.Drawing.Point(536, 77);
            this.picObstacle3.Name = "picObstacle3";
            this.picObstacle3.Size = new System.Drawing.Size(99, 80);
            this.picObstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObstacle3.TabIndex = 8;
            this.picObstacle3.TabStop = false;
            this.picObstacle3.Click += new System.EventHandler(this.picAnchor_Click);
            // 
            // picObstacle2
            // 
            this.picObstacle2.BackColor = System.Drawing.Color.Transparent;
            this.picObstacle2.Image = global::OOP_GroupProject.Properties.Resources.rock;
            this.picObstacle2.Location = new System.Drawing.Point(325, 154);
            this.picObstacle2.Name = "picObstacle2";
            this.picObstacle2.Size = new System.Drawing.Size(100, 65);
            this.picObstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObstacle2.TabIndex = 7;
            this.picObstacle2.TabStop = false;
            this.picObstacle2.Click += new System.EventHandler(this.picRock_Click);
            // 
            // picObstacle1
            // 
            this.picObstacle1.BackColor = System.Drawing.Color.Transparent;
            this.picObstacle1.Image = global::OOP_GroupProject.Properties.Resources.coral;
            this.picObstacle1.Location = new System.Drawing.Point(-1, 192);
            this.picObstacle1.Name = "picObstacle1";
            this.picObstacle1.Size = new System.Drawing.Size(86, 84);
            this.picObstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObstacle1.TabIndex = 6;
            this.picObstacle1.TabStop = false;
            this.picObstacle1.Click += new System.EventHandler(this.picCoral_Click);
            // 
            // picFishBeginner
            // 
            this.picFishBeginner.BackColor = System.Drawing.Color.Transparent;
            this.picFishBeginner.Image = global::OOP_GroupProject.Properties.Resources.shark2;
            this.picFishBeginner.Location = new System.Drawing.Point(12, 334);
            this.picFishBeginner.Name = "picFishBeginner";
            this.picFishBeginner.Size = new System.Drawing.Size(132, 114);
            this.picFishBeginner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFishBeginner.TabIndex = 5;
            this.picFishBeginner.TabStop = false;
            this.picFishBeginner.Click += new System.EventHandler(this.picFishBeginner_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnRightBeginner);
            this.panel4.Controls.Add(this.btnLeftBeginner);
            this.panel4.Controls.Add(this.btnUpBeginner);
            this.panel4.Location = new System.Drawing.Point(559, 304);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 148);
            this.panel4.TabIndex = 10;
            // 
            // btnRightBeginner
            // 
            this.btnRightBeginner.BackColor = System.Drawing.Color.LightBlue;
            this.btnRightBeginner.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightBeginner.Location = new System.Drawing.Point(142, 78);
            this.btnRightBeginner.Name = "btnRightBeginner";
            this.btnRightBeginner.Size = new System.Drawing.Size(87, 56);
            this.btnRightBeginner.TabIndex = 2;
            this.btnRightBeginner.Text = "→";
            this.btnRightBeginner.UseVisualStyleBackColor = false;
            this.btnRightBeginner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRightBeginner_MouseDown);
            this.btnRightBeginner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRightBeginner_MouseUp);
            // 
            // btnLeftBeginner
            // 
            this.btnLeftBeginner.BackColor = System.Drawing.Color.LightBlue;
            this.btnLeftBeginner.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftBeginner.Location = new System.Drawing.Point(13, 78);
            this.btnLeftBeginner.Name = "btnLeftBeginner";
            this.btnLeftBeginner.Size = new System.Drawing.Size(95, 56);
            this.btnLeftBeginner.TabIndex = 1;
            this.btnLeftBeginner.Text = "←";
            this.btnLeftBeginner.UseVisualStyleBackColor = false;
            this.btnLeftBeginner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeftBeginner_MouseDown);
            this.btnLeftBeginner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeftBeginner_MouseUp);
            // 
            // btnUpBeginner
            // 
            this.btnUpBeginner.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpBeginner.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpBeginner.Location = new System.Drawing.Point(83, 6);
            this.btnUpBeginner.Name = "btnUpBeginner";
            this.btnUpBeginner.Size = new System.Drawing.Size(87, 69);
            this.btnUpBeginner.TabIndex = 0;
            this.btnUpBeginner.Text = "↑";
            this.btnUpBeginner.UseVisualStyleBackColor = false;
            this.btnUpBeginner.Click += new System.EventHandler(this.btnUpBeginner_Click);
            // 
            // btnDebugComplete
            //
            this.btnDebugComplete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDebugComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebugComplete.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnDebugComplete.ForeColor = System.Drawing.Color.White;
            this.btnDebugComplete.Location = new System.Drawing.Point(560, 6);
            this.btnDebugComplete.Name = "btnDebugComplete";
            this.btnDebugComplete.Size = new System.Drawing.Size(150, 28);
            this.btnDebugComplete.TabIndex = 20;
            this.btnDebugComplete.Text = "[DEBUG] Complete Level";
            this.btnDebugComplete.UseVisualStyleBackColor = false;
            this.btnDebugComplete.Click += new System.EventHandler(this.btnDebugComplete_Click);
            // 
            // BeginnerGame
            // 
            this.BackgroundImage = global::OOP_GroupProject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picFishBeginner);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.picDoorBeginner);
            this.Controls.Add(this.picObstacle3);
            this.Controls.Add(this.picObstacle2);
            this.Controls.Add(this.picObstacle1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBeginner);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnDebugComplete);
            this.Name = "BeginnerGame";
            this.Load += new System.EventHandler(this.BeginnerGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDoorBeginner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFishBeginner)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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