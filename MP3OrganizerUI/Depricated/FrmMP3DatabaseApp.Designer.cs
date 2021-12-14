namespace MP3OrganizerUI
{
    partial class FrmMP3DatabaseApp
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.ucatComment = new BCHControls.UCAddToListBox();
            this.ucatAlbum = new BCHControls.UCAddToListBox();
            this.ucatGenre = new BCHControls.UCAddToListBox();
            this.ucatFileName = new BCHControls.UCAddToListBox();
            this.ucAddToListBox1 = new BCHControls.UCAddToListBox();
            this.ucatArtists = new BCHControls.UCAddToListBox();
            this.ucatTitle = new BCHControls.UCAddToListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbAndOr = new System.Windows.Forms.GroupBox();
            this.rbOr = new System.Windows.Forms.RadioButton();
            this.rbAnd = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxUseLike = new System.Windows.Forms.CheckBox();
            this.btnCreatePdbTableFile = new System.Windows.Forms.Button();
            this.btnCreateM3U = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.ddtbMp3DbFile = new BCHControls.UCDragDropTextBox();
            this.btnRefreshDb = new System.Windows.Forms.Button();
            this.gbSearch.SuspendLayout();
            this.gbAndOr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.ucatComment);
            this.gbSearch.Controls.Add(this.ucatAlbum);
            this.gbSearch.Controls.Add(this.ucatGenre);
            this.gbSearch.Controls.Add(this.ucatFileName);
            this.gbSearch.Controls.Add(this.ucAddToListBox1);
            this.gbSearch.Controls.Add(this.ucatArtists);
            this.gbSearch.Controls.Add(this.ucatTitle);
            this.gbSearch.Location = new System.Drawing.Point(12, 45);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(952, 471);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // ucatComment
            // 
            this.ucatComment.AllowDupes = false;
            this.ucatComment.CaseSensitive = true;
            this.ucatComment.ListBoxSelectionMode = 2;
            this.ucatComment.Location = new System.Drawing.Point(646, 241);
            this.ucatComment.Name = "ucatComment";
            this.ucatComment.Size = new System.Drawing.Size(300, 225);
            this.ucatComment.TabIndex = 5;
            this.ucatComment.Title = "Comment Search";
            // 
            // ucatAlbum
            // 
            this.ucatAlbum.AllowDupes = false;
            this.ucatAlbum.CaseSensitive = true;
            this.ucatAlbum.ListBoxSelectionMode = 2;
            this.ucatAlbum.Location = new System.Drawing.Point(8, 241);
            this.ucatAlbum.Name = "ucatAlbum";
            this.ucatAlbum.Size = new System.Drawing.Size(300, 225);
            this.ucatAlbum.TabIndex = 4;
            this.ucatAlbum.Title = "Album Search";
            // 
            // ucatGenre
            // 
            this.ucatGenre.AllowDupes = false;
            this.ucatGenre.CaseSensitive = true;
            this.ucatGenre.ListBoxSelectionMode = 2;
            this.ucatGenre.Location = new System.Drawing.Point(325, 241);
            this.ucatGenre.Name = "ucatGenre";
            this.ucatGenre.Size = new System.Drawing.Size(300, 225);
            this.ucatGenre.TabIndex = 3;
            this.ucatGenre.Title = "Genre Search";
            // 
            // ucatFileName
            // 
            this.ucatFileName.AllowDupes = false;
            this.ucatFileName.CaseSensitive = true;
            this.ucatFileName.ListBoxSelectionMode = 2;
            this.ucatFileName.Location = new System.Drawing.Point(646, 19);
            this.ucatFileName.Name = "ucatFileName";
            this.ucatFileName.Size = new System.Drawing.Size(300, 225);
            this.ucatFileName.TabIndex = 2;
            this.ucatFileName.Title = "File Name Search";
            // 
            // ucAddToListBox1
            // 
            this.ucAddToListBox1.AllowDupes = false;
            this.ucAddToListBox1.CaseSensitive = true;
            this.ucAddToListBox1.ListBoxSelectionMode = 2;
            this.ucAddToListBox1.Location = new System.Drawing.Point(203, 103);
            this.ucAddToListBox1.Name = "ucAddToListBox1";
            this.ucAddToListBox1.Size = new System.Drawing.Size(0, 0);
            this.ucAddToListBox1.TabIndex = 1;
            this.ucAddToListBox1.Title = "Artist Search";
            // 
            // ucatArtists
            // 
            this.ucatArtists.AllowDupes = false;
            this.ucatArtists.CaseSensitive = true;
            this.ucatArtists.ListBoxSelectionMode = 2;
            this.ucatArtists.Location = new System.Drawing.Point(325, 19);
            this.ucatArtists.Name = "ucatArtists";
            this.ucatArtists.Size = new System.Drawing.Size(300, 225);
            this.ucatArtists.TabIndex = 1;
            this.ucatArtists.Title = "Artist Search";
            // 
            // ucatTitle
            // 
            this.ucatTitle.AllowDupes = false;
            this.ucatTitle.CaseSensitive = true;
            this.ucatTitle.ListBoxSelectionMode = 2;
            this.ucatTitle.Location = new System.Drawing.Point(8, 19);
            this.ucatTitle.Name = "ucatTitle";
            this.ucatTitle.Size = new System.Drawing.Size(300, 225);
            this.ucatTitle.TabIndex = 0;
            this.ucatTitle.Title = "Title Search";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 608);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbAndOr
            // 
            this.gbAndOr.Controls.Add(this.rbOr);
            this.gbAndOr.Controls.Add(this.rbAnd);
            this.gbAndOr.Location = new System.Drawing.Point(143, 597);
            this.gbAndOr.Name = "gbAndOr";
            this.gbAndOr.Size = new System.Drawing.Size(177, 44);
            this.gbAndOr.TabIndex = 22;
            this.gbAndOr.TabStop = false;
            this.gbAndOr.Text = "And Or";
            // 
            // rbOr
            // 
            this.rbOr.AutoSize = true;
            this.rbOr.Location = new System.Drawing.Point(56, 19);
            this.rbOr.Name = "rbOr";
            this.rbOr.Size = new System.Drawing.Size(36, 17);
            this.rbOr.TabIndex = 1;
            this.rbOr.Text = "Or";
            this.rbOr.UseVisualStyleBackColor = true;
            // 
            // rbAnd
            // 
            this.rbAnd.AutoSize = true;
            this.rbAnd.Checked = true;
            this.rbAnd.Location = new System.Drawing.Point(6, 19);
            this.rbAnd.Name = "rbAnd";
            this.rbAnd.Size = new System.Drawing.Size(44, 17);
            this.rbAnd.TabIndex = 0;
            this.rbAnd.TabStop = true;
            this.rbAnd.Text = "And";
            this.rbAnd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 742);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(931, 163);
            this.dataGridView1.TabIndex = 23;
            // 
            // cbxUseLike
            // 
            this.cbxUseLike.AutoSize = true;
            this.cbxUseLike.Location = new System.Drawing.Point(252, 616);
            this.cbxUseLike.Name = "cbxUseLike";
            this.cbxUseLike.Size = new System.Drawing.Size(68, 17);
            this.cbxUseLike.TabIndex = 24;
            this.cbxUseLike.Text = "Use Like";
            this.cbxUseLike.UseVisualStyleBackColor = true;
            // 
            // btnCreatePdbTableFile
            // 
            this.btnCreatePdbTableFile.Location = new System.Drawing.Point(489, 608);
            this.btnCreatePdbTableFile.Name = "btnCreatePdbTableFile";
            this.btnCreatePdbTableFile.Size = new System.Drawing.Size(118, 23);
            this.btnCreatePdbTableFile.TabIndex = 25;
            this.btnCreatePdbTableFile.Text = "Create PDB Table File";
            this.btnCreatePdbTableFile.UseVisualStyleBackColor = true;
            this.btnCreatePdbTableFile.Click += new System.EventHandler(this.btnCreatePdbTableFile_Click);
            // 
            // btnCreateM3U
            // 
            this.btnCreateM3U.Location = new System.Drawing.Point(362, 608);
            this.btnCreateM3U.Name = "btnCreateM3U";
            this.btnCreateM3U.Size = new System.Drawing.Size(108, 23);
            this.btnCreateM3U.TabIndex = 26;
            this.btnCreateM3U.Text = "Create M3U From Results";
            this.btnCreateM3U.UseVisualStyleBackColor = true;
            this.btnCreateM3U.Click += new System.EventHandler(this.btnCreateM3U_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(15, 640);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(928, 96);
            this.rtbMessages.TabIndex = 27;
            this.rtbMessages.Text = "";
            // 
            // ddtbMp3DbFile
            // 
            this.ddtbMp3DbFile.AllowDrop = true;
            this.ddtbMp3DbFile.ButtonText = "Get Mp3 Db File";
            this.ddtbMp3DbFile.FileDialogTitle = null;
            this.ddtbMp3DbFile.ItemFilters = "mdb";
            this.ddtbMp3DbFile.ItemText = "";
            this.ddtbMp3DbFile.LeftRight = 40;
            this.ddtbMp3DbFile.Location = new System.Drawing.Point(20, 12);
            this.ddtbMp3DbFile.Name = "ddtbMp3DbFile";
            this.ddtbMp3DbFile.Size = new System.Drawing.Size(804, 29);
            this.ddtbMp3DbFile.TabIndex = 35;
            // 
            // btnRefreshDb
            // 
            this.btnRefreshDb.Location = new System.Drawing.Point(830, 16);
            this.btnRefreshDb.Name = "btnRefreshDb";
            this.btnRefreshDb.Size = new System.Drawing.Size(113, 23);
            this.btnRefreshDb.TabIndex = 36;
            this.btnRefreshDb.Text = "Refresh Db File";
            this.btnRefreshDb.UseVisualStyleBackColor = true;
            this.btnRefreshDb.Click += new System.EventHandler(this.btnRefreshDb_Click);
            // 
            // FrmMP3DatabaseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 917);
            this.Controls.Add(this.btnRefreshDb);
            this.Controls.Add(this.ddtbMp3DbFile);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnCreateM3U);
            this.Controls.Add(this.btnCreatePdbTableFile);
            this.Controls.Add(this.cbxUseLike);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbAndOr);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbSearch);
            this.Name = "FrmMP3DatabaseApp";
            this.Text = "FrmMP3DatabaseApp";
            this.gbSearch.ResumeLayout(false);
            this.gbAndOr.ResumeLayout(false);
            this.gbAndOr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private BCHControls.UCAddToListBox ucatTitle;
        private BCHControls.UCAddToListBox ucatComment;
        private BCHControls.UCAddToListBox ucatAlbum;
        private BCHControls.UCAddToListBox ucatGenre;
        private BCHControls.UCAddToListBox ucatFileName;
        private BCHControls.UCAddToListBox ucatArtists;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSearch;
        private BCHControls.UCAddToListBox ucAddToListBox1;
        private System.Windows.Forms.GroupBox gbAndOr;
        private System.Windows.Forms.RadioButton rbOr;
        private System.Windows.Forms.RadioButton rbAnd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbxUseLike;
        private System.Windows.Forms.Button btnCreatePdbTableFile;
        private System.Windows.Forms.Button btnCreateM3U;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private BCHControls.UCDragDropTextBox ddtbMp3DbFile;
        private System.Windows.Forms.Button btnRefreshDb;
    }
}