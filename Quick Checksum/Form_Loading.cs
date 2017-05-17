using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Checksum
{
    public partial class Form_Loading : Form
    {
        string md5sum;
        string sha1sum;
        string sha256sum;
        string filename = string.Empty;

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public Form_Loading()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }


        private void Form_Loading_Load(object sender, EventArgs e)
        {
            
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                label_Files.Text = "File: " + args[1];
                filename = args[1];

                backgroundWorkerChecksum.RunWorkerAsync();

            }

        }

        private void backgroundWorkerChecksum_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerChecksum.ReportProgress(99);


            using (var stream = File.OpenRead(filename))
            {
                    
                using (var md5 = MD5.Create())
                {
                    md5sum = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }

                using (var sha1 = SHA1.Create())
                {
                    sha1sum = BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", string.Empty);
                }
                
                using (var sha256 = SHA256.Create())
                {
                    sha256sum = BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", string.Empty);
                }
                
            }
            
        }

        private void backgroundWorkerChecksum_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Hide();
            Form_SingleFile frmSingleFile = new Form_SingleFile(filename, md5sum, sha1sum, sha256sum);
            frmSingleFile.Closed += (s, args) => this.Close();
            frmSingleFile.Show();

        }

        private void backgroundWorkerChecksum_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
