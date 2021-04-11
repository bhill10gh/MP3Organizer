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
            this.tbMP3DBFile = new System.Windows.Forms.TextBox();
            this.btnGetMP3DBFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbAndOr = new System.Windows.Forms.GroupBox();
            this.rbOr = new System.Windows.Forms.RadioButton();
            this.rbAnd = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxUseLike = new System.Windows.Forms.CheckBox();
            this.btnCreatePdbTableFile = new System.Windows.Forms.Button();
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
            this.gbSearch.Location = new System.Drawing.Point(12, 77);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(952, 250);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // ucatComment
            // 
            this.ucatComment.AllowDupes = false;
            this.ucatComment.CaseSensitive = true;
            this.ucatComment.ListBoxSelectionMode = 2;
            this.ucatComment.Location = new System.Drawing.Point(788, 19);
            this.ucatComment.Name = "ucatComment";
            this.ucatComment.Size = new System.Drawing.Size(150, 225);
            this.ucatComment.TabIndex = 5;
            this.ucatComment.Title = "Comment Search";
            // 
            // ucatAlbum
            // 
            this.ucatAlbum.AllowDupes = false;
            this.ucatAlbum.CaseSensitive = true;
            this.ucatAlbum.ListBoxSelectionMode = 2;
            this.ucatAlbum.Location = new System.Drawing.Point(476, 19);
            this.ucatAlbum.Name = "ucatAlbum";
            this.ucatAlbum.Size = new System.Drawing.Size(150, 225);
            this.ucatAlbum.TabIndex = 4;
            this.ucatAlbum.Title = "Album Search";
            // 
            // ucatGenre
            // 
            this.ucatGenre.AllowDupes = false;
            this.ucatGenre.CaseSensitive = true;
            this.ucatGenre.ListBoxSelectionMode = 2;
            this.ucatGenre.Location = new System.Drawing.Point(632, 19);
            this.ucatGenre.Name = "ucatGenre";
            this.ucatGenre.Size = new System.Drawing.Size(150, 225);
            this.ucatGenre.TabIndex = 3;
            this.ucatGenre.Title = "Genre Search";
            // 
            // ucatFileName
            // 
            this.ucatFileName.AllowDupes = false;
            this.ucatFileName.CaseSensitive = true;
            this.ucatFileName.ListBoxSelectionMode = 2;
            this.ucatFileName.Location = new System.Drawing.Point(320, 19);
            this.ucatFileName.Name = "ucatFileName";
            this.ucatFileName.Size = new System.Drawing.Size(150, 225);
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
            this.ucatArtists.Location = new System.Drawing.Point(164, 19);
            this.ucatArtists.Name = "ucatArtists";
            this.ucatArtists.Size = new System.Drawing.Size(150, 225);
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
            this.ucatTitle.Size = new System.Drawing.Size(150, 225);
            this.ucatTitle.TabIndex = 0;
            this.ucatTitle.Title = "Title Search";
            // 
            // tbMP3DBFile
            // 
            this.tbMP3DBFile.Location = new System.Drawing.Point(150, 14);
            this.tbMP3DBFile.Multiline = true;
            this.tbMP3DBFile.Name = "tbMP3DBFile";
            this.tbMP3DBFile.ReadOnly = true;
            this.tbMP3DBFile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbMP3DBFile.Size = new System.Drawing.Size(670, 33);
            this.tbMP3DBFile.TabIndex = 19;
            // 
            // btnGetMP3DBFile
            // 
            this.btnGetMP3DBFile.Location = new System.Drawing.Point(12, 12);
            this.btnGetMP3DBFile.Name = "btnGetMP3DBFile";
            this.btnGetMP3DBFile.Size = new System.Drawing.Size(112, 23);
            this.btnGetMP3DBFile.TabIndex = 18;
            this.btnGetMP3DBFile.Text = "Get MP3 DB File";
            this.btnGetMP3DBFile.UseVisualStyleBackColor = true;
            this.btnGetMP3DBFile.Click += new System.EventHandler(this.btnGetMP3DBFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(12, 383);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(828, 160);
            this.lbResults.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 333);
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
            this.gbAndOr.Location = new System.Drawing.Point(136, 333);
            this.gbAndOr.Name = "gbAndOr";
            this.gbAndOr.Size = new System.Drawing.Size(119, 44);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(933, 188);
            this.dataGridView1.TabIndex = 23;
            // 
            // cbxUseLike
            // 
            this.cbxUseLike.AutoSize = true;
            this.cbxUseLike.Location = new System.Drawing.Point(245, 352);
            this.cbxUseLike.Name = "cbxUseLike";
            this.cbxUseLike.Size = new System.Drawing.Size(68, 17);
            this.cbxUseLike.TabIndex = 24;
            this.cbxUseLike.Text = "Use Like";
            this.cbxUseLike.UseVisualStyleBackColor = true;
            // 
            // btnCreatePdbTableFile
            // 
            this.btnCreatePdbTableFile.Location = new System.Drawing.Point(349, 352);
            this.btnCreatePdbTableFile.Name = "btnCreatePdbTableFile";
            this.btnCreatePdbTableFile.Size = new System.Drawing.Size(118, 23);
            this.btnCreatePdbTableFile.TabIndex = 25;
            this.btnCreatePdbTableFile.Text = "Create PDB Table File";
            this.btnCreatePdbTableFile.UseVisualStyleBackColor = true;
            this.btnCreatePdbTableFile.Click += new System.EventHandler(this.btnCreatePdbTableFile_Click);
            // 
            // FrmMP3DatabaseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 583);
            this.Controls.Add(this.btnCreatePdbTableFile);
            this.Controls.Add(this.cbxUseLike);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbAndOr);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.tbMP3DBFile);
            this.Controls.Add(this.btnGetMP3DBFile);
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
        private System.Windows.Forms.TextBox tbMP3DBFile;
        private System.Windows.Forms.Button btnGetMP3DBFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnSearch;
        private BCHControls.UCAddToListBox ucAddToListBox1;
        private System.Windows.Forms.GroupBox gbAndOr;
        private System.Windows.Forms.RadioButton rbOr;
        private System.Windows.Forms.RadioButton rbAnd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbxUseLike;
        private System.Windows.Forms.Button btnCreatePdbTableFile;
    }
}