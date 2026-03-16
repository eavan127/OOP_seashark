using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SEASHARK
{
    public abstract class Level
    {
        protected int difficultyIndex;
        protected double timeLimit;
        protected bool Completed; 
        private List<Quiz> quiz = new List<Quiz>();

        public abstract void LoadQuiz();
        public virtual void StartLevel() { }

        public virtual void CompleteLevel() { Completed = true;
        }
        public double GetTimeLimit()
        {
            return timeLimit;
        }
    }
}
