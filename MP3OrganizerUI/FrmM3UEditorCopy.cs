using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using BCHFramwork;
using MP3OrganizerBusinessLogic;

namespace MP3OrganizerUI
{
    public partial class FrmM3UEditorCopy : Form
    {
        #region Members



        #endregion

        #region Ctor

        public FrmM3UEditorCopy()
        {
            InitializeComponent();

            uatlbFileExt.Title = "File Extention Filter";
            uftM3U.SetListBoxTitle("Media Filses", BCHControls.UCFromToEnum.From);
            uftM3U.SetListBoxTitle("M3U List", BCHControls.UCFromToEnum.To);
            uftM3U.FromAllowDrop = false;

            ttAddDirFiles.SetToolTip(btnAddDirFiles, "Execute and add search files.");
            ttDeleteDirFileList.SetToolTip(btnDeleteDirFileList, "Delete files from file list.");
            ttDeleteAllDirFileList.SetToolTip(btnDeleteAllDirFileList, "Delete all files.");
            pnlAddFiles.Height = 620;
            btnCloseFloPnl.Focus();

            List<string> extList = new List<string>();
            extList.Add("mp3");
            extList.Add("wav");
            extList.Add("flv");
            extList.Add("avi");

            uftM3U.FileTypes = extList;
        }

        #endregion

        #region Events

        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddFiles.Visible = true;
            pnlM3UPlayList.Visible = false;
            if (uatlbFileExt.StringList.Count < 1)
                SetGetFilesListBoxes();
            btnCloseFloPnl.Focus();
        }

        private void btnCloseFloPnl_Click(object sender, EventArgs e)
        {
            pnlAddFiles.Visible = false;
            pnlM3UPlayList.Visible = true;

            AddMediaFiles();
        }

        private void btnDeleteDirFileList_Click(object sender, EventArgs e)
        {

            for (int i = lbFileList.Items.Count - 1; i >= 0; i--)
            {
                if (lbFileList.SelectedIndices.Contains(i))
                {
                    lbFileList.Items.RemoveAt(i);
                }
            }
        }

        private void btnDeleteAllDirFileList_Click(object sender, EventArgs e)
        {
            lbFileList.Items.Clear();
        }

        private void btnAddDirFiles_Click(object sender, EventArgs e)
        {
            AddDirFilesToFileListBox();
        }

        private void btnGetM3UPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath.Length < 0)
            {
                MessageBox.Show("Error!", "You must choose a folder!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbM3UDir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void saveM3uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlM3UPlayList.Visible)
            {
                return;
            }

            string msg = string.Empty;

            if (tbM3UDir.Text.Length < 0)
            {
                msg = "You must have a valid M3U path selected! \n";
            }

            if (tbM3UFileName.Text.Length < 0 || tbM3UFileName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                msg += "You must have a valid file name! \n File name cannot cantain any of these characters:" +
                        Path.GetInvalidFileNameChars().ToString();
            }

            if (msg.Length < 0)
            {
                MessageBox.Show("Error!", msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationResult op = new OperationResult();
            M3UEditor me = new M3UEditor();

            string fileName = Path.Combine(tbM3UDir.Text, tbM3UFileName.Text);

            me.SetM3U(fileName, uftM3U.GetStrList(BCHControls.UCFromToEnum.To), true, ref op);

            if (!op.Success)
            {
                MessageBox.Show("Error!", op.GetAllMessages("\n"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            me.CreateM3U(ref op);

            if (!op.Success)
            {
                MessageBox.Show("Error!", op.GetAllMessages("\n"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Complete!", "M3U File Created.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openM3UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName.Trim().Length < 1 || !File.Exists(openFileDialog1.FileName))
            {
                MessageBox.Show("Error!", "You must choose a file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationResult op = new OperationResult();

            M3UEditor me = new M3UEditor();

            me.SetM3U(openFileDialog1.FileName, new List<string>(), false, ref op);

            if (!op.Success)
            {
                MessageBox.Show("Error!", op.GetAllMessages("\n"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            uftM3U.SetListBox(me.M3USongList, BCHControls.UCFromToEnum.To);
        }

        private void btnGetDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            if (folderBrowserDialog1.SelectedPath.Length < 0)
            {
                MessageBox.Show("Error!", "You must choose a folder!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbMusicDirs.DataSource = DirPathUtilities.GetDirPathsInPath(folderBrowserDialog1.SelectedPath);
        }

        #endregion

        #region Methods

        private void SetGetFilesListBoxes()
        {
            List<string> extList = new List<string>();
            extList.Add("mp3");
            extList.Add("wav");
            extList.Add("flv");
            extList.Add("avi");
            uatlbFileExt.SetListboxList(extList);

            List<string> mList = uftM3U.GetStrList(BCHControls.UCFromToEnum.From);
            AddToListbox(uftM3U.GetStrList(BCHControls.UCFromToEnum.From), lbFileList, false);
        }

        private void AddDirFilesToFileListBox()
        {
            OperationResult op = new OperationResult();
            List<string> mediaDirs = ucDirectoryChooser1.DirList;


            if (mediaDirs.Count < 1)
                return;

            List<string> files = new List<string>();

            FileSearch fs = new FileSearch();

            fs.FileFilters = uatlbFileExt.StringList;

            fs.SearchString = tbSearchString.Text.Trim();

            foreach (string dir in mediaDirs)
            {
                fs.StartDir = dir;
                fs.StartSearch(ref op);
                if (!op.Success)
                    throw new Exception("There was an exception!");
                files.AddRange(fs.Files);
            }

            files.AddRange(GetListFromListbox(lbFileList));

            files =
                (
                    from f in files
                    select f
                ).Distinct().ToList<string>();
            lbFileList.DataSource = files;
        }

        private void AddMediaFiles()
        {

            uftM3U.SetListBox(GetListFromListbox(lbFileList), BCHControls.UCFromToEnum.From);
        }


        private List<string> GetListFromListbox(ListBox lb)
        {
            List<string> list = new List<string>();

            foreach (var item in lb.Items)
            {
                list.Add(item.ToString());
            }

            return list;
        }

        private void AddToListbox(List<string> list, ListBox toLb, bool isCaseSensitive)
        {
            List<string> toList = GetListFromListbox(toLb);
            foreach (string item in list)
            {
                if ((isCaseSensitive && !toList.Contains(item, StringComparer.CurrentCulture)) ||
                        (!isCaseSensitive && !toList.Contains(item, StringComparer.CurrentCultureIgnoreCase)))
                    toLb.Items.Add(item);
            }
        }

        #endregion











    }
}
