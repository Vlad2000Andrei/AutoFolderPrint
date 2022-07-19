using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFolderPrint
{
    public partial class AutoPrint : Form
    {
        private bool AskBeforePrinting;
        private bool RemoveAfterPrinting;

        public AutoPrint()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfigs();
        }

        // Triggered when the "Browse" button is clicked to change the monitored folder.
        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result =  dialog.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    Program.dirMonitor = new DirectoryMonitor(dialog.SelectedPath);

                    if (!Program.dirMonitor.CheckDirEmpty())
                    {
                        MessageBox.Show(text: "The selected folder is not empty. Please select and empty folder.",
                                        caption: "Error", buttons:MessageBoxButtons.OK, icon:MessageBoxIcon.Error);
                        return;
                    }

                    Program.dirMonitor.WatchDirectory();
                    textBox1.Text = dialog.SelectedPath;

                    SaveConfigs();
                }
            };
        }

        private void LoadConfigs()
        {
            string path = Properties.Settings.Default.PathToMonitor;

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (dirInfo.Exists == false) return;

            Program.dirMonitor = new DirectoryMonitor(path);
            textBox1.Text = path;
            Program.dirMonitor.WatchDirectory();

            AskBeforePrinting = Properties.Settings.Default.AskBeforePrinting;
            askBeforePrintingCheckbox.Checked = AskBeforePrinting;

            RemoveAfterPrinting = Properties.Settings.Default.RemoveAfterPrinting;
            removeAfterPrintingCheckbox.Checked = RemoveAfterPrinting;
        }

        private void SaveConfigs()
        {
            if (Program.dirMonitor != null) {
                Properties.Settings.Default.PathToMonitor = Program.dirMonitor.DirectoryPath;
            }           

            Properties.Settings.Default.Save();
        }

        private void askBeforePrintingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            AskBeforePrinting = askBeforePrintingCheckbox.Checked;
            Properties.Settings.Default.AskBeforePrinting = AskBeforePrinting;
            SaveConfigs();
        }

        private void removeAfterPrintingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RemoveAfterPrinting = removeAfterPrintingCheckbox.Checked;
            Properties.Settings.Default.RemoveAfterPrinting = RemoveAfterPrinting;
            SaveConfigs();
        }
    }
}
