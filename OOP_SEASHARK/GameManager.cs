using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SEASHARK
{
    public class GameManager
    {
        //public Player player = new Player();
        public Level currentLvl;
        public Timer timer = new Timer();

        public void StartGame() { currentLvl.StartLevel(); }
        //public void RestartPosition() { player.ResetPosition(); }
        public void End() { }
        public void Unlock() { }
    }
}
