using BCHFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3OrganizerUI.Mp3FileUtilities
{
    public partial class FrmFileUtils : Form
    {
        public FrmFileUtils()
        {
            InitializeComponent();
        }

        private void btnClosePanelAddMP3Files_Click(object sender, EventArgs e)
        {
            BCHWinFormUtilities.ListBoxToListBox(ucDirFileSearch1.FileListBox, lbFiles, true);
            lblFileCount.Text = "Count: " + lbFiles.Items.Count.ToString();
            pnlMain.Visible = true;
            pnlDirFileSearch.Visible = false;
        }

        private void btnCancelFileAdd_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = true;
            pnlDirFileSearch.Visible = false;
        }

        private void btnGetFiles_Click(object sender, EventArgs e)
        {
            ucDirFileSearch1.FileTypeEnabled = true;
            List<string> ftList = ucDirFileSearch1.FileTypeList;
            //if (ftList.Count < 1 || ftList.Count > 1 ||
            //    !ftList.Contains("mp3", StringComparer.CurrentCultureIgnoreCase))
            //{
            //    ftList.Clear();
            //    ftList.Add("mp3");
            //    ucDirFileSearch1.FileTypeList = ftList;
            //}

            BCHWinFormUtilities.ListBoxToListBox(lbFiles, ucDirFileSearch1.FileListBox, true);

            pnlMain.Visible = false;
            pnlDirFileSearch.Visible = true;
        }
    }
}
