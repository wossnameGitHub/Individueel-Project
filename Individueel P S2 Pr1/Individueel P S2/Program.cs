using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individueel_P_S2
{
    static class Program
    {
        public static TEMP_Form OmdatTimer;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OmdatTimer = new TEMP_Form();
            Application.Run(OmdatTimer);
        }
    }
}
