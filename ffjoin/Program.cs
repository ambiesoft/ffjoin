using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Ambiesoft;

namespace ffjoin
{
    static class Program
    {
       

        /// <summary>
        /// 
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<string> inputVideos = new List<string>();
            foreach(string arg in args)
            {
                if(!File.Exists(arg))
                {
                    CppUtils.Alert(string.Format(Properties.Resources.S_FILE_NOT_EXISTS, arg));
                    return;
                }
                inputVideos.Add(Path.GetFullPath(arg));
            }
            Application.Run(new FormMain(inputVideos));
        }
    }
}