using BCHFramework;
using MP3OrganizerBusinessLogic;
using SqliteDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3OrganizerUI.MP3DbUtilities
{
    public partial class FrmMp3DbFileCreater : Form
    {


        #region Events

        private void btnCreateDbFile_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();

            rtbMessages.Text = "";
            if (!MP3DBExists())
            {
                SetMessages("You must choose an Access 2000 to 2003 version database (mdb) file!", true);
                return;
            }

            CreateDbFiles(ref op);
            if (!op.Success)
            {
                SetMessages(op.GetAllErrorsAndExceptions("\n"));
                return;
            }
            SetMessages("Success", true);

        }

        #endregion


        #region Methods

        public FrmMp3DbFileCreater()
        {
            InitializeComponent();
        }

        private bool MP3DBExists()
        {
            return File.Exists(ddtbMp3DbFile.ItemText);
        }

        private void CreateDbFiles(ref OperationResult op)
        {
            if (!MP3DBExists())
            {
                op.AddError("You must choose an Access 2000 to 2003 version database (mdb) file!");
                return;
            }

            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();
                mdbmgr.SetDataStore(ddtbMp3DbFile.ItemText, ref op);
                if (!op.Success)
                {
                    return;
                }

                string dirName = dddtbTargetDir.ItemText;

                string delimiter = rbtnTab.Checked ? "\t" : ",";
                List<string> tables = new List<string> { "tbFileInfo", "tbMp3Info", "tbArtist" };
                foreach (var table in tables)
                {
                    string sql = $"select  * from {table}";

                    List<string> data = GetTableData(sql, table, delimiter, ref op);
                    if (!op.Success)
                    {
                        return;
                    }

                    string fName = Path.Combine(dirName, $"{table}.txt");
                    BCHFileIO.WriteFullFile(fName, data, ref op);
                    if (!op.Success)
                    {
                        return;
                    } 
                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                rtbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return;
            }
        }

        private List<string> GetTableData(string sql, string tableName, string delimiter, ref OperationResult op)
        {
            List<string> data = new List<string>();
            try
            {
                MP3DBManager mdbmgr = new MP3DBManager();
                mdbmgr.SetDataStore(ddtbMp3DbFile.ItemText, ref op);

                Dictionary<string, string> parms = new Dictionary<string, string>();

                parms.Add("Sql", sql);

                DataTable dt = mdbmgr.RunSqlScript(ref parms, DAL.SqlScriptEnum.DynamicSQL, ref op);
                string colVal = "";

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataTable dtn = mdbmgr.GetDbTables(ref op);

                    DataTable dtColomns = mdbmgr.GetDbTableColumns(tableName, ref op);

                    StringBuilder rowData = new StringBuilder();
                    string rowString = "";
                    int colCount = dt.Columns.Count;

                    string val;
                    string cols = "";
                    int c = 0;


                    foreach (DataRow row in dtColomns.Rows)
                    {
                        val = row["ColumnName"] != null && row["ColumnName"].ToString().Trim().Length > 0 ? row["ColumnName"].ToString().Trim() : string.Empty;
                        cols += val + (c < colCount - 1 ? delimiter : "");
                        c++;
                    }

                    data.Add(cols);


                    foreach (DataRow row in dt.Rows)
                    {
                        rowData = new StringBuilder();
                        for (int i = 0; i < colCount; i++)
                        {
                            //if(tableName == )
                            colVal = row[i].ToString();
                            colVal = string.IsNullOrWhiteSpace(colVal) ? "<null>>" : colVal;
                            rowData.Append(colVal + ( i< colCount - 1 ? delimiter: ""));
                        }
                        
                        rowString = rowData.ToString();
                        data.Add(rowString);
                    }
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
            return data;
        }



        private void LoadDb(ref OperationResult op)
        {
            

            //if (dddtbGetMp3RootDir.ItemText.Trim().Length < 1)
            //{
            //    MessageBox.Show("You must enter an MP3 Root Dir!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //timer1.Interval = 1000;
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = lbMP3s.Items.Count;

            //StartTime = DateTime.Now;
            //timer1.Start();
            //backgroundWorker1.RunWorkerAsync();
        }

        private void SetMessages(string message, bool clearMessages = false)
        {
            if(clearMessages)
            {
                rtbMessages.Text = "";
            }

            rtbMessages.Text += message;
        }


        #endregion

    }
}
