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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTunesSongsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadLibraryFile
            // 
            this.btnReadLibraryFile.Location = new System.Drawing.Point(749, 157);
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
            this.dataGridView1.Location = new System.Drawing.Point(51, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(51, 336);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(677, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(51, 512);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(677, 150);
            this.dataGridView3.TabIndex = 4;
            // 
            // btnExportSongList
            // 
            this.btnExportSongList.Location = new System.Drawing.Point(749, 186);
            this.btnExportSongList.Name = "btnExportSongList";
            this.btnExportSongList.Size = new System.Drawing.Size(156, 23);
            this.btnExportSongList.TabIndex = 26;
            this.btnExportSongList.Text = "Export Song List";
            this.btnExportSongList.UseVisualStyleBackColor = true;
            this.btnExportSongList.Click += new System.EventHandler(this.btnExportSongList_Click);
            // 
            // btnExportPlayLists
            // 
            this.btnExportPlayLists.Location = new System.Drawing.Point(749, 215);
            this.btnExportPlayLists.Name = "btnExportPlayLists";
            this.btnExportPlayLists.Size = new System.Drawing.Size(156, 23);
            this.btnExportPlayLists.TabIndex = 27;
            this.btnExportPlayLists.Text = "Export Play List";
            this.btnExportPlayLists.UseVisualStyleBackColor = true;
            this.btnExportPlayLists.Click += new System.EventHandler(this.btnExportPlayLists_Click);
            // 
            // tbMessages
            // 
            this.tbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessages.Location = new System.Drawing.Point(734, 38);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.Size = new System.Drawing.Size(313, 101);
            this.tbMessages.TabIndex = 131;
            this.tbMessages.Text = "";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(733, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 130;
            this.label13.Text = "Messages";
            // 
            // btnCrtMu3FrmPlyLst
            // 
            this.btnCrtMu3FrmPlyLst.Location = new System.Drawing.Point(749, 244);
            this.btnCrtMu3FrmPlyLst.Name = "btnCrtMu3FrmPlyLst";
            this.btnCrtMu3FrmPlyLst.Size = new System.Drawing.Size(156, 23);
            this.btnCrtMu3FrmPlyLst.TabIndex = 132;
            this.btnCrtMu3FrmPlyLst.Text = "Create MU3 From Plan List";
            this.btnCrtMu3FrmPlyLst.UseVisualStyleBackColor = true;
            this.btnCrtMu3FrmPlyLst.Click += new System.EventHandler(this.btnCrtMu3FrmPlyLst_Click);
            // 
            // tbLibraryMusicPath
            // 
            this.tbLibraryMusicPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLibraryMusicPath.Location = new System.Drawing.Point(153, 104);
            this.tbLibraryMusicPath.Multiline = true;
            this.tbLibraryMusicPath.Name = "tbLibraryMusicPath";
            this.tbLibraryMusicPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbLibraryMusicPath.Size = new System.Drawing.Size(575, 20);
            this.tbLibraryMusicPath.TabIndex = 133;
            this.tbLibraryMusicPath.Text = "C:\\Barry Hill\\My Music\\Music";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 107);
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
            this.ddtbITunesLibraryFile.Location = new System.Drawing.Point(12, 22);
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
            this.dddtbOutputPath.Location = new System.Drawing.Point(6, 48);
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
            this.dddMusicDirPath.Location = new System.Drawing.Point(6, 71);
            this.dddMusicDirPath.Name = "dddMusicDirPath";
            this.dddMusicDirPath.Size = new System.Drawing.Size(722, 27);
            this.dddMusicDirPath.TabIndex = 138;
            // 
            // FrmiTunesLibraryReader
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 671);
            this.Controls.Add(this.dddMusicDirPath);
            this.Controls.Add(this.dddtbOutputPath);
            this.Controls.Add(this.ddtbITunesLibraryFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLibraryMusicPath);
            this.Controls.Add(this.btnCrtMu3FrmPlyLst);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnExportPlayLists);
            this.Controls.Add(this.btnExportSongList);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReadLibraryFile);
            this.Name = "FrmiTunesLibraryReader";
            this.Text = "FrmiTunesLibraryReader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTunesSongsBindingSource)).EndInit();
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
    }
}