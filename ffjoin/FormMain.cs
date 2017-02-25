using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ffjoin
{
    public partial class FormMain : Form
    {
        private string ffmpeg_;
        private string inipath_;

        public FormMain()
        {
            InitializeComponent();
        }

        private string getVideoLengthWork(string ins)
        {
            string ret;
            ret = getVL1(ins);
            if (!string.IsNullOrEmpty(ret))
                return ret;

            ret = getVL2(ins);
            if (!string.IsNullOrEmpty(ret))
                return ret;

            return string.Empty;
        }
        private string getVL1(string ins)
        {
            Regex reg = new Regex(@"Duration: (?<duration>.*?), start");

            string[] parts = ins.Split('\n');
            foreach (string part in parts)
            {
                string s = part.TrimEnd('\r');
                Match match = reg.Match(s);
                if (match.Success)
                {
                    return match.Groups["duration"].Value;
                    //return match.Value;
                }
            }
            return string.Empty;
        }
        private string getVL2(string ins)
        {
            bool inmeta = false;
            Dictionary<string, string> allattr = new Dictionary<string, string>();
            string[] parts = ins.Split('\n');
            foreach (string part in parts)
            {
                string s = part.TrimEnd('\r');
                if (s == "  Metadata:")
                {
                    inmeta = true;
                }

                if (inmeta)
                {
                    char[] c = { ':' };
                    string[] nv = s.Split(c, 2);
                    if (nv.Length == 2 && nv[0] != null && nv[1] != null)
                    {
                        try
                        {
                            allattr.Add(nv[0].Trim(), nv[1].Trim());
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }

            try
            {
                string[] dparts = allattr["Duration"].Split(',');
                return dparts[0];
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        private string getVideoLength(string filename)
        {
            ProcessStartInfo psi = new ProcessStartInfo();

            string argument = "-i " + "\"" + filename + "\"";

            psi.FileName = getffmpeg();
            psi.Arguments = argument;
            psi.RedirectStandardOutput = false;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;


            Process p = Process.Start(psi);
            // string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();
            p.WaitForExit();
            if (0 != p.ExitCode)
            {
            }

            if (string.IsNullOrEmpty(error))
                return error;

            return getVideoLengthWork(error);
        }
        private void lvMain_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                foreach (string s in fileName)
                {
                    FileInfo fi = new FileInfo(s);
                    ListViewItem item = new ListViewItem();
                    item.Text = s;
                    item.SubItems.Add(fi.LastAccessTime.ToString());
                    item.SubItems.Add(fi.Extension);
                    item.SubItems.Add(getVideoLength(s));
                    item.Tag = fi;
                    lvMain.Items.Add(item);
                }
                calcSum();
            }
        }

        private TimeSpan getSum()
        {
            try
            {
                TimeSpan tsall = new TimeSpan();
                foreach (ListViewItem item in lvMain.Items)
                {
                    string s = item.SubItems[3].Text;
                    string[] parts = s.Split(':');
                    int hour;
                    int.TryParse(parts[0], out hour);
                    int minutes;
                    int.TryParse(parts[1], out minutes);

                    string[] mili = parts[2].Split('.');
                    int sec;
                    int.TryParse(mili[0], out sec);
                    int milisec;
                    int.TryParse(mili[1] + "0", out milisec);

                    TimeSpan ts = new TimeSpan(0, hour, minutes, sec, milisec);
                    tsall += ts;
                }
                return tsall;
            }
            catch (Exception)
            {
                return new TimeSpan(0);
            }
        }
        private void calcSum()
        {
            txtAllduration.Text = getSum().ToString().TrimEnd('0');
        }
        private void lvMain_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }



        private void lvMain_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }


        private string getffmpeg()
        {
            if (File.Exists(ffmpeg_))
                return ffmpeg_;

            FileInfo fithis = new FileInfo(Application.ExecutablePath);
            ffmpeg_ = fithis.Directory + "\\ffmpeg.exe";
            if (File.Exists(ffmpeg_))
                return ffmpeg_;

            OpenFileDialog ofd = new OpenFileDialog();

            //�͂��߂̃t�@�C�������w�肷��
            //�͂��߂Ɂu�t�@�C�����v�ŕ\������镶������w�肷��
            ofd.FileName = "ffmpeg.exe";

            //�͂��߂ɕ\�������t�H���_���w�肷��
            //�w�肵�Ȃ��i��̕�����j�̎��́A���݂̃f�B���N�g�����\�������
            ofd.InitialDirectory = @"C:\";
            
            //[�t�@�C���̎��]�ɕ\�������I�������w�肷��
            //�w�肵�Ȃ��Ƃ��ׂẴt�@�C�����\�������
            ofd.Filter = "Executable (*.exe)|*.exe";
            
            //[�t�@�C���̎��]�ł͂��߂�
            //�u���ׂẴt�@�C���v���I������Ă���悤�ɂ���
            ofd.FilterIndex = 1;
            
            //�^�C�g����ݒ肷��
            ofd.Title = "Choose ffmpeg";

            //�_�C�A���O�{�b�N�X�����O�Ɍ��݂̃f�B���N�g���𕜌�����悤�ɂ���
            // ofd.RestoreDirectory = true;

            //���݂��Ȃ��t�@�C���̖��O���w�肳�ꂽ�Ƃ��x����\������
            //�f�t�H���g��True�Ȃ̂Ŏw�肷��K�v�͂Ȃ�
            ofd.CheckFileExists = true;
            
            //���݂��Ȃ��p�X���w�肳�ꂽ�Ƃ��x����\������
            //�f�t�H���g��True�Ȃ̂Ŏw�肷��K�v�͂Ȃ�
            ofd.CheckPathExists = true;

            //�_�C�A���O��\������
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return "";
            }
            ffmpeg_ = ofd.FileName;
            ofd.Dispose();
            return ffmpeg_;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string ext=null;
            foreach (ListViewItem item in lvMain.Items)
            {
                string file = item.Text;
                FileInfo fi = new FileInfo(file);
                if (ext == null)
                    ext = fi.Extension;
                else
                {
                    if (string.Compare(ext, fi.Extension, true) != 0)
                    {
                        Ambiesoft.CenteredMessageBox.Show(this, Properties.Resources.S_DIFFERENT_EXTENSION);
                        return;
                    }
                }
            }

            string outfilename = null;
            foreach (ListViewItem item in lvMain.Items)
            {
                string file = item.Text;
                FileInfo fi = new FileInfo(file);
                if (outfilename == null)
                    outfilename = fi.Name;
                else
                {
                    int isame = 0;
                    try
                    {
                        for (int i = 0; i < fi.Name.Length; ++i)
                        {
                            if (fi.Name[i] == outfilename[i])
                                isame = i+1;
                            else
                                break;
                        }
                    }
                    catch (Exception) { }

                    outfilename = outfilename.Substring(0, isame);
                }
            }
            string tempfile = Path.GetTempFileName();
            using (TextWriter writer = File.CreateText(tempfile))
            {
                foreach (ListViewItem item in lvMain.Items)
                {
                    writer.Write(@"file '");
                    writer.Write(item.Text);
                    writer.Write(@"'");
                    writer.WriteLine();
                }
            }

            string extwithout=ext.TrimStart('.');
            string outfile=null;
            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = outfilename;
                string filter = extwithout + "File ";
                filter += "(*.";
                filter += extwithout;
                filter += ")|*.";
                filter += extwithout;
                filter += "|All File(*.*)|*.*";
                sfd.Filter=filter;
                if(DialogResult.OK != sfd.ShowDialog(this))
                    return;

                outfile = sfd.FileName;
            }

            // FileInfo fithis = new FileInfo(Application.ExecutablePath);
            string ffmpeg = getffmpeg();
            string argument = "-f concat -i \"";

            argument += tempfile;
            argument += "\"";
            argument += " -c copy \"";
            argument += outfile;
            argument += "\"";
            

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = ffmpeg;
            psi.Arguments = argument;
            psi.RedirectStandardOutput = false;
            psi.RedirectStandardError = false;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;

            Process p = Process.Start(psi);
            p.WaitForExit();
            string prevsum = getSum().ToString().TrimEnd('0');
            string resultsum = getVideoLength(outfile);
            Ambiesoft.CenteredMessageBox.Show(this,
                "prev sum duration =\t" + prevsum + "\r\n" + "result duration =\t\t" + resultsum,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            File.Delete(tempfile);
        }

        private bool _reverse = false;
        private void lvMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            _reverse = !_reverse;
            lvMain.ListViewItemSorter = new ListViewItemComparer(e.Column, _reverse);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvMain.Items.Clear();
            calcSum();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string inipath = Application.ExecutablePath;
            inipath = Path.GetDirectoryName(inipath);
            inipath = Path.Combine(inipath, Application.ProductName + ".ini");
            Ambiesoft.Profile.GetString("option", "ffmpeg", "", out ffmpeg_, inipath);
            inipath_ = inipath;
            getffmpeg();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool failed = false;
            failed |= !Ambiesoft.Profile.WriteString("option", "ffmpeg", ffmpeg_, inipath_);

            if (failed)
            {
                Ambiesoft.CenteredMessageBox.Show(this,
                    Properties.Resources.S_INISAVE_FAILED,
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnJoinDifferent_Click(object sender, EventArgs e)
        {
            string outfilename = null;
            foreach (ListViewItem item in lvMain.Items)
            {
                string file = item.Text;
                FileInfo fi = new FileInfo(file);
                if (outfilename == null)
                    outfilename = fi.Name;
                else
                {
                    int isame = 0;
                    try
                    {
                        for (int i = 0; i < fi.Name.Length; ++i)
                        {
                            if (fi.Name[i] == outfilename[i])
                                isame = i + 1;
                            else
                                break;
                        }
                    }
                    catch (Exception) { }

                    outfilename = outfilename.Substring(0, isame);
                }
            }
            //string tempfile = Path.GetTempFileName();
            //using (TextWriter writer = File.CreateText(tempfile))
            //{
            //    foreach (ListViewItem item in lvMain.Items)
            //    {
            //        writer.Write(@"file '");
            //        writer.Write(item.Text);
            //        writer.Write(@"'");
            //        writer.WriteLine();
            //    }
            //}

            
            string outfile = null;
            string[] availableext = { "mp4", "avi" };
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = outfilename;
                StringBuilder sbFilter = new StringBuilder();
                foreach (string ae in availableext)
                {
                    sbFilter.Append(ae);
                    sbFilter.Append("File ");
                    sbFilter.Append("(*.");


                    sbFilter.Append(ae);
                    sbFilter.Append(")|*.");
                    sbFilter.Append(ae);
                    sbFilter.Append("|");
                }
                sbFilter.Append("All File(*.*)|*.*");

                sfd.Filter = sbFilter.ToString();
                if (DialogResult.OK != sfd.ShowDialog(this))
                    return;

                outfile = sfd.FileName;
            }

            
            string ffmpeg = getffmpeg();


            // c:\work>c:\LegacyPrograms\ffmpeg\bin\ffmpeg.exe -i stream_0.mp4 -i stream_1.mp4
            // -filter_complex "[0:v:0] [0:a:0] [1:v:0] [1:a:0] concat=n=2:v=1:a=1 [v] [a]" -ma
            // p "[v]" -map "[a]" aaa.mp4
            
            // -i "C:\work\stream_0.mp4" -i "C:\work\stream_1.mp4" 
            // -filter_complex "[0:v:0] [0:a:0] [1:v:1] [1:a:1] concat=n=2:v=1:a=1 [v] [a]" -ma
            // p "[v]" -map "[a]" "C:\Users\1dollar\Desktop\4.mp4"

            string argument="";
            foreach (ListViewItem item in lvMain.Items)
            {
                argument += "-i \"" + item.Text + "\" ";
            }

            argument += "-filter_complex \"";
            string tmp="";
            for (int i = 0; i < lvMain.Items.Count; ++i)
            {
                tmp += string.Format("[{0}:v:0] [{1}:a:0] ", i, i);
            }
            argument += tmp;

            argument += string.Format("concat=n={0}:v=1:a=1 [v] [a]\" ", lvMain.Items.Count);

            argument += "-map \"[v]\" -map \"[a]\" ";

            argument += "\"" + outfile + "\"";

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = ffmpeg;
            psi.Arguments = argument;
            psi.RedirectStandardOutput = false;
            psi.RedirectStandardError = false;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;

            Process p = Process.Start(psi);
            p.WaitForExit();
            
            string prevsum = getSum().ToString().TrimEnd('0');
            string resultsum = getVideoLength(outfile);
            Ambiesoft.CenteredMessageBox.Show(this,
                "prev sum duration =\t" + prevsum + "\r\n" + "result duration =\t\t" + resultsum,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //File.Delete(tempfile);
        }



    }

    public class ListViewItemComparer : System.Collections.IComparer
    {
        private int _column;
        private bool _reverse;
        /// <summary>
        /// ListViewItemComparer�N���X�̃R���X�g���N�^
        /// </summary>
        /// <param name="col">���ёւ����ԍ�</param>
        public ListViewItemComparer(int col, bool reverse)
        {
            _column = col;
            _reverse = reverse;
        }

        //x��y��菬�����Ƃ��̓}�C�i�X�̐��A�傫���Ƃ��̓v���X�̐��A
        //�����Ƃ���0��Ԃ�
        public int Compare(object x, object y)
        {
            //ListViewItem�̎擾
            ListViewItem itemx = (ListViewItem)x;
            ListViewItem itemy = (ListViewItem)y;

            int ret = 0;
            if (_column == 0)
            {
                ret = string.Compare(itemx.SubItems[_column].Text,
                    itemy.SubItems[_column].Text);
            }
            else if (_column == 1)
            {
                FileInfo fix = (FileInfo)itemx.Tag;
                FileInfo fiy = (FileInfo)itemy.Tag;

                ret = fix.LastAccessTime.CompareTo(fiy.LastAccessTime);
            }
            else if(_column==2)
            {
                ret = string.Compare(itemx.SubItems[_column].Text,
                    itemy.SubItems[_column].Text,true);
            }
            else
            {
                Debug.Assert(false);
            }
            return _reverse ? -ret : ret;

        }
    }


}