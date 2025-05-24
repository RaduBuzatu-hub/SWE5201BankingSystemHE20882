// we use this namespace for logging 
using Microsoft.VisualBasic.Logging;

namespace SWE5201BankingSystemHE20882.MainProgram
{
    // this class is the program's main part where it starts
    internal static class Program
    {
        /// This is where the program begins running, like the main entrance.
        [STAThread]
        static void Main()
        {
  
            // we create a login form and call it loginForm
            Log_In loginForm = new Log_In();

            // this makes the form take up the whole screen
            loginForm.WindowState = FormWindowState.Maximized;

            // this makes the form stay on top of other windows
            loginForm.TopMost = true;

            // now we run the application and show the login form
            Application.Run(loginForm);
        }
    }
}
