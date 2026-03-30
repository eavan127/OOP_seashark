using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GroupProject
{
    public class AdvancedLevel : Level
    {
        public AdvancedLevel()
        {
            // Advanced level is tougher, so we'll give them 7 minutes (420 seconds)
            timeLimit = 420;

        }
        public override void LoadQuiz() { }
    }
}