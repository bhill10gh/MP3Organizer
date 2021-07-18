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
            this.mP3TagEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileUtilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m3UEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unformattedMp3FilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3DatabaseAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMP3DBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3DatabaseSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLRunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFolderStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFilesToSameFolderStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTunesLibFileReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyIPhoneBackupFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mP3TagEditorToolStripMenuItem,
            this.copyFolderStructureToolStripMenuItem,
            this.m3UEditorToolStripMenuItem,
            this.iTunesLibFileReaderToolStripMenuItem,
            this.mP3ToolStripMenuItem,
            this.unformattedMp3FilesToolStripMenuItem,
            this.mP3DatabaseAppToolStripMenuItem,
            this.loadMP3DBToolStripMenuItem,
            this.mP3DatabaseSearchToolStripMenuItem,
            this.fileUtilityToolStripMenuItem,
            this.sQLRunnerToolStripMenuItem,
            this.copyFilesToSameFolderStructureToolStripMenuItem,
            this.testFormToolStripMenuItem,
            this.copyIPhoneBackupFilesToolStripMenuItem});
            this.mP3ToolsToolStripMenuItem.Name = "mP3ToolsToolStripMenuItem";
            this.mP3ToolsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.mP3ToolsToolStripMenuItem.Text = "&MP3 Tools";
            // 
            // mP3TagEditorToolStripMenuItem
            // 
            this.mP3TagEditorToolStripMenuItem.Name = "mP3TagEditorToolStripMenuItem";
            this.mP3TagEditorToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.mP3TagEditorToolStripMenuItem.Text = "M&P3 &Batch Tag Editor";
            this.mP3TagEditorToolStripMenuItem.Click += new System.EventHandler(this.mP3TagEditorToolStripMenuItem_Click);
            // 
            // fileUtilityToolStripMenuItem
            // 
            this.fileUtilityToolStripMenuItem.Name = "fileUtilityToolStripMenuItem";
            this.fileUtilityToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.fileUtilityToolStripMenuItem.Text = "&File Utility";
            this.fileUtilityToolStripMenuItem.Click += new System.EventHandler(this.fileUtilityToolStripMenuItem_Click);
            // 
            // m3UEditorToolStripMenuItem
            // 
            this.m3UEditorToolStripMenuItem.Name = "m3UEditorToolStripMenuItem";
            this.m3UEditorToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.m3UEditorToolStripMenuItem.Text = "&M3U Editor";
            this.m3UEditorToolStripMenuItem.Click += new System.EventHandler(this.m3UEditorToolStripMenuItem_Click);
            // 
            // mP3ToolStripMenuItem
            // 
            this.mP3ToolStripMenuItem.Name = "mP3ToolStripMenuItem";
            this.mP3ToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.mP3ToolStripMenuItem.Text = "MP3 &Tag Editor";
            this.mP3ToolStripMenuItem.Click += new System.EventHandler(this.mP3ToolStripMenuItem_Click);
            // 
            // unformattedMp3FilesToolStripMenuItem
            // 
            this.unformattedMp3FilesToolStripMenuItem.Name = "unformattedMp3FilesToolStripMenuItem";
            this.unformattedMp3FilesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.unformattedMp3FilesToolStripMenuItem.Text = "&Unformatted Mp3 Files";
            this.unformattedMp3FilesToolStripMenuItem.Click += new System.EventHandler(this.unformattedMp3FilesToolStripMenuItem_Click);
            // 
            // mP3DatabaseAppToolStripMenuItem
            // 
            this.mP3DatabaseAppToolStripMenuItem.Name = "mP3DatabaseAppToolStripMenuItem";
            this.mP3DatabaseAppToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.mP3DatabaseAppToolStripMenuItem.Text = "MP3 &Database App";
            this.mP3DatabaseAppToolStripMenuItem.Visible = false;
            this.mP3DatabaseAppToolStripMenuItem.Click += new System.EventHandler(this.mP3DatabaseAppToolStripMenuItem_Click);
            // 
            // loadMP3DBToolStripMenuItem
            // 
            this.loadMP3DBToolStripMenuItem.Name = "loadMP3DBToolStripMenuItem";
            this.loadMP3DBToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.loadMP3DBToolStripMenuItem.Text = "&Load MP3 DB";
            this.loadMP3DBToolStripMenuItem.Click += new System.EventHandler(this.loadMP3DBToolStripMenuItem_Click);
            // 
            // mP3DatabaseSearchToolStripMenuItem
            // 
            this.mP3DatabaseSearchToolStripMenuItem.Name = "mP3DatabaseSearchToolStripMenuItem";
            this.mP3DatabaseSearchToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.mP3DatabaseSearchToolStripMenuItem.Text = "MP3 Database Search";
            this.mP3DatabaseSearchToolStripMenuItem.Click += new System.EventHandler(this.mP3DatabaseSearchToolStripMenuItem_Click);
            // 
            // sQLRunnerToolStripMenuItem
            // 
            this.sQLRunnerToolStripMenuItem.Name = "sQLRunnerToolStripMenuItem";
            this.sQLRunnerToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.sQLRunnerToolStripMenuItem.Text = "SQL DB Runner";
            this.sQLRunnerToolStripMenuItem.Click += new System.EventHandler(this.sQLRunnerToolStripMenuItem_Click);
            // 
            // copyFolderStructureToolStripMenuItem
            // 
            this.copyFolderStructureToolStripMenuItem.Name = "copyFolderStructureToolStripMenuItem";
            this.copyFolderStructureToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.copyFolderStructureToolStripMenuItem.Text = "Copy Folder Structure";
            this.copyFolderStructureToolStripMenuItem.Click += new System.EventHandler(this.copyFolderStructureToolStripMenuItem_Click);
            // 
            // copyFilesToSameFolderStructureToolStripMenuItem
            // 
            this.copyFilesToSameFolderStructureToolStripMenuItem.Name = "copyFilesToSameFolderStructureToolStripMenuItem";
            this.copyFilesToSameFolderStructureToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.copyFilesToSameFolderStructureToolStripMenuItem.Text = "Copy Files To Same Folder Structure";
            this.copyFilesToSameFolderStructureToolStripMenuItem.Click += new System.EventHandler(this.copyFilesToSameFolderStructureToolStripMenuItem_Click);
            // 
            // testFormToolStripMenuItem
            // 
            this.testFormToolStripMenuItem.Name = "testFormToolStripMenuItem";
            this.testFormToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.testFormToolStripMenuItem.Text = "&Test Form";
            this.testFormToolStripMenuItem.Visible = false;
            this.testFormToolStripMenuItem.Click += new System.EventHandler(this.testFormToolStripMenuItem_Click);
            // 
            // iTunesLibFileReaderToolStripMenuItem
            // 
            this.iTunesLibFileReaderToolStripMenuItem.Name = "iTunesLibFileReaderToolStripMenuItem";
            this.iTunesLibFileReaderToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.iTunesLibFileReaderToolStripMenuItem.Text = "iTunes Lib File Reader";
            this.iTunesLibFileReaderToolStripMenuItem.Click += new System.EventHandler(this.iTunesLibFileReaderToolStripMenuItem_Click);
            // 
            // copyIPhoneBackupFilesToolStripMenuItem
            // 
            this.copyIPhoneBackupFilesToolStripMenuItem.Name = "copyIPhoneBackupFilesToolStripMenuItem";
            this.copyIPhoneBackupFilesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.copyIPhoneBackupFilesToolStripMenuItem.Text = "Copy iPhone Backup Files";
            this.copyIPhoneBackupFilesToolStripMenuItem.Click += new System.EventHandler(this.copyIPhoneBackupFilesToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem testFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m3UEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3TagEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unformattedMp3FilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3DatabaseAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMP3DBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3DatabaseSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFolderStructureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFilesToSameFolderStructureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLRunnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTunesLibFileReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyIPhoneBackupFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileUtilityToolStripMenuItem;
    }
}



