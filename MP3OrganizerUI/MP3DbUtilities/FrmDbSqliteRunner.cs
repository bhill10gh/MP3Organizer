using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

using BCHControls;
using BCHFramework;
using MP3OrganizerBusinessLogic;
using MP3OrganizerUI.Controls;
using System.IO;
using SqliteDAL;

namespace MP3OrganizerUI
{
    public partial class FrmDbSqliteRunner : Form
    {
        #region Members

        private Mp3Repository _mp3Repository { get; set; }

        #endregion


        #region Events

        private void lbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();

            LoadDbColumnListBox(lbTables.SelectedItem.ToString(), ref op);
        }

        private void lbColumns_DoubleClick(object sender, EventArgs e)
        {
            string selCol = lbColumns.SelectedItem.ToString();
            string selTable = lbTables.SelectedItem.ToString();
            string selItem = $"{selTable}.{selCol}";
            rtbSql.SelectedText = selItem;
        }

        private void lbTables_DoubleClick(object sender, EventArgs e)
        {
            rtbSql.Text += " " + lbTables.SelectedItem.ToString();
        }

        private void lbFromSnipits_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbFromSnipits.SelectedIndex)
            {
                case 0:
                    rtbSql.Text += $"\n{tbMp3InfotbArtist}";
                    break;
                case 1:
                    rtbSql.Text += $"\n{tbMp3InfotbFileInfo}";
                    break;
                case 2:
                    rtbSql.Text += $"\n{allJoin}";
                    break;
                case 3:
                    rtbSql.Text += $"\n{tbItunesPlaylisttbItunesPlaylistSongtbItunesSong}";
                    break;
                case 4:
                    rtbSql.Text += $"\n{tbItunesSongtbFileInfo}";
                    break;
                default:
                    break;
            }

        }

        private void btnExecuteSql_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();

            lblResults.Text = "Results (0)";
            rtbMessages.Text = "";

            dgvSqlResults.DataSource = null;
            try
            {
                string sql = rtbSql.Text;

                DataTable dt = _mp3Repository.RunSql(sql, ref op);
                if (!op.Success)
                {
                    rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                    return;
                }

                int count = 0;

                if (dt != null && dt.Rows.Count > 0)
                {
                    count = dt.Rows.Count;
                    dgvSqlResults.DataSource = dt;
                    lblResults.Text = $"Results ({count})";
                }

                if (op.Success)
                {
                    op.AddInformation("SQL Excution Successfull");
                    rtbMessages.Text = op.GetAllInfos("\n");
                }
                else
                {
                    rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                }

            }
            catch (Exception ex)
            {
                op.AddException(ex);
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
            }
        }

        private void btnRefreshDb_Click(object sender, EventArgs e)
        {
            SetControls();
        }

        private void lbSqlStatements_DoubleClick(object sender, EventArgs e)
        {
            string selItem = $"{lbSqlStatements.SelectedItem} \n";
            rtbSql.SelectedText = selItem;
        }

        #endregion


        #region Methods

        public FrmDbSqliteRunner()
        {
            InitializeComponent();

            OperationResult op = new OperationResult();

            ddtbMp3DbFile.AfterTextDragEvent += AfterFileTextDrop;

            lbSqlStatements.Items.Add("Select \n");
            lbSqlStatements.Items.Add("From \n");
            lbSqlStatements.Items.Add("Where \n");

        }

        private void CreateMp3Repository(string dbName, ref OperationResult op)
        {
            try
            {
                if(!dbName.EndsWith(".db", StringComparison.InvariantCultureIgnoreCase))
                {
                    op.AddError($"{dbName} is not a Sqlite fil.  Must end with \".db\".");
                    return;
                }
                if (!File.Exists(dbName))
                {
                    op.AddError($"{dbName} does not exist.");
                    return;
                }

                _mp3Repository = new Mp3Repository(dbName, ref op);
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        private void LoadDbTableListBox(ref OperationResult op)
        {
            try
            {

                lbTables.Items.Clear();

                DataTable dt = _mp3Repository.GetAllTables(ref op);
                if (!op.Success)
                {
                    rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                    return;
                }

                BCHWinFormUtilities.DataTableToListBox(dt, lbTables, "name");

                lbTables.SelectedIndex = 0;

                LoadDbColumnListBox(lbTables.SelectedItem.ToString(), ref op);
                if(!op.Success)
                {
                    return;
                }                
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                return;
            }
        }

        private void LoadDbColumnListBox(string tableName, ref OperationResult op)
        {
            try
            {
                lbColumns.Items.Clear();

                DataTable dt = _mp3Repository.GetTableColumns(tableName, ref op);
                if (!op.Success)
                {
                    return;
                }

                BCHWinFormUtilities.DataTableToListBox(dt, lbColumns, "name");
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }
        }

        private void AfterFileTextDrop(string dbName)
        {
            ddtbMp3DbFile.ItemText = dbName;
            SetControls();
        }

        private void SetControls()
        {
            OperationResult op = new OperationResult();

            string dbName = ddtbMp3DbFile.ItemText;

            rtbMessages.Text = "";
            CreateMp3Repository(dbName, ref op);
            if (!op.Success)
            {
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return;
            }

            LoadDbTableListBox(ref op);
            if (!op.Success)
            {
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return;
            }

            rtbMessages.Text = "Loaded all data";
        }

        #endregion

        #region From Clauses

        string tbMp3InfotbArtist = @"
from tbMp3Info as m
inner join tbArtist as a on a.Mp3Info_Id = m.Mp3Info_Id";

        string tbMp3InfotbFileInfo = @"
from tbMp3Info as m
inner join tbFileInfo as f on f.FileInfo_Id = m.FileInfo_Id";

        string allJoin = @"
from tbMp3Info as m
inner join tbArtist as a on a.Mp3Info_Id = m.Mp3Info_Id
inner join  tbFileInfo as f on f.FileInfo_Id = m.FileInfo_Id";

        string tbItunesPlaylisttbItunesPlaylistSongtbItunesSong = @"
from tbItunesPlaylist pl
inner join tbItunesPlaylistSong pls on pl.Playlist_Id = pls.Playlist_Id
inner join tbItunesSong s on s.Song_Id = pls.Song_Id";

        string tbItunesSongtbFileInfo = @"
from tbItunesSong s
inner join tbFileInfo f on f.FileInfo_Id = s.FileInfo_Id";




        #endregion
    }
}
