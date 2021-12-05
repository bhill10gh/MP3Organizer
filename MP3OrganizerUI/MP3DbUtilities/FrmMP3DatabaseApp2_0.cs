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
using System.Collections.Specialized;

using BCHFramework;
using DAL;
using MP3OrganizerBusinessLogic;

namespace MP3OrganizerUI
{
    public partial class FrmMP3DatabaseApp2_0 : Form
    {

        #region Events

        private void btnCreatePdbTableFile_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            OperationResult op = new OperationResult();

            CsvDb.CreateCsvTable(dt, @"C:\temp\music.txt", ref op, ",", ",");
            if (!op.Success)
            {
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return;
            }
        }

        private void btnCreateM3U_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            try
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                CreateM3uFromResults(dt, "", ref op);
                if (!op.Success)
                {
                    rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                    return;
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return;
            }

            rtbMessages.Text = "Success";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            rtbMessages.Text = "";



            if (!MP3DBExists())
            {
                rtbMessages.Text = "Database file does not exists";
                return;
            }

            List<string> list = new List<string>();            

            string wherePart = CreateWherePart(ftAlbum, "Album");
            if (wherePart.Trim().Length > 0)
                list.Add(wherePart);

            wherePart = CreateWherePart(ftArtist, "artist_Name");
            if (wherePart.Trim().Length > 0)
                list.Add(wherePart);

            wherePart = CreateWherePart(ftComment, "Comments");
            if (wherePart.Trim().Length > 0)
                list.Add(wherePart);

            wherePart = CreateWherePart(ftFileName, "File_Name");
            if (wherePart.Trim().Length > 0)
                list.Add(wherePart);

            wherePart = CreateWherePart(ftGenre, "Genre");
            if (wherePart.Trim().Length > 0)
                list.Add(wherePart);

            wherePart = CreateWherePart(ftTitle, "Song_Title");
            if (wherePart.Trim().Length > 0)
                list.Add(wherePart);

            OperationResult op = new OperationResult();

            try
            {
                wherePart = MP3DBManager.BuildSearchWhereClause(list, rbAnd.Checked);


                MP3DBManager mdbmgr = new MP3DBManager();

                mdbmgr.SetDataStore(ddtbMp3DbFile.ItemText, ref op);
                Dictionary<string, string> parms = new Dictionary<string, string>();
                parms.Add("Where_Clause", wherePart);


                DataTable dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.GetMP3Data_EnterWhereClause, ref op);

                if (op.Success)
                {
                    dataGridView1.DataSource = dt;
                    int count = 0;

                    if(dt != null && dt.Rows.Count > 0)
                    {
                        count = dt.Rows.Count;
                    }
                    rtbMessages.Text = $"Search Results - {count}";
                }
                else
                {
                    rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                    return;
                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return;
            }
        }

        private void btnRefreshDb_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            ProcessMp3DbFile(ref op);
        }

        #endregion


        #region Methods 

        public FrmMP3DatabaseApp2_0()
        {
            InitializeComponent();

            ddtbMp3DbFile.AfterTextDragEvent += AfterFileTextDrop;

            ftAlbum.SetDupes(false);
            ftAlbum.ShowMoveButtons = false;
            ftAlbum.SetListBoxTitle("Albums", BCHControls.UCFromToEnum.From);
            ftAlbum.SetListBoxTitle("Search Values", BCHControls.UCFromToEnum.To);
            ftArtist.SetDupes(false);
            ftArtist.ShowMoveButtons = false;
            ftArtist.SetListBoxTitle("Artists", BCHControls.UCFromToEnum.From);
            ftArtist.SetListBoxTitle("Search Values", BCHControls.UCFromToEnum.To);
            ftComment.SetDupes(false);
            ftComment.ShowMoveButtons = false;
            ftComment.SetListBoxTitle("Comments", BCHControls.UCFromToEnum.From);
            ftComment.SetListBoxTitle("Search Values", BCHControls.UCFromToEnum.To);
            ftFileName.SetDupes(false);
            ftFileName.ShowMoveButtons = false;
            ftFileName.SetListBoxTitle("File Names", BCHControls.UCFromToEnum.From);
            ftFileName.SetListBoxTitle("Search Values", BCHControls.UCFromToEnum.To);
            ftGenre.SetDupes(false);
            ftGenre.ShowMoveButtons = false;
            ftGenre.SetListBoxTitle("Genres", BCHControls.UCFromToEnum.From);
            ftGenre.SetListBoxTitle("Search Values", BCHControls.UCFromToEnum.To);
            ftTitle.SetDupes(false);
            ftTitle.ShowMoveButtons = false;
            ftTitle.SetListBoxTitle("Title", BCHControls.UCFromToEnum.From);
            ftTitle.SetListBoxTitle("Search Values", BCHControls.UCFromToEnum.To);
        }

        private void ProcessMp3DbFile(ref  OperationResult op)
        {
            try
            {                
                if (!File.Exists(ddtbMp3DbFile.ItemText) || !ddtbMp3DbFile.ItemText.ToUpper().EndsWith(".MDB"))
                {
                    throw new Exception("You must choose an Access 2000 to 2003 version database (mdb) file!");
                }

                FillListBoxes(ref op);
                if (!op.Success)
                {
                    rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                    ddtbMp3DbFile.ItemText = string.Empty;
                    return;
                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return;
            }
        }


        private void FillListBoxes(ref OperationResult op)
        {
            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();

                mdbmgr.SetDataStore(ddtbMp3DbFile.ItemText, ref op);
                Dictionary<string, string> parms = new Dictionary<string, string>();
                int count = 0;
                
                DataTable dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllAlbums, ref op);
                count = ftAlbum.AddDataTable(dt, "Album", BCHControls.UCFromToEnum.From);
                lblAlbum.Text = $"Album ({count})";

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllArtists, ref op);
                count = ftArtist.AddDataTable(dt, "Artist_Name", BCHControls.UCFromToEnum.From);
                lblArtist.Text = $"Artist ({count})";

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllComments, ref op);
                count = ftComment.AddDataTable(dt, "Comments", BCHControls.UCFromToEnum.From);
                lblComment.Text = $"Comment ({count})";

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllFileNames, ref op);
                count = ftFileName.AddDataTable(dt, "File_Name", BCHControls.UCFromToEnum.From);
                lblFileName.Text = $"File Name ({count})";

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllGenres, ref op);
                count = ftGenre.AddDataTable(dt, "Genre", BCHControls.UCFromToEnum.From);
                lblGenre.Text = $"Genre ({count})";

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllSongs, ref op);
                count = ftTitle.AddDataTable(dt, "Song_Title", BCHControls.UCFromToEnum.From);
                lblTitle.Text = $"Title ({count})";
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return;
            }
        }

        private bool MP3DBExists()
        {
            return File.Exists(ddtbMp3DbFile.ItemText);
        }

        private string CreateWherePart(BCHControls.UCFromTo atl, string field)
        {
            string wherePart = string.Empty;
            List<string> list = atl.GetStrList(BCHControls.UCFromToEnum.To);

            if (!list.Any())
            {
                return wherePart;
            }

            List<string> listFixed = new List<string>();

            //make sure to escape sinqle quotes for query
            foreach (var item in list)
            {
                listFixed.Add(item.Replace("'", "''"));
            }            

            wherePart = MP3DBManager.BuildSearchWhereClausePart(field, listFixed, true, rbAnd.Checked, cbxUseLike.Checked);

            return wherePart;
        }

        private void CreateM3uFromResults(DataTable dt, string m3uFileName, ref OperationResult op)
        {

            try
            {
                if (dt == null || dt.Rows.Count < 1)
                {
                    return;
                }

                List<string> songs = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    songs.Add(Path.Combine((string)row["Path"], (string)row["File_Name"]));

                    BCHFileIO.WriteFullFile(m3uFileName, songs, ref op);

                    if (!op.Success)
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
                return;
            }
        }

        private void AfterFileTextDrop(string fName)
        {
            OperationResult op = new OperationResult();
            ProcessMp3DbFile(ref op);
            
        }


        #endregion
    }


}
