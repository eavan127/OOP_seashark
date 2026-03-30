using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    partial class PopQuiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            quizTimer = new System.Windows.Forms.Timer(components);
            pnlBackground = new Panel();
            btnHint = new Button();
            lblTimer = new Label();
            lblTimerText = new Label();
            pnlTimeBarBg = new Panel();
            pnlTimeBarFill = new Panel();
            pnlQuizOuter = new Panel();
            pnlQuizCard = new Panel();
            btnD = new Button();
            btnC = new Button();
            btnB = new Button();
            btnA = new Button();
            lblQuestion = new Label();
            lblTitle = new Label();
            pnlSharkInner2 = new Panel();
            pnlCategory = new Panel();
            lblCategory = new Label();
            pnlSharkInner1 = new Panel();
            pnlSharkOuter = new Panel();
            pnlBackground.SuspendLayout();
            pnlTimeBarBg.SuspendLayout();
            pnlQuizOuter.SuspendLayout();
            pnlQuizCard.SuspendLayout();
            pnlCategory.SuspendLayout();
            SuspendLayout();
            // 
            // quizTimer
            // 
            quizTimer.Interval = 1000;
            quizTimer.Tick += quizTimer_Tick;
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.Transparent;
            pnlBackground.BackgroundImage = Properties.Resources.background_sea;
            pnlBackground.BackgroundImageLayout = ImageLayout.Stretch;
            pnlBackground.Controls.Add(btnHint);
            pnlBackground.Controls.Add(lblTimer);
            pnlBackground.Controls.Add(lblTimerText);
            pnlBackground.Controls.Add(pnlTimeBarBg);
            pnlBackground.Controls.Add(pnlQuizOuter);
            pnlBackground.Controls.Add(pnlSharkOuter);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Margin = new Padding(3, 4, 3, 4);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(1353, 948);
            pnlBackground.TabIndex = 6;
            pnlBackground.Paint += pnlBackground_Paint_1;
            // 
            // btnHint
            // 
            btnHint.BackColor = Color.Transparent;
            btnHint.BackgroundImage = Properties.Resources.lightbulb;
            btnHint.BackgroundImageLayout = ImageLayout.Stretch;
            btnHint.FlatAppearance.BorderSize = 0;
            btnHint.FlatStyle = FlatStyle.Flat;
            btnHint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHint.Location = new Point(1054, 580);
            btnHint.Margin = new Padding(3, 4, 3, 4);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(86, 100);
            btnHint.TabIndex = 7;
            btnHint.UseVisualStyleBackColor = false;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.Orange;
            lblTimer.Location = new Point(867, 720);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(37, 23);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "30s";
            lblTimer.Visible = false;
            // 
            // lblTimerText
            // 
            lblTimerText.AutoSize = true;
            lblTimerText.BackColor = Color.Transparent;
            lblTimerText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimerText.ForeColor = Color.Orange;
            lblTimerText.Location = new Point(454, 720);
            lblTimerText.Name = "lblTimerText";
            lblTimerText.Size = new Size(141, 23);
            lblTimerText.TabIndex = 6;
            lblTimerText.Text = "Time Remaining";
            lblTimerText.Visible = false;
            // 
            // pnlTimeBarBg
            // 
            pnlTimeBarBg.BackColor = Color.SteelBlue;
            pnlTimeBarBg.Controls.Add(pnlTimeBarFill);
            pnlTimeBarBg.Location = new Point(454, 780);
            pnlTimeBarBg.Margin = new Padding(3, 4, 3, 4);
            pnlTimeBarBg.Name = "pnlTimeBarBg";
            pnlTimeBarBg.Padding = new Padding(2);
            pnlTimeBarBg.Size = new Size(446, 26);
            pnlTimeBarBg.TabIndex = 5;
            // 
            // pnlTimeBarFill
            // 
            pnlTimeBarFill.BackColor = Color.Orange;
            pnlTimeBarFill.Location = new Point(6, 6);
            pnlTimeBarFill.Margin = new Padding(3, 4, 3, 4);
            pnlTimeBarFill.Name = "pnlTimeBarFill";
            pnlTimeBarFill.Size = new Size(434, 14);
            pnlTimeBarFill.TabIndex = 6;
            // 
            // pnlQuizOuter
            // 
            pnlQuizOuter.BackColor = Color.Orange;
            pnlQuizOuter.Controls.Add(pnlQuizCard);
            pnlQuizOuter.Controls.Add(pnlSharkInner1);
            pnlQuizOuter.Location = new Point(305, 134);
            pnlQuizOuter.Margin = new Padding(3, 4, 3, 4);
            pnlQuizOuter.Name = "pnlQuizOuter";
            pnlQuizOuter.Padding = new Padding(11, 14, 11, 14);
            pnlQuizOuter.Size = new Size(743, 546);
            pnlQuizOuter.TabIndex = 7;
            // 
            // pnlQuizCard
            // 
            pnlQuizCard.BackColor = Color.AntiqueWhite;
            pnlQuizCard.Controls.Add(btnD);
            pnlQuizCard.Controls.Add(btnC);
            pnlQuizCard.Controls.Add(btnB);
            pnlQuizCard.Controls.Add(btnA);
            pnlQuizCard.Controls.Add(lblQuestion);
            pnlQuizCard.Controls.Add(lblTitle);
            pnlQuizCard.Controls.Add(pnlSharkInner2);
            pnlQuizCard.Controls.Add(pnlCategory);
            pnlQuizCard.Location = new Point(17, 20);
            pnlQuizCard.Margin = new Padding(3, 4, 3, 4);
            pnlQuizCard.Name = "pnlQuizCard";
            pnlQuizCard.Size = new Size(709, 506);
            pnlQuizCard.TabIndex = 2;
            // 
            // btnD
            // 
            btnD.BackColor = Color.WhiteSmoke;
            btnD.FlatAppearance.BorderSize = 0;
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnD.Location = new Point(377, 360);
            btnD.Margin = new Padding(3, 4, 3, 4);
            btnD.Name = "btnD";
            btnD.Size = new Size(263, 66);
            btnD.TabIndex = 6;
            btnD.Tag = "D";
            btnD.Text = "   D    Declare Int score(10);";
            btnD.TextAlign = ContentAlignment.MiddleLeft;
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.WhiteSmoke;
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC.Location = new Point(57, 360);
            btnC.Margin = new Padding(3, 4, 3, 4);
            btnC.Name = "btnC";
            btnC.Size = new Size(263, 66);
            btnC.TabIndex = 5;
            btnC.Tag = "C";
            btnC.Text = "   C    var score: 10;";
            btnC.TextAlign = ContentAlignment.MiddleLeft;
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnB
            // 
            btnB.BackColor = Color.WhiteSmoke;
            btnB.FlatAppearance.BorderSize = 0;
            btnB.FlatStyle = FlatStyle.Flat;
            btnB.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB.Location = new Point(377, 266);
            btnB.Margin = new Padding(3, 4, 3, 4);
            btnB.Name = "btnB";
            btnB.Size = new Size(263, 66);
            btnB.TabIndex = 4;
            btnB.Tag = "B";
            btnB.Text = "   B    int score = 10;";
            btnB.TextAlign = ContentAlignment.MiddleLeft;
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.WhiteSmoke;
            btnA.FlatAppearance.BorderSize = 0;
            btnA.FlatStyle = FlatStyle.Flat;
            btnA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA.Location = new Point(57, 266);
            btnA.Margin = new Padding(3, 4, 3, 4);
            btnA.Name = "btnA";
            btnA.Size = new Size(263, 66);
            btnA.TabIndex = 3;
            btnA.Tag = "A";
            btnA.Text = "   A    integer score = 10;";
            btnA.TextAlign = ContentAlignment.MiddleLeft;
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.Black;
            lblQuestion.Location = new Point(69, 160);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(571, 66);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Which of the following is the correct syntax to declare an integer variable named 'score' with a value of 10?\r\n";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(183, 94);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(343, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Declaring Integers?";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSharkInner2
            // 
            pnlSharkInner2.BackColor = Color.Transparent;
            pnlSharkInner2.Location = new Point(-240, 109);
            pnlSharkInner2.Margin = new Padding(3, 4, 3, 4);
            pnlSharkInner2.Name = "pnlSharkInner2";
            pnlSharkInner2.Size = new Size(343, 400);
            pnlSharkInner2.TabIndex = 10;
            // 
            // pnlCategory
            // 
            pnlCategory.BackColor = Color.Orange;
            pnlCategory.Controls.Add(lblCategory);
            pnlCategory.Location = new Point(280, 34);
            pnlCategory.Margin = new Padding(3, 4, 3, 4);
            pnlCategory.Name = "pnlCategory";
            pnlCategory.Size = new Size(207, 46);
            pnlCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(23, 14);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(117, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "C# CHALLENGE";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSharkInner1
            // 
            pnlSharkInner1.BackColor = Color.Transparent;
            pnlSharkInner1.Location = new Point(-223, 129);
            pnlSharkInner1.Margin = new Padding(3, 4, 3, 4);
            pnlSharkInner1.Name = "pnlSharkInner1";
            pnlSharkInner1.Size = new Size(343, 400);
            pnlSharkInner1.TabIndex = 9;
            // 
            // pnlSharkOuter
            // 
            pnlSharkOuter.BackColor = Color.Transparent;
            pnlSharkOuter.BackgroundImage = Properties.Resources.shark2;
            pnlSharkOuter.BackgroundImageLayout = ImageLayout.Stretch;
            pnlSharkOuter.Location = new Point(52, 201);
            pnlSharkOuter.Margin = new Padding(3, 4, 3, 4);
            pnlSharkOuter.Name = "pnlSharkOuter";
            pnlSharkOuter.Size = new Size(247, 332);
            pnlSharkOuter.TabIndex = 8;
            // 
            // PopQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1353, 948);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PopQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz Screen";
            Load += Form1_Load;
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            pnlTimeBarBg.ResumeLayout(false);
            pnlQuizOuter.ResumeLayout(false);
            pnlQuizCard.ResumeLayout(false);
            pnlCategory.ResumeLayout(false);
            pnlCategory.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private Label lblTimeText;
        private Label lblTimer;
        private Panel pnlTimeBarBg;
        private Panel pnlTimeBarFill;
        private Panel pnlBackground;
        private Label lblTimerText;
        private Panel pnlQuizOuter;
        private Panel pnlQuizCard;
        private Button btnHint;
        private Button btnD;
        private Button btnC;
        private Button btnB;
        private Button btnA;
        private Label lblQuestion;
        private Label lblTitle;
        private Panel pnlCategory;
        private Label lblCategory;
        private Panel pnlSharkOuter;
        private Panel pnlSharkInner1;
        private Panel pnlSharkInner2;
        private System.Windows.Forms.Timer quizTimer;
    }
}
