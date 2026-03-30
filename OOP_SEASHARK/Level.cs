using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GroupProject
{
    public abstract class Level
    {
        protected int difficultyIndex;
        protected double timeLimit;
        protected bool Completed; 
        private List<IQuiz> quiz = new List<IQuiz>();

        public abstract void LoadQuiz();
        public virtual void StartLevel() { }

        // This marks the level as finished, good job!
        public virtual void CompleteLevel() { Completed = true;
        }

        public double GetTimeLimit()
        {
            return timeLimit;
        }
    }
}
