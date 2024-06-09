using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace Zadaca_03
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
            DB.SetConfiguration("PI2324_tmuhar22_DB", "PI2324_tmuhar22_User", "&l3RTM]d");
            Application.Run(new Form1());
        }
    }
}
