namespace OOP_GroupProject
{
    partial class AdvancedCompleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedCompleteForm));
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            panelKeys = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panelTime = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMain.SuspendLayout();
            panelKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(81, 188);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(477, 48);
            label1.TabIndex = 0;
            label1.Text = "Advanced Level Completed !";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(56, 246);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(580, 43);
            label2.TabIndex = 0;
            label2.Text = "You've  succesfully  navigate  the  deep  sea  currents  and  found  hidden  treasure!";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Teal;
            btnExit.Location = new Point(383, 385);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 58);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.TitleBar;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 17);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.LightCyan;
            panelMain.Controls.Add(btnExit);
            panelMain.Controls.Add(panelKeys);
            panelMain.Controls.Add(panelTime);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(label1);
            panelMain.Location = new Point(96, 46);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(667, 462);
            panelMain.TabIndex = 6;
            // 
            // panelKeys
            // 
            panelKeys.BackColor = Color.LightSteelBlue;
            panelKeys.Controls.Add(pictureBox2);
            panelKeys.Controls.Add(label4);
            panelKeys.Location = new Point(375, 285);
            panelKeys.Margin = new Padding(4, 5, 4, 5);
            panelKeys.Name = "panelKeys";
            panelKeys.Size = new Size(143, 82);
            panelKeys.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.key;
            pictureBox2.Location = new Point(4, 5);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(72, 5);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 7;
            label4.Text = "KEYS";
            // 
            // panelTime
            // 
            panelTime.BackColor = Color.LightSteelBlue;
            panelTime.Controls.Add(pictureBox3);
            panelTime.Controls.Add(label3);
            panelTime.Location = new Point(183, 285);
            panelTime.Margin = new Padding(4, 5, 4, 5);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(143, 82);
            panelTime.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(5, 5);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(72, 5);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 0;
            label3.Text = "TIME";
            // 
            // AdvancedCompleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            BackgroundImage = Properties.Resources.background_sea;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 555);
            Controls.Add(panelMain);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdvancedCompleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelKeys.ResumeLayout(false);
            panelKeys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTime.ResumeLayout(false);
            panelTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnExit;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Panel panelMain;
        protected System.Windows.Forms.Panel panelKeys;
        protected System.Windows.Forms.Panel panelTime;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.PictureBox pictureBox2;
        protected System.Windows.Forms.PictureBox pictureBox3;
        //protected System.Windows.Forms.Label lblTime;
        //protected System.Windows.Forms.Label label5;
        //protected System.Windows.Forms.Button btnPlayAgain;
    }
}

