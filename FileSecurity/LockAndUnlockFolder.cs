using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSecurity
{
    class LockAndUnlockFolder
    {
        private string adminUsername;
        public LockAndUnlockFolder() {
            adminUsername = Environment.UserName;
        }
        public void Lock(string folderPath) { 
            DirectorySecurity ds = Directory.GetAccessControl(folderPath);
            FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(adminUsername, FileSystemRights.FullControl, AccessControlType.Deny);
            ds.AddAccessRule(fileSystemAccessRule);
            Directory.SetAccessControl(folderPath, ds);
            MessageBox.Show("Locked "+ folderPath);
        }

        public void UnLock(string folderPath) {
            DirectorySecurity ds = Directory.GetAccessControl(folderPath);
            FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(adminUsername, FileSystemRights.FullControl, AccessControlType.Deny);
            ds.RemoveAccessRule(fileSystemAccessRule);
            Directory.SetAccessControl(folderPath, ds);
            MessageBox.Show("Unlocked " + folderPath);
        }

        public void DenyDeleteAccess(string folderPath) {
            DirectorySecurity ds = Directory.GetAccessControl(folderPath);
            FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(adminUsername, FileSystemRights.DeleteSubdirectoriesAndFiles, AccessControlType.Deny);
            ds.AddAccessRule(fileSystemAccessRule);
            Directory.SetAccessControl(folderPath, ds);
            MessageBox.Show("Delete Access Denied");
        }
    }
}
