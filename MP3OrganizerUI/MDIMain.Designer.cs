namespace MP3OrganizerUI
{
    partial class MDIMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3TaggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3BatchTagEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3TagEditorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unformattedMp3FilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3DatabaseUtilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSqliteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlDbRunnerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.accessDatabaseUtilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMP3DBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3DatabaseSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLDBRunnerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.iPhoneAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTunesLibFileReaderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyIPhoneBackupFilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3FolderUtilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFolderStructureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFilesToSameFolderStructureToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mp3DatabaseSearchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.mP3ToolsToolStripMenuItem,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(962, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // mP3ToolsToolStripMenuItem
            // 
            this.mP3ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mP3TaggingToolStripMenuItem,
            this.mP3DatabaseUtilitiesToolStripMenuItem,
            this.accessDatabaseUtilitiesToolStripMenuItem,
            this.iPhoneAppsToolStripMenuItem,
            this.mP3FolderUtilitiesToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.mP3ToolsToolStripMenuItem.Name = "mP3ToolsToolStripMenuItem";
            this.mP3ToolsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.mP3ToolsToolStripMenuItem.Text = "&MP3 Tools";
            // 
            // mP3TaggingToolStripMenuItem
            // 
            this.mP3TaggingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mP3BatchTagEditorToolStripMenuItem,
            this.mP3TagEditorToolStripMenuItem1,
            this.unformattedMp3FilesToolStripMenuItem1});
            this.mP3TaggingToolStripMenuItem.Name = "mP3TaggingToolStripMenuItem";
            this.mP3TaggingToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.mP3TaggingToolStripMenuItem.Text = "MP3 Tagging";
            // 
            // mP3BatchTagEditorToolStripMenuItem
            // 
            this.mP3BatchTagEditorToolStripMenuItem.Name = "mP3BatchTagEditorToolStripMenuItem";
            this.mP3BatchTagEditorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.mP3BatchTagEditorToolStripMenuItem.Text = "M&P3 &Batch Tag Editor";
            this.mP3BatchTagEditorToolStripMenuItem.Click += new System.EventHandler(this.mP3BatchTagEditorToolStripMenuItem_Click);
            // 
            // mP3TagEditorToolStripMenuItem1
            // 
            this.mP3TagEditorToolStripMenuItem1.Name = "mP3TagEditorToolStripMenuItem1";
            this.mP3TagEditorToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.mP3TagEditorToolStripMenuItem1.Text = "MP3 &Tag Editor";
            this.mP3TagEditorToolStripMenuItem1.Click += new System.EventHandler(this.mP3TagEditorToolStripMenuItem1_Click);
            // 
            // unformattedMp3FilesToolStripMenuItem1
            // 
            this.unformattedMp3FilesToolStripMenuItem1.Name = "unformattedMp3FilesToolStripMenuItem1";
            this.unformattedMp3FilesToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.unformattedMp3FilesToolStripMenuItem1.Text = "&Unformatted Mp3 Files";
            this.unformattedMp3FilesToolStripMenuItem1.Click += new System.EventHandler(this.unformattedMp3FilesToolStripMenuItem1_Click);
            // 
            // mP3DatabaseUtilitiesToolStripMenuItem
            // 
            this.mP3DatabaseUtilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sqlDbRunnerToolStripMenuItem3,
            this.mp3DatabaseSearchToolStripMenuItem1,
            this.createSqliteToolStripMenuItem});
            this.mP3DatabaseUtilitiesToolStripMenuItem.Name = "mP3DatabaseUtilitiesToolStripMenuItem";
            this.mP3DatabaseUtilitiesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.mP3DatabaseUtilitiesToolStripMenuItem.Text = "Sqlite Database Utilities";
            // 
            // createSqliteToolStripMenuItem
            // 
            this.createSqliteToolStripMenuItem.Name = "createSqliteToolStripMenuItem";
            this.createSqliteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.createSqliteToolStripMenuItem.Text = "Create Sqlite";
            this.createSqliteToolStripMenuItem.Click += new System.EventHandler(this.createSqliteToolStripMenuItem_Click);
            // 
            // sqlDbRunnerToolStripMenuItem3
            // 
            this.sqlDbRunnerToolStripMenuItem3.Name = "sqlDbRunnerToolStripMenuItem3";
            this.sqlDbRunnerToolStripMenuItem3.Size = new System.Drawing.Size(187, 22);
            this.sqlDbRunnerToolStripMenuItem3.Text = "Sql Db Runner";
            this.sqlDbRunnerToolStripMenuItem3.Click += new System.EventHandler(this.sqlDbRunnerToolStripMenuItem3_Click);
            // 
            // accessDatabaseUtilitiesToolStripMenuItem
            // 
            this.accessDatabaseUtilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mP3DatabaseSearchToolStripMenuItem,
            this.sQLDBRunnerToolStripMenuItem2,
            this.loadMP3DBToolStripMenuItem1});
            this.accessDatabaseUtilitiesToolStripMenuItem.Name = "accessDatabaseUtilitiesToolStripMenuItem";
            this.accessDatabaseUtilitiesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.accessDatabaseUtilitiesToolStripMenuItem.Text = "Access Database Utilities";
            // 
            // loadMP3DBToolStripMenuItem1
            // 
            this.loadMP3DBToolStripMenuItem1.Name = "loadMP3DBToolStripMenuItem1";
            this.loadMP3DBToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.loadMP3DBToolStripMenuItem1.Text = "&Load MP3 DB";
            this.loadMP3DBToolStripMenuItem1.Click += new System.EventHandler(this.loadMP3DBToolStripMenuItem1_Click);
            // 
            // mP3DatabaseSearchToolStripMenuItem
            // 
            this.mP3DatabaseSearchToolStripMenuItem.Name = "mP3DatabaseSearchToolStripMenuItem";
            this.mP3DatabaseSearchToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.mP3DatabaseSearchToolStripMenuItem.Text = "MP3 Database Search";
            this.mP3DatabaseSearchToolStripMenuItem.Click += new System.EventHandler(this.mP3DatabaseSearchToolStripMenuItem_Click);
            // 
            // sQLDBRunnerToolStripMenuItem2
            // 
            this.sQLDBRunnerToolStripMenuItem2.Name = "sQLDBRunnerToolStripMenuItem2";
            this.sQLDBRunnerToolStripMenuItem2.Size = new System.Drawing.Size(187, 22);
            this.sQLDBRunnerToolStripMenuItem2.Text = "SQL DB Runner";
            this.sQLDBRunnerToolStripMenuItem2.Click += new System.EventHandler(this.sQLDBRunnerToolStripMenuItem2_Click);
            // 
            // iPhoneAppsToolStripMenuItem
            // 
            this.iPhoneAppsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTunesLibFileReaderToolStripMenuItem1,
            this.copyIPhoneBackupFilesToolStripMenuItem1});
            this.iPhoneAppsToolStripMenuItem.Name = "iPhoneAppsToolStripMenuItem";
            this.iPhoneAppsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.iPhoneAppsToolStripMenuItem.Text = "iPhone Apps";
            // 
            // iTunesLibFileReaderToolStripMenuItem1
            // 
            this.iTunesLibFileReaderToolStripMenuItem1.Name = "iTunesLibFileReaderToolStripMenuItem1";
            this.iTunesLibFileReaderToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.iTunesLibFileReaderToolStripMenuItem1.Text = "iTunes Lib File Reader";
            this.iTunesLibFileReaderToolStripMenuItem1.Click += new System.EventHandler(this.iTunesLibFileReaderToolStripMenuItem1_Click);
            // 
            // copyIPhoneBackupFilesToolStripMenuItem1
            // 
            this.copyIPhoneBackupFilesToolStripMenuItem1.Name = "copyIPhoneBackupFilesToolStripMenuItem1";
            this.copyIPhoneBackupFilesToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.copyIPhoneBackupFilesToolStripMenuItem1.Text = "Copy iPhone Backup Files";
            // 
            // mP3FolderUtilitiesToolStripMenuItem
            // 
            this.mP3FolderUtilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyFolderStructureToolStripMenuItem1,
            this.copyFilesToSameFolderStructureToolStripMenuItem2});
            this.mP3FolderUtilitiesToolStripMenuItem.Name = "mP3FolderUtilitiesToolStripMenuItem";
            this.mP3FolderUtilitiesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.mP3FolderUtilitiesToolStripMenuItem.Text = "MP3 Folder Utilities";
            // 
            // copyFolderStructureToolStripMenuItem1
            // 
            this.copyFolderStructureToolStripMenuItem1.Name = "copyFolderStructureToolStripMenuItem1";
            this.copyFolderStructureToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            this.copyFolderStructureToolStripMenuItem1.Text = "Copy Folder Structure";
            this.copyFolderStructureToolStripMenuItem1.Click += new System.EventHandler(this.copyFolderStructureToolStripMenuItem1_Click);
            // 
            // copyFilesToSameFolderStructureToolStripMenuItem2
            // 
            this.copyFilesToSameFolderStructureToolStripMenuItem2.Name = "copyFilesToSameFolderStructureToolStripMenuItem2";
            this.copyFilesToSameFolderStructureToolStripMenuItem2.Size = new System.Drawing.Size(262, 22);
            this.copyFilesToSameFolderStructureToolStripMenuItem2.Text = "Copy Files To Same Folder Structure";
            this.copyFilesToSameFolderStructureToolStripMenuItem2.Click += new System.EventHandler(this.copyFilesToSameFolderStructureToolStripMenuItem2_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newWindowToolStripMenuItem.Text = "&New Window";
            this.newWindowToolStripMenuItem.Visible = false;
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            this.helpMenu.Visible = false;
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 734);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(962, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mp3DatabaseSearchToolStripMenuItem1
            // 
            this.mp3DatabaseSearchToolStripMenuItem1.Name = "mp3DatabaseSearchToolStripMenuItem1";
            this.mp3DatabaseSearchToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.mp3DatabaseSearchToolStripMenuItem1.Text = "Mp3 Database Search";
            this.mp3DatabaseSearchToolStripMenuItem1.Click += new System.EventHandler(this.mp3DatabaseSearchToolStripMenuItem1_Click);
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 756);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIMain";
            this.Text = "MDIMain";
            this.Load += new System.EventHandler(this.MDIMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mP3ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3TaggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3BatchTagEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3TagEditorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unformattedMp3FilesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iPhoneAppsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTunesLibFileReaderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyIPhoneBackupFilesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mP3FolderUtilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFolderStructureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyFilesToSameFolderStructureToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mP3DatabaseUtilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessDatabaseUtilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sqlDbRunnerToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem loadMP3DBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mP3DatabaseSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLDBRunnerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createSqliteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mp3DatabaseSearchToolStripMenuItem1;
    }
}



