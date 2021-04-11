namespace MP3OrganizerUI
{
    partial class FrmM3UEditorCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmM3UEditor));
            this.ttAddDirFiles = new System.Windows.Forms.ToolTip(this.components);
            this.ttDeleteDirFileList = new System.Windows.Forms.ToolTip(this.components);
            this.ttDeleteAllDirFileList = new System.Windows.Forms.ToolTip(this.components);
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openM3UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveM3uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAddFiles = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddDirFiles = new System.Windows.Forms.Button();
            this.btnDeleteAllDirFileList = new System.Windows.Forms.Button();
            this.btnDeleteDirFileList = new System.Windows.Forms.Button();
            this.lbFileList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchString = new System.Windows.Forms.TextBox();
            this.pnlFLO = new System.Windows.Forms.Panel();
            this.btnCloseFloPnl = new System.Windows.Forms.Button();
            this.ucDirectoryChooser1 = new BCHControls.UCDirectoryChooser();
            this.uatlbFileExt = new BCHControls.UCAddToListBox();
            this.pnlM3UPlayList = new System.Windows.Forms.Panel();
            this.uftM3U = new BCHControls.UCFromToDragDropFiles();
            this.tbM3UFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbM3UDir = new System.Windows.Forms.TextBox();
            this.btnGetM3UPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlChangePath = new System.Windows.Forms.Panel();
            this.btnGetDir = new System.Windows.Forms.Button();
            this.lbMusicDirs = new System.Windows.Forms.ListBox();
            this.btnGetMusicRootFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.flpMain.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlAddFiles.SuspendLayout();
            this.pnlFLO.SuspendLayout();
            this.pnlM3UPlayList.SuspendLayout();
            this.pnlChangePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.Controls.Add(this.pnlMenu);
            this.flpMain.Controls.Add(this.pnlAddFiles);
            this.flpMain.Controls.Add(this.pnlM3UPlayList);
            this.flpMain.Controls.Add(this.pnlChangePath);
            this.flpMain.Location = new System.Drawing.Point(12, 12);
            this.flpMain.Name = "flpMain";
            this.flpMain.Padding = new System.Windows.Forms.Padding(2);
            this.flpMain.Size = new System.Drawing.Size(733, 511);
            this.flpMain.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.Controls.Add(this.menuStrip1);
            this.pnlMenu.Location = new System.Drawing.Point(5, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(683, 26);
            this.pnlMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 26);
            this.menuStrip1.TabIndex = 0;
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
            this.openM3UToolStripMenuItem,
            this.addFilesToolStripMenuItem,
            this.saveM3uToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.fileToolStripMenuItem.Text = "&M3U File";
            // 
            // openM3UToolStripMenuItem
            // 
            this.openM3UToolStripMenuItem.Name = "openM3UToolStripMenuItem";
            this.openM3UToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.openM3UToolStripMenuItem.Text = "&Open M3U";
            this.openM3UToolStripMenuItem.Click += new System.EventHandler(this.openM3UToolStripMenuItem_Click);
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addFilesToolStripMenuItem.Text = "&Add Files";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // saveM3uToolStripMenuItem
            // 
            this.saveM3uToolStripMenuItem.Name = "saveM3uToolStripMenuItem";
            this.saveM3uToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveM3uToolStripMenuItem.Text = "&Save M3u";
            this.saveM3uToolStripMenuItem.Click += new System.EventHandler(this.saveM3uToolStripMenuItem_Click);
            // 
            // pnlAddFiles
            // 
            this.pnlAddFiles.Controls.Add(this.label3);
            this.pnlAddFiles.Controls.Add(this.btnAddDirFiles);
            this.pnlAddFiles.Controls.Add(this.btnDeleteAllDirFileList);
            this.pnlAddFiles.Controls.Add(this.btnDeleteDirFileList);
            this.pnlAddFiles.Controls.Add(this.lbFileList);
            this.pnlAddFiles.Controls.Add(this.label1);
            this.pnlAddFiles.Controls.Add(this.tbSearchString);
            this.pnlAddFiles.Controls.Add(this.pnlFLO);
            this.pnlAddFiles.Controls.Add(this.uatlbFileExt);
            this.pnlAddFiles.Location = new System.Drawing.Point(5, 37);
            this.pnlAddFiles.Name = "pnlAddFiles";
            this.pnlAddFiles.Size = new System.Drawing.Size(686, 394);
            this.pnlAddFiles.TabIndex = 3;
            this.pnlAddFiles.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "File List";
            // 
            // btnAddDirFiles
            // 
            this.btnAddDirFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDirFiles.Image")));
            this.btnAddDirFiles.Location = new System.Drawing.Point(227, 348);
            this.btnAddDirFiles.Name = "btnAddDirFiles";
            this.btnAddDirFiles.Size = new System.Drawing.Size(36, 23);
            this.btnAddDirFiles.TabIndex = 10;
            this.btnAddDirFiles.UseVisualStyleBackColor = true;
            this.btnAddDirFiles.Click += new System.EventHandler(this.btnAddDirFiles_Click);
            // 
            // btnDeleteAllDirFileList
            // 
            this.btnDeleteAllDirFileList.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllDirFileList.Image")));
            this.btnDeleteAllDirFileList.Location = new System.Drawing.Point(334, 348);
            this.btnDeleteAllDirFileList.Name = "btnDeleteAllDirFileList";
            this.btnDeleteAllDirFileList.Size = new System.Drawing.Size(36, 23);
            this.btnDeleteAllDirFileList.TabIndex = 9;
            this.btnDeleteAllDirFileList.UseVisualStyleBackColor = true;
            this.btnDeleteAllDirFileList.CursorChanged += new System.EventHandler(this.btnDeleteAllDirFileList_Click);
            // 
            // btnDeleteDirFileList
            // 
            this.btnDeleteDirFileList.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDirFileList.Image")));
            this.btnDeleteDirFileList.Location = new System.Drawing.Point(278, 348);
            this.btnDeleteDirFileList.Name = "btnDeleteDirFileList";
            this.btnDeleteDirFileList.Size = new System.Drawing.Size(36, 23);
            this.btnDeleteDirFileList.TabIndex = 8;
            this.btnDeleteDirFileList.UseVisualStyleBackColor = true;
            this.btnDeleteDirFileList.CursorChanged += new System.EventHandler(this.btnDeleteDirFileList_Click);
            // 
            // lbFileList
            // 
            this.lbFileList.FormattingEnabled = true;
            this.lbFileList.Location = new System.Drawing.Point(12, 405);
            this.lbFileList.Name = "lbFileList";
            this.lbFileList.Size = new System.Drawing.Size(611, 160);
            this.lbFileList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search String";
            // 
            // tbSearchString
            // 
            this.tbSearchString.Location = new System.Drawing.Point(3, 200);
            this.tbSearchString.Multiline = true;
            this.tbSearchString.Name = "tbSearchString";
            this.tbSearchString.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbSearchString.Size = new System.Drawing.Size(269, 38);
            this.tbSearchString.TabIndex = 4;
            // 
            // pnlFLO
            // 
            this.pnlFLO.Controls.Add(this.btnCloseFloPnl);
            this.pnlFLO.Controls.Add(this.ucDirectoryChooser1);
            this.pnlFLO.Location = new System.Drawing.Point(3, 3);
            this.pnlFLO.Name = "pnlFLO";
            this.pnlFLO.Size = new System.Drawing.Size(680, 235);
            this.pnlFLO.TabIndex = 3;
            // 
            // btnCloseFloPnl
            // 
            this.btnCloseFloPnl.Location = new System.Drawing.Point(3, 3);
            this.btnCloseFloPnl.Name = "btnCloseFloPnl";
            this.btnCloseFloPnl.Size = new System.Drawing.Size(120, 23);
            this.btnCloseFloPnl.TabIndex = 4;
            this.btnCloseFloPnl.Text = "Add files";
            this.btnCloseFloPnl.UseVisualStyleBackColor = true;
            this.btnCloseFloPnl.Click += new System.EventHandler(this.btnCloseFloPnl_Click);
            // 
            // ucDirectoryChooser1
            // 
            this.ucDirectoryChooser1.Location = new System.Drawing.Point(3, 32);
            this.ucDirectoryChooser1.Name = "ucDirectoryChooser1";
            this.ucDirectoryChooser1.Size = new System.Drawing.Size(614, 146);
            this.ucDirectoryChooser1.TabIndex = 0;
            // 
            // uatlbFileExt
            // 
            this.uatlbFileExt.AllowDupes = false;
            this.uatlbFileExt.CaseSensitive = true;
            this.uatlbFileExt.Location = new System.Drawing.Point(412, 175);
            this.uatlbFileExt.Name = "uatlbFileExt";
            this.uatlbFileExt.Size = new System.Drawing.Size(168, 177);
            this.uatlbFileExt.TabIndex = 1;
            // 
            // pnlM3UPlayList
            // 
            this.pnlM3UPlayList.Controls.Add(this.uftM3U);
            this.pnlM3UPlayList.Controls.Add(this.tbM3UFileName);
            this.pnlM3UPlayList.Controls.Add(this.label5);
            this.pnlM3UPlayList.Controls.Add(this.tbM3UDir);
            this.pnlM3UPlayList.Controls.Add(this.btnGetM3UPath);
            this.pnlM3UPlayList.Controls.Add(this.label4);
            this.pnlM3UPlayList.Controls.Add(this.label2);
            this.pnlM3UPlayList.Location = new System.Drawing.Point(5, 437);
            this.pnlM3UPlayList.Name = "pnlM3UPlayList";
            this.pnlM3UPlayList.Size = new System.Drawing.Size(718, 278);
            this.pnlM3UPlayList.TabIndex = 6;
            // 
            // uftM3U
            // 
            this.uftM3U.FileTypes = ((System.Collections.Generic.List<string>)(resources.GetObject("uftM3U.FileTypes")));
            this.uftM3U.FromAllowDrop = true;
            this.uftM3U.Location = new System.Drawing.Point(2, 71);
            this.uftM3U.Name = "uftM3U";
            this.uftM3U.Size = new System.Drawing.Size(697, 189);
            this.uftM3U.TabIndex = 13;
            // 
            // tbM3UFileName
            // 
            this.tbM3UFileName.Location = new System.Drawing.Point(445, 32);
            this.tbM3UFileName.Name = "tbM3UFileName";
            this.tbM3UFileName.Size = new System.Drawing.Size(201, 20);
            this.tbM3UFileName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "M3U Path";
            // 
            // tbM3UDir
            // 
            this.tbM3UDir.Location = new System.Drawing.Point(197, 32);
            this.tbM3UDir.Multiline = true;
            this.tbM3UDir.Name = "tbM3UDir";
            this.tbM3UDir.ReadOnly = true;
            this.tbM3UDir.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbM3UDir.Size = new System.Drawing.Size(201, 33);
            this.tbM3UDir.TabIndex = 10;
            // 
            // btnGetM3UPath
            // 
            this.btnGetM3UPath.Location = new System.Drawing.Point(104, 30);
            this.btnGetM3UPath.Name = "btnGetM3UPath";
            this.btnGetM3UPath.Size = new System.Drawing.Size(87, 23);
            this.btnGetM3UPath.TabIndex = 9;
            this.btnGetM3UPath.Text = "Get M3U Path";
            this.btnGetM3UPath.UseVisualStyleBackColor = true;
            this.btnGetM3UPath.Click += new System.EventHandler(this.btnGetM3UPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "M3U File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "M3U List";
            // 
            // pnlChangePath
            // 
            this.pnlChangePath.Controls.Add(this.btnGetDir);
            this.pnlChangePath.Controls.Add(this.lbMusicDirs);
            this.pnlChangePath.Controls.Add(this.btnGetMusicRootFolder);
            this.pnlChangePath.Controls.Add(this.textBox1);
            this.pnlChangePath.Location = new System.Drawing.Point(5, 721);
            this.pnlChangePath.Name = "pnlChangePath";
            this.pnlChangePath.Size = new System.Drawing.Size(699, 125);
            this.pnlChangePath.TabIndex = 7;
            this.pnlChangePath.Visible = false;
            // 
            // btnGetDir
            // 
            this.btnGetDir.Location = new System.Drawing.Point(9, 3);
            this.btnGetDir.Name = "btnGetDir";
            this.btnGetDir.Size = new System.Drawing.Size(75, 23);
            this.btnGetDir.TabIndex = 14;
            this.btnGetDir.Text = "Get Dir";
            this.btnGetDir.UseVisualStyleBackColor = true;
            this.btnGetDir.Click += new System.EventHandler(this.btnGetDir_Click);
            // 
            // lbMusicDirs
            // 
            this.lbMusicDirs.FormattingEnabled = true;
            this.lbMusicDirs.HorizontalScrollbar = true;
            this.lbMusicDirs.Location = new System.Drawing.Point(92, 3);
            this.lbMusicDirs.Name = "lbMusicDirs";
            this.lbMusicDirs.Size = new System.Drawing.Size(187, 95);
            this.lbMusicDirs.TabIndex = 13;
            // 
            // btnGetMusicRootFolder
            // 
            this.btnGetMusicRootFolder.Location = new System.Drawing.Point(285, 3);
            this.btnGetMusicRootFolder.Name = "btnGetMusicRootFolder";
            this.btnGetMusicRootFolder.Size = new System.Drawing.Size(114, 23);
            this.btnGetMusicRootFolder.TabIndex = 12;
            this.btnGetMusicRootFolder.Text = "Get MusicRoot Dir";
            this.btnGetMusicRootFolder.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(201, 33);
            this.textBox1.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmM3UEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 550);
            this.Controls.Add(this.flpMain);
            this.Name = "FrmM3UEditor";
            this.Text = "M3UEditor";
            this.flpMain.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAddFiles.ResumeLayout(false);
            this.pnlAddFiles.PerformLayout();
            this.pnlFLO.ResumeLayout(false);
            this.pnlM3UPlayList.ResumeLayout(false);
            this.pnlM3UPlayList.PerformLayout();
            this.pnlChangePath.ResumeLayout(false);
            this.pnlChangePath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ttAddDirFiles;
        private System.Windows.Forms.ToolTip ttDeleteDirFileList;
        private System.Windows.Forms.ToolTip ttDeleteAllDirFileList;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openM3UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveM3uToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAddFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddDirFiles;
        private System.Windows.Forms.Button btnDeleteAllDirFileList;
        private System.Windows.Forms.Button btnDeleteDirFileList;
        private System.Windows.Forms.ListBox lbFileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchString;
        private System.Windows.Forms.Panel pnlFLO;
        private System.Windows.Forms.Button btnCloseFloPnl;
        private BCHControls.UCDirectoryChooser ucDirectoryChooser1;
        private BCHControls.UCAddToListBox uatlbFileExt;
        private System.Windows.Forms.Panel pnlM3UPlayList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGetM3UPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbM3UFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbM3UDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private BCHControls.UCFromToDragDropFiles uftM3U;
        private System.Windows.Forms.Panel pnlChangePath;
        private System.Windows.Forms.ListBox lbMusicDirs;
        private System.Windows.Forms.Button btnGetMusicRootFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGetDir;
    }
}