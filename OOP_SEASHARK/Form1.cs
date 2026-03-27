using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using OOP_SEASHARK.Properties;
namespace OOP_GroupProject

{
    public partial class frmQuiz: Form
    {
        private OutlineLabel lblTimeTextOutline;
        private OutlineLabel lblTimeOutline;

        private int totalTime = 30;
        private int timeLeft = 30;
        private int maxFillWidth;

        private PictureBox picAnswerResult;
        private string correctAnswer = "B";
        private bool quizAnswered = false;
        public frmQuiz()
        {
            InitializeComponent();
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

            // hide old normal labels if you already replaced them
            lblTimerText.Visible = false;
            lblTimer.Visible = false;

            // store full width of orange time bar
            maxFillWidth = pnlTimeBarFill.Width;

            // starting text
            lblTimeOutline.Text = timeLeft + "s";
            lblTimeOutline.Invalidate();

            // start timer immediately when quiz screen appears
            quizTimer.Start();

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

                // update timer text
                lblTimeOutline.Text = timeLeft + "s";
                lblTimeOutline.Invalidate();

                // update orange progress bar
                int newWidth = (timeLeft * maxFillWidth) / totalTime;

                if (newWidth < 0)
                    newWidth = 0;

                pnlTimeBarFill.Width = newWidth;

                // re-round after width changes
                MakeRoundedControl(pnlTimeBarFill, pnlTimeBarFill.Height);
            }
            else
            {
                quizTimer.Stop();

                lblTimeOutline.Text = "0s";
                lblTimeOutline.Invalidate();

                MessageBox.Show("Time is up!", "Quiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckAnswer(string selectedAnswer, Button clickedButton)
        {
            if (quizAnswered)
                return;

            quizAnswered = true;

            // stop timer when player answers
            quizTimer.Stop();

            // disable all answer buttons
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            // place image beside clicked button
            picAnswerResult.Location = new Point(
                clickedButton.Right,
                clickedButton.Top + (clickedButton.Height - picAnswerResult.Height) / 2
            );

            // check correct or wrong
            if (selectedAnswer == correctAnswer)
            {
                picAnswerResult.Image = OOP_SEASHARK.Properties.Resources.correct_icon;
                picAnswerResult.Visible = true;

                // MessageBox.Show("Correct answer!", "Quiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                picAnswerResult.Image = OOP_SEASHARK.Properties.Resources.incorrect_icon;
                picAnswerResult.Visible = true;

                // MessageBox.Show("Wrong answer!", "Quiz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            CheckAnswer("A", btnA);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            CheckAnswer("B", btnB);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CheckAnswer("C", btnC);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            CheckAnswer("D", btnD);
        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e)
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
