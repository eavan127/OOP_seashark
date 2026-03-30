using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;

namespace OOP_GroupProject
{
    public class GameManager
    {
        //public Player player = new Player();
        public Level currentLvl;
        public Timer timer = new Timer();
        private IWavePlayer wavePlayer;
        private AudioFileReader audioFileReader;

        public void StartGame()
        {
            PlayMusic();
            currentLvl.StartLevel();
        }

        public void PlayMusic()
        {
            try
            {
                string musicPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "music",
                    "background.mp3"
                );

                if (!File.Exists(musicPath))
                {
                    MessageBox.Show($"Music file not found:\n{musicPath}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StopMusic(); // prevent overlap

                wavePlayer = new WaveOutEvent();
                audioFileReader = new AudioFileReader(musicPath)
                {
                    Volume = 0.5f
                };

                wavePlayer.Init(audioFileReader);
                wavePlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing music: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StopMusic()
        {
            try
            {
                if (wavePlayer != null)
                {
                    wavePlayer.Stop();
                    wavePlayer.Dispose();
                    wavePlayer = null;
                }
                if (audioFileReader != null)
                {
                    audioFileReader.Dispose();
                    audioFileReader = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error stopping music: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void RestartPosition() { player.ResetPosition(); }
        public void End()
        {
            StopMusic();
        }

        public void Unlock() { }

    }
}
