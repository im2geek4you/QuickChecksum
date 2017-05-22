using System;
using System.IO;
using System.IO.Pipes;
using System.Windows.Forms;

namespace Quick_Checksum
{
    public partial class Form_Loading : Form
    {
        Form_MultiFiles frmMultiFile;

        public Form_Loading()
        {
            InitializeComponent();
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Loading_Shown(object sender, EventArgs e)
        {
            
            if (GlobalArgs.GlobalArgList.Count == 0)
            {
                MessageBox.Show("No item selected");
                this.Close();
            }
            else if (GlobalArgs.GlobalArgList.Count >= 1)
            {
                this.Hide();
                frmMultiFile = new Form_MultiFiles(GlobalArgs.GlobalArgList);
                frmMultiFile.Closed += (s, args_) => this.Close();
                frmMultiFile.Show();

            }
            
            try
            {
                // Create async pipe 
                NamedPipeServerStream pipeServer = new NamedPipeServerStream("3DDEFE04-A2CE-4B4F-AD18-BB175716BC89", PipeDirection.In, 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous);

                // Wait for connection
                pipeServer.BeginWaitForConnection(new AsyncCallback(WaitForConnectionCallBack), pipeServer);
            }
            catch (Exception oEX)
            {
                MessageBox.Show(oEX.Message);
            }

        }


        private void WaitForConnectionCallBack(IAsyncResult iar)
        {
            try
            {
                // Get the pipe
                NamedPipeServerStream pipeServer = (NamedPipeServerStream)iar.AsyncState;
                // End waiting for the connection
                pipeServer.EndWaitForConnection(iar);

                using (StreamReader sw = new StreamReader(pipeServer))
                {
                    GlobalArgs.GlobalArgList.Add(sw.ReadLine());
                }

                frmMultiFile.Invoke((MethodInvoker)delegate () {
                    frmMultiFile.AddChecksum(GlobalArgs.GlobalArgList);
                });


                // restart server
                pipeServer.Close();
                pipeServer = null;
                pipeServer = new NamedPipeServerStream("3DDEFE04-A2CE-4B4F-AD18-BB175716BC89", PipeDirection.In, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);

                // Wait for new connection again
                pipeServer.BeginWaitForConnection(new AsyncCallback(WaitForConnectionCallBack), pipeServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
