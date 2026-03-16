using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SEASHARK
{
    using System;

    namespace OOP_SEASHARK
    {
        public class Player
        {
            private string playerName;
            private int crtPosition;
            private int crtLevel;
            private int collectedKeys;

            public void Jump()
            {
                // jump logic handled in BeginnerGame form
            }

            public void Left()
            {
                // move left logic handled in BeginnerGame form
            }

            public void Right()
            {
                // move right logic handled in BeginnerGame form
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
}
