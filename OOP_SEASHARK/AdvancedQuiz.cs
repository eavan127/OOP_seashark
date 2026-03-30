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
            // Here's our list of tougher, advanced-level questions
            questions = new string[]
            {
                "Which of the following is an example of Polymorphism?",
                "What is the principle of Encapsulation?",
                "Does C# support multiple inheritance for classes?"
            };

            // And the options for each question
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
                "Polymorphism allows objects of different classes to be treated as objects of a common superclass. This is often achieved through 'method overriding'.\n\nFor example, if you have a 'Fish' superclass with a 'Swim' method, you can have 'Shark' and 'Dolphin' subclasses that provide their own specialized 'Swim' behavior.\n\nThis makes your code more flexible and easier to maintain by focusing on what an object *does* rather than what it *is*.",
                "Encapsulation is the principle of bundling data and methods into a single unit (a class). It also involves restricting direct access to some of the object's components.\n\nIn C#, we use 'private' fields and 'public' properties to achieve this. This protects the internal state of an object from being modified in an uncontrolled way by outside code.\n\nIt is like a black box: you know how to interact with it, but you don't need to know its internal details.",
                "In C#, a class can only inherit from one other class. This is called single inheritance. It prevents the complexity and ambiguity that can arise from multiple inheritance.\n\nHowever, a class can implement multiple 'interfaces'. An interface defines a contract of behavior that a class must provide.\n\nThis gives you the benefits of multiple inheritance without the diamond problem or other common complications."
            };
            return hints[questionIndex];
        }

        public int TotalQuestions() { return questions.Length; }
    }
}
