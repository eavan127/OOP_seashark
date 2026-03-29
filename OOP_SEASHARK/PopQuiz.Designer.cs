using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_SEASHARK
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
            this.components = new System.ComponentModel.Container();
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnHint = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimerText = new System.Windows.Forms.Label();
            this.pnlTimeBarBg = new System.Windows.Forms.Panel();
            this.pnlTimeBarFill = new System.Windows.Forms.Panel();
            this.pnlQuizOuter = new System.Windows.Forms.Panel();
            this.pnlQuizCard = new System.Windows.Forms.Panel();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSharkInner2 = new System.Windows.Forms.Panel();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlSharkInner1 = new System.Windows.Forms.Panel();
            this.pnlSharkOuter = new System.Windows.Forms.Panel();
            this.pnlBackground.SuspendLayout();
            this.pnlTimeBarBg.SuspendLayout();
            this.pnlQuizOuter.SuspendLayout();
            this.pnlQuizCard.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // quizTimer
            // 
            this.quizTimer.Interval = 1000;
            this.quizTimer.Tick += new System.EventHandler(this.quizTimer_Tick);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackground.BackgroundImage = global::OOP_SEASHARK.Properties.Resources.background_sea;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.btnHint);
            this.pnlBackground.Controls.Add(this.lblTimer);
            this.pnlBackground.Controls.Add(this.lblTimerText);
            this.pnlBackground.Controls.Add(this.pnlTimeBarBg);
            this.pnlBackground.Controls.Add(this.pnlQuizOuter);
            this.pnlBackground.Controls.Add(this.pnlSharkOuter);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1353, 758);
            this.pnlBackground.TabIndex = 6;
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackground_Paint_1);
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.Transparent;
            this.btnHint.BackgroundImage = global::OOP_SEASHARK.Properties.Resources.lightbulb;
            this.btnHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHint.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHint.FlatAppearance.BorderSize = 0;
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(1054, 464);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(86, 80);
            this.btnHint.TabIndex = 7;
            this.btnHint.UseVisualStyleBackColor = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Orange;
            this.lblTimer.Location = new System.Drawing.Point(867, 576);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(37, 23);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "30s";
            this.lblTimer.Visible = false;
            // 
            // lblTimerText
            // 
            this.lblTimerText.AutoSize = true;
            this.lblTimerText.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerText.ForeColor = System.Drawing.Color.Orange;
            this.lblTimerText.Location = new System.Drawing.Point(454, 576);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.Size = new System.Drawing.Size(141, 23);
            this.lblTimerText.TabIndex = 6;
            this.lblTimerText.Text = "Time Remaining";
            this.lblTimerText.Visible = false;
            // 
            // pnlTimeBarBg
            // 
            this.pnlTimeBarBg.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTimeBarBg.Controls.Add(this.pnlTimeBarFill);
            this.pnlTimeBarBg.Location = new System.Drawing.Point(454, 624);
            this.pnlTimeBarBg.Name = "pnlTimeBarBg";
            this.pnlTimeBarBg.Padding = new System.Windows.Forms.Padding(2);
            this.pnlTimeBarBg.Size = new System.Drawing.Size(446, 21);
            this.pnlTimeBarBg.TabIndex = 5;
            // 
            // pnlTimeBarFill
            // 
            this.pnlTimeBarFill.BackColor = System.Drawing.Color.Orange;
            this.pnlTimeBarFill.Location = new System.Drawing.Point(6, 5);
            this.pnlTimeBarFill.Name = "pnlTimeBarFill";
            this.pnlTimeBarFill.Size = new System.Drawing.Size(434, 11);
            this.pnlTimeBarFill.TabIndex = 6;
            // 
            // pnlQuizOuter
            // 
            this.pnlQuizOuter.BackColor = System.Drawing.Color.Orange;
            this.pnlQuizOuter.Controls.Add(this.pnlQuizCard);
            this.pnlQuizOuter.Controls.Add(this.pnlSharkInner1);
            this.pnlQuizOuter.Location = new System.Drawing.Point(305, 107);
            this.pnlQuizOuter.Name = "pnlQuizOuter";
            this.pnlQuizOuter.Padding = new System.Windows.Forms.Padding(11);
            this.pnlQuizOuter.Size = new System.Drawing.Size(743, 437);
            this.pnlQuizOuter.TabIndex = 7;
            // 
            // pnlQuizCard
            // 
            this.pnlQuizCard.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlQuizCard.Controls.Add(this.btnD);
            this.pnlQuizCard.Controls.Add(this.btnC);
            this.pnlQuizCard.Controls.Add(this.btnB);
            this.pnlQuizCard.Controls.Add(this.btnA);
            this.pnlQuizCard.Controls.Add(this.lblQuestion);
            this.pnlQuizCard.Controls.Add(this.lblTitle);
            this.pnlQuizCard.Controls.Add(this.pnlSharkInner2);
            this.pnlQuizCard.Controls.Add(this.pnlCategory);
            this.pnlQuizCard.Location = new System.Drawing.Point(17, 16);
            this.pnlQuizCard.Name = "pnlQuizCard";
            this.pnlQuizCard.Size = new System.Drawing.Size(709, 405);
            this.pnlQuizCard.TabIndex = 2;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(377, 288);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(263, 53);
            this.btnD.TabIndex = 6;
            this.btnD.Tag = "D";
            this.btnD.Text = "   D    Declare Int score(10);";
            this.btnD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(57, 288);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(263, 53);
            this.btnC.TabIndex = 5;
            this.btnC.Tag = "C";
            this.btnC.Text = "   C    var score: 10;";
            this.btnC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(377, 213);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(263, 53);
            this.btnB.TabIndex = 4;
            this.btnB.Tag = "B";
            this.btnB.Text = "   B    int score = 10;";
            this.btnB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(57, 213);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(263, 53);
            this.btnA.TabIndex = 3;
            this.btnA.Tag = "A";
            this.btnA.Text = "   A    integer score = 10;";
            this.btnA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion.Location = new System.Drawing.Point(69, 128);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(571, 53);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Which of the following is the correct syntax to declare an integer variable named" +
    " \'score\' with a value of 10?\r\n";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(183, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 43);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Declaring Integers?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSharkInner2
            // 
            this.pnlSharkInner2.BackColor = System.Drawing.Color.Transparent;
            this.pnlSharkInner2.Location = new System.Drawing.Point(-240, 87);
            this.pnlSharkInner2.Name = "pnlSharkInner2";
            this.pnlSharkInner2.Size = new System.Drawing.Size(343, 320);
            this.pnlSharkInner2.TabIndex = 10;
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.Orange;
            this.pnlCategory.Controls.Add(this.lblCategory);
            this.pnlCategory.Location = new System.Drawing.Point(280, 27);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(176, 37);
            this.pnlCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(23, 11);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(117, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "C# CHALLENGE";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSharkInner1
            // 
            this.pnlSharkInner1.BackColor = System.Drawing.Color.Transparent;
            this.pnlSharkInner1.Location = new System.Drawing.Point(-223, 103);
            this.pnlSharkInner1.Name = "pnlSharkInner1";
            this.pnlSharkInner1.Size = new System.Drawing.Size(343, 320);
            this.pnlSharkInner1.TabIndex = 9;
            // 
            // pnlSharkOuter
            // 
            this.pnlSharkOuter.BackColor = System.Drawing.Color.Transparent;
            this.pnlSharkOuter.BackgroundImage = global::OOP_SEASHARK.Properties.Resources.shark2;
            this.pnlSharkOuter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSharkOuter.Location = new System.Drawing.Point(52, 161);
            this.pnlSharkOuter.Name = "pnlSharkOuter";
            this.pnlSharkOuter.Size = new System.Drawing.Size(247, 266);
            this.pnlSharkOuter.TabIndex = 8;
            // 
            // PopQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 758);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PopQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlTimeBarBg.ResumeLayout(false);
            this.pnlQuizOuter.ResumeLayout(false);
            this.pnlQuizCard.ResumeLayout(false);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.ResumeLayout(false);

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
