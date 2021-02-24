using GRUBSCHOOL.Apresentation.Desktop.NETCore.Formularios;
using System;
using System.Windows.Forms;

namespace GRUBSCHOOL.Apresentation.Desktop.NETCore
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }
}
