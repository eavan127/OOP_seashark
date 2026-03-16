using System;
using System.Windows.Forms;

namespace OOP_SEASHARK
{
    public partial class PopQuiz : Form
    {
        public bool AnsweredCorrectly = false;

        private Quiz quiz;
        private int obstacleIndex;
        private int timeLeft;

        public PopQuiz(int obstacleIndex, int timeLeft)
        {
            InitializeComponent();
            this.obstacleIndex = obstacleIndex;
            this.timeLeft = timeLeft;

            quiz = new Quiz();
            LoadQuestion();
        }

        // LOAD QUESTION
        private void LoadQuestion()
        {
            lblQuestion.Text = quiz.GetQuestion(obstacleIndex);
            string[] opts = quiz.GetOptions(obstacleIndex);
            btnA.Text = "A. " + opts[0];
            btnB.Text = "B. " + opts[1];
            btnC.Text = "C. " + opts[2];
            btnD.Text = "D. " + opts[3];
            lblHint.Text = "";
        }

        // ANSWER BUTTONS
        private void btnA_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void CheckAnswer(int selectedIndex)
        {
            if (quiz.CheckAns(obstacleIndex, selectedIndex))
            {
                AnsweredCorrectly = true;
                quiz.UpdateScore();
                MessageBox.Show("Correct! 🎉", "Pop Quiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AnsweredCorrectly = false;
                MessageBox.Show("Wrong answer! ❌", "Pop Quiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        // HINT BUTTON
        private void btnHint_Click(object sender, EventArgs e)
        {
            lblHint.Text = quiz.GetHint(obstacleIndex);
        }

        // LOAD EVENT
        private void Quiz_Load(object sender, EventArgs e)
        {
        }
    }
}
