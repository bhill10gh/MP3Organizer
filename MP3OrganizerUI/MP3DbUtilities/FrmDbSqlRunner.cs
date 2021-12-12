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

namespace MP3OrganizerUI
{
    public partial class FrmDbSqlRunner : Form
    {

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
                MP3DBManager mdbmgr = new MP3DBManager();
                mdbmgr.SetDataStore(ddtbMp3DbFile.ItemText, ref op);

                Dictionary<string, string> parms = new Dictionary<string, string>();

                string sql = rtbSql.Text;
                parms.Add("Sql", sql);

                DataTable dt = mdbmgr.RunSqlScript(ref parms, DAL.SqlScriptEnum.DynamicSQL, ref op);
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
            SetConrol();
        }

        private void lbSqlStatements_DoubleClick(object sender, EventArgs e)
        {
            string selItem = $"{lbSqlStatements.SelectedItem} \n";
            rtbSql.SelectedText = selItem;
        }

        #endregion


        #region Methods

        public FrmDbSqlRunner()
        {
            InitializeComponent();

            OperationResult op = new OperationResult();

            ddtbMp3DbFile.AfterTextDragEvent += AfterFileTextDrop;

            lbSqlStatements.Items.Add("Select \n");
            lbSqlStatements.Items.Add("From \n");
            lbSqlStatements.Items.Add("Where \n");

        }

        private void SetConrol()
        {
            rtbMessages.Text = "";
            OperationResult op = new OperationResult();
            if (MP3DBExists())
            {
                LoadDbTableListBox(ref op);
                if(!op.Success)
                {
                    rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                }
            }
            else
            {
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
            }
        }

        private void LoadDbTableListBox(ref OperationResult op)
        {
            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();
                mdbmgr.SetDataStore(ddtbMp3DbFile.ItemText, ref op);

                //string sql = 
                //    "SELECT MSysObjects.Name AS TableName " +
                //    "FROM MSysObjects " +
                //    "WHERE (((Left([Name],1))<>\"~\") " +
                //    "AND ((Left([Name],4))<>\"MSys\")  " +
                //    "AND ((MSysObjects.Type) In (1,4,6)))  " +
                //    "order by MSysObjects.Name " +
                //    "";

                lbTables.Items.Clear();


                DataTable dt = mdbmgr.GetDbTables(ref op);

                BCHWinFormUtilities.DataTableToListBox(dt, lbTables, "TABLE_NAME");

                lbTables.SelectedIndex = 0;

                LoadDbColumnListBox(lbTables.SelectedItem.ToString(), ref op);
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

        private void LoadDbColumnListBox(string tableName, ref OperationResult op)
        {
            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();
                mdbmgr.SetDataStore(ddtbMp3DbFile.ItemText, ref op);

                lbColumns.Items.Clear();

                DataTable dt = mdbmgr.GetDbTableColumns(tableName, ref op);

                BCHWinFormUtilities.DataTableToListBox(dt, lbColumns, "ColumnName");

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

        private void AfterFileTextDrop(string fName)
        {
            SetConrol();
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
from (tbMp3Info as m
inner join tbArtist as a on a.Mp3Info_Id = m.Mp3Info_Id)
inner join  tbFileInfo as f on f.FileInfo_Id = m.FileInfo_Id";





        #endregion

        
    }
}
