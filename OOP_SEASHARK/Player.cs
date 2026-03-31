using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CA1416

// a container for all classes
// avoid same name class conflict
namespace OOP_GroupProject
{
    public class Player
    {
        private string playerName = "";
        private int crtPosition;
        private int crtLevel;
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
