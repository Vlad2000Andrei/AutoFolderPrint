using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        public void Execute()
        {
            Print();
            if (Properties.Settings.Default.RemoveAfterPrinting)
            {
                RemoveFile();
            }
        }

        private void Print()
        {
            // Code source: https://ourcodeworld.com/articles/read/502/how-to-print-a-pdf-from-your-winforms-application-in-c-sharp
            using (PrintDialog printDialog = new PrintDialog())
            {
                if (Properties.Settings.Default.AskBeforePrinting)
                {
                    DialogResult result = MessageBox.Show($"Print: {Path.GetFileName(FilePath)}?", "AutoPrint: Printing Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) return;
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

            RemoveFile();
        }

        private void RemoveFile()
        {
            FileInfo fileInfo = new FileInfo(FilePath);

            try
            {
                fileInfo.Delete();
            } catch (Exception ex)
            {
                DialogResult result = MessageBox.Show($"The file could not be deleted after printing. Please manually delete the file to avoid duplicate printing later! \n\nError Info:\n{ex.Message}", "Error: Could not remove file", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Retry)
                {
                    RemoveFile();
                }
                else
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo()
                    {
                        Arguments = FilePath,
                        FileName = "explorer.exe"
                    };
                    Process.Start(startInfo);
                }
            }
        }
        
    }
}
