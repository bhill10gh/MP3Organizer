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
using BCHControls;

namespace MP3OrganizerUI
{
    

    public partial class FrmBCHUnformatedMp3Files : Form
    {
        public List<UMFileInfoType> BadMp3List { get; set; }

        public FrmBCHUnformatedMp3Files()
        {
            InitializeComponent();

            BadMp3List = new List<UMFileInfoType>();

            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            if (appSettings == null)
            {
                return;
            }

            foreach (string appKey in appSettings.AllKeys)
            {
                foreach (string val in appSettings.GetValues(appKey))
                {
                    string appValue = appSettings[appKey];
                    string file = appValue;
                    if (!string.IsNullOrEmpty(file) && appKey.StartsWith("MP3RootDir") && Directory.Exists(file))
                    {
                        tbMP3RootDir.Text = file;
                        break;
                    }
                }

            }
        }

        private void btnGetAllUnFormatedMp3_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if(e.ColumnIndex != 4)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btnGetMP3RootDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            tbMP3RootDir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnUpdateFiles_Click(object sender, EventArgs e)
        {
            RenameFiles();
        }

        private void btnInsertDash_Click(object sender, EventArgs e)
        {
            AddDashTolastdash();
        }

        private void LoadGrid()
        {
            string mp3RtDir = tbMP3RootDir.Text;
            if (!Directory.Exists(mp3RtDir))
            {
                MessageBox.Show("The root directoy does not exist!", "ERROR!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            OperationResult op = new OperationResult();
            FileSearch fs = new FileSearch();

            fs.FileFilters = new List<string>((new string[] { "mp3" }).ToList());
            fs.StartDir = mp3RtDir;

            fs.StartSearch(ref op);

            List<string> badMp3List = new List<string>();

            if (ckbWithNoDblDash.Checked)
            {
                badMp3List = (
                                           from f in fs.Files
                                           where !f.Contains("--")
                                           select f
                                       ).ToList();
            }

            if (ckbWithNoDash.Checked)
            {
                badMp3List.AddRange ((
                                           from f in fs.Files
                                           where !f.Contains("--")
                                           && !f.Contains("-")
                                           select f
                                       ).ToList());
            }

            BadMp3List = new List<UMFileInfoType>();

            foreach (string mp3 in badMp3List)
            {
                UMFileInfoType f = new UMFileInfoType();
                f.FileNameOriginal = Path.GetFileName(mp3);
                f.FileNameNew = Path.GetFileName(mp3);
                f.FileNamePath = Path.GetFullPath(mp3);
                f.FilePath = Path.GetDirectoryName(mp3);
                BadMp3List.Add(f);
            }

            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn fileNameOrigCol = new DataGridViewTextBoxColumn();
            fileNameOrigCol.DataPropertyName = "FileNameOriginal";
            fileNameOrigCol.HeaderText = "Original File Name";
            fileNameOrigCol.ReadOnly = true;

            DataGridViewTextBoxColumn fileNameNewCol = new DataGridViewTextBoxColumn();
            fileNameNewCol.DataPropertyName = "FileNameNew";
            fileNameNewCol.HeaderText = "New File Name";
            fileNameNewCol.ReadOnly = false;

            DataGridViewTextBoxColumn fileNamePathCol = new DataGridViewTextBoxColumn();
            fileNamePathCol.DataPropertyName = "FileNamePath";
            fileNamePathCol.HeaderText = "Full File Name";
            fileNamePathCol.ReadOnly = true;

            DataGridViewTextBoxColumn filePathCol = new DataGridViewTextBoxColumn();
            filePathCol.DataPropertyName = "FilePath";
            filePathCol.HeaderText = "Path";
            filePathCol.ReadOnly = true;

            dataGridView1.Columns.Add(fileNameOrigCol);
            dataGridView1.Columns.Add(fileNameNewCol);
            dataGridView1.Columns.Add(fileNamePathCol);
            dataGridView1.Columns.Add(filePathCol);

            dataGridView1.DataSource = BadMp3List;

            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;


            tbBadFileCount.Text = BadMp3List.Count.ToString();
        }

        private void RenameFiles()
        {
            OperationResult op = new OperationResult();
            int row = 0;
            int cnt = 0;
            List<string> output = new List<string>();

            try
            {
                string newName = string.Empty;
                string m3RtDir = tbMP3RootDir.Text;
                
                foreach (DataGridViewRow dgvr in dataGridView1.Rows)
                {
                    //MessageBox.Show(dgvr.Cells[0].Value.ToString() + "," + dataGridView1.Columns[0].Name + "\n"
                    //    + dgvr.Cells[1].Value.ToString() + "\n" + "," + dataGridView1.Columns[1].Name + "\n"
                    //    + dgvr.Cells[2].Value.ToString() + "\n" + "," + dataGridView1.Columns[2].Name + "\n"
                    //    + dgvr.Cells[3].Value.ToString() + "\n" + "," + dataGridView1.Columns[3].Name );
                    if (dgvr.Cells[2] != null && dgvr.Cells[2].Value.ToString().Trim().Length > 0 &&
                        !dgvr.Cells[1].Value.ToString().Trim().Equals(dgvr.Cells[2].Value.ToString().Trim()))
                    {
                        newName = Path.Combine(dgvr.Cells[3].Value.ToString().Trim(), dgvr.Cells[2].Value.ToString().Trim());
                        File.Move(BadMp3List[row].FileNamePath, newName);
                        if (ckbUpdateTagInfo.Checked)
                        {
                            UpdateTagInfo(newName, m3RtDir, ckbUseDirInfo.Checked, ref op);
                        }
                        if (!op.Success)
                        {
                            break;
                        }
                        output.Add(dgvr.Cells[0].Value.ToString() + "; " +newName);
                        cnt++;
                    }
                    row++;
                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                
            }

            LoadGrid();
            string msg = "File name changes complete. \nSuccessfull changes: " + cnt.ToString();
            MessageBoxIcon mbi = op.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            string msgBxMsg = op.Success ? msg : msg + "\n" + "There were errors!\n" + op.GetAllErrorsAndExceptions("\n");
            string msgCap = op.Success ? "INFORMATION" : "ERROR!";
            MessageBox.Show(msgBxMsg, msgCap, MessageBoxButtons.OK, mbi);

            output.Insert(0, msg);
        }


        private void AddDashTolastdash()
        {
            OperationResult op = new OperationResult();
            int cnt = 0;
            try
            {
                foreach (DataGridViewRow dgvr in dataGridView1.Rows)
                {
                    if (dgvr.Cells[2] != null && dgvr.Cells[2].Value.ToString().Trim().Length > 0)
                    {
                        string fName = dgvr.Cells[2].Value.ToString().Trim();
                        int idx = fName.LastIndexOf("-");
                        if (idx < 0)
                        {
                            continue;
                        }
                        string frstPrt = fName.Substring(0, idx).Trim();
                        string scndPrt = fName.Substring(idx + 1).Trim();
                        dgvr.Cells[2].Value =  frstPrt + "--" + scndPrt;

                        cnt++;
                    }

                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);

            }

            string msg = "File name changes complete. \nSuccessfull changes: " + cnt.ToString();
            MessageBoxIcon mbi = op.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            string msgBxMsg = op.Success ? msg : msg + "\n" + "There were errors!\n" + op.GetAllErrorsAndExceptions("\n");
            string msgCap = op.Success ? "INFORMATION" : "ERROR!";
            MessageBox.Show(msgBxMsg, msgCap, MessageBoxButtons.OK, mbi);
        }


        private void UpdateTagInfo(string mp3File, string mp3MusicRootPath, bool useDirInfo, ref OperationResult op)
        {
            OperationResult _op = new OperationResult();

                try
                {
                    bool badfile = false;
                    MP3FileDataType mp3 = BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmtWithDirInfo(mp3File,
                        mp3MusicRootPath, ref _op);
                    if (!_op.Success)
                    {
                        badfile = true;
                    }

                    if (_op.Success)
                    {
                        BCHMP3Utilities.SaveMp3IdInfo(mp3, ref _op);
                    }

                    if (!_op.Success && !badfile)
                    {
                        badfile = true;
                    }
                }
                catch (Exception ex)
                {

                    _op.AddException(ex);
                }
                op.AddOperationResult(ref _op);
            }
            }

    public class UMFileInfoType
    {
        public string FileNamePath { get; set; }

        public string FileNameOriginal { get; set; }

        public string FileNameNew { get; set; }

        public string FilePath { get; set; }
    }
}
