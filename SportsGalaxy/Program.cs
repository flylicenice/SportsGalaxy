using System;
using System.Windows.Forms;

namespace SportsGalaxy
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
            Application.SetCompatibleTextRenderingDefault(true);
            CustomFonts.Initialize();
            Application.Run(new Login());
        }
    }
}
