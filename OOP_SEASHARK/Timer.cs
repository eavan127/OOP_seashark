using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GroupProject
{
    public class Timer
    {
        private int timeLeft;

        public void StartTimer(double timeLimit)
        {
            // We get the time limit from the level (usually 300 or 420 seconds)
            timeLeft = (int)timeLimit; 
        }


        public void UpdateTimer()
        {
            timeLeft--;
        }

        public bool TimeUp()
        {
            return timeLeft <= 0;
        }

        public int GetTimeLeft()
        {
            return timeLeft;
        }
    }
}
