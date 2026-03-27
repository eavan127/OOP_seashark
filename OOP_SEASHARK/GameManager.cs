using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace OOP_SEASHARK
{
    public class GameManager
    {
        //public Player player = new Player();
        public Level currentLvl;
        public Timer timer = new Timer();
        private WindowsMediaPlayer bgMusic = new WindowsMediaPlayer();

        public void StartGame() {
            PlayMusic();
            currentLvl.StartLevel();
        }

        public void PlayMusic()
        {
            bgMusic.URL = Application.StartupPath + @"\music\background.mp3";
            bgMusic.settings.setMode("loop", true);
            bgMusic.settings.volume = 50;
            bgMusic.controls.play();
        }

        public void StopMusic()
        {
            bgMusic.controls.stop();
        }

        //public void RestartPosition() { player.ResetPosition(); }
        public void End() 
        {
            StopMusic();
        }

        public void Unlock() { }

    }
}
