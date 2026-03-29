namespace OOP_SEASHARK
{
    partial class SelectLevel
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
            lblSelect = new Label();
            panel1 = new Panel();
            picKeys = new PictureBox();
            lblKeys = new Label();
            label1 = new Label();
            btnPlayAdvanced = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            btnBackMain = new Button();
            label2 = new Label();
            btnPlayBeginner = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKeys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.BackColor = Color.Transparent;
            lblSelect.Font = new Font("Californian FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelect.ForeColor = Color.Navy;
            lblSelect.Location = new Point(256, 99);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(289, 43);
            lblSelect.TabIndex = 0;
            lblSelect.Text = "Select Your Level";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(picKeys);
            panel1.Controls.Add(lblKeys);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Navy;
            panel1.Location = new Point(33, 18);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 112);
            panel1.TabIndex = 1;
            // 
            // picKeys
            // 
            picKeys.BackColor = Color.Transparent;
            picKeys.Image = OOP_GroupProject.Properties.Resources.key;
            picKeys.Location = new Point(12, 19);
            picKeys.Margin = new Padding(3, 4, 3, 4);
            picKeys.Name = "picKeys";
            picKeys.Size = new Size(52, 76);
            picKeys.SizeMode = PictureBoxSizeMode.Zoom;
            picKeys.TabIndex = 2;
            picKeys.TabStop = false;
            // 
            // lblKeys
            // 
            lblKeys.AutoSize = true;
            lblKeys.BackColor = Color.Transparent;
            lblKeys.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeys.Location = new Point(89, 56);
            lblKeys.Name = "lblKeys";
            lblKeys.Size = new Size(49, 23);
            lblKeys.TabIndex = 1;
            lblKeys.Text = "0 / 6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Californian FB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 19);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 0;
            label1.Text = "Keys Found";
            // 
            // btnPlayAdvanced
            // 
            btnPlayAdvanced.BackColor = Color.Azure;
            btnPlayAdvanced.FlatStyle = FlatStyle.Popup;
            btnPlayAdvanced.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayAdvanced.ForeColor = Color.Navy;
            btnPlayAdvanced.Location = new Point(478, 464);
            btnPlayAdvanced.Margin = new Padding(3, 4, 3, 4);
            btnPlayAdvanced.Name = "btnPlayAdvanced";
            btnPlayAdvanced.Size = new Size(156, 51);
            btnPlayAdvanced.TabIndex = 2;
            btnPlayAdvanced.Text = "Play Level";
            btnPlayAdvanced.UseVisualStyleBackColor = false;
            btnPlayAdvanced.Click += btnPlayAdvanced_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Californian FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(450, 405);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 1;
            label3.Text = "Advanced Level";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = OOP_GroupProject.Properties.Resources.shark2;
            pictureBox2.Location = new Point(363, 15);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnBackMain
            // 
            btnBackMain.BackColor = Color.Transparent;
            btnBackMain.FlatAppearance.BorderSize = 0;
            btnBackMain.FlatStyle = FlatStyle.Popup;
            btnBackMain.Font = new Font("Californian FB", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackMain.ForeColor = Color.Navy;
            btnBackMain.Location = new Point(696, 482);
            btnBackMain.Margin = new Padding(3, 4, 3, 4);
            btnBackMain.Name = "btnBackMain";
            btnBackMain.Size = new Size(80, 65);
            btnBackMain.TabIndex = 4;
            btnBackMain.Text = "Back";
            btnBackMain.UseVisualStyleBackColor = false;
            btnBackMain.Click += btnBackMain_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Californian FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(154, 405);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 1;
            label2.Text = "Beginner Level";
            // 
            // btnPlayBeginner
            // 
            btnPlayBeginner.BackColor = Color.Azure;
            btnPlayBeginner.FlatStyle = FlatStyle.Popup;
            btnPlayBeginner.Font = new Font("Californian FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayBeginner.ForeColor = Color.Navy;
            btnPlayBeginner.Location = new Point(176, 464);
            btnPlayBeginner.Margin = new Padding(3, 4, 3, 4);
            btnPlayBeginner.Name = "btnPlayBeginner";
            btnPlayBeginner.Size = new Size(138, 51);
            btnPlayBeginner.TabIndex = 2;
            btnPlayBeginner.Text = "Play Level";
            btnPlayBeginner.UseVisualStyleBackColor = false;
            btnPlayBeginner.Click += btnPlayBeginner_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = OOP_GroupProject.Properties.Resources.sea_star1;
            pictureBox3.Location = new Point(157, 176);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(181, 210);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = OOP_GroupProject.Properties.Resources.clam;
            pictureBox1.Location = new Point(456, 176);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // SelectLevel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = OOP_GroupProject.Properties.Resources.background_sea;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 562);
            Controls.Add(pictureBox1);
            Controls.Add(btnPlayAdvanced);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(btnPlayBeginner);
            Controls.Add(btnBackMain);
            Controls.Add(panel1);
            Controls.Add(lblSelect);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SelectLevel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Level Selection Screen";
            Load += SelectLevel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picKeys).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picKeys;
        private System.Windows.Forms.Button btnPlayAdvanced;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlayBeginner;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}