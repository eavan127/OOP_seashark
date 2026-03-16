using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SEASHARK
{
    public class BeginnerLevel : Level
    {
        public BeginnerLevel()
        {
            difficultyIndex = 1;
            timeLimit = 300; // in seconds = 5 minutes 
            Completed = false;
        }

        public override void LoadQuiz()
        {
            // Load beginner questions here
        }
    }
}
