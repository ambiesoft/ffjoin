using System;
using System.IO;
using System.Windows.Forms;

namespace ffjoin
{
    public partial class FormMain : Form
    {
        private void FormMain_Load(object sender, EventArgs e)
        {
            string inipath = Application.ExecutablePath;
            inipath = Path.GetDirectoryName(inipath);
            inipath = Path.Combine(inipath, Application.ProductName + ".ini");
            Ambiesoft.Profile.GetString("option", "ffmpeg", "", out ffmpeg_, inipath);
            inipath_ = inipath;
            getffmpeg();

            UpdateTitle();
        }
    }
}
