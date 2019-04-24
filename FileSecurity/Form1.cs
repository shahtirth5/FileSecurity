using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileSecurity
{
    public partial class Form1 : Form
    {
        private LockAndUnlockFolder lockAndUnlock;
        private bool isAdmin = false;
        private FileOperations fileOperations;
        public Form1() {
            InitializeComponent();
            lockAndUnlock = new LockAndUnlockFolder();
            lockAndUnlock.Lock(@"C:\Users\Tirth\Desktop\hello");
            lockAndUnlock.Lock(@"C:\Users\Tirth\Desktop\Logs");
            btnLogout.Visible = false;
        }

        private void btnLoginClicked(object sender, EventArgs e) {
            if (tfUsername.Text.Equals("admin") && tfPassword.Text.Equals("123456"))
            {
                lblIncorrectPassword.Visible = false;
                lockAndUnlock.UnLock(@"C:\Users\Tirth\Desktop\hello");
                lockAndUnlock.UnLock(@"C:\Users\Tirth\Desktop\Logs");
                isAdmin = true;
                btnLogin.Visible = false;
                btnLogout.Visible = true;
            }
            else if (tfUsername.Text.Equals("user") && tfPassword.Text.Equals("123456"))
            {
                lblIncorrectPassword.Visible = false;
                isAdmin = false;
                btnLogin.Visible = false;
                btnLogout.Visible = true;
                lockAndUnlock.UnLock(@"C:\Users\Tirth\Desktop\hello");
                lockAndUnlock.UnLock(@"C:\Users\Tirth\Desktop\Logs");
                String time1 = DateTime.Now.ToString("_MMMdd_yyyy_HH-mm-ss");
                /*******************************************************************
                                    File Operation(COPY)
                 *******************************************************************/
                FileOperations fileOperations = new FileOperations();
                fileOperations.DirectoryCopy(@"C:\Users\Tirth\Desktop\hello\", @"C:\Users\Tirth\Desktop\Logs\"+time1 , true);
                /*******************************************************************
                 *******************************************************************/ 
                lockAndUnlock.Lock(@"C:\Users\Tirth\Desktop\Logs");
                checkForChanges();
            }
            else {
                lblIncorrectPassword.Visible = true;
            }
        }

        private void checkForChanges() {
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(@"C:\Users\Tirth\Desktop\hello\");
            fileSystemWatcher.IncludeSubdirectories = true;
            fileSystemWatcher.Changed += new FileSystemEventHandler(onFilesChanged);
            fileSystemWatcher.Created += new FileSystemEventHandler(onFilesChanged);
            fileSystemWatcher.Deleted += new FileSystemEventHandler(onFilesChanged);
        }

        private void onFilesChanged(object sender, FileSystemEventArgs e) {
            MessageBox.Show("Changes Occured. File Name is : " + e.Name );            
        }

        private void btnLogoutClicked(object sender, EventArgs e) {
            btnLogin.Visible = true;
            btnLogout.Visible = false;
            tfPassword.Text = "";
            tfUsername.Text = "";
            lockAndUnlock.Lock(@"C:\Users\Tirth\Desktop\hello");
            lockAndUnlock.Lock(@"C:\Users\Tirth\Desktop\Logs");
        }
    }
}
