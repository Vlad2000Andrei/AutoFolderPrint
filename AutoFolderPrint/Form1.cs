using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFolderPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {

                fileDialog.AddExtension = true;
                fileDialog.Filter = "*.pdf|";
                fileDialog.CheckFileExists = true;
                fileDialog.CheckPathExists = true;
                fileDialog.Multiselect = false;
                DialogResult result = fileDialog.ShowDialog();

                if (result == DialogResult.OK) new PrintJob(fileDialog.FileName).Print();
            };

        }

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
                }
            };
        }
    }
}
