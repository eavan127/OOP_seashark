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
            this.SuspendLayout();
            // 
            // frmQuizPopup
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmQuizPopup";
            this.Load += new System.EventHandler(this.frmQuizPopup_Load);
            this.ResumeLayout(false);

        }

        private void frmQuizPopup_Load(object sender, EventArgs e)
        {

        }
    }
}
