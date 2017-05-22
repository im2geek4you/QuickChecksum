using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Checksum
{
    class CalcSUM
    {
        private ManualResetEvent _doneEvent;
        private DataGridViewRow _dgvRow;


        public CalcSUM(DataGridViewRow dgvRow, ManualResetEvent doneEvent)
        {
            _dgvRow = dgvRow;
            _doneEvent = doneEvent;
        }

        private void CalculateSum()
        {
            if (_dgvRow.Cells["Column_FILENAME"].Value.ToString() != string.Empty)
            {
                using (var stream = File.OpenRead(_dgvRow.Cells["Column_FILENAME"].Value.ToString()))
                {
                    using (var md5 = MD5.Create())
                    {
                        _dgvRow.Cells["Column_MD5"].Value = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                    }

                    stream.Position = 0;
                    using (var sha1 = SHA1.Create())
                    {
                        _dgvRow.Cells["Column_SHA1"].Value = BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", string.Empty);
                    }
                    stream.Position = 0;
                    using (var sha256 = SHA256.Create())
                    {
                        _dgvRow.Cells["Column_SHA256"].Value = BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", string.Empty);
                    }
                    _dgvRow.Cells["Column_PROGRESS"].Value = "100%";
                }
            }
            
        }

        public void ThreadPoolCallback(Object threadContext)
        {
            int threadIndex = (int)threadContext;
            CalculateSum();
            _doneEvent.Set();
        }

    }
}
