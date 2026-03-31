using System;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public class CompleteFormBase : Form
    {
        // must be protected so child Designer files can access them
        protected Label lblTime;
        protected Label lblKey;
        protected Button btnPlayAgain;

        protected string FormatTime(int seconds)
        {
            int mins = seconds / 60;
            int secs = seconds % 60;
            return $"{mins:D2}:{secs:D2}";
        }

        protected virtual void LoadStats(int timeRemaining, int keysCollected)
        {
            lblTime.Text = FormatTime(timeRemaining);
            lblKey.Text = $"{keysCollected}/6";
        }

        protected virtual void OnPlayAgainClicked()
        {
            // to be override in child class
        }

        protected virtual void OnExitOrBackClicked()
        {
            // to be override in child class
        }
    }
}