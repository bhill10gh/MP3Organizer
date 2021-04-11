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

namespace MP3OrganizerUI
{
    public partial class FrmDbSqlRunner : Form
    {
        public FrmDbSqlRunner()
        {
            InitializeComponent();

            OperationResult op = new OperationResult();

            SetConrol(ref op);

            ucResultDisplay1.AddOperationResult(ref op, true, true, true);
        }

        private void SetConrol(ref OperationResult op)
        {
            ucDatabaseFile1.SetControl();

            if (ucDatabaseFile1.MP3DBExists)
            {

                LoadDbTableListBox(ref op);
            }
        }

        private void LoadDbTableListBox(ref OperationResult op)
        {
            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();
                mdbmgr.SetDataStore(ucDatabaseFile1.MP3DBFileName, ref op);

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
                
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                return;
            }
        }

        private void LoadDbColumnListBox(string tableName,  ref OperationResult op)
        {
            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();
                mdbmgr.SetDataStore(ucDatabaseFile1.MP3DBFileName, ref op);

                lbColumns.Items.Clear();

                DataTable dt = mdbmgr.GetDbTableColumns(tableName, ref op);

                BCHWinFormUtilities.DataTableToListBox(dt, lbColumns, "ColumnName");

            }
            catch (Exception ex)
            {
                op.AddException(ex);
                return;
            }
        }

        private void lbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();

            LoadDbColumnListBox(lbTables.SelectedItem.ToString(), ref op);
        }

        private void lbColumns_DoubleClick(object sender, EventArgs e)
        {
            rtbSql.Text += "\n" + lbColumns.SelectedItem.ToString();
        }

        private void lbTables_DoubleClick(object sender, EventArgs e)
        {
            rtbSql.Text += "\n" + lbTables.SelectedItem.ToString();
        }

        private void btnExecuteSql_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();

            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();
                mdbmgr.SetDataStore(ucDatabaseFile1.MP3DBFileName, ref op);

                Dictionary<string, string> parms = new Dictionary<string, string>();

                string sql = rtbSql.Text;
                parms.Add("Sql", sql);

                DataTable dt = mdbmgr.RunSqlScript(ref parms, DAL.SqlScriptEnum.DynamicSQL, ref op);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvSqlResults.DataSource = dt;
                }

                if (op.Success)
                {
                    op.AddInformation("SQL Excution Successfull");
                }

            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }

            ucResultDisplay1.AddOperationResult(ref op, true, true, true);
        }

        private void dgvSqlResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
