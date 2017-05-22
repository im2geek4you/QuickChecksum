using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Quick_Checksum
{
    public partial class Form_MultiFiles : Form
    {
        List<string> files;

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public Form_MultiFiles(List<string> args)
        {
            InitializeComponent();
            files = args;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }

        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }


        private void Form_MultiFiles_Shown(object sender, EventArgs e)
        {

            ManualResetEvent[] doneEvents = new ManualResetEvent[files.Count];
            CalcSUM[] CalcSUMArray = new CalcSUM[files.Count];

            for (int a=0; a<files.Count; a++)
            {
                var index = dataGridView_Files.Rows.Add();
                dataGridView_Files.Rows[index].Cells[0].Value = files[a];
                dataGridView_Files.Rows[index].Cells[1].Value = "0%";

                doneEvents[a] = new ManualResetEvent(false);
                CalcSUM f = new CalcSUM(dataGridView_Files.Rows[index], doneEvents[a]);
                CalcSUMArray[a] = f;
                ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback, a);
            }


        }
        public void AddChecksum(List<string> args)
        {
            ManualResetEvent[] doneEvents = new ManualResetEvent[1];
            CalcSUM[] CalcSUMArray = new CalcSUM[1];

            var index = dataGridView_Files.Rows.Add();
            dataGridView_Files.Rows[index].Cells[0].Value = args[index];
            dataGridView_Files.Rows[index].Cells[1].Value = "0%";

            doneEvents[0] = new ManualResetEvent(false);
            CalcSUM f = new CalcSUM(dataGridView_Files.Rows[index], doneEvents[0]);
            CalcSUMArray[0] = f;
            ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback, index);

        }
    }
}
