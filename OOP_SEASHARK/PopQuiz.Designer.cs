//using System;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

//namespace OOP_SEASHARK
//{
//    public partial class PopQuiz : Form
//    {
//        public bool AnsweredCorrectly = false;

//        private Quiz quiz;
//        private int obstacleIndex;
//        private int timeLeft;

//        public PopQuiz(int obstacleIndex, int timeLeft)
//        {
//            InitializeComponent();
//            this.obstacleIndex = obstacleIndex;
//            this.timeLeft = timeLeft;

//            quiz = new Quiz();
//            LoadQuestion();
//        }

//        // =====================
//        // LOAD QUESTION
//        // =====================
//        private void LoadQuestion()
//        {
//        }

//        // =====================
//        // ANSWER BUTTONS
//        // =====================
//        private void btnA_Click(object sender, EventArgs e)
//        {
//            CheckAnswer(0);
//        }

//        private void btnB_Click(object sender, EventArgs e)
//        {
//            CheckAnswer(1);
//        }

//        private void btnC_Click(object sender, EventArgs e)
//        {
//            CheckAnswer(2);
//        }

//        private void btnD_Click(object sender, EventArgs e)
//        {
//            CheckAnswer(3);
//        }

//        private void CheckAnswer(int selectedIndex)
//        {
   
//        }

//        // =====================
//        // HINT BUTTON
//        // =====================
//        private void btnHint_Click(object sender, EventArgs e)
//        {
//        }

//        // =====================
//        // LOAD EVENT
//        // =====================
//        private void Quiz_Load(object sender, EventArgs e)
//        {
//        }
//    }
//}