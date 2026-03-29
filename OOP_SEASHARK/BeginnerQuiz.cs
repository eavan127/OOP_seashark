using System;

namespace OOP_GroupProject
{
    public class BeginnerQuiz : IQuiz
    {
        private string[] questions;
        private string[][] options;
        private int[] correctAnswerIndex;
        private int score;

        public BeginnerQuiz()
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
            score = 0;
        }

        public string GetCategory() { return "BEGINNER CHALLENGE"; }
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
                "In C#, every variable must have a defined type (like int, string, or bool). The standard way to declare a variable is: [Type] [Variable Name] = [Value]; For example: int score = 10;",
                "Classes are the blueprints for objects in OOP. In C#, you define them using the 'class' keyword followed by the name of the class (usually capitalized).",
                "OOP stands for Object-Oriented Programming. It is a programming paradigm based on the concept of 'objects', which can contain data and code: data in the form of fields, and code in the form of procedures."
            };
            return hints[questionIndex];
        }

        public int TotalQuestions() { return questions.Length; }
    }
}
