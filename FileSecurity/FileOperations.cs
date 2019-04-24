using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSecurity
{
    class FileOperations
    {
        public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

    public void Move(string source, string destination)
        {
            string sourceFolderName = Path.GetFileName(source);
            Console.WriteLine(sourceFolderName);
            string destFolderName = destination + "\\" + sourceFolderName;
            if(!Directory.Exists(destFolderName))
                Directory.CreateDirectory(destFolderName);
            DirectoryInfo directoryInfo = new DirectoryInfo(source);
            directoryInfo.MoveTo(destFolderName);
        }
    }
}

//foreach (string directory in subDirectories)
//{
//if (!Directory.Exists(directory))
//{
//MessageBox.Show("Moving " + directory);
//Directory.Move(directory, destination);
//}
//else
//{
//MessageBox.Show("File already Exists");
//}
//}


/**
 * string[] sourceDirectories = Directory.GetDirectories(source);
            foreach (string sourceDirectory in sourceDirectories)
            {
                Directory.CreateDirectory(destination + "\\" + Path.GetFileName(sourceDirectory));
                string Destpath = destination + "\\" + Path.GetFileName(sourceDirectory) + "\\";
                string[] fileArray = Directory.GetFiles(sourceDirectory);
                foreach (string file in fileArray)
                {
                    FileInfo nwFile = new FileInfo(file);
                    nwFile.MoveTo(Destpath);
                }
            }
 * 
 **/
