using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quick_Checksum
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{3DDEFE04-A2CE-4B4F-AD18-BB175716BC89}");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                //first process in memory
                if (Environment.GetCommandLineArgs().Length > 1)
                {
                    GlobalArgs.GlobalArgList.Add(Environment.GetCommandLineArgs()[1]);
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form_Loading());                   
                mutex.ReleaseMutex();
            }
            else
            {
                //process already in memory
                try
                {
                    NamedPipeClientStream pipeStream = new NamedPipeClientStream(".", "3DDEFE04-A2CE-4B4F-AD18-BB175716BC89", PipeDirection.Out, PipeOptions.Asynchronous);

                    // wait up to 60 for the pipe to become available
                    pipeStream.Connect(60000);
                   
                    byte[] _buffer = Encoding.UTF8.GetBytes(Environment.GetCommandLineArgs()[1]);
                    Thread.Sleep(500); //TODO: this shouldn't be needed
                    pipeStream.BeginWrite(_buffer, 0, _buffer.Length, new AsyncCallback(AsyncSend), pipeStream);
                    pipeStream.Flush();
                    pipeStream.Close();
                }
                catch (TimeoutException oEX)
                {
                    MessageBox.Show(oEX.Message);
                }

                // send Win32 message to bring the window on top
                NativeMethods.PostMessage(
                    (IntPtr)NativeMethods.HWND_BROADCAST,
                    NativeMethods.WM_SHOWME,
                    IntPtr.Zero,
                    IntPtr.Zero);
            }
            void AsyncSend(IAsyncResult iar)
            {
                try
                {
                    // Get the pipe
                    NamedPipeClientStream pipeStream = (NamedPipeClientStream)iar.AsyncState;

                    // End the write
                    pipeStream.EndWrite(iar);
                    pipeStream.Flush();
                    pipeStream.Close();
                    pipeStream.Dispose();
                }
                catch (Exception oEX)
                {
                    MessageBox.Show(oEX.Message);
                }
            }

        }



    }
}
