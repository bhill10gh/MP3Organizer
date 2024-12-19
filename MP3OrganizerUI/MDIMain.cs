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
using MP3OrganizerUI.MP3DbUtilities;
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

        private void MDIMain_Load(object sender, EventArgs e)
        {

        }

        private void mP3BatchTagEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBatchMp3TagEditor me = new FrmBatchMp3TagEditor();
            me.MdiParent = this;
            me.Show();
        }

        private void mP3TagEditorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMp3TagEditor me = new FrmMp3TagEditor();
            me.MdiParent = this;
            me.Show();
        }

        private void unformattedMp3FilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBatchMp3TagEditor me = new FrmBatchMp3TagEditor();
            me.MdiParent = this;
            me.Show();
        }

        private void iTunesLibFileReaderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmiTunesLibraryReader filr = new FrmiTunesLibraryReader();
            filr.MdiParent = this;
            filr.Show();
        }


        private void copyFolderStructureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCopyFolderStructure frm = new FrmCopyFolderStructure();
            frm.MdiParent = this;
            frm.Show();
        }

        private void copyFilesToSameFolderStructureToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCopyFilesToSameFolderStructure frm = new FrmCopyFilesToSameFolderStructure();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loadMP3DBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLoadMP3DB lmdb = new FrmLoadMP3DB();
            lmdb.MdiParent = this;
            lmdb.Show();
        }

        private void mP3DatabaseSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMP3DatabaseApp2_0 fu = new FrmMP3DatabaseApp2_0();
            fu.MdiParent = this;
            fu.Show();
        }

        private void sQLDBRunnerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDbSqlRunner dsr = new FrmDbSqlRunner();
            dsr.MdiParent = this;
            dsr.Show();
        }

        private void sqlDbRunnerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmDbSqliteRunner frm = new FrmDbSqliteRunner();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createSqliteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreateSqliteDb frm = new FrmCreateSqliteDb();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mp3DatabaseSearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMP3SqliteDatabaseApp frm = new FrmMP3SqliteDatabaseApp();
            frm.MdiParent = this;
            frm.Show();
        }

        private void yepYepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYepYepUrlManager frm = new FrmYepYepUrlManager();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
