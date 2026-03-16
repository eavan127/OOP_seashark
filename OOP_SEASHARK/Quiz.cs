using System;

namespace OOP_SEASHARK
{
    public class Quiz
    {
        private string[] questions;
        private string[][] options;
        private int[] correctAnswerIndex;
        private int currentQuestionIndex;
        private int score;

        public Quiz()
        {
            questions = new string[]
            {
                "What is the correct syntax to declare a variable in C#?",
                "Which keyword is used to create a class in C#?",
                "What does OOP stand for?"
            };

            options = new string[][]
            {
                new string[] { "int x = 5;", "x = 5;", "variable x = 5;", "int = x 5;" },
                new string[] { "object", "class", "struct", "form" },
                new string[] { "Object Oriented Programming", "Open Object Program",
                               "Output Oriented Process", "Object Order Program" }
            };

            correctAnswerIndex = new int[] { 0, 1, 0 };
            currentQuestionIndex = 0;
            score = 0;
        }

        public string GetQuestion(int index) { return questions[index]; }
        public string[] GetOptions(int index) { return options[index]; }

        public bool CheckAns(int questionIndex, int answerIndex)
        {
            return answerIndex == correctAnswerIndex[questionIndex];
        }

        public void UpdateScore() { score++; }
        public int GetScore() { return score; }

        public string GetHint(int questionIndex)
        {
            string[] hints = new string[]
            {
                "Hint: In C#, you must declare the data type before the variable name!",
                "Hint: It is the same keyword used in most OOP languages!",
                "Hint: Think about what the letters stand for — Object, Oriented..."
            };
            return hints[questionIndex];
        }

        public int TotalQuestions() { return questions.Length; }
    }
}