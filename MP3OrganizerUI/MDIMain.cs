using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CopyFolderStructure;
using MP3OrganizerUI.iTunes;
using MP3OrganizerUI.Mp3FileUtilities;

namespace MP3OrganizerUI
{
    

    public partial class MDIMain : Form
    {
        private int childFormNumber = 0;

        public MDIMain()
        {
            InitializeComponent();

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void testFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            
        }

        private void m3UEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmM3UEditor me = new FrmM3UEditor();
            me.MdiParent = this;
            me.Show();
        }

        private void mP3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMp3TagEditor me = new FrmMp3TagEditor();
            me.MdiParent = this;
            me.Show();
        }

        private void mP3TagEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBatchMp3TagEditor me = new FrmBatchMp3TagEditor();
            me.MdiParent = this;
            me.Show();
        }

        private void unformattedMp3FilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCHUnformatedMp3Files uf = new FrmBCHUnformatedMp3Files();
            uf.MdiParent = this;
            uf.Show();
        }

        private void mP3DatabaseAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIMP3DBApp mmda = new MDIMP3DBApp();
            mmda.Show();
        }

        private void loadMP3DBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoadMP3DB lmdb = new FrmLoadMP3DB();
            lmdb.MdiParent = this;
            lmdb.Show();
        }

        private void mP3DatabaseSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMP3DatabaseApp mdbs = new FrmMP3DatabaseApp();
            mdbs.MdiParent = this;
            mdbs.Show();
        }

        private void copyFolderStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCopyFolderStructure frm = new FrmCopyFolderStructure();
            frm.MdiParent = this;
            frm.Show();
        }

        private void copyFilesToSameFolderStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCopyFilesToSameFolderStructure frm = new FrmCopyFilesToSameFolderStructure();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sQLRunnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDbSqlRunner dsr = new FrmDbSqlRunner();
            dsr.MdiParent = this;
            dsr.Show();
        }

        private void iTunesLibFileReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmiTunesLibraryReader filr = new FrmiTunesLibraryReader();
            filr.MdiParent = this;
            filr.Show();
        }

        private void copyIPhoneBackupFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCopyiPhoneBackupFIles fc = new FrmCopyiPhoneBackupFIles();
            fc.MdiParent = this;
            fc.Show();
        }

        private void fileUtilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFileUtils fu = new FrmFileUtils();
            fu.MdiParent = this;
            fu.Show();
        }
    }
}
