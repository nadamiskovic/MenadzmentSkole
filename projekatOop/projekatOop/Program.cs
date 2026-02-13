using System;
using System.Windows.Forms;

namespace projekatOop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Pokreni početnu formu (navigacionu)
            Application.Run(new MainForm());
        }
    }
}