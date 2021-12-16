using BCHFramework;
using SqliteDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3OrganizerUI.MP3DbUtilities
{
    public partial class FrmCreateSqliteDb : Form
    {

        #region Members


        private int CurrentCount { get; set; }

        private List<string> Errors { get; set; }

        private List<string> CompletedMessage { get; set; }

        private OperationResult Op { get; set; }

        private DateTime StartTime { get; set; }

        private List<string> Mp3Files { get; set; }

        private Mp3Repository mp3Repository { get; set; }

        #endregion

        #region Events

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = this.CurrentCount;
            tbProgress.Text = this.CurrentCount + " of " + ddlbMp3s.LbList.Count.ToString();
            this.Refresh();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Op = new OperationResult();
            OperationResult op = new OperationResult();

            LoadSqliteDb(ref op);

            this.Op.AddOperationResult(ref op);            
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
                "Number of mp3 files:   " + ddlbMp3s.LbList.Count + "\n" +
                "Total execution time (s):  " + ts.Seconds.ToString();
            CompletedMessage.Add("DB Load complete");
            CompletedMessage.Add("Number of mp3 files:   " + ddlbMp3s.LbList.Count);
            CompletedMessage.Add("Total execution time (s):  " + ts.Seconds.ToString());
            rtbMessages.Text = BCHUtilities.ListToString(CompletedMessage, "\n");
            progressBar1.Value = ddlbMp3s.LbList.Count;

            rtbMessages.Text = Op.GetAllMessages("\n");
        }

        private void btnLoadSqliteDb_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            rtbMessages.Text = "";

            if (ddlbMp3s.LbList.Count < 1 && rbtnUseFileList.Checked)
            {
                rtbMessages.Text = "No mp3s to process!";
                return;
            }

            if (!Directory.Exists(dddtbGetMp3RootDir.ItemText) && rbtnBHFileNameFormat.Checked)
            {
                rtbMessages.Text = "You must enter an MP3 Root Dir!";
                return;
            }

            try
            {
                string dbFname = Path.Combine(dddtbGetDbDir.ItemText, tbSqliteDbFileName.Text);

                CreateMp3Repository(dbFname, ref op);
                if (!op.Success)
                {
                    rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                }

                if (ckbMakeDbCopyIfExist.Checked)
                {
                    CreateCopyOfDb(dbFname, ref op);
                    if (!op.Success)
                    {
                        rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                    }
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
                return;
            }        

            timer1.Interval = 1000;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = ddlbMp3s.LbList.Count;
            this.CurrentCount = 0;

            StartTime = DateTime.Now;
            timer1.Start();
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnGetMp3s_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            
            GetMp3songs(ref op);
            if(!op.Success)
            {
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
            }
            else
            {
                lblMp3Count.Text = "Mp3 Count: " + ddlbMp3s.LbList.Count;
                rtbMessages.Text = "Success";
            }
        }

        #endregion

        #region Methods

        public FrmCreateSqliteDb()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            ddtbDbFile.AfterTextDragEvent += AfterDbFileAdd;
            ddlbMp3s.AfterDragAndDropListBoxEvent += DdlbMp3s_AfterDragAndDropListBoxEvent;
            ddlbMp3s.DragAndDropDropListBoxFailedEvent += DdlbMp3s_DragAndDropDropListBoxFailedEvent;
        }

        private void DdlbMp3s_DragAndDropDropListBoxFailedEvent(OperationResult op)
        {
            rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
        }

        private void DdlbMp3s_AfterDragAndDropListBoxEvent(List<string> files)
        {
        }

        private void GetMp3songs(ref OperationResult op)
        {
            if (!Directory.Exists(dddtbGetMp3RootDir.ItemText))
            {
                op.AddError($"\"{dddtbGetMp3RootDir.ItemText}\" does not exists.");
                return;
            }

            List<string> extentionFilters = new List<string> { ".mp3" };
            List<string> mp3Files = BCHFileIO.GetAllFilesInDir(dddtbGetMp3RootDir.ItemText, ref extentionFilters, true, ref op);
            if(!op.Success)
            {
                return;
            }

            if (mp3Files == null || !mp3Files.Any())
            {
                op.AddError($"No mp3 files.");
                return;
            }

            ddlbMp3s.AddFiles(mp3Files, false);
        }

        private void LoadSqliteDb(ref OperationResult op)
        {
            if (ddlbMp3s.LbList.Count < 1)
            {
                op.AddError($"No mp3 songs.");
                return;
            }

            try
            {
                MakeDatabaseReady(ref op);
                if (!op.Success)
                {
                    return;
                }

                if (rbtnBHFileNameFormat.Checked)
                {
                    InsertMP3s(ddlbMp3s.LbList, dddtbGetMp3RootDir.ItemText, true, ref op);
                    if (!op.Success)
                    {
                        return;
                    }
                }
                else
                {
                    InsertMP3s(ddlbMp3s.LbList, ref op);
                    if (!op.Success)
                    {
                        return;
                    }
                }

                
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        private void MakeDatabaseReady(ref OperationResult op)
        {
            try
            {
                if (!ckbAddToDb.Checked)
                {
                    mp3Repository.DropAllTables(ref op);
                    if (!op.Success)
                    {
                        return;
                    }

                    mp3Repository.CreateDatabaseTables(ref op);
                    if (!op.Success)
                    {
                        return;
                    }
                }
                else
                {
                    Mp3TableStatusGroup mp3TableStatusGroup = mp3Repository.CheckIfAllTablesExists(ref op);
                    if (!op.Success)
                    {
                        return;
                    }

                    bool anyMissingTables = mp3TableStatusGroup.AnyMissngTablds(ref op);
                    if (!op.Success)
                    {
                        return;
                    }
                    if (anyMissingTables)
                    {
                        mp3Repository.DropAllTables(ref op);
                        if (!op.Success)
                        {
                            return;
                        }
                        mp3Repository.CreateDatabaseTables(ref op);
                        if (!op.Success)
                        {
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        private void SetCount(int cnt)
        {
            CurrentCount = cnt;
        }

        private void InsertMP3s(List<string> mp3List, string mp3RtDir, bool useFolderInfo, ref OperationResult op)
        {
            try
            {

                int cnt = 0;

                foreach (string mp3Item in mp3List)
                {
                    cnt++;
                    SetCount(cnt);

                    OperationResult _op = new OperationResult();
                    MP3FileDataType mp3 = useFolderInfo ?
                        BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmtWithDirInfo(mp3Item, mp3RtDir, ref _op)
                        : BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmt(mp3Item, ref _op);

                    if (!_op.Success)
                    {
                        op.AddOperationResult(ref _op);
                        return;
                    }

                    mp3Repository.InsertMp3(mp3, ref op);

                    if (!_op.Success)
                    {
                        op.AddOperationResult(ref _op);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }

        }

        private void InsertMP3s(List<string> mp3List, ref OperationResult op)
        {
            try
            {
                int cnt = 0;

                foreach (string mp3Item in mp3List)
                {
                    cnt++;
                    SetCount(cnt);

                    OperationResult _op = new OperationResult();
                    if(!mp3Item.EndsWith(".mp3"))
                    {
                        continue;
                    }    
                    MP3FileDataType mp3 = BCHMP3Utilities.UseFileTagsToGetInfo(mp3Item, ref _op);

                    if (!_op.Success)
                    {
                        op.AddOperationResult(ref _op);
                        return;
                    }

                    mp3Repository.InsertMp3(mp3, ref op);

                    if (!_op.Success)
                    {
                        op.AddOperationResult(ref _op);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }

        }

        private void AfterDbFileAdd(string fname)
        {
            tbSqliteDbFileName.Text = Path.GetFileName(fname);
            dddtbGetDbDir.ItemText = Path.GetDirectoryName(fname);
            OperationResult op = new OperationResult();

            GetMp3songs(ref op);
            if (!op.Success)
            {
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
            }
        }


        private void CreateMp3Repository (string dbName, ref OperationResult op)
        {
            try
            {
                dbName = dbName.EndsWith(".db") ? dbName : dbName + ".db";
                if (!op.Success)
                {
                    return;
                }

                mp3Repository = new Mp3Repository(dbName, ref op);
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        private void CreateCopyOfDb(string dbName, ref OperationResult op)
        {
            try
            {
                if(File.Exists(dbName))
                {
                    BCHFileIO.CopyFile(dbName, true, ref op);
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            Mp3Repository mp3Repository = new Mp3Repository(Path.Combine(dddtbGetDbDir.ItemText, tbSqliteDbFileName.Text), ref op);

            var relsult = mp3Repository.GetAllMp3FileInfo();

        }
    }
}
