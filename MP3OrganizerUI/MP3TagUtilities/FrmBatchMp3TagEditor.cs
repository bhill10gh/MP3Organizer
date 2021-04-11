using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using BCHFramework;
using BCHControls;
using MP3OrganizerBusinessLogic;

using ID3;

namespace MP3OrganizerUI
{
    public partial class FrmBatchMp3TagEditor : Form
    {
        public FrmBatchMp3TagEditor()
        {
            InitializeComponent();

            Op = new OperationResult();
            BadFiles = new List<string>();
            ErrorMesssages = new List<string>();
            CompletedMessage = new List<string>();

        }

        private int CurrentCount { get; set; }

        private OperationResult Op { get; set; }

        private List<string> BadFiles { get; set; }

        private List<string> ErrorMesssages { get; set; }

        private List<string> CompletedMessage { get; set; }

        private DateTime StartTime { get; set; }

        #region Events

        private void btnGetMP3RootDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            tbMP3RootDir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void addMP3FilesMenuItem_Click(object sender, EventArgs e)
        {
            ucDirFileSearch1.FileTypeEnabled = false;
            List<string> ftList = ucDirFileSearch1.FileTypeList;
            if (ftList.Count < 1 || ftList.Count > 1 ||
                !ftList.Contains("mp3", StringComparer.CurrentCultureIgnoreCase))
            {
                ftList.Clear();
                ftList.Add("mp3");
                ucDirFileSearch1.FileTypeList = ftList;
            }

            BCHWinFormUtilities.ListBoxToListBox(lbMP3Files, ucDirFileSearch1.FileListBox, true);

            pnlBatchMp3TagEdit.Visible = false;
            pnlDirFileSearch.Visible = true;
        }

        private void btnClosePanelAddMP3Files_Click(object sender, EventArgs e)
        {
            BCHWinFormUtilities.ListBoxToListBox(ucDirFileSearch1.FileListBox, lbMP3Files, true);
            tbMP3Count.Text = lbMP3Files.Items.Count.ToString();
            pnlBatchMp3TagEdit.Visible = true;
            pnlDirFileSearch.Visible = false;
        }

        private void btnCancelFileAdd_Click(object sender, EventArgs e)
        {
            pnlBatchMp3TagEdit.Visible = true;
            pnlDirFileSearch.Visible = false;
        }

        private void saveM3uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbMP3Files.Items.Count < 1)
            {
                MessageBox.Show("There must be at least one mp3 file!", "ERROR!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            this.Op = new OperationResult();

            this.CurrentCount = 0;
            lbBadMp3Filse.Items.Clear();
            lbErrorList.Items.Clear();

            timer1.Interval = 1000;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = lbMP3Files.Items.Count;

            StartTime = DateTime.Now;
            timer1.Start();
            backgroundWorker1.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = this.CurrentCount;
            tbProgress.Text = this.CurrentCount.ToString() + " of " + tbMP3Count.Text;
            this.Refresh();
        }

        #endregion


        #region Methods

        private void UpdateProgressBar(int indx)
        {
            this.CurrentCount = indx;
            progressBar1.Value = this.CurrentCount;
            tbProgress.Text = this.CurrentCount.ToString() + " of " + tbMP3Count.Text;
            this.Refresh();
        }

        public List<string> EditMP3Tags(List<string> mp3Files, string mp3MusicRootPath, bool useFileInfo, ref OperationResult op)
        {

            int cnt = 0;
            bool badfile = false;
            List<string> badMp3List = new List<string>();

            foreach (string mp3File in mp3Files)
            {
                badfile = false;
                cnt++;

                this.CurrentCount = cnt;
                OperationResult _op = new OperationResult();

                try
                {
                    MP3FileDataType mp3 = BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmtWithDirInfo(mp3File,
                        mp3MusicRootPath, ref _op);
                    if (!_op.Success)
                    {
                        badMp3List.Add(mp3File);
                        badfile = true;
                    }

                    if (_op.Success)
                    {
                        BCHMP3Utilities.SaveMp3IdInfo(mp3, ref _op);
                    }

                    if (!_op.Success && !badfile)
                    {
                        badfile = true;
                        badMp3List.Add(mp3File);
                    }
                }
                catch (Exception ex)
                {

                    _op.AddException(ex);
                    if (!badfile)
                    {
                        badfile = true;
                        badMp3List.Add(mp3File);
                    }
                }
                op.AddOperationResult(ref _op);
            }



            return badMp3List;
        }

        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            OperationResult _op = new OperationResult();

            List<string> mp3List = BCHWinFormUtilities.ListBoxToList(lbMP3Files);
            int mp3Cnt = mp3List.Count;



            BadFiles = EditMP3Tags(mp3List, tbMP3RootDir.Text, ckbUseFolderInfo.Checked, ref _op);

            this.Op.AddOperationResult(ref _op);

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer1.Stop();

            if (!Op.Success)
            {
                //MessageBox.Show("There were errors.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbBadMp3Filse.DataSource = BadFiles;
                List<string> Errors = new List<string>();
                Errors.AddRange(Op.GetAllExceptionsAndMessages());
                Errors.AddRange(Op.Errors);
                lbErrorList.DataSource = Errors;
                this.ErrorMesssages = Errors;
            }

            TimeSpan ts = DateTime.Now.Subtract(StartTime);

            string msg =
                "Batch edit complete!\n" +
                "Number of mp3 files:   " + tbMP3Count.Text + "\n" +
                "Number of bad mp3 files:  " + BadFiles.Count.ToString() + "\n" +
                "Total execution time (s):  " + ts.Seconds.ToString();
            this.CompletedMessage = new List<string>();
            this.CompletedMessage.Add("Batch edit complete!");
            this.CompletedMessage.Add("Number of mp3 files:   " + tbMP3Count.Text);
            this.CompletedMessage.Add("Number of bad mp3 files:  " + BadFiles.Count.ToString());
            this.CompletedMessage.Add("Total execution time (s):  " + ts.Seconds.ToString());
            MessageBoxIcon mbi = Op.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            string msgBxMsg = Op.Success ? msg : msg + "\n" + "There were errors!";
            string msgCap = Op.Success ? "INFORMATION" : "ERROR!";
            MessageBox.Show(msgBxMsg, msgCap, MessageBoxButtons.OK, mbi);
            progressBar1.Value = int.Parse(tbMP3Count.Text);
            OperationResult op = new OperationResult();
            SaveMessagesToFile(ref op);


        }

        private void SaveMessagesToFile(ref OperationResult op)
        {

            List<string> output = new List<string>();
            output.Add("Batch MP3 Edit Run " + DateTime.Now.ToShortDateString());
            output.AddRange(this.CompletedMessage);
            output.Add("Error and Exception Messages:");
            output.AddRange(this.ErrorMesssages);
            output.Add("Bad Files:");
            output.AddRange(this.BadFiles);
            DateTime now = DateTime.Now;
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);

            string appDriveDir = appPath; //.Substring(0,3);
            string infoFile = Path.Combine(appDriveDir, "BatchMp3TagEditorRun");

            BCHFileIO.SaveMessagesToFile(infoFile, output, ref op);

            if(!op.Success)
            {
                MessageBoxIcon mbi = MessageBoxIcon.Error;
                string msgBxMsg = "There were errors! saving log file.";
                string msgCap = "ERROR!";
                MessageBox.Show(msgBxMsg, msgCap, MessageBoxButtons.OK, mbi);
            }
        }

    }
}
