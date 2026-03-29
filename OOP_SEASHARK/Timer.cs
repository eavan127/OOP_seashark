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
            timeLeft = (int)timeLimit; // gets 300 or 420 from Level
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
