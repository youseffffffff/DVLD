using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;
using System.Threading;
using DVLD_System.Tests;


namespace DVLD_System
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);





            new Thread(StartFromLoginForm).Start();

        }

        static void StartFromLoginForm()
        {
            Application.Run(new Login());
        }

    }
}
