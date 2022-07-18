using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFolderPrint
{
    class DirectoryMonitor
    {
        public readonly string DirectoryPath;
        private FileSystemWatcher watcher;

        public DirectoryMonitor (string path)
        {
            DirectoryPath = path.Trim();
        }

        public bool CheckDirEmpty()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(DirectoryPath);
            
            bool containsFiles = dirInfo.GetFiles().Count() > 0;
            bool containsDirs = dirInfo.GetDirectories().Count() > 0;

            return !containsFiles && !containsDirs && dirInfo.Exists;
        }

        public void WatchDirectory()
        {
            watcher = new FileSystemWatcher(DirectoryPath);
            
            watcher.NotifyFilter = NotifyFilters.Attributes
                                | NotifyFilters.CreationTime
                                | NotifyFilters.DirectoryName
                                | NotifyFilters.FileName
                                | NotifyFilters.LastWrite
                                | NotifyFilters.Security
                                | NotifyFilters.Size;

            watcher.Changed += HandleNewFile;
            watcher.Created += HandleNewFile;

            watcher.Filter = "*.pdf";

            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
        }

        private static void HandleNewFile(object sender, FileSystemEventArgs e)
        {
            new PrintJob(e.FullPath).Execute();
        }
    }
}
