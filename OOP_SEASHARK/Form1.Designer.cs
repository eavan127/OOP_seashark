namespace OOP_GroupProject
{
    partial class frmQuiz
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
            lblTimer = new Label();
            pnlTimeBarBg = new Panel();
            pnlTimeBarFill = new Panel();
            pnlBackground = new Panel();
            btnHint = new Button();
            lblTimerText = new Label();
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
            quizTimer = new System.Windows.Forms.Timer(components);
            pnlTimeBarBg.SuspendLayout();
            pnlBackground.SuspendLayout();
            pnlQuizOuter.SuspendLayout();
            pnlQuizCard.SuspendLayout();
            pnlCategory.SuspendLayout();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.Orange;
            lblTimer.Location = new Point(759, 540);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(28, 17);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "30s";
            lblTimer.Visible = false;
            // 
            // pnlTimeBarBg
            // 
            pnlTimeBarBg.BackColor = Color.SteelBlue;
            pnlTimeBarBg.Controls.Add(pnlTimeBarFill);
            pnlTimeBarBg.Location = new Point(397, 585);
            pnlTimeBarBg.Name = "pnlTimeBarBg";
            pnlTimeBarBg.Padding = new Padding(2);
            pnlTimeBarBg.Size = new Size(390, 20);
            pnlTimeBarBg.TabIndex = 5;
            // 
            // pnlTimeBarFill
            // 
            pnlTimeBarFill.BackColor = Color.Orange;
            pnlTimeBarFill.Location = new Point(5, 5);
            pnlTimeBarFill.Name = "pnlTimeBarFill";
            pnlTimeBarFill.Size = new Size(380, 10);
            pnlTimeBarFill.TabIndex = 6;
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.Transparent;
            pnlBackground.BackgroundImage = Properties.Resources.background_blur;
            pnlBackground.BackgroundImageLayout = ImageLayout.None;
            pnlBackground.Controls.Add(btnHint);
            pnlBackground.Controls.Add(lblTimer);
            pnlBackground.Controls.Add(lblTimerText);
            pnlBackground.Controls.Add(pnlTimeBarBg);
            pnlBackground.Controls.Add(pnlQuizOuter);
            pnlBackground.Controls.Add(pnlSharkOuter);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(1184, 711);
            pnlBackground.TabIndex = 6;
            pnlBackground.Paint += pnlBackground_Paint;
            // 
            // btnHint
            // 
            btnHint.BackColor = Color.White;
            btnHint.FlatAppearance.BorderSize = 0;
            btnHint.FlatStyle = FlatStyle.Flat;
            btnHint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHint.Image = Properties.Resources.hint_icon1;
            btnHint.Location = new Point(858, 450);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(75, 75);
            btnHint.TabIndex = 7;
            btnHint.UseVisualStyleBackColor = false;
            // 
            // lblTimerText
            // 
            lblTimerText.AutoSize = true;
            lblTimerText.BackColor = Color.Transparent;
            lblTimerText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimerText.ForeColor = Color.Orange;
            lblTimerText.Location = new Point(397, 540);
            lblTimerText.Name = "lblTimerText";
            lblTimerText.Size = new Size(109, 17);
            lblTimerText.TabIndex = 6;
            lblTimerText.Text = "Time Remaining";
            lblTimerText.Visible = false;
            // 
            // pnlQuizOuter
            // 
            pnlQuizOuter.BackColor = Color.Orange;
            pnlQuizOuter.Controls.Add(pnlQuizCard);
            pnlQuizOuter.Controls.Add(pnlSharkInner1);
            pnlQuizOuter.Location = new Point(267, 100);
            pnlQuizOuter.Name = "pnlQuizOuter";
            pnlQuizOuter.Padding = new Padding(10);
            pnlQuizOuter.Size = new Size(650, 410);
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
            pnlQuizCard.Location = new Point(15, 15);
            pnlQuizCard.Name = "pnlQuizCard";
            pnlQuizCard.Size = new Size(620, 380);
            pnlQuizCard.TabIndex = 2;
            // 
            // btnD
            // 
            btnD.BackColor = Color.WhiteSmoke;
            btnD.FlatAppearance.BorderSize = 0;
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnD.Location = new Point(330, 270);
            btnD.Name = "btnD";
            btnD.Size = new Size(230, 50);
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
            btnC.Location = new Point(50, 270);
            btnC.Name = "btnC";
            btnC.Size = new Size(230, 50);
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
            btnB.Location = new Point(330, 200);
            btnB.Name = "btnB";
            btnB.Size = new Size(230, 50);
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
            btnA.Location = new Point(50, 200);
            btnA.Name = "btnA";
            btnA.Size = new Size(230, 50);
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
            lblQuestion.Location = new Point(60, 120);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(500, 50);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Which of the following is the correct syntax to declare an integer variable named 'score' with a value of 10?\r\n";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(160, 70);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Declaring Integers?";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSharkInner2
            // 
            pnlSharkInner2.BackColor = Color.Transparent;
            pnlSharkInner2.BackgroundImage = Properties.Resources.shark1;
            pnlSharkInner2.Location = new Point(-210, 82);
            pnlSharkInner2.Name = "pnlSharkInner2";
            pnlSharkInner2.Size = new Size(300, 300);
            pnlSharkInner2.TabIndex = 10;
            // 
            // pnlCategory
            // 
            pnlCategory.BackColor = Color.Orange;
            pnlCategory.Controls.Add(lblCategory);
            pnlCategory.Location = new Point(245, 25);
            pnlCategory.Name = "pnlCategory";
            pnlCategory.Size = new Size(130, 35);
            pnlCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(20, 10);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "C# CHALLENGE";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSharkInner1
            // 
            pnlSharkInner1.BackColor = Color.Transparent;
            pnlSharkInner1.BackgroundImage = Properties.Resources.shark1;
            pnlSharkInner1.Location = new Point(-195, 97);
            pnlSharkInner1.Name = "pnlSharkInner1";
            pnlSharkInner1.Size = new Size(300, 300);
            pnlSharkInner1.TabIndex = 9;
            // 
            // pnlSharkOuter
            // 
            pnlSharkOuter.BackColor = Color.Transparent;
            pnlSharkOuter.BackgroundImage = Properties.Resources.shark1;
            pnlSharkOuter.Location = new Point(72, 197);
            pnlSharkOuter.Name = "pnlSharkOuter";
            pnlSharkOuter.Size = new Size(300, 300);
            pnlSharkOuter.TabIndex = 8;
            // 
            // quizTimer
            // 
            quizTimer.Interval = 1000;
            quizTimer.Tick += quizTimer_Tick;
            // 
            // frmQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 711);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz Screen";
            Load += Form1_Load;
            pnlTimeBarBg.ResumeLayout(false);
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
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
