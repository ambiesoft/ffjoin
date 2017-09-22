using System;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace ffjoin
{
    public partial class FormMain : Form
    {
        private void btnAbout_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(Application.ProductName).Append(" ver ");
            sb.Append(Assembly.GetExecutingAssembly().GetName().Version.Major.ToString());
            sb.Append(".");
            sb.Append(Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString());

            Info(sb.ToString());
        }

        void Info(string message)
        {
            MessageBox.Show(message,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}
