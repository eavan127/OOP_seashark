using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace OOP_GroupProject

{
    public partial class PopQuiz : Form
    {
        public bool AnsweredCorrectly = false;
        private IQuiz quiz;
        private int obstacleIndex;

        private OutlineLabel lblTimeTextOutline;
        private OutlineLabel lblTimeOutline;

        private int totalTime = 30;
        private int timeLeft = 30;
        private int maxFillWidth;

        private PictureBox picAnswerResult;
        private bool quizAnswered = false;

        public PopQuiz(int obstacleIndex, int timeLeft, IQuiz quiz)
        {
            InitializeComponent();
            this.obstacleIndex = obstacleIndex;
            this.timeLeft = timeLeft;
            this.totalTime = timeLeft;
            this.quiz = quiz;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBackground.SendToBack();
            pnlQuizCard.BringToFront();
            lblTimerText.BringToFront();
            lblTimer.BringToFront();
            pnlTimeBarBg.BringToFront();
            pnlTimeBarFill.BringToFront();

            MakeRoundedPanel(pnlQuizCard, 30);
            MakeRoundedPanel(pnlCategory, 15);

            MakeRoundedButton(btnA, 25);
            MakeRoundedButton(btnB, 25);
            MakeRoundedButton(btnC, 25);
            MakeRoundedButton(btnD, 25);

            MakeRoundedControl(pnlTimeBarBg, pnlTimeBarBg.Height);
            MakeRoundedControl(pnlTimeBarFill, pnlTimeBarFill.Height);

            DrawRoundedBorder(pnlQuizOuter, 49, 7, Color.White);

            MakeCircleButton(btnHint);
            MakeCircleButton(btnHint);
            DrawCircleBorder(btnHint, 4, Color.Orange);

            lblTimeTextOutline = new OutlineLabel();
            lblTimeTextOutline.Text = "Time Remaining";
            lblTimeTextOutline.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTimeTextOutline.ForeColor = Color.Orange;
            lblTimeTextOutline.OutlineColor = Color.White;
            lblTimeTextOutline.OutlineWidth = 4f;
            lblTimeTextOutline.Size = new Size(220, 40);
            lblTimeTextOutline.Location = new Point(400, 540);
            lblTimeTextOutline.TextAlign = ContentAlignment.MiddleLeft;
            lblTimeTextOutline.Parent = pnlBackground;
            lblTimeTextOutline.BackColor = Color.Transparent;

            lblTimeOutline = new OutlineLabel();
            lblTimeOutline.Text = "15s";
            lblTimeOutline.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTimeOutline.ForeColor = Color.Orange;
            lblTimeOutline.OutlineColor = Color.White;
            lblTimeOutline.OutlineWidth = 4f;
            lblTimeOutline.Size = new Size(80, 40);
            lblTimeOutline.Location = new Point(700, 540);
            lblTimeOutline.TextAlign = ContentAlignment.MiddleRight;
            lblTimeOutline.Parent = pnlBackground;
            lblTimeOutline.BackColor = Color.Transparent;

            pnlBackground.Controls.Add(lblTimeTextOutline);
            pnlBackground.Controls.Add(lblTimeOutline);

            lblTimeTextOutline.BringToFront();
            lblTimeOutline.BringToFront();

            // We don't need the default labels since we've got our custom outlined ones now
            lblTimerText.Visible = false;
            lblTimer.Visible = false;

            // We'll keep track of how wide the bar is so we can shrink it as time runs out
            maxFillWidth = pnlTimeBarFill.Width;

            // starting text
            lblTimeOutline.Text = timeLeft + "s";
            lblTimeOutline.Invalidate();

            // Let's get that timer started right away!
            quizTimer.Start();

            // Time to load up the questions and answers
            lblCategory.Text = quiz.GetCategory();
            lblTitle.Text = $"Question {obstacleIndex + 1}";
            lblQuestion.Text = quiz.GetQuestion(obstacleIndex);
            
            string[] opts = quiz.GetOptions(obstacleIndex);
            btnA.Text = "   A    " + opts[0];
            btnB.Text = "   B    " + opts[1];
            btnC.Text = "   C    " + opts[2];
            btnD.Text = "   D    " + opts[3];

            btnHint.Click += BtnHint_Click;

            picAnswerResult = new PictureBox();
            picAnswerResult.Size = new Size(35, 35);
            picAnswerResult.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnswerResult.BackColor = Color.Transparent;
            picAnswerResult.Visible = false;
            picAnswerResult.Parent = pnlQuizCard;

            pnlQuizCard.Controls.Add(picAnswerResult);
            picAnswerResult.BringToFront();

        }

        private void MakeRoundedPanel(Control ctrl, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(ctrl.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(ctrl.Width - radius - 1, ctrl.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, ctrl.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();
            ctrl.Region = new Region(path);
        }

        private void MakeRoundedButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            btn.Region = new Region(path);
        }

        private void MakeCircleButton(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void MakeRoundedControl(Control ctrl, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(ctrl.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(ctrl.Width - radius - 1, ctrl.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, ctrl.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();

            ctrl.Region = new Region(path);
        }

        private void DrawRoundedBorder(Panel panel, int radius, int borderThickness, Color borderColor)
        {
            GraphicsPath path = new GraphicsPath();

            int r = radius;
            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);

            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }
        private void DrawCircleBorder(Button btn, int thickness, Color borderColor)
        {
            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(
                    thickness / 2,
                    thickness / 2,
                    btn.Width - thickness,
                    btn.Height - thickness
                );

                using (Pen pen = new Pen(borderColor, thickness))
                {
                    e.Graphics.DrawEllipse(pen, rect);
                }
            };
        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;

                // Time to update the clock on the screen
                lblTimeOutline.Text = timeLeft + "s";
                lblTimeOutline.Invalidate();

                // We'll shrink the progress bar to show the time ticking away
                int newWidth = (timeLeft * maxFillWidth) / totalTime;

                if (newWidth < 0)
                    newWidth = 0;

                pnlTimeBarFill.Width = newWidth;

                // Need to make sure the bar stays rounded even as it gets smaller
                MakeRoundedControl(pnlTimeBarFill, pnlTimeBarFill.Height);
            }
            else
            {
                quizTimer.Stop();

                lblTimeOutline.Text = "0s";
                lblTimeOutline.Invalidate();

                AnsweredCorrectly = false;
                MessageBox.Show("Time is up!", "Quiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private async void CheckAnswer(int answerIndex, Button clickedButton)
        {
            if (quizAnswered)
                return;

            quizAnswered = true;

            // The player answered, so we can stop the clock
            quizTimer.Stop();

            // Let's disable the buttons so they can't change their mind
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            // place image beside clicked button
            picAnswerResult.Location = new Point(
                clickedButton.Right,
                clickedButton.Top + (clickedButton.Height - picAnswerResult.Height) / 2
            );

            // Now let's see if they got it right or not...
            if (quiz.CheckAns(obstacleIndex, answerIndex))
            {
                AnsweredCorrectly = true;
                quiz.UpdateScore();
                picAnswerResult.Visible = true;

                MessageBox.Show("Correct! 🎉 Your answer is correct!", "Quiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AnsweredCorrectly = false;
                picAnswerResult.Visible = true;

                MessageBox.Show("Wrong answer! ❌ Try to do better next time!", "Quiz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Wait 1.5 seconds so player can see the image icon before closing
            await System.Threading.Tasks.Task.Delay(1500);
            this.Close();
        }

        private void btnA_Click(object sender, EventArgs e) { CheckAnswer(0, btnA); }
        private void btnB_Click(object sender, EventArgs e) { CheckAnswer(1, btnB); }
        private void btnC_Click(object sender, EventArgs e) { CheckAnswer(2, btnC); }
        private void btnD_Click(object sender, EventArgs e) { CheckAnswer(3, btnD); }

        private void BtnHint_Click(object sender, EventArgs e)
        {
            string hintText = quiz.GetHint(obstacleIndex);
            
            // "Jump" to the hint page by hiding the quiz form
            
            frmHint hintForm = new frmHint(hintText);
            hintForm.ShowDialog();
            
            // Return to the quiz form
            this.Show();
        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBackground_Paint_1(object sender, PaintEventArgs e)
        {

        }


        //private void ResetQuiz()
        //{
        //    quizAnswered = false;

        //    btnA.Enabled = true;
        //    btnB.Enabled = true;
        //    btnC.Enabled = true;
        //    btnD.Enabled = true;

        //    picAnswerResult.Visible = false;

        //    timeLeft = totalTime;
        //    pnlTimeBarFill.Width = maxFillWidth;
        //    MakeRoundedControl(pnlTimeBarFill, pnlTimeBarFill.Height);

        //    lblTimeOutline.Text = timeLeft + "s";
        //    lblTimeOutline.Invalidate();

        //    quizTimer.Start();
        //}
    }




}
