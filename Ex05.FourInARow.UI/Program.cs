using System;
using System.Windows.Forms;

// $G$ RUL-004 (-10) Wrong zip name format / folder name format

namespace Ex05.FourInARow.UI
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FourInARowForm());
        }
    }
}
