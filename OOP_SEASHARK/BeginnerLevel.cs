using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GroupProject
{
    public class BeginnerLevel : Level
    {
        public BeginnerLevel()
        {
            difficultyIndex = 1;

            // We give the player 5 minutes (300 seconds) to finish this level
            timeLimit = 300; 
            Completed = false;
        }

        public override void LoadQuiz()
        {
            // This is where we'll set up all the beginner-friendly questions
        }
    }
}
