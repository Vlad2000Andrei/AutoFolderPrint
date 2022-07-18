# AutoFolderPrint: Automatically print PDF files that are added to a folder

Ever since Google CloudPrint was deprecated, I've wanted a simple way to share a non-smart printer without much hassle. This is a solution to that problem.

## How it works:

The software allows you to choose a directory which will be monitored. This acts as a pseudo-print-queue. Any file that is added to this directory is printed
and then deleted.

In order to print PDF documents (which is surpsisingly impossible natively in C#), the code relies on Adobe Acrobat Reader being installed on the user machine. 
This is a hard requirement, it will not work without it.

## Use case for printer sharing:

In order to share a printer, you can use Google Drive (or any other service with similar functionality) in order to share a folder. If you set the folder up such that 
its contents are automatically sync-ed to your local machine, you can set AutoFolderPrint to monitor that Drive folder. Then, anyone who has access to the drive folder
can add PDF files to it and the "host" PC will print them and then remove them from the drive.
