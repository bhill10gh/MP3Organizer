using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Specialized;

using BCHControls;
using BCHFramework;
using MP3OrganizerBusinessLogic;
using MP3OrganizerUI.Controls;


namespace MP3OrganizerUI
{
    public partial class FrmLoadMP3DB : Form
    {
        #region Members


        private int CurrentCount { get; set; }

        private List<string> Errors { get; set; }

        private List<string> CompletedMessage { get; set; }

        private OperationResult Op { get; set; }

        private DateTime StartTime { get; set; }

        #endregion

        public FrmLoadMP3DB()
        {
            InitializeComponent();
            
            tbMP3RootDir.Text =  BCHUtilities.GetConfigValue("MP3RootDir", 0, string.Empty, 0, false, true);

            ucDatabaseFile1.SetControl();
        }

        #region Events

        private void btnGetMP3RootDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbMP3RootDir.Text = folderBrowserDialog1.SelectedPath;
        }
       

        private void btnGetMP3s_Click(object sender, EventArgs e)
        {
            if (tbMP3RootDir.Text.Trim().Length < 1)
            {
                MessageBox.Show("You must enter an MP3 Root Dir!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileSearch fs = new FileSearch();

            fs.FileFilters.Add("mp3");
            fs.StartDir = tbMP3RootDir.Text.Trim();

            OperationResult op = new OperationResult();

            fs.StartSearch(ref op);

            if (!op.Success)
            {
                MessageBoxIcon mbi = MessageBoxIcon.Error;
                string msgBxMsg = op.GetAllErrorsAndExceptions("\n");
                string msgCap = "ERROR!";
                MessageBox.Show(msgBxMsg, msgCap, MessageBoxButtons.OK, mbi);
            }

            lbMP3s.DataSource = fs.Files;
            lblMP3Count.Text = fs.Files.Count.ToString();

        }

        private void btnLoadMP3DB_Click(object sender, EventArgs e)
        {
            if (!ucDatabaseFile1.MP3DBExists)
            {
                MessageBox.Show("You must choose an Access 2000 to 2003 version database (mdb) file!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbMP3RootDir.Text.Trim().Length < 1)
            {
                MessageBox.Show("You must enter an MP3 Root Dir!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            timer1.Interval = 1000;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = lbMP3s.Items.Count;

            StartTime = DateTime.Now;
            timer1.Start();
            backgroundWorker1.RunWorkerAsync();

        }

        private void btnDeleteAllMp3s_Click(object sender, EventArgs e)
        {
            if (!ucDatabaseFile1.MP3DBExists)
            {
                MessageBox.Show("You must choose an Access 2000 to 2003 version database (mdb) file!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete all mp3's in this database?", "WARNING!",
                                         MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                DeleteAllMp3s();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Op = new OperationResult();
            OperationResult op = new OperationResult();
            LoadDB(ref op);
            this.Op.AddOperationResult(ref op);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer1.Stop();

            CompletedMessage = new List<string>();
            Errors = new List<string>();

            if (!Op.Success)
            {
                Errors = this.Op.GetAllErrorsAndExceptions();
            }



            TimeSpan ts = DateTime.Now.Subtract(StartTime);

            string msg =
                "DB Load complete!\n" +
                "Number of mp3 files:   " + lbMP3s.Items.Count + "\n" +
                "Total execution time (s):  " + ts.Seconds.ToString();
            CompletedMessage.Add("DB Load complete");
            CompletedMessage.Add("Number of mp3 files:   " + lbMP3s.Items.Count);
            CompletedMessage.Add("Total execution time (s):  " + ts.Seconds.ToString());
            MessageBoxIcon mbi = Op.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            string msgBxMsg = Op.Success ? msg : msg + "\n" + "There were errors!";
            string msgCap = Op.Success ? "INFORMATION" : "ERROR!";
            MessageBox.Show(msgBxMsg, msgCap, MessageBoxButtons.OK, mbi);
            progressBar1.Value = lbMP3s.Items.Count;
            OperationResult op = new OperationResult();
            SaveMessagesToFile(ref op);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = this.CurrentCount;
            tbProgress.Text = this.CurrentCount + " of " + lbMP3s.Items.Count.ToString();
            this.Refresh();
        }

        private void btnCmpctRprDB_Click(object sender, EventArgs e)
        {
            CompactRepareDB();
        }

        #endregion

        #region Methods

        private void LoadDB(ref OperationResult op)
        {

            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();
                mdbmgr.SetDataStore(ucDatabaseFile1.MP3DBFileName, ref op);
                mdbmgr.onCountChange += SetCount;

                List<string> mp3List = BCHWinFormUtilities.ListBoxToList(lbMP3s);
                string mp3RtDir = tbMP3RootDir.Text;
                mdbmgr.InsertMP3s(mp3List, mp3RtDir, ckbUseFolderInfo.Checked, ref op);


            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        private void DeleteAllMp3s()
        {
            OperationResult op = new OperationResult();

            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();
                mdbmgr.SetDataStore(ucDatabaseFile1.MP3DBFileName, ref op);
                mdbmgr.DeleteallMP3s(ref op);
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }

            string msg = "Delete MP3 Complete.";
            MessageBoxIcon mbi = op.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            string msgBxMsg = op.Success ? msg : msg + "\n" + "There were errors!\n" + op.GetAllErrorsAndExceptions("\n");
            string msgCap = op.Success ? "INFORMATION" : "ERROR!";
            MessageBox.Show(msgBxMsg, msgCap, MessageBoxButtons.OK, mbi);
        }

        private void SetCount(int cnt)
        {
            CurrentCount = cnt;
        }

        private void SaveMessagesToFile(ref OperationResult op)
        {

            List<string> output = new List<string>();
            output.Add("Load MP3 DB Run " + DateTime.Now.ToShortDateString());
            output.AddRange(this.CompletedMessage);
            output.Add("Error and Exception Messages:");
            output.AddRange(this.Errors);
            DateTime now = DateTime.Now;
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string appDriveDir = appPath; // appPath.Substring(0, 3);
            string infoFile = Path.Combine(appDriveDir, "LoadMP3DBRun");

            BCHFileIO.SaveMessagesToFile(infoFile, output, ref op);

            if (!op.Success)
            {
                MessageBoxIcon mbi = MessageBoxIcon.Error;
                string msgBxMsg = "There were errors! saving log file.";
                string msgCap = "ERROR!";
                MessageBox.Show(msgBxMsg, msgCap, MessageBoxButtons.OK, mbi);
            }
        }

        private void CompactRepareDB()
        {
            OperationResult op = new OperationResult();

            MP3DBManager mdbmgr = new MP3DBManager();

            mdbmgr.SetDataStore(ucDatabaseFile1.MP3DBFileName, ref op);

            string msg = "Delete MP3 Complete.";
            MessageBoxIcon mbi = op.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            string msgBxMsg = op.Success ? msg : msg + "\n" + "There were errors!\n" + op.GetAllErrorsAndExceptions("\n");
            string msgCap = op.Success ? "INFORMATION" : "ERROR!";
            MessageBox.Show(msgBxMsg, msgCap, MessageBoxButtons.OK, mbi);
        }

        #endregion

        private void tbMP3RootDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMP3DBFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
