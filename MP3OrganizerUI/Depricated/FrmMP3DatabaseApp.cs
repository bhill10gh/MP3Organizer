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
    public partial class FrmMP3DatabaseApp : Form
    {

        //public string MP3DBFileName { get; set; }

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

            List<string> list = new List<string>();

            dataGridView1.DataSource = null;

            string wherePart = CreateWherePart(ucatAlbum, "Album");
            if (wherePart != "'None'" && wherePart.Trim().Length > 0)
                list.Add(wherePart);

            wherePart = CreateWherePart(ucatArtists, "artist_Name");
            if (wherePart != "'None'" && wherePart.Trim().Length > 0)
                list.Add(wherePart);

            wherePart = CreateWherePart(ucatComment, "Comments");
            if (wherePart != "'None'" && wherePart.Trim().Length > 0)
                list.Add(wherePart);

            wherePart = CreateWherePart(ucatFileName, "File_Name");
            if (wherePart != "'None'" && wherePart.Trim().Length > 0)
                list.Add(wherePart);

            wherePart = CreateWherePart(ucatGenre, "Genre");
            if (wherePart != "'None'" && wherePart.Trim().Length > 0)
                list.Add(wherePart);

            wherePart = CreateWherePart(ucatTitle, "Song_Title");
            if (wherePart != "'None'" && wherePart.Trim().Length > 0)
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

        public FrmMP3DatabaseApp()
        {
            InitializeComponent();

            ddtbMp3DbFile.AfterTextDragEvent += AfterFileTextDrop;
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

                string none = "None";
                DataTable dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllAlbums, ref op);
                ucatAlbum.ClearListbox();
                ucatAlbum.SetListboxList(dt, "Album");
                ucatAlbum.InsertListBoxItem(0, none);
                ucatAlbum.SetSelectedIndex(0);

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllArtists, ref op);
                ucatArtists.ClearListbox();
                ucatArtists.SetListboxList(dt, "Artist_Name");
                ucatArtists.InsertListBoxItem(0, none);
                ucatArtists.SetSelectedIndex(0);

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllComments, ref op);
                ucatComment.ClearListbox();
                ucatComment.SetListboxList(dt, "Comments");
                ucatComment.InsertListBoxItem(0, none);
                ucatComment.SetSelectedIndex(0);

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllFileNames, ref op);
                ucatFileName.ClearListbox();
                ucatFileName.SetListboxList(dt, "File_Name");
                ucatFileName.InsertListBoxItem(0, none);
                ucatFileName.SetSelectedIndex(0);

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllGenres, ref op);
                ucatGenre.ClearListbox();
                ucatGenre.SetListboxList(dt, "Genre");
                ucatGenre.InsertListBoxItem(0, none);
                ucatGenre.SetSelectedIndex(0);

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllSongs, ref op);
                ucatTitle.ClearListbox();
                ucatTitle.SetListboxList(dt, "Song_Title");
                ucatTitle.InsertListBoxItem(0, none);
                ucatTitle.SetSelectedIndex(0);
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

        private string CreateWherePart(BCHControls.UCAddToListBox atl, string field)
        {
            string wherePart = string.Empty;

            if (atl.SelectedCount < 1)
            {
                return wherePart;
            }

            List<string> list = atl.GetSelectedItems();

            if (atl.SelectedCount == 1 && list[0] == "None")
            {
                return wherePart;
            }

            wherePart = MP3DBManager.BuildSearchWhereClausePart(field, list, true, rbAnd.Checked, cbxUseLike.Checked);

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
