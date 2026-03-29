using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            try 
            {
                MessageBox.Show("Debug: Application starting...", "Diagnostic");
                Application.Run(new frmMain());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Debug: Application crashed with error:\n\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
