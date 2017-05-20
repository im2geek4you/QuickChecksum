using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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

            ManualResetEvent[] doneEvents = new ManualResetEvent[files.Length-1];
            CalcSUM[] CalcSUMArray = new CalcSUM[files.Length-1];

            for (int a=1; a<files.Length; a++)
            {
                var index = dataGridView_Files.Rows.Add();
                dataGridView_Files.Rows[index].Cells[0].Value = files[a];
                dataGridView_Files.Rows[index].Cells[1].Value = "0%";

                doneEvents[a-1] = new ManualResetEvent(false);
                CalcSUM f = new CalcSUM(dataGridView_Files.Rows[index], doneEvents[a-1]);
                CalcSUMArray[a-1] = f;
                ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback, a-1);
            }
            // Wait for all threads in pool to calculate.  
            //WaitHandle.WaitAll(doneEvents);

        }

    }
}
