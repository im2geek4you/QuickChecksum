using System;
using System.Collections.Generic;
using System.IO;
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

        private void MD5copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                if (item != null)
                {
                    if (item.Text == "Copy to clipboard")
                    {
                        Clipboard.Clear();
                        string values = string.Empty;
                        for (int i = dataGridView_Files.SelectedRows.Count - 1; i >= 0; i--)
                        {
                            var selectedRow = dataGridView_Files.SelectedRows[i];
                            if (i == 0)
                            {
                                values = values + selectedRow.Cells[Column_MD5.Name].Value.ToString();
                            }
                            else
                            {
                                values = values + selectedRow.Cells[Column_MD5.Name].Value.ToString() + Environment.NewLine;
                            }
                        }
                        Clipboard.SetText(values);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SHA1copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                if (item != null)
                {
                    if (item.Text == "Copy to clipboard")
                    {
                        Clipboard.Clear();
                        string values = string.Empty;
                        for (int i = dataGridView_Files.SelectedRows.Count - 1; i >= 0; i--)
                        {
                            var selectedRow = dataGridView_Files.SelectedRows[i];
                            if (i == 0)
                            {
                                values = values + selectedRow.Cells[Column_SHA1.Name].Value.ToString();
                            }
                            else
                            {
                                values = values + selectedRow.Cells[Column_SHA1.Name].Value.ToString() + Environment.NewLine;
                            }
                        }
                        Clipboard.SetText(values);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SHA256copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                if (item != null)
                {
                    if (item.Text == "Copy to clipboard")
                    {
                        Clipboard.Clear();
                        string values = string.Empty;
                        for (int i = dataGridView_Files.SelectedRows.Count - 1; i >= 0; i--)
                        {
                            var selectedRow = dataGridView_Files.SelectedRows[i];
                            if (i==0)
                            {
                                values = values + selectedRow.Cells[Column_SHA256.Name].Value.ToString();
                            }
                            else {
                                values = values + selectedRow.Cells[Column_SHA256.Name].Value.ToString() + Environment.NewLine;
                            }
                        }
                        Clipboard.SetText(values);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MD5compareWithClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                if (item != null)
                {
                    if (item.Text == "Compare with clipboard")
                    {
                        if (dataGridView_Files.SelectedRows.Count ==1)
                        {
                            DataGridViewRow selectedRow = dataGridView_Files.SelectedRows[0];
                            if (Clipboard.GetText() == selectedRow.Cells[Column_MD5.Name].Value.ToString())
                            {
                                MessageBox.Show("Clipboard:\t " + Clipboard.GetText() + "\nTable MD5:\t " + selectedRow.Cells[Column_MD5.Name].Value.ToString(), "Match!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (dataGridView_Files.SelectedRows.Count >= 1)
                        {
                            MessageBox.Show("Only one item can be compared at a time!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SHA1compareWithClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                if (item != null)
                {
                    if (item.Text == "Compare with clipboard")
                    {
                        if (dataGridView_Files.SelectedRows.Count == 1)
                        {
                            DataGridViewRow selectedRow = dataGridView_Files.SelectedRows[0];
                            if (Clipboard.GetText() == selectedRow.Cells[Column_SHA1.Name].Value.ToString())
                            {
                                MessageBox.Show("Clipboard:\t " + Clipboard.GetText() + "\nTable SHA1:\t " + selectedRow.Cells[Column_SHA1.Name].Value.ToString(), "Match!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (dataGridView_Files.SelectedRows.Count >= 1)
                        {
                            MessageBox.Show("Only one item can be compared at a time!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SHA256compareWithClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                if (item != null)
                {
                    if (item.Text == "Compare with clipboard")
                    {
                        if (dataGridView_Files.SelectedRows.Count == 1)
                        {
                            DataGridViewRow selectedRow = dataGridView_Files.SelectedRows[0];
                            if (Clipboard.GetText() == selectedRow.Cells[Column_SHA256.Name].Value.ToString())
                            {
                                MessageBox.Show("Clipboard:\t " + Clipboard.GetText() + "\nTable SHA256:\t " + selectedRow.Cells[Column_SHA256.Name].Value.ToString(), "Match!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (dataGridView_Files.SelectedRows.Count >= 1)
                        {
                            MessageBox.Show("Only one item can be compared at a time!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductName +" v"+ Application.ProductVersion + "\nDeveloped by Carlos Santos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonClearTable_Click(object sender, EventArgs e)
        {
            dataGridView_Files.Rows.Clear();
        }

        private void deleteThisFileFromDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                if (item != null)
                {
                    if (dataGridView_Files.SelectedRows.Count >= 1)
                    {
                        if (MessageBox.Show("Do you want to delete selected file(s) from disk?", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            try
                            {
                                foreach (DataGridViewRow row in dataGridView_Files.SelectedRows)
                                {

                                    File.Delete(row.Cells[Column_FILENAME.Name].Value.ToString());
                                    dataGridView_Files.Rows.Remove(row);

                                }
                                MessageBox.Show("Delete successful", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonFindDuplicates_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_Files.Rows)
            {
                if (dataGridView_Files.Rows.Count >= 1)
                {
                    for (int i = row.Index + 1; i <= dataGridView_Files.Rows.Count - 1; i++)
                    {
                        if (row.Cells[Column_MD5.Name].Value.ToString() == dataGridView_Files.Rows[i].Cells[Column_MD5.Name].Value.ToString())
                        {
                            System.Drawing.Color matchColor = GetRandomColor(row.Index);
                            row.DefaultCellStyle.BackColor = matchColor;
                            dataGridView_Files.Rows[i].DefaultCellStyle.BackColor = matchColor;
                        }
                    }
                }

            }
        }

        public System.Drawing.Color GetRandomColor(int seed)
        {
            Random randomGen = new Random(seed);
            System.Drawing.KnownColor[] names = (System.Drawing.KnownColor[])Enum.GetValues(typeof(System.Drawing.KnownColor));
            System.Drawing.KnownColor randomColorName = names[randomGen.Next(names.Length)];
            System.Drawing.Color randomColor = System.Drawing.Color.FromKnownColor(randomColorName);
            return randomColor;
        }
    }
}
