using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFolderPrint
{
    internal class PrintJob
    {
        private string FilePath;

        public PrintJob(string path)
        {
            FilePath = path;
        }

        public bool Print()
        {
            // Code source: https://ourcodeworld.com/articles/read/502/how-to-print-a-pdf-from-your-winforms-application-in-c-sharp
            using (PrintDialog printDialog = new PrintDialog())
            {
                DialogResult dialogResult = printDialog.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    return false;
                }

                ProcessStartInfo processStartInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = this.FilePath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process acrobatPrintProcess = new Process();
                acrobatPrintProcess.StartInfo = processStartInfo;
                acrobatPrintProcess.Start();

                acrobatPrintProcess.WaitForInputIdle();
                Thread.Sleep(3000);

                if (!acrobatPrintProcess.CloseMainWindow())
                {
                    acrobatPrintProcess.Kill();
                }

            }

           
            return true;
        }
        
    }
}
