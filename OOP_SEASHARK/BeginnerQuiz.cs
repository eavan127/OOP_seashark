using System;

namespace OOP_GroupProject
{
    public class BeginnerQuiz : IQuiz //inheritance from the Quiz Interface
    {
        //private fields
        private string[] questions; // 1d array
        private string[][] options; // 2d array
        private int[] correctAnswerIndex;
        private int score;

        public BeginnerQuiz()
        {
            // set the three questions
            questions = new string[]
            {
                "What is the correct syntax to declare a variable in C#?",
                "Which keyword is used to create a class in C#?",
                "What does OOP stand for?"
            };

            // the options for each question, each question's option has 4 string options.
            options = new string[][]
            {
                new string[] { "int x = 5;", "x = 5;", "variable x = 5;", "int = x 5;" },
                new string[] { "object", "class", "struct", "form" },
                new string[] { "Object Oriented Programming", "Open Object Program",
                               "Output Oriented Process", "Object Order Program" }
            };

            // the index of the correct answer in the list
            correctAnswerIndex = new int[] { 0, 1, 0 };
            score = 0;
        }

        // encapsulation
        public string GetCategory() 
        { 
            return "BEGINNER CHALLENGE";  //getter
        }
        public string GetQuestion(int index) 
        { 
            return questions[index]; //getter
        }
        public string[] GetOptions(int index) 
        { 
            return options[index]; //getter
        }

        public bool CheckAns(int questionIndex, int answerIndex)
        {
                 //example:0                                 0
            return answerIndex == correctAnswerIndex[questionIndex];
        }

        public void UpdateScore() 
        { 
            score++; //setter
        }
        public int GetScore() 
        { 
            return score; //getter
        }

        // set the hints string
        public string GetHint(int questionIndex)
        {
            string[] hints = new string[]
            {
                "In C#, \"int\" stands for integer and is used to store whole numbers without decimals (e.g., 5, 10, 100).\n\nIf your value contains decimal points, you should use \"double\" (e.g., 3.14, 2.75), which can store floating-point numbers.\n\nChoosing the correct data type helps your program run correctly and efficiently.",
                "The 'class' keyword is the fundamental building block of Object-Oriented Programming in C#. It acts as a blueprint or template for creating objects.\n\nInside a class, you define the properties (data) and methods (behavior) that the object will have. Most languages like Java and C++ use this same standard keyword.",
                "OOP stands for Object-Oriented Programming. This approach organizes software design around data, or objects, rather than functions and logic.\n\nAn object can be defined as a data field that has unique attributes and behavior. Think of the letters: O for Object, O for Oriented, and P for Programming!"
            };
            return hints[questionIndex]; //getter
        }

        public int TotalQuestions() 
        { 
            return questions.Length; //getter
        }
    }
}
