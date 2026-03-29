using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public partial class frmQuizPopup : Form
    {
        public frmQuizPopup()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // frmQuizPopup
            // 
            ClientSize = new Size(735, 377);
            Name = "frmQuizPopup";
            Load += frmQuizPopup_Load;
            ResumeLayout(false);

        }

        private void frmQuizPopup_Load(object sender, EventArgs e)
        {

        }
    }
}
