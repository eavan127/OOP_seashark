using System;

namespace OOP_GroupProject
{
    public class AdvancedQuiz : IQuiz
    {
        private string[] questions;
        private string[][] options;
        private int[] correctAnswerIndex;
        private int score;

        public AdvancedQuiz()
        {
            questions = new string[]
            {
                "Which of the following is an example of Polymorphism?",
                "What is the principle of Encapsulation?",
                "Does C# support multiple inheritance for classes?"
            };

            options = new string[][]
            {
                new string[] { "Declaring variables", "Method overriding", "A single class", "Using properties" },
                new string[] { "Hiding internal data", "Code repetition", "Global variable", "No access modifiers" },
                new string[] { "Yes, directly", "No, only via interfaces", "Yes, with base keyword", "None of the above" }
            };

            correctAnswerIndex = new int[] { 1, 0, 1 };
            score = 0;
        }

        public string GetCategory() { return "ADVANCED CHALLENGE"; }
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
                "Hint: Poly means many, morph means forms. Think of overridden methods.",
                "Hint: It restricts direct access to some components of an object.",
                "Hint: C# classes can inherit from only one base class."
            };
            return hints[questionIndex];
        }

        public int TotalQuestions() { return questions.Length; }
    }
}
