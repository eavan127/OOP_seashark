using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GroupProject
{
    public class Timer
    {
        private int timeLeft; //Apply Encapsulation

        public void StartTimer(double timeLimit) // Method to start or initialize the timer
        {
            // We get the time limit from the level (usually 300 or 420 seconds)
            timeLeft = (int)timeLimit; 
        }

        public void UpdateTimer()
        {
            timeLeft--;  // Decrease time by 1 (countdown effect)
        }

        public bool TimeUp() //To check if time is finished 

        {
            return timeLeft <= 0;
        }

        public int GetTimeLeft() //To get remaining time for display purposes
        {
            return timeLeft;
        }
    }
}
