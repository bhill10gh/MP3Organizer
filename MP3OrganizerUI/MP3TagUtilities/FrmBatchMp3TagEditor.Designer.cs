namespace MP3OrganizerUI
{
    partial class FrmBatchMp3TagEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatchMp3TagEditor));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBatchMp3TagEdit = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbErrorList = new System.Windows.Forms.ListBox();
            this.tbProgress = new System.Windows.Forms.TextBox();
            this.lbBadMp3Filse = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbMP3Count = new System.Windows.Forms.TextBox();
            this.ckbUseFolderInfo = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbMP3Files = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMP3RootDir = new System.Windows.Forms.TextBox();
            this.btnGetMP3RootDir = new System.Windows.Forms.Button();
            this.pnlDirFileSearch = new System.Windows.Forms.Panel();
            this.btnCancelFileAdd = new System.Windows.Forms.Button();
            this.btnClosePanelAddMP3Files = new System.Windows.Forms.Button();
            this.ucDirFileSearch1 = new BCHControls.UCDirFileSearch();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMP3FilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveM3uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlBatchMp3TagEdit.SuspendLayout();
            this.pnlDirFileSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlBatchMp3TagEdit);
            this.flowLayoutPanel1.Controls.Add(this.pnlDirFileSearch);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(851, 940);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlBatchMp3TagEdit
            // 
            this.pnlBatchMp3TagEdit.Controls.Add(this.label3);
            this.pnlBatchMp3TagEdit.Controls.Add(this.label2);
            this.pnlBatchMp3TagEdit.Controls.Add(this.lbErrorList);
            this.pnlBatchMp3TagEdit.Controls.Add(this.tbProgress);
            this.pnlBatchMp3TagEdit.Controls.Add(this.lbBadMp3Filse);
            this.pnlBatchMp3TagEdit.Controls.Add(this.label1);
            this.pnlBatchMp3TagEdit.Controls.Add(this.progressBar1);
            this.pnlBatchMp3TagEdit.Controls.Add(this.tbMP3Count);
            this.pnlBatchMp3TagEdit.Controls.Add(this.ckbUseFolderInfo);
            this.pnlBatchMp3TagEdit.Controls.Add(this.textBox1);
            this.pnlBatchMp3TagEdit.Controls.Add(this.lbMP3Files);
            this.pnlBatchMp3TagEdit.Controls.Add(this.label5);
            this.pnlBatchMp3TagEdit.Controls.Add(this.tbMP3RootDir);
            this.pnlBatchMp3TagEdit.Controls.Add(this.btnGetMP3RootDir);
            this.pnlBatchMp3TagEdit.Location = new System.Drawing.Point(3, 3);
            this.pnlBatchMp3TagEdit.Name = "pnlBatchMp3TagEdit";
            this.pnlBatchMp3TagEdit.Size = new System.Drawing.Size(830, 521);
            this.pnlBatchMp3TagEdit.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Error List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bad File List";
            // 
            // lbErrorList
            // 
            this.lbErrorList.FormattingEnabled = true;
            this.lbErrorList.HorizontalScrollbar = true;
            this.lbErrorList.Location = new System.Drawing.Point(13, 423);
            this.lbErrorList.Name = "lbErrorList";
            this.lbErrorList.Size = new System.Drawing.Size(392, 95);
            this.lbErrorList.TabIndex = 28;
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(473, 374);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.ReadOnly = true;
            this.tbProgress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbProgress.Size = new System.Drawing.Size(206, 20);
            this.tbProgress.TabIndex = 27;
            // 
            // lbBadMp3Filse
            // 
            this.lbBadMp3Filse.FormattingEnabled = true;
            this.lbBadMp3Filse.HorizontalScrollbar = true;
            this.lbBadMp3Filse.Location = new System.Drawing.Point(438, 423);
            this.lbBadMp3Filse.Name = "lbBadMp3Filse";
            this.lbBadMp3Filse.Size = new System.Drawing.Size(385, 95);
            this.lbBadMp3Filse.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Status:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(64, 371);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 23);
            this.progressBar1.TabIndex = 21;
            // 
            // tbMP3Count
            // 
            this.tbMP3Count.Location = new System.Drawing.Point(704, 339);
            this.tbMP3Count.Name = "tbMP3Count";
            this.tbMP3Count.ReadOnly = true;
            this.tbMP3Count.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbMP3Count.Size = new System.Drawing.Size(110, 20);
            this.tbMP3Count.TabIndex = 20;
            // 
            // ckbUseFolderInfo
            // 
            this.ckbUseFolderInfo.AutoSize = true;
            this.ckbUseFolderInfo.Checked = true;
            this.ckbUseFolderInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseFolderInfo.Location = new System.Drawing.Point(18, 335);
            this.ckbUseFolderInfo.Name = "ckbUseFolderInfo";
            this.ckbUseFolderInfo.Size = new System.Drawing.Size(188, 17);
            this.ckbUseFolderInfo.TabIndex = 18;
            this.ckbUseFolderInfo.Text = "Use File Info For Genre and Album";
            this.ckbUseFolderInfo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(658, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "File Format: Artist 1-Artist 2-..Artist n[-Track #]--Song Title[~Numeration][_Com" +
    "ments].mp3";
            // 
            // lbMP3Files
            // 
            this.lbMP3Files.FormattingEnabled = true;
            this.lbMP3Files.HorizontalScrollbar = true;
            this.lbMP3Files.Location = new System.Drawing.Point(18, 92);
            this.lbMP3Files.Name = "lbMP3Files";
            this.lbMP3Files.Size = new System.Drawing.Size(796, 238);
            this.lbMP3Files.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "MP3 Count: ";
            // 
            // tbMP3RootDir
            // 
            this.tbMP3RootDir.Location = new System.Drawing.Point(156, 27);
            this.tbMP3RootDir.Multiline = true;
            this.tbMP3RootDir.Name = "tbMP3RootDir";
            this.tbMP3RootDir.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbMP3RootDir.Size = new System.Drawing.Size(658, 33);
            this.tbMP3RootDir.TabIndex = 13;
            this.tbMP3RootDir.Text = "F:\\Barry Hill\\My Music\\Music";
            this.tbMP3RootDir.Click += new System.EventHandler(this.btnGetMP3RootDir_Click);
            // 
            // btnGetMP3RootDir
            // 
            this.btnGetMP3RootDir.Location = new System.Drawing.Point(18, 25);
            this.btnGetMP3RootDir.Name = "btnGetMP3RootDir";
            this.btnGetMP3RootDir.Size = new System.Drawing.Size(112, 23);
            this.btnGetMP3RootDir.TabIndex = 12;
            this.btnGetMP3RootDir.Text = "Get MP3 Root Dir";
            this.btnGetMP3RootDir.UseVisualStyleBackColor = true;
            this.btnGetMP3RootDir.Click += new System.EventHandler(this.btnGetMP3RootDir_Click);
            // 
            // pnlDirFileSearch
            // 
            this.pnlDirFileSearch.Controls.Add(this.btnCancelFileAdd);
            this.pnlDirFileSearch.Controls.Add(this.btnClosePanelAddMP3Files);
            this.pnlDirFileSearch.Controls.Add(this.ucDirFileSearch1);
            this.pnlDirFileSearch.Location = new System.Drawing.Point(3, 530);
            this.pnlDirFileSearch.Name = "pnlDirFileSearch";
            this.pnlDirFileSearch.Size = new System.Drawing.Size(830, 700);
            this.pnlDirFileSearch.TabIndex = 1;
            this.pnlDirFileSearch.Visible = false;
            // 
            // btnCancelFileAdd
            // 
            this.btnCancelFileAdd.Location = new System.Drawing.Point(156, 5);
            this.btnCancelFileAdd.Name = "btnCancelFileAdd";
            this.btnCancelFileAdd.Size = new System.Drawing.Size(126, 23);
            this.btnCancelFileAdd.TabIndex = 2;
            this.btnCancelFileAdd.Text = "Cancel";
            this.btnCancelFileAdd.UseVisualStyleBackColor = true;
            this.btnCancelFileAdd.Click += new System.EventHandler(this.btnCancelFileAdd_Click);
            // 
            // btnClosePanelAddMP3Files
            // 
            this.btnClosePanelAddMP3Files.Location = new System.Drawing.Point(5, 5);
            this.btnClosePanelAddMP3Files.Name = "btnClosePanelAddMP3Files";
            this.btnClosePanelAddMP3Files.Size = new System.Drawing.Size(126, 23);
            this.btnClosePanelAddMP3Files.TabIndex = 1;
            this.btnClosePanelAddMP3Files.Text = "Add MP3 Files";
            this.btnClosePanelAddMP3Files.UseVisualStyleBackColor = true;
            this.btnClosePanelAddMP3Files.Click += new System.EventHandler(this.btnClosePanelAddMP3Files_Click);
            // 
            // ucDirFileSearch1
            // 
            this.ucDirFileSearch1.AutoScroll = true;
            this.ucDirFileSearch1.FileList = ((System.Collections.Generic.List<string>)(resources.GetObject("ucDirFileSearch1.FileList")));
            this.ucDirFileSearch1.FileTypeEnabled = true;
            this.ucDirFileSearch1.FileTypeList = ((System.Collections.Generic.List<string>)(resources.GetObject("ucDirFileSearch1.FileTypeList")));
            this.ucDirFileSearch1.Location = new System.Drawing.Point(3, 44);
            this.ucDirFileSearch1.Name = "ucDirFileSearch1";
            this.ucDirFileSearch1.SearchString = "";
            this.ucDirFileSearch1.Size = new System.Drawing.Size(697, 518);
            this.ucDirFileSearch1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(18, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 22);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMP3FilesMenuItem,
            this.saveM3uToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.fileToolStripMenuItem.Text = "&MP3 Tag Editor";
            // 
            // addMP3FilesMenuItem
            // 
            this.addMP3FilesMenuItem.Name = "addMP3FilesMenuItem";
            this.addMP3FilesMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addMP3FilesMenuItem.Text = "&Add MP3 Files";
            this.addMP3FilesMenuItem.Click += new System.EventHandler(this.addMP3FilesMenuItem_Click);
            // 
            // saveM3uToolStripMenuItem
            // 
            this.saveM3uToolStripMenuItem.Name = "saveM3uToolStripMenuItem";
            this.saveM3uToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveM3uToolStripMenuItem.Text = "&Edit MP3 Tags";
            this.saveM3uToolStripMenuItem.Click += new System.EventHandler(this.saveM3uToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmBatchMp3TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 874);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmBatchMp3TagEditor";
            this.Text = "FrmBatchMp3TagEditor";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlBatchMp3TagEdit.ResumeLayout(false);
            this.pnlBatchMp3TagEdit.PerformLayout();
            this.pnlDirFileSearch.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlBatchMp3TagEdit;
        private System.Windows.Forms.Panel pnlDirFileSearch;
        private BCHControls.UCDirFileSearch ucDirFileSearch1;
        private System.Windows.Forms.TextBox tbMP3RootDir;
        private System.Windows.Forms.Button btnGetMP3RootDir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbMP3Files;
        private System.Windows.Forms.CheckBox ckbUseFolderInfo;
        private System.Windows.Forms.TextBox tbMP3Count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMP3FilesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveM3uToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnClosePanelAddMP3Files;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCancelFileAdd;
        private System.Windows.Forms.ListBox lbBadMp3Filse;
        private System.Windows.Forms.TextBox tbProgress;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lbErrorList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}