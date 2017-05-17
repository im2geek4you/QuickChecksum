using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Checksum
{
    public partial class Form_MultiFiles : Form
    {
        string[] files;

        public Form_MultiFiles(string[] args)
        {
            InitializeComponent();
            files = args;
        }

        private void Form_MultiFiles_Shown(object sender, EventArgs e)
        {
            for (int a=1; a<files.Length; a++)
            {
                var index = dataGridView_Files.Rows.Add();
                dataGridView_Files.Rows[index].Cells[0].Value = files[a];
                dataGridView_Files.Rows[index].Cells[1].Value = "0%";
            }


        }
    }
}
