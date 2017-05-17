using System;
using System.Windows.Forms;

namespace Quick_Checksum
{
    public partial class Form_SingleFile : Form
    {
        private string fileName = string.Empty;
        private string md5sum = string.Empty;
        private string sha1sum = string.Empty;
        private string sha256sum = string.Empty;

        public Form_SingleFile(string fileName, string md5sum, string sha1sum, string sha256sum)
        {
            InitializeComponent();
            this.fileName = fileName;
            this.md5sum = md5sum;
            this.sha1sum = sha1sum;
            this.sha256sum = sha256sum;
        }

        private void Form_SingleFile_Load(object sender, EventArgs e)
        {
            textBoxMD5.Text = md5sum;
            textBoxSHA1.Text = sha1sum;
            textBoxSHA256.Text = sha256sum;
            labelFileName.Text = fileName;
        }
    }
}
