namespace OOP_GroupProject
{
    partial class frmTimeUp
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.background_sea;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Timer;
            pictureBox2.Location = new Point(230, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(67, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(638, 381);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(338, 314);
            button2.Name = "button2";
            button2.Size = new Size(183, 34);
            button2.TabIndex = 6;
            button2.Text = "Exit To Home 🏠";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimHei", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(120, 250);
            label3.Name = "label3";
            label3.Size = new Size(416, 20);
            label3.TabIndex = 5;
            label3.Text = "The Dee Sea Currents was too strong🌊";
            // 
            // button1
            // 
            button1.Location = new Point(138, 314);
            button1.Name = "button1";
            button1.Size = new Size(156, 34);
            button1.TabIndex = 4;
            button1.Text = "Restart Level 🔄";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 16);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 2;
            label1.Text = "⌛ Times Up";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(711, 376);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // frmTimeUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "frmTimeUp";
            Text = "frmTimeUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label label3;
        private PictureBox pictureBox3;
    }
}