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

        public string MP3DBFileName { get; set; }
        public bool MP3DBExists { get; set; }

        public FrmMP3DatabaseApp()
        {
            InitializeComponent();
            OperationResult op = new OperationResult();

            try
            {
                MP3DBExists = false;

                NameValueCollection appSettings = ConfigurationManager.AppSettings;

                if (appSettings == null)
                {
                    rtbMessages.Text = "No App Settings.";
                    return;
                }

                foreach (string appKey in appSettings.AllKeys)
                {
                    foreach (string val in appSettings.GetValues(appKey))
                    {
                        string appValue = appSettings[appKey];
                        string file = appValue;
                        if (!string.IsNullOrEmpty(file) && File.Exists(file) && file.ToUpper().EndsWith(".MDB"))
                        {
                            this.MP3DBExists = true;
                            tbMP3DBFile.Text = file;
                        }
                    }
                    if (MP3DBExists)
                    {
                        break;
                    }

                }

                if (MP3DBExists)
                    FillListBoxes(ref op);
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return;
            }
        }

        private void btnGetMP3DBFile_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();

            try
            {
                openFileDialog1.Title = "Choose an Access 2000 to 2003 version database (mdb) file.";
                openFileDialog1.ShowDialog();
                this.MP3DBFileName = openFileDialog1.FileName;
                if (File.Exists(MP3DBFileName) && MP3DBFileName.ToUpper().EndsWith(".MDB"))
                {
                    this.MP3DBExists = true;
                }
                else
                {
                    this.MP3DBExists = false;
                    MessageBox.Show("The databse you chose is not valid!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtbMessages.Text = "The databse you chose is not valid!";
                    return;
                }

                tbMP3DBFile.Text = this.MP3DBFileName;
                FillListBoxes(ref op);
                if(!op.Success)
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

        private void FillListBoxes(ref OperationResult op)
        {
            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();

                this.MP3DBFileName = tbMP3DBFile.Text;
                mdbmgr.SetDataStore(MP3DBFileName, ref op);
                Dictionary<string, string> parms = new Dictionary<string, string>();

                string none = "None";
                DataTable dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllAlbums, ref op);
                ucatAlbum.SetListboxList(dt, "Album");
                ucatAlbum.InsertListBoxItem(0, none);
                ucatAlbum.SetSelectedIndex(0);

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllArtists, ref op);
                ucatArtists.SetListboxList(dt, "Artist_Name");
                ucatArtists.InsertListBoxItem(0, none);
                ucatArtists.SetSelectedIndex(0);

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllComments, ref op);
                ucatComment.SetListboxList(dt, "Comments");
                ucatComment.InsertListBoxItem(0, none);
                ucatComment.SetSelectedIndex(0);

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllFileNames, ref op);
                ucatFileName.SetListboxList(dt, "File_Name");
                ucatFileName.InsertListBoxItem(0, none);
                ucatFileName.SetSelectedIndex(0);

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllGenres, ref op);
                ucatGenre.SetListboxList(dt, "Genre");
                ucatGenre.InsertListBoxItem(0, none);
                ucatGenre.SetSelectedIndex(0);

                dt = mdbmgr.RunSqlScript(ref parms, SqlScriptEnum.SelectAllSongs, ref op);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            List<string> list = new List<string>();

            dataGridView1.DataSource = null;

            string wherePart = CreateWherePart(ucatAlbum, "Album");
            if(wherePart != "'None'" && wherePart.Trim().Length > 0)
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

                this.MP3DBFileName = tbMP3DBFile.Text;
                mdbmgr.SetDataStore(MP3DBFileName, ref op);
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

        private void btnCreatePdbTableFile_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            OperationResult op = new OperationResult();

            CsvDb.CreateCsvTable(dt, @"C:\temp\music.txt", ref op, ",", ",");
            if(!op.Success)
            {
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return;
            }
        }

        private void CreateM3uFromResults(DataTable dt, string m3uFileName, ref OperationResult op)
        {

            try
            {
                if(dt == null || dt.Rows.Count < 1)
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

        private void btnCreateM3U_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            try
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                CreateM3uFromResults(dt, "", ref op);
                if(!op.Success)
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
    }


}
