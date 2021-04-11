using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using BCHFramework;

namespace MP3OrganizerUI.iTunes
{
    public partial class FrmCopyiPhoneBackupFIles : Form
    {
        private int FileProcCnt = 0;
        private int FileCnt = 0;
        private OperationResult Op = new OperationResult();

        public FrmCopyiPhoneBackupFIles()
        {
            InitializeComponent();
            Init();
        }

        protected void Init()
        {
            ucGetFromPath.SetControlFromConfig("iPhoneFromBackupFolder", 0, "", 0, false);
            ucGetToPath.SetControlFromConfig("iPhoneToBackupFolder", 0, "", 0, false);
        }


        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

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
                this.FileProcCnt++;
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

        private void btnCopyFiles_Click(object sender, EventArgs e)
        {
            Op = new OperationResult();



            if (cbxDeleteToDir.Checked)
            {
                try
                {
                    DeleteToDirContents(ucGetToPath.FileName);
                }
                catch (Exception ex)
                {

                    Op.AddException(ex);
                    ucResultDisplay1.DisplayText = Op.GetAllInfos("\n");
                    return;
                } 
            }



            this.FileCnt = Directory.GetFiles(ucGetFromPath.FileName, "*.*", SearchOption.AllDirectories).Length;
            this.FileProcCnt = 0;

            timer1.Interval = 1000;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = FileCnt;
            lblProgStat.Text = "1 of " + FileCnt.ToString();

            timer1.Start();
            backgroundWorker1.RunWorkerAsync();
        }


        private void DeleteToDirContents(string dirPath)
        {
            System.IO.DirectoryInfo downloadedMessageInfo = new DirectoryInfo(dirPath);

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {               

                DirectoryCopy(ucGetFromPath.FileName, ucGetToPath.FileName, true);
                
            }
            catch (Exception ex)
            {

                Op.AddException(ex);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            Op.AddInformation("Files copied successfully.");

            //try
            //{
            //    System.Diagnostics.Process.Start("explorer.exe", ucGetToPath.FileName);
            //}
            //catch (Exception ex)
            //{

            //    Op.AddException(ex);
            //}

            ucResultDisplay1.DisplayText = Op.GetAllInfos("\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = this.FileProcCnt;
            lblProgStat.Text = FileProcCnt.ToString() + " of " + FileCnt.ToString();
            this.Refresh();
        }

        private void btnOpenFromDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", ucGetFromPath.FileName);
        }

        private void btnOpenToDIr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", ucGetToPath.FileName);
        }


    }
}
