namespace MP3OrganizerUI
{
    partial class FrmM3UEditor
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.openWPLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlM3UPlayList = new System.Windows.Forms.Panel();
            this.rbPlainM3U = new System.Windows.Forms.RadioButton();
            this.rbDoMediaPlayerFormat = new System.Windows.Forms.RadioButton();
            this.rbDoArchosM3UFormat = new System.Windows.Forms.RadioButton();
            this.btnChngRootDir = new System.Windows.Forms.Button();
            this.btnCnvrtBckToPC = new System.Windows.Forms.Button();
            this.btnSortByDir = new System.Windows.Forms.Button();
            this.btnSortBySong = new System.Windows.Forms.Button();
            this.btnSortByArtist = new System.Windows.Forms.Button();
            this.ckbDoArchosFormat = new System.Windows.Forms.CheckBox();
            this.tbArchosMusicRootDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uftM3U = new BCHControls.UCFromToDragDropFiles();
            this.tbM3UFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbM3UDir = new System.Windows.Forms.TextBox();
            this.btnGetM3UPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAddFiles = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ucdfs = new BCHControls.UCDirFileSearch();
            this.btnCloseFloPnl = new System.Windows.Forms.Button();
            this.pnlChangePath = new System.Windows.Forms.Panel();
            this.btnGetDir = new System.Windows.Forms.Button();
            this.lbMusicDirs = new System.Windows.Forms.ListBox();
            this.btnGetMusicRootFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSortByDirArtSng = new System.Windows.Forms.Button();
            this.flpMain.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.pnlM3UPlayList.SuspendLayout();
            this.pnlAddFiles.SuspendLayout();
            this.pnlChangePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.Controls.Add(this.pnlMenu);
            this.flpMain.Controls.Add(this.pnlM3UPlayList);
            this.flpMain.Controls.Add(this.pnlAddFiles);
            this.flpMain.Controls.Add(this.pnlChangePath);
            this.flpMain.Location = new System.Drawing.Point(12, 12);
            this.flpMain.Name = "flpMain";
            this.flpMain.Padding = new System.Windows.Forms.Padding(2);
            this.flpMain.Size = new System.Drawing.Size(762, 1009);
            this.flpMain.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.Controls.Add(this.menuStrip2);
            this.pnlMenu.Location = new System.Drawing.Point(5, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(683, 26);
            this.pnlMenu.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip2.Location = new System.Drawing.Point(3, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(279, 26);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 22);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.openWPLToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(65, 22);
            this.toolStripMenuItem3.Text = "&M3U File";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem4.Text = "&Open M3U";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.openM3UToolStripMenuItem_Click);
            // 
            // openWPLToolStripMenuItem
            // 
            this.openWPLToolStripMenuItem.Name = "openWPLToolStripMenuItem";
            this.openWPLToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.openWPLToolStripMenuItem.Text = "O&pen WPL";
            this.openWPLToolStripMenuItem.Click += new System.EventHandler(this.openWPLToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem5.Text = "&Add Files";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem6.Text = "&Save M3u";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.saveM3uToolStripMenuItem_Click);
            // 
            // pnlM3UPlayList
            // 
            this.pnlM3UPlayList.Controls.Add(this.btnSortByDirArtSng);
            this.pnlM3UPlayList.Controls.Add(this.rbPlainM3U);
            this.pnlM3UPlayList.Controls.Add(this.rbDoMediaPlayerFormat);
            this.pnlM3UPlayList.Controls.Add(this.rbDoArchosM3UFormat);
            this.pnlM3UPlayList.Controls.Add(this.btnChngRootDir);
            this.pnlM3UPlayList.Controls.Add(this.btnCnvrtBckToPC);
            this.pnlM3UPlayList.Controls.Add(this.btnSortByDir);
            this.pnlM3UPlayList.Controls.Add(this.btnSortBySong);
            this.pnlM3UPlayList.Controls.Add(this.btnSortByArtist);
            this.pnlM3UPlayList.Controls.Add(this.ckbDoArchosFormat);
            this.pnlM3UPlayList.Controls.Add(this.tbArchosMusicRootDir);
            this.pnlM3UPlayList.Controls.Add(this.label1);
            this.pnlM3UPlayList.Controls.Add(this.uftM3U);
            this.pnlM3UPlayList.Controls.Add(this.tbM3UFileName);
            this.pnlM3UPlayList.Controls.Add(this.label5);
            this.pnlM3UPlayList.Controls.Add(this.tbM3UDir);
            this.pnlM3UPlayList.Controls.Add(this.btnGetM3UPath);
            this.pnlM3UPlayList.Controls.Add(this.label4);
            this.pnlM3UPlayList.Controls.Add(this.label2);
            this.pnlM3UPlayList.Location = new System.Drawing.Point(5, 37);
            this.pnlM3UPlayList.Name = "pnlM3UPlayList";
            this.pnlM3UPlayList.Size = new System.Drawing.Size(757, 310);
            this.pnlM3UPlayList.TabIndex = 6;
            // 
            // rbPlainM3U
            // 
            this.rbPlainM3U.AutoSize = true;
            this.rbPlainM3U.Location = new System.Drawing.Point(511, 257);
            this.rbPlainM3U.Name = "rbPlainM3U";
            this.rbPlainM3U.Size = new System.Drawing.Size(71, 17);
            this.rbPlainM3U.TabIndex = 25;
            this.rbPlainM3U.Text = "PlainM3U";
            this.rbPlainM3U.UseVisualStyleBackColor = true;
            // 
            // rbDoMediaPlayerFormat
            // 
            this.rbDoMediaPlayerFormat.AutoSize = true;
            this.rbDoMediaPlayerFormat.Location = new System.Drawing.Point(367, 257);
            this.rbDoMediaPlayerFormat.Name = "rbDoMediaPlayerFormat";
            this.rbDoMediaPlayerFormat.Size = new System.Drawing.Size(138, 17);
            this.rbDoMediaPlayerFormat.TabIndex = 24;
            this.rbDoMediaPlayerFormat.Text = "Do Media Player Format";
            this.rbDoMediaPlayerFormat.UseVisualStyleBackColor = true;
            // 
            // rbDoArchosM3UFormat
            // 
            this.rbDoArchosM3UFormat.AutoSize = true;
            this.rbDoArchosM3UFormat.Checked = true;
            this.rbDoArchosM3UFormat.Location = new System.Drawing.Point(223, 257);
            this.rbDoArchosM3UFormat.Name = "rbDoArchosM3UFormat";
            this.rbDoArchosM3UFormat.Size = new System.Drawing.Size(136, 17);
            this.rbDoArchosM3UFormat.TabIndex = 23;
            this.rbDoArchosM3UFormat.TabStop = true;
            this.rbDoArchosM3UFormat.Text = "Do Archos M3U Format";
            this.rbDoArchosM3UFormat.UseVisualStyleBackColor = true;
            // 
            // btnChngRootDir
            // 
            this.btnChngRootDir.Location = new System.Drawing.Point(146, 280);
            this.btnChngRootDir.Name = "btnChngRootDir";
            this.btnChngRootDir.Size = new System.Drawing.Size(76, 23);
            this.btnChngRootDir.TabIndex = 22;
            this.btnChngRootDir.Text = "Change Dir";
            this.btnChngRootDir.UseVisualStyleBackColor = true;
            this.btnChngRootDir.Click += new System.EventHandler(this.btnChngRootDir_Click);
            // 
            // btnCnvrtBckToPC
            // 
            this.btnCnvrtBckToPC.Location = new System.Drawing.Point(9, 280);
            this.btnCnvrtBckToPC.Name = "btnCnvrtBckToPC";
            this.btnCnvrtBckToPC.Size = new System.Drawing.Size(131, 23);
            this.btnCnvrtBckToPC.TabIndex = 21;
            this.btnCnvrtBckToPC.Text = "Convert Back To PC";
            this.btnCnvrtBckToPC.UseVisualStyleBackColor = true;
            this.btnCnvrtBckToPC.Click += new System.EventHandler(this.btnCnvrtBckToPC_Click);
            // 
            // btnSortByDir
            // 
            this.btnSortByDir.Location = new System.Drawing.Point(395, 280);
            this.btnSortByDir.Name = "btnSortByDir";
            this.btnSortByDir.Size = new System.Drawing.Size(68, 23);
            this.btnSortByDir.TabIndex = 20;
            this.btnSortByDir.Text = "Sort By Dir";
            this.btnSortByDir.UseVisualStyleBackColor = true;
            this.btnSortByDir.Click += new System.EventHandler(this.btnSortByDir_Click);
            // 
            // btnSortBySong
            // 
            this.btnSortBySong.Location = new System.Drawing.Point(312, 280);
            this.btnSortBySong.Name = "btnSortBySong";
            this.btnSortBySong.Size = new System.Drawing.Size(77, 23);
            this.btnSortBySong.TabIndex = 19;
            this.btnSortBySong.Text = "Sort By Song";
            this.btnSortBySong.UseVisualStyleBackColor = true;
            this.btnSortBySong.Click += new System.EventHandler(this.btnSortBySong_Click);
            // 
            // btnSortByArtist
            // 
            this.btnSortByArtist.Location = new System.Drawing.Point(228, 280);
            this.btnSortByArtist.Name = "btnSortByArtist";
            this.btnSortByArtist.Size = new System.Drawing.Size(78, 23);
            this.btnSortByArtist.TabIndex = 18;
            this.btnSortByArtist.Text = "Sort By Artist";
            this.btnSortByArtist.UseVisualStyleBackColor = true;
            this.btnSortByArtist.Click += new System.EventHandler(this.btnSortByArtist_Click);
            // 
            // ckbDoArchosFormat
            // 
            this.ckbDoArchosFormat.AutoSize = true;
            this.ckbDoArchosFormat.Checked = true;
            this.ckbDoArchosFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDoArchosFormat.Location = new System.Drawing.Point(603, 283);
            this.ckbDoArchosFormat.Name = "ckbDoArchosFormat";
            this.ckbDoArchosFormat.Size = new System.Drawing.Size(137, 17);
            this.ckbDoArchosFormat.TabIndex = 16;
            this.ckbDoArchosFormat.Text = "Do Archos M3U Format";
            this.ckbDoArchosFormat.UseVisualStyleBackColor = true;
            // 
            // tbArchosMusicRootDir
            // 
            this.tbArchosMusicRootDir.Location = new System.Drawing.Point(9, 256);
            this.tbArchosMusicRootDir.Name = "tbArchosMusicRootDir";
            this.tbArchosMusicRootDir.Size = new System.Drawing.Size(201, 20);
            this.tbArchosMusicRootDir.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Archos\\PC Root Music Dir";
            // 
            // uftM3U
            // 
            this.uftM3U.FileTypes = ((System.Collections.Generic.List<string>)(resources.GetObject("uftM3U.FileTypes")));
            this.uftM3U.FromAllowDrop = true;
            this.uftM3U.Location = new System.Drawing.Point(5, 71);
            this.uftM3U.Name = "uftM3U";
            this.uftM3U.ShoMoveButtons = true;
            this.uftM3U.Size = new System.Drawing.Size(735, 175);
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
            // pnlAddFiles
            // 
            this.pnlAddFiles.Controls.Add(this.btnCancel);
            this.pnlAddFiles.Controls.Add(this.ucdfs);
            this.pnlAddFiles.Controls.Add(this.btnCloseFloPnl);
            this.pnlAddFiles.Location = new System.Drawing.Point(5, 353);
            this.pnlAddFiles.Name = "pnlAddFiles";
            this.pnlAddFiles.Size = new System.Drawing.Size(686, 365);
            this.pnlAddFiles.TabIndex = 8;
            this.pnlAddFiles.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(129, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCloseFloPnl_Click);
            // 
            // ucdfs
            // 
            this.ucdfs.AutoScroll = true;
            this.ucdfs.FileList = ((System.Collections.Generic.List<string>)(resources.GetObject("ucdfs.FileList")));
            this.ucdfs.FileTypeEnabled = true;
            this.ucdfs.FileTypeList = ((System.Collections.Generic.List<string>)(resources.GetObject("ucdfs.FileTypeList")));
            this.ucdfs.Location = new System.Drawing.Point(3, 32);
            this.ucdfs.Name = "ucdfs";
            this.ucdfs.SearchString = "";
            this.ucdfs.Size = new System.Drawing.Size(662, 536);
            this.ucdfs.TabIndex = 6;
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
            // pnlChangePath
            // 
            this.pnlChangePath.Controls.Add(this.btnGetDir);
            this.pnlChangePath.Controls.Add(this.lbMusicDirs);
            this.pnlChangePath.Controls.Add(this.btnGetMusicRootFolder);
            this.pnlChangePath.Controls.Add(this.textBox1);
            this.pnlChangePath.Location = new System.Drawing.Point(5, 724);
            this.pnlChangePath.Name = "pnlChangePath";
            this.pnlChangePath.Size = new System.Drawing.Size(699, 125);
            this.pnlChangePath.TabIndex = 9;
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
            // btnSortByDirArtSng
            // 
            this.btnSortByDirArtSng.Location = new System.Drawing.Point(469, 280);
            this.btnSortByDirArtSng.Name = "btnSortByDirArtSng";
            this.btnSortByDirArtSng.Size = new System.Drawing.Size(113, 23);
            this.btnSortByDirArtSng.TabIndex = 26;
            this.btnSortByDirArtSng.Text = "Sort By Dir-Arts-Sng";
            this.btnSortByDirArtSng.UseVisualStyleBackColor = true;
            this.btnSortByDirArtSng.Click += new System.EventHandler(this.btnSortByDirArtSng_Click);
            // 
            // FrmM3UEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 518);
            this.Controls.Add(this.flpMain);
            this.Name = "FrmM3UEditor";
            this.Text = "M3UEditor";
            this.flpMain.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnlM3UPlayList.ResumeLayout(false);
            this.pnlM3UPlayList.PerformLayout();
            this.pnlAddFiles.ResumeLayout(false);
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
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.CheckBox ckbDoArchosFormat;
        private System.Windows.Forms.TextBox tbArchosMusicRootDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSortBySong;
        private System.Windows.Forms.Button btnSortByArtist;
        private System.Windows.Forms.Button btnSortByDir;
        private System.Windows.Forms.Button btnCnvrtBckToPC;
        private System.Windows.Forms.Panel pnlAddFiles;
        private System.Windows.Forms.Button btnCancel;
        private BCHControls.UCDirFileSearch ucdfs;
        private System.Windows.Forms.Button btnCloseFloPnl;
        private System.Windows.Forms.Panel pnlChangePath;
        private System.Windows.Forms.Button btnGetDir;
        private System.Windows.Forms.ListBox lbMusicDirs;
        private System.Windows.Forms.Button btnGetMusicRootFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnChngRootDir;
        private System.Windows.Forms.RadioButton rbDoArchosM3UFormat;
        private System.Windows.Forms.RadioButton rbDoMediaPlayerFormat;
        private System.Windows.Forms.RadioButton rbPlainM3U;
        private System.Windows.Forms.ToolStripMenuItem openWPLToolStripMenuItem;
        private System.Windows.Forms.Button btnSortByDirArtSng;
    }
}