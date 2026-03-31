using System;

#pragma warning disable CA1416

// a container for all classes
// avoid same name class conflict
namespace OOP_GroupProject
{
    public class Player
    {
        private int crtPosition; // current position
        private int crtLevel; // current level
        private int collectedKeys;

        public void Jump()
        {
            // The jump physics are actually handled inside the game screen forms
        }

        public void Left()
        {
            // Moving left and right is also handled by the game screen forms
        }

        public void Right()
        {
            // Moving left and right is also handled by the game screen forms
        }

        public void ResetPosition()
        {
            crtPosition = 0;
        }

        public int CurrentLevel()
        {
            return crtLevel;
        }
    }
}
