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
            if(rbtnBHFileNameFormat.Checked)
            {
                LoadSqliteDb(ref op);
            }
            else
            {

            }
            
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
            rtbMessages.Text = "";

            if (dddtbGetMp3RootDir.ItemText.Trim().Length < 1)
            {
                rtbMessages.Text = "You must enter an MP3 Root Dir!";
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

        private void lbMP3s_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void lbMP3s_DragEnter(object sender, DragEventArgs e)
        {

        }

        #endregion

        #region Methods

        public FrmCreateSqliteDb()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            ddtbDbFile.AfterTextDragEvent += AfterDbFileAdd;
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

            //BCHWinFormUtilities.ListToListBox(mp3Files, lbMP3s, true);
            ddlbMp3s.AddFiles(mp3Files, true);
        }

        private void LoadSqliteDb(ref OperationResult op)
        {
            if (ddlbMp3s.LbList.Count < 1)
            {
                op.AddError($"No mp3 songs.");
                return;
            }

            if (!Directory.Exists(dddtbGetDbDir.ItemText))
            {
                op.AddError($"\"{dddtbGetDbDir.ItemText}\" does not exists.");
                return;
            }

            string dbName = tbSqliteDbFileName.Text;
            
            if (File.Exists(dbName))
            {
                op.AddError($"\"{dbName}\" already exists.  Choose another name.");
                return;
            }

            if (dbName.IndexOfAny(Path.GetInvalidFileNameChars()) > 0)
            {
                op.AddError($"\"{dbName}\" has invalid characters.  Choose another name.");
                return;
            }
            dbName = Path.Combine(dddtbGetDbDir.ItemText, dbName);

            dbName = dbName.EndsWith(".db") ? dbName : dbName + ".db";

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection(dbName, ref op);
            if (!op.Success)
            {
                return;
            }

            string createArtistTableSql = "CREATE TABLE [tbArtist]([Artist_Id][INTEGER] PRIMARY KEY, [Mp3Info_Id] [INTEGER] NOT NULL, [Artist_Name] [nvarchar](255) NOT NULL)";
            string createFileInfoTableSql = "CREATE TABLE [tbFileInfo]([FileInfo_Id][INTEGER] PRIMARY KEY, [File_Name] [nvarchar](250) NOT NULL, [Path] [nvarchar](255) NOT NULL)";
            string createMp3InfoTableSql = "CREATE TABLE [tbMp3Info]( [Mp3Info_Id] [INTEGER] PRIMARY KEY, [FileInfo_Id] [INTEGER] NOT NULL, [Song_Title] [nvarchar](255) NOT NULL, [Album] [nvarchar](255) NULL, [Genre] [nvarchar](255) NULL, [Comments] [nvarchar](255) NULL, [Track] [INTEGER] NULL, [Song_Numeraton] [nvarchar](255) NULL) ";

            try
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = createArtistTableSql;
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = createFileInfoTableSql;
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = createMp3InfoTableSql;
                sqlite_cmd.ExecuteNonQuery();

                InsertMP3s(ddlbMp3s.LbList, dddtbGetMp3RootDir.ItemText, sqlite_conn, true, ref op);
                if (!op.Success)
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        private SQLiteConnection CreateConnection(string dbFileName, ref OperationResult op)
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection($"Data Source={dbFileName}; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }
            return sqlite_conn;
        }

        private void SetCount(int cnt)
        {
            CurrentCount = cnt;
        }

        private void InsertMP3s(List<string> mp3List, string mp3RtDir, SQLiteConnection conn, bool useFolderInfo, ref OperationResult op)
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
                        continue;
                    }


                    InsertMP3IntoTables(mp3, conn, ref _op);

                    if (!_op.Success)
                    {
                        op.AddOperationResult(ref _op);
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }

        }

        public void InsertMP3IntoTables(MP3FileDataType mp3, SQLiteConnection conn, ref OperationResult op)
        {
            try
            {
                SQLiteDataAdapter sQLiteDataAdapter;
                SQLiteCommand sqlite_cmd;

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO tbFileInfo (File_Name, Path) VALUES ('{mp3.FileName.Replace("'", "''")}', '{mp3.FilePath.Replace("'", "''")}')";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"SELECT FileInfo_Id FROM tbFileInfo WHERE Path = '{mp3.FilePath.Replace("'", "''")}' AND File_Name = '{mp3.FileName.Replace("'", "''")}'";
                sQLiteDataAdapter = new SQLiteDataAdapter(sqlite_cmd);
                DataTable dt = new DataTable();
                sQLiteDataAdapter.Fill(dt);

                if(dt == null || dt.Rows.Count != 1)
                {
                    op.AddError("Failed trying to get FileIfno Row.");
                    return;
                }

                int fileInfoId = Int32.Parse(dt.Rows[0][0].ToString());

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO tbMp3Info (FileInfo_Id, Song_Title, Album, Genre, Comments, Track,Song_Numeraton ) " + 
                    $"VALUES ({fileInfoId}, '{mp3.SongTitle.Replace("'", "''")}', '{mp3.Album.Replace("'", "''")}', '{mp3.Genre.Replace("'", "''")}', '{mp3.Comments?.Replace("'", "''")}', {mp3.Track}, '{mp3.SongTitleAndNumeration.Replace("'", "''")}')";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"SELECT Mp3Info_Id FROM tbMp3Info WHERE FileInfo_Id = {fileInfoId}";
                sQLiteDataAdapter = new SQLiteDataAdapter(sqlite_cmd);
                dt = new DataTable();
                sQLiteDataAdapter.Fill(dt);

                if (dt == null || dt.Rows.Count != 1)
                {
                    op.AddError("Failed trying to get Mp3Info Row.");
                    return;
                }

                int mp3InfoId = Int32.Parse(dt.Rows[0][0].ToString());

                foreach (var artist in mp3.Artists)
                {
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = $"INSERT INTO tbArtist (Mp3Info_Id, Artist_Name) VALUES ({mp3InfoId}, '{artist.Replace("'", "''")}')";
                    sqlite_cmd.ExecuteNonQuery();
                }




            }
            catch (Exception ex)
            {

                op.AddException(ex);
                throw;
            }
        }

        private void AfterDbFileAdd(string fname)
        {
            tbSqliteDbFileName.Text = Path.GetFileName(fname);
            dddtbGetDbDir.ItemText = Path.GetDirectoryName(fname);
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Mp3Repository mp3Repository = new Mp3Repository(Path.Combine(dddtbGetDbDir.ItemText, tbSqliteDbFileName.Text));

            var relsult = mp3Repository.GetAllMp3FileInfo();

        }
    }
}
