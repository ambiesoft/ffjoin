using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ffjoin
{
    static class Program
    {
       

        /// <summary>
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}