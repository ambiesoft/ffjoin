using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ffjoin
{
    static class Program
    {
        private static System.Reflection.Assembly CustomResolve(object sender, System.ResolveEventArgs args)
        {
            if (args.Name.StartsWith("Ambiesoft.AmbLibcpp.x86"))
            {
                string filename = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                    "platform",
                    string.Format("Ambiesoft.AmbLibcpp.{0}.dll",
                        Environment.Is64BitProcess ? "x64" : "x86"));

                return System.Reflection.Assembly.LoadFile(filename);
            }
            return null;
        }

        static Program()
        {
            System.AppDomain.CurrentDomain.AssemblyResolve += CustomResolve;
        }
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