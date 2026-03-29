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
                "Polymorphism allows objects of different classes to be treated as objects of a common superclass. This is often achieved through 'method overriding' where a subclass provides its own version of a method already defined in its parent class.",
                "Encapsulation is the practice of bundling data (fields) and the methods that operate on that data into a single unit (class). It also involves using access modifiers like 'private' to hide internal data from outside interference.",
                "In C#, a class can only inherit from one other class (single inheritance). However, to achieve similar results to multiple inheritance, a class can implement multiple 'interfaces', which define contracts for behavior."
            };
            return hints[questionIndex];
        }

        public int TotalQuestions() { return questions.Length; }
    }
}
