using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SEASHARK
{
    public partial class PopQuiz : Form
    {
        public bool AnsweredCorrectly = false;

        public PopQuiz(int questionIndex, int timeLeft)
        {
            InitializeComponent();
        }
    }
}
