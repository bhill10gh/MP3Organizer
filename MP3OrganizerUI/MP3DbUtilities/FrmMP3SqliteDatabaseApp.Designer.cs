namespace MP3OrganizerUI
{
    partial class FrmMP3SqliteDatabaseApp
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblComment = new System.Windows.Forms.Label();
            this.ftComment = new BCHControls.UCFromTo();
            this.lblGenre = new System.Windows.Forms.Label();
            this.ftGenre = new BCHControls.UCFromTo();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.ftAlbum = new BCHControls.UCFromTo();
            this.lblFileName = new System.Windows.Forms.Label();
            this.ftFileName = new BCHControls.UCFromTo();
            this.lblArtist = new System.Windows.Forms.Label();
            this.ftArtist = new BCHControls.UCFromTo();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ftTitle = new BCHControls.UCFromTo();
            this.ucAddToListBox1 = new BCHControls.UCAddToListBox();
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
            this.btnRefreshDb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddtbMp3DbFile = new BCHControls.UCDragDropTextBox();
            this.gbSearch.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.gbAndOr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.pnlSearch);
            this.gbSearch.Controls.Add(this.ucAddToListBox1);
            this.gbSearch.Location = new System.Drawing.Point(12, 46);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(1183, 581);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.AutoScroll = true;
            this.pnlSearch.Controls.Add(this.lblComment);
            this.pnlSearch.Controls.Add(this.ftComment);
            this.pnlSearch.Controls.Add(this.lblGenre);
            this.pnlSearch.Controls.Add(this.ftGenre);
            this.pnlSearch.Controls.Add(this.lblAlbum);
            this.pnlSearch.Controls.Add(this.ftAlbum);
            this.pnlSearch.Controls.Add(this.lblFileName);
            this.pnlSearch.Controls.Add(this.ftFileName);
            this.pnlSearch.Controls.Add(this.lblArtist);
            this.pnlSearch.Controls.Add(this.ftArtist);
            this.pnlSearch.Controls.Add(this.lblTitle);
            this.pnlSearch.Controls.Add(this.ftTitle);
            this.pnlSearch.Location = new System.Drawing.Point(8, 19);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1166, 556);
            this.pnlSearch.TabIndex = 7;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(572, 377);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 17;
            this.lblComment.Text = "Comment";
            // 
            // ftComment
            // 
            this.ftComment.Location = new System.Drawing.Point(572, 365);
            this.ftComment.MaximumSize = new System.Drawing.Size(544, 187);
            this.ftComment.MinimumSize = new System.Drawing.Size(544, 187);
            this.ftComment.Name = "ftComment";
            this.ftComment.ShowMoveButtons = true;
            this.ftComment.ShowToListText = true;
            this.ftComment.Size = new System.Drawing.Size(544, 187);
            this.ftComment.TabIndex = 16;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(9, 377);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Genre";
            // 
            // ftGenre
            // 
            this.ftGenre.Location = new System.Drawing.Point(9, 365);
            this.ftGenre.MaximumSize = new System.Drawing.Size(544, 187);
            this.ftGenre.MinimumSize = new System.Drawing.Size(544, 187);
            this.ftGenre.Name = "ftGenre";
            this.ftGenre.ShowMoveButtons = true;
            this.ftGenre.ShowToListText = true;
            this.ftGenre.Size = new System.Drawing.Size(544, 187);
            this.ftGenre.TabIndex = 14;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(569, 189);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(36, 13);
            this.lblAlbum.TabIndex = 13;
            this.lblAlbum.Text = "Album";
            // 
            // ftAlbum
            // 
            this.ftAlbum.Location = new System.Drawing.Point(569, 189);
            this.ftAlbum.MaximumSize = new System.Drawing.Size(544, 187);
            this.ftAlbum.MinimumSize = new System.Drawing.Size(544, 187);
            this.ftAlbum.Name = "ftAlbum";
            this.ftAlbum.ShowMoveButtons = true;
            this.ftAlbum.ShowToListText = true;
            this.ftAlbum.Size = new System.Drawing.Size(544, 187);
            this.ftAlbum.TabIndex = 12;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 189);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(54, 13);
            this.lblFileName.TabIndex = 11;
            this.lblFileName.Text = "File Name";
            // 
            // ftFileName
            // 
            this.ftFileName.Location = new System.Drawing.Point(6, 189);
            this.ftFileName.MaximumSize = new System.Drawing.Size(544, 187);
            this.ftFileName.MinimumSize = new System.Drawing.Size(544, 187);
            this.ftFileName.Name = "ftFileName";
            this.ftFileName.ShowMoveButtons = true;
            this.ftFileName.ShowToListText = true;
            this.ftFileName.Size = new System.Drawing.Size(544, 187);
            this.ftFileName.TabIndex = 10;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(566, 10);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(30, 13);
            this.lblArtist.TabIndex = 9;
            this.lblArtist.Text = "Artist";
            // 
            // ftArtist
            // 
            this.ftArtist.Location = new System.Drawing.Point(566, 10);
            this.ftArtist.MaximumSize = new System.Drawing.Size(544, 187);
            this.ftArtist.MinimumSize = new System.Drawing.Size(544, 187);
            this.ftArtist.Name = "ftArtist";
            this.ftArtist.ShowMoveButtons = true;
            this.ftArtist.ShowToListText = true;
            this.ftArtist.Size = new System.Drawing.Size(544, 187);
            this.ftArtist.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title";
            // 
            // ftTitle
            // 
            this.ftTitle.Location = new System.Drawing.Point(3, 10);
            this.ftTitle.MaximumSize = new System.Drawing.Size(544, 187);
            this.ftTitle.MinimumSize = new System.Drawing.Size(544, 187);
            this.ftTitle.Name = "ftTitle";
            this.ftTitle.ShowMoveButtons = true;
            this.ftTitle.ShowToListText = true;
            this.ftTitle.Size = new System.Drawing.Size(544, 187);
            this.ftTitle.TabIndex = 6;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(19, 636);
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
            this.gbAndOr.Controls.Add(this.cbxUseLike);
            this.gbAndOr.Location = new System.Drawing.Point(142, 625);
            this.gbAndOr.Name = "gbAndOr";
            this.gbAndOr.Size = new System.Drawing.Size(198, 44);
            this.gbAndOr.TabIndex = 22;
            this.gbAndOr.TabStop = false;
            // 
            // rbOr
            // 
            this.rbOr.AutoSize = true;
            this.rbOr.Location = new System.Drawing.Point(144, 19);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 686);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1147, 103);
            this.dataGridView1.TabIndex = 23;
            // 
            // cbxUseLike
            // 
            this.cbxUseLike.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxUseLike.AutoSize = true;
            this.cbxUseLike.Location = new System.Drawing.Point(63, 19);
            this.cbxUseLike.Name = "cbxUseLike";
            this.cbxUseLike.Size = new System.Drawing.Size(68, 17);
            this.cbxUseLike.TabIndex = 24;
            this.cbxUseLike.Text = "Use Like";
            this.cbxUseLike.UseVisualStyleBackColor = true;
            // 
            // btnCreatePdbTableFile
            // 
            this.btnCreatePdbTableFile.Location = new System.Drawing.Point(488, 636);
            this.btnCreatePdbTableFile.Name = "btnCreatePdbTableFile";
            this.btnCreatePdbTableFile.Size = new System.Drawing.Size(118, 23);
            this.btnCreatePdbTableFile.TabIndex = 25;
            this.btnCreatePdbTableFile.Text = "Create PDB Table File";
            this.btnCreatePdbTableFile.UseVisualStyleBackColor = true;
            this.btnCreatePdbTableFile.Click += new System.EventHandler(this.btnCreatePdbTableFile_Click);
            // 
            // btnCreateM3U
            // 
            this.btnCreateM3U.Location = new System.Drawing.Point(361, 636);
            this.btnCreateM3U.Name = "btnCreateM3U";
            this.btnCreateM3U.Size = new System.Drawing.Size(108, 23);
            this.btnCreateM3U.TabIndex = 26;
            this.btnCreateM3U.Text = "Create M3U From Results";
            this.btnCreateM3U.UseVisualStyleBackColor = true;
            this.btnCreateM3U.Click += new System.EventHandler(this.btnCreateM3U_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbMessages.Location = new System.Drawing.Point(625, 644);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(534, 36);
            this.rtbMessages.TabIndex = 27;
            this.rtbMessages.Text = "";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search Results";
            // 
            // ddtbMp3DbFile
            // 
            this.ddtbMp3DbFile.AllowDrop = true;
            this.ddtbMp3DbFile.ButtonText = "Get Mp3 Db File";
            this.ddtbMp3DbFile.FileDialogTitle = null;
            this.ddtbMp3DbFile.ItemFilters = ".db";
            this.ddtbMp3DbFile.ItemText = "";
            this.ddtbMp3DbFile.LeftRight = 40;
            this.ddtbMp3DbFile.Location = new System.Drawing.Point(20, 12);
            this.ddtbMp3DbFile.Name = "ddtbMp3DbFile";
            this.ddtbMp3DbFile.Size = new System.Drawing.Size(804, 29);
            this.ddtbMp3DbFile.TabIndex = 35;
            // 
            // FrmMP3SqliteDatabaseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1207, 801);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefreshDb);
            this.Controls.Add(this.ddtbMp3DbFile);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnCreateM3U);
            this.Controls.Add(this.btnCreatePdbTableFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbAndOr);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbSearch);
            this.Name = "FrmMP3SqliteDatabaseApp";
            this.Text = "FrmMP3DatabaseApp";
            this.gbSearch.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.gbAndOr.ResumeLayout(false);
            this.gbAndOr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
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
        private BCHControls.UCFromTo ftTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private BCHControls.UCFromTo ftArtist;
        private System.Windows.Forms.Label lblComment;
        private BCHControls.UCFromTo ftComment;
        private System.Windows.Forms.Label lblGenre;
        private BCHControls.UCFromTo ftGenre;
        private System.Windows.Forms.Label lblAlbum;
        private BCHControls.UCFromTo ftAlbum;
        private System.Windows.Forms.Label lblFileName;
        private BCHControls.UCFromTo ftFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}