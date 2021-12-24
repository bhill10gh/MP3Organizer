namespace MP3OrganizerUI.iTunes
{
    partial class FrmiTunesLibraryReader
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
            this.btnReadLibraryFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnExportSongList = new System.Windows.Forms.Button();
            this.btnExportPlayLists = new System.Windows.Forms.Button();
            this.tbMessages = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCrtMu3FrmPlyLst = new System.Windows.Forms.Button();
            this.tbLibraryMusicPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iTunesSongsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ddtbITunesLibraryFile = new BCHControls.UCDragDropTextBox();
            this.dddtbOutputPath = new BCHControls.UCDragDropDirTextBox();
            this.dddMusicDirPath = new BCHControls.UCDragDropDirTextBox();
            this.tabITunesLibrary = new System.Windows.Forms.TabControl();
            this.tpSongsArtistPlayLists = new System.Windows.Forms.TabPage();
            this.lblLibraryPlaylistSongs = new System.Windows.Forms.Label();
            this.lblLibraryPlaylists = new System.Windows.Forms.Label();
            this.lblLibrarySongs = new System.Windows.Forms.Label();
            this.tpItunesLibraryDbFunctions = new System.Windows.Forms.TabPage();
            this.btnLoadItunesLibraryData = new System.Windows.Forms.Button();
            this.btnRefreshDb = new System.Windows.Forms.Button();
            this.ddtbDbFile = new BCHControls.UCDragDropTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlaylistsdd = new System.Windows.Forms.Label();
            this.btnSyncITunesWithMp3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTunesSongsBindingSource)).BeginInit();
            this.tabITunesLibrary.SuspendLayout();
            this.tpSongsArtistPlayLists.SuspendLayout();
            this.tpItunesLibraryDbFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadLibraryFile
            // 
            this.btnReadLibraryFile.Location = new System.Drawing.Point(5, 455);
            this.btnReadLibraryFile.Name = "btnReadLibraryFile";
            this.btnReadLibraryFile.Size = new System.Drawing.Size(156, 23);
            this.btnReadLibraryFile.TabIndex = 1;
            this.btnReadLibraryFile.Text = "Read Library File";
            this.btnReadLibraryFile.UseVisualStyleBackColor = true;
            this.btnReadLibraryFile.Click += new System.EventHandler(this.btnReadLibraryFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 107);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 209);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(712, 107);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_ColumnHeaderMouseClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(4, 342);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(712, 107);
            this.dataGridView3.TabIndex = 4;
            // 
            // btnExportSongList
            // 
            this.btnExportSongList.Location = new System.Drawing.Point(190, 455);
            this.btnExportSongList.Name = "btnExportSongList";
            this.btnExportSongList.Size = new System.Drawing.Size(156, 23);
            this.btnExportSongList.TabIndex = 26;
            this.btnExportSongList.Text = "Export Song List";
            this.btnExportSongList.UseVisualStyleBackColor = true;
            this.btnExportSongList.Click += new System.EventHandler(this.btnExportSongList_Click);
            // 
            // btnExportPlayLists
            // 
            this.btnExportPlayLists.Location = new System.Drawing.Point(375, 455);
            this.btnExportPlayLists.Name = "btnExportPlayLists";
            this.btnExportPlayLists.Size = new System.Drawing.Size(156, 23);
            this.btnExportPlayLists.TabIndex = 27;
            this.btnExportPlayLists.Text = "Export Play List";
            this.btnExportPlayLists.UseVisualStyleBackColor = true;
            this.btnExportPlayLists.Click += new System.EventHandler(this.btnExportPlayLists_Click);
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(16, 21);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.Size = new System.Drawing.Size(710, 44);
            this.tbMessages.TabIndex = 131;
            this.tbMessages.Text = "";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 130;
            this.label13.Text = "Messages";
            // 
            // btnCrtMu3FrmPlyLst
            // 
            this.btnCrtMu3FrmPlyLst.Location = new System.Drawing.Point(560, 455);
            this.btnCrtMu3FrmPlyLst.Name = "btnCrtMu3FrmPlyLst";
            this.btnCrtMu3FrmPlyLst.Size = new System.Drawing.Size(156, 23);
            this.btnCrtMu3FrmPlyLst.TabIndex = 132;
            this.btnCrtMu3FrmPlyLst.Text = "Create MU3 From Plan List";
            this.btnCrtMu3FrmPlyLst.UseVisualStyleBackColor = true;
            this.btnCrtMu3FrmPlyLst.Click += new System.EventHandler(this.btnCrtMu3FrmPlyLst_Click);
            // 
            // tbLibraryMusicPath
            // 
            this.tbLibraryMusicPath.Location = new System.Drawing.Point(152, 106);
            this.tbLibraryMusicPath.Multiline = true;
            this.tbLibraryMusicPath.Name = "tbLibraryMusicPath";
            this.tbLibraryMusicPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbLibraryMusicPath.Size = new System.Drawing.Size(574, 20);
            this.tbLibraryMusicPath.TabIndex = 133;
            this.tbLibraryMusicPath.Text = "C:\\Barry Hill\\My Music\\Music";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 134;
            this.label2.Text = "Library Music Path";
            // 
            // iTunesSongsBindingSource
            // 
            this.iTunesSongsBindingSource.DataSource = typeof(MP3OrganizerBusinessLogic.iTunesSongs);
            // 
            // ddtbITunesLibraryFile
            // 
            this.ddtbITunesLibraryFile.AllowDrop = true;
            this.ddtbITunesLibraryFile.ButtonText = "Get iTunes Library File";
            this.ddtbITunesLibraryFile.FileDialogTitle = null;
            this.ddtbITunesLibraryFile.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ddtbITunesLibraryFile.ItemFilters = null;
            this.ddtbITunesLibraryFile.ItemText = "";
            this.ddtbITunesLibraryFile.LeftRight = 60;
            this.ddtbITunesLibraryFile.Location = new System.Drawing.Point(10, 71);
            this.ddtbITunesLibraryFile.Name = "ddtbITunesLibraryFile";
            this.ddtbITunesLibraryFile.Size = new System.Drawing.Size(716, 29);
            this.ddtbITunesLibraryFile.TabIndex = 135;
            // 
            // dddtbOutputPath
            // 
            this.dddtbOutputPath.AllowDrop = true;
            this.dddtbOutputPath.ButtonText = "Output Path";
            this.dddtbOutputPath.FileDialogTitle = null;
            this.dddtbOutputPath.ItemFilters = null;
            this.dddtbOutputPath.ItemText = "";
            this.dddtbOutputPath.LeftRight = 60;
            this.dddtbOutputPath.Location = new System.Drawing.Point(-3, 7);
            this.dddtbOutputPath.Name = "dddtbOutputPath";
            this.dddtbOutputPath.Size = new System.Drawing.Size(722, 27);
            this.dddtbOutputPath.TabIndex = 136;
            // 
            // dddMusicDirPath
            // 
            this.dddMusicDirPath.AllowDrop = true;
            this.dddMusicDirPath.ButtonText = "Music Dir Path";
            this.dddMusicDirPath.FileDialogTitle = null;
            this.dddMusicDirPath.ItemFilters = null;
            this.dddMusicDirPath.ItemText = "C:\\Barry Hill\\My Music\\Music";
            this.dddMusicDirPath.LeftRight = 60;
            this.dddMusicDirPath.Location = new System.Drawing.Point(-3, 30);
            this.dddMusicDirPath.Name = "dddMusicDirPath";
            this.dddMusicDirPath.Size = new System.Drawing.Size(722, 27);
            this.dddMusicDirPath.TabIndex = 138;
            // 
            // tabITunesLibrary
            // 
            this.tabITunesLibrary.Controls.Add(this.tpSongsArtistPlayLists);
            this.tabITunesLibrary.Controls.Add(this.tpItunesLibraryDbFunctions);
            this.tabITunesLibrary.Location = new System.Drawing.Point(6, 130);
            this.tabITunesLibrary.Name = "tabITunesLibrary";
            this.tabITunesLibrary.SelectedIndex = 0;
            this.tabITunesLibrary.Size = new System.Drawing.Size(737, 512);
            this.tabITunesLibrary.TabIndex = 139;
            // 
            // tpSongsArtistPlayLists
            // 
            this.tpSongsArtistPlayLists.Controls.Add(this.lblLibraryPlaylistSongs);
            this.tpSongsArtistPlayLists.Controls.Add(this.dddMusicDirPath);
            this.tpSongsArtistPlayLists.Controls.Add(this.lblLibraryPlaylists);
            this.tpSongsArtistPlayLists.Controls.Add(this.dddtbOutputPath);
            this.tpSongsArtistPlayLists.Controls.Add(this.btnCrtMu3FrmPlyLst);
            this.tpSongsArtistPlayLists.Controls.Add(this.lblLibrarySongs);
            this.tpSongsArtistPlayLists.Controls.Add(this.dataGridView1);
            this.tpSongsArtistPlayLists.Controls.Add(this.dataGridView2);
            this.tpSongsArtistPlayLists.Controls.Add(this.btnExportPlayLists);
            this.tpSongsArtistPlayLists.Controls.Add(this.dataGridView3);
            this.tpSongsArtistPlayLists.Controls.Add(this.btnExportSongList);
            this.tpSongsArtistPlayLists.Controls.Add(this.btnReadLibraryFile);
            this.tpSongsArtistPlayLists.Location = new System.Drawing.Point(4, 22);
            this.tpSongsArtistPlayLists.Name = "tpSongsArtistPlayLists";
            this.tpSongsArtistPlayLists.Padding = new System.Windows.Forms.Padding(3);
            this.tpSongsArtistPlayLists.Size = new System.Drawing.Size(729, 486);
            this.tpSongsArtistPlayLists.TabIndex = 0;
            this.tpSongsArtistPlayLists.Text = "Songs Artists Playlists";
            this.tpSongsArtistPlayLists.UseVisualStyleBackColor = true;
            // 
            // lblLibraryPlaylistSongs
            // 
            this.lblLibraryPlaylistSongs.AutoSize = true;
            this.lblLibraryPlaylistSongs.Location = new System.Drawing.Point(5, 326);
            this.lblLibraryPlaylistSongs.Name = "lblLibraryPlaylistSongs";
            this.lblLibraryPlaylistSongs.Size = new System.Drawing.Size(72, 13);
            this.lblLibraryPlaylistSongs.TabIndex = 7;
            this.lblLibraryPlaylistSongs.Text = "Playlist Songs";
            // 
            // lblLibraryPlaylists
            // 
            this.lblLibraryPlaylists.AutoSize = true;
            this.lblLibraryPlaylists.Location = new System.Drawing.Point(5, 193);
            this.lblLibraryPlaylists.Name = "lblLibraryPlaylists";
            this.lblLibraryPlaylists.Size = new System.Drawing.Size(44, 13);
            this.lblLibraryPlaylists.TabIndex = 6;
            this.lblLibraryPlaylists.Text = "Playlists";
            // 
            // lblLibrarySongs
            // 
            this.lblLibrarySongs.AutoSize = true;
            this.lblLibrarySongs.Location = new System.Drawing.Point(7, 61);
            this.lblLibrarySongs.Name = "lblLibrarySongs";
            this.lblLibrarySongs.Size = new System.Drawing.Size(37, 13);
            this.lblLibrarySongs.TabIndex = 5;
            this.lblLibrarySongs.Text = "Songs";
            // 
            // tpItunesLibraryDbFunctions
            // 
            this.tpItunesLibraryDbFunctions.Controls.Add(this.btnSyncITunesWithMp3);
            this.tpItunesLibraryDbFunctions.Controls.Add(this.btnLoadItunesLibraryData);
            this.tpItunesLibraryDbFunctions.Controls.Add(this.btnRefreshDb);
            this.tpItunesLibraryDbFunctions.Controls.Add(this.ddtbDbFile);
            this.tpItunesLibraryDbFunctions.Controls.Add(this.label6);
            this.tpItunesLibraryDbFunctions.Controls.Add(this.lblPlaylistsdd);
            this.tpItunesLibraryDbFunctions.Location = new System.Drawing.Point(4, 22);
            this.tpItunesLibraryDbFunctions.Name = "tpItunesLibraryDbFunctions";
            this.tpItunesLibraryDbFunctions.Padding = new System.Windows.Forms.Padding(3);
            this.tpItunesLibraryDbFunctions.Size = new System.Drawing.Size(729, 486);
            this.tpItunesLibraryDbFunctions.TabIndex = 1;
            this.tpItunesLibraryDbFunctions.Text = "iTunes Library DB Functions";
            this.tpItunesLibraryDbFunctions.UseVisualStyleBackColor = true;
            // 
            // btnLoadItunesLibraryData
            // 
            this.btnLoadItunesLibraryData.Location = new System.Drawing.Point(7, 53);
            this.btnLoadItunesLibraryData.Name = "btnLoadItunesLibraryData";
            this.btnLoadItunesLibraryData.Size = new System.Drawing.Size(149, 23);
            this.btnLoadItunesLibraryData.TabIndex = 57;
            this.btnLoadItunesLibraryData.Text = "Load iTunes Library Data";
            this.btnLoadItunesLibraryData.UseVisualStyleBackColor = true;
            this.btnLoadItunesLibraryData.Click += new System.EventHandler(this.btnLoadItunesLibraryData_Click);
            // 
            // btnRefreshDb
            // 
            this.btnRefreshDb.Location = new System.Drawing.Point(603, 7);
            this.btnRefreshDb.Name = "btnRefreshDb";
            this.btnRefreshDb.Size = new System.Drawing.Size(113, 28);
            this.btnRefreshDb.TabIndex = 56;
            this.btnRefreshDb.Text = "Refresh Db File";
            this.btnRefreshDb.UseVisualStyleBackColor = true;
            this.btnRefreshDb.Click += new System.EventHandler(this.btnRefreshDb_Click);
            // 
            // ddtbDbFile
            // 
            this.ddtbDbFile.AllowDrop = true;
            this.ddtbDbFile.ButtonText = "Get DB File";
            this.ddtbDbFile.FileDialogTitle = null;
            this.ddtbDbFile.ItemFilters = null;
            this.ddtbDbFile.ItemText = "";
            this.ddtbDbFile.LeftRight = 40;
            this.ddtbDbFile.Location = new System.Drawing.Point(3, 6);
            this.ddtbDbFile.Name = "ddtbDbFile";
            this.ddtbDbFile.Size = new System.Drawing.Size(585, 29);
            this.ddtbDbFile.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "           ";
            // 
            // lblPlaylistsdd
            // 
            this.lblPlaylistsdd.AutoSize = true;
            this.lblPlaylistsdd.Location = new System.Drawing.Point(4, 6);
            this.lblPlaylistsdd.Name = "lblPlaylistsdd";
            this.lblPlaylistsdd.Size = new System.Drawing.Size(16, 13);
            this.lblPlaylistsdd.TabIndex = 7;
            this.lblPlaylistsdd.Text = "   ";
            // 
            // btnSyncITunesWithMp3
            // 
            this.btnSyncITunesWithMp3.Location = new System.Drawing.Point(567, 53);
            this.btnSyncITunesWithMp3.Name = "btnSyncITunesWithMp3";
            this.btnSyncITunesWithMp3.Size = new System.Drawing.Size(149, 23);
            this.btnSyncITunesWithMp3.TabIndex = 58;
            this.btnSyncITunesWithMp3.Text = "Sync Ituens With Mp3s";
            this.btnSyncITunesWithMp3.UseVisualStyleBackColor = true;
            this.btnSyncITunesWithMp3.Click += new System.EventHandler(this.btnSyncITunesWithMp3_Click);
            // 
            // FrmiTunesLibraryReader
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 643);
            this.Controls.Add(this.tabITunesLibrary);
            this.Controls.Add(this.ddtbITunesLibraryFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLibraryMusicPath);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.label13);
            this.Name = "FrmiTunesLibraryReader";
            this.Text = "FrmiTunesLibraryReader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTunesSongsBindingSource)).EndInit();
            this.tabITunesLibrary.ResumeLayout(false);
            this.tpSongsArtistPlayLists.ResumeLayout(false);
            this.tpSongsArtistPlayLists.PerformLayout();
            this.tpItunesLibraryDbFunctions.ResumeLayout(false);
            this.tpItunesLibraryDbFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReadLibraryFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource iTunesSongsBindingSource;
        private System.Windows.Forms.Button btnExportSongList;
        private System.Windows.Forms.Button btnExportPlayLists;
        private System.Windows.Forms.RichTextBox tbMessages;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCrtMu3FrmPlyLst;
        private System.Windows.Forms.TextBox tbLibraryMusicPath;
        private System.Windows.Forms.Label label2;
        private BCHControls.UCDragDropTextBox ddtbITunesLibraryFile;
        private BCHControls.UCDragDropDirTextBox dddtbOutputPath;
        private BCHControls.UCDragDropDirTextBox dddMusicDirPath;
        private System.Windows.Forms.TabControl tabITunesLibrary;
        private System.Windows.Forms.TabPage tpSongsArtistPlayLists;
        private System.Windows.Forms.Label lblLibraryPlaylistSongs;
        private System.Windows.Forms.Label lblLibraryPlaylists;
        private System.Windows.Forms.Label lblLibrarySongs;
        private System.Windows.Forms.TabPage tpItunesLibraryDbFunctions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlaylistsdd;
        private BCHControls.UCDragDropTextBox ddtbDbFile;
        private System.Windows.Forms.Button btnRefreshDb;
        private System.Windows.Forms.Button btnLoadItunesLibraryData;
        private System.Windows.Forms.Button btnSyncITunesWithMp3;
    }
}