using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CA1416


namespace OOP_GroupProject
{
    internal static class Program
    //static it is only used to run the Main method and does not need to create any object
    //internal so it can be access within same project which can improve encapsulation
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
                Application.Run(new frmMain()); //start main form
            }
            catch (Exception ex) //Handle Error //catch any error and store in ex
            {
                MessageBox.Show($"Startup Error: {ex.Message}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
