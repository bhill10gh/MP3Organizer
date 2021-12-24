using BCHControls;
using BCHFramework;
using MP3OrganizerBusinessLogic;
using MP3OrganizerUI.Controls;



namespace MP3OrganizerUI
{
    partial class FrmDbSqliteRunner
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
            this.rtbSql = new System.Windows.Forms.RichTextBox();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.lbColumns = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSqlResults = new System.Windows.Forms.DataGridView();
            this.btnExecuteSql = new System.Windows.Forms.Button();
            this.lbFromSnipits = new System.Windows.Forms.ListBox();
            this.btnRefreshDb = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.ddtbMp3DbFile = new BCHControls.UCDragDropTextBox();
            this.lbSqlStatements = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqlResults)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbSql
            // 
            this.rtbSql.Location = new System.Drawing.Point(12, 53);
            this.rtbSql.Name = "rtbSql";
            this.rtbSql.Size = new System.Drawing.Size(546, 296);
            this.rtbSql.TabIndex = 0;
            this.rtbSql.Text = "";
            // 
            // lbTables
            // 
            this.lbTables.FormattingEnabled = true;
            this.lbTables.Location = new System.Drawing.Point(564, 53);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(215, 69);
            this.lbTables.TabIndex = 1;
            this.lbTables.SelectedIndexChanged += new System.EventHandler(this.lbTables_SelectedIndexChanged);
            this.lbTables.DoubleClick += new System.EventHandler(this.lbTables_DoubleClick);
            // 
            // lbColumns
            // 
            this.lbColumns.FormattingEnabled = true;
            this.lbColumns.Location = new System.Drawing.Point(564, 128);
            this.lbColumns.Name = "lbColumns";
            this.lbColumns.Size = new System.Drawing.Size(215, 69);
            this.lbColumns.TabIndex = 2;
            this.lbColumns.DoubleClick += new System.EventHandler(this.lbColumns_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL";
            // 
            // dgvSqlResults
            // 
            this.dgvSqlResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSqlResults.Location = new System.Drawing.Point(12, 413);
            this.dgvSqlResults.Name = "dgvSqlResults";
            this.dgvSqlResults.Size = new System.Drawing.Size(767, 181);
            this.dgvSqlResults.TabIndex = 6;
            // 
            // btnExecuteSql
            // 
            this.btnExecuteSql.Location = new System.Drawing.Point(12, 361);
            this.btnExecuteSql.Name = "btnExecuteSql";
            this.btnExecuteSql.Size = new System.Drawing.Size(75, 23);
            this.btnExecuteSql.TabIndex = 7;
            this.btnExecuteSql.Text = "Execute SQL";
            this.btnExecuteSql.UseVisualStyleBackColor = true;
            this.btnExecuteSql.Click += new System.EventHandler(this.btnExecuteSql_Click);
            // 
            // lbFromSnipits
            // 
            this.lbFromSnipits.FormattingEnabled = true;
            this.lbFromSnipits.Items.AddRange(new object[] {
            "From tbMp3Info and tbArtist ",
            "From tbMp3Info and tbFileInfo",
            "From tbMp3Info and tbArtist  and tbFileInfo",
            "From tbItunesPlaylist and tbItunesPlaylistSong and tbItunesSong",
            "From tbItunesSong and tbFileInfo"});
            this.lbFromSnipits.Location = new System.Drawing.Point(564, 203);
            this.lbFromSnipits.Name = "lbFromSnipits";
            this.lbFromSnipits.Size = new System.Drawing.Size(215, 69);
            this.lbFromSnipits.TabIndex = 9;
            this.lbFromSnipits.SelectedIndexChanged += new System.EventHandler(this.lbFromSnipits_SelectedIndexChanged);
            // 
            // btnRefreshDb
            // 
            this.btnRefreshDb.Location = new System.Drawing.Point(666, 12);
            this.btnRefreshDb.Name = "btnRefreshDb";
            this.btnRefreshDb.Size = new System.Drawing.Size(113, 23);
            this.btnRefreshDb.TabIndex = 37;
            this.btnRefreshDb.Text = "Refresh Db File";
            this.btnRefreshDb.UseVisualStyleBackColor = true;
            this.btnRefreshDb.Click += new System.EventHandler(this.btnRefreshDb_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(15, 394);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 38;
            this.lblResults.Text = "Results";
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbMessages.Location = new System.Drawing.Point(93, 361);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(686, 46);
            this.rtbMessages.TabIndex = 39;
            this.rtbMessages.Text = "";
            // 
            // ddtbMp3DbFile
            // 
            this.ddtbMp3DbFile.AllowDrop = true;
            this.ddtbMp3DbFile.ButtonText = "Get Mp3 Db File";
            this.ddtbMp3DbFile.FileDialogTitle = null;
            this.ddtbMp3DbFile.ItemFilters = ".db";
            this.ddtbMp3DbFile.ItemText = "";
            this.ddtbMp3DbFile.LeftRight = 40;
            this.ddtbMp3DbFile.Location = new System.Drawing.Point(10, 9);
            this.ddtbMp3DbFile.Name = "ddtbMp3DbFile";
            this.ddtbMp3DbFile.Size = new System.Drawing.Size(650, 29);
            this.ddtbMp3DbFile.TabIndex = 34;
            // 
            // lbSqlStatements
            // 
            this.lbSqlStatements.FormattingEnabled = true;
            this.lbSqlStatements.Location = new System.Drawing.Point(564, 280);
            this.lbSqlStatements.Name = "lbSqlStatements";
            this.lbSqlStatements.Size = new System.Drawing.Size(215, 69);
            this.lbSqlStatements.TabIndex = 40;
            this.lbSqlStatements.DoubleClick += new System.EventHandler(this.lbSqlStatements_DoubleClick);
            // 
            // FrmDbSqliteRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 598);
            this.Controls.Add(this.lbSqlStatements);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnRefreshDb);
            this.Controls.Add(this.ddtbMp3DbFile);
            this.Controls.Add(this.lbFromSnipits);
            this.Controls.Add(this.btnExecuteSql);
            this.Controls.Add(this.dgvSqlResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbColumns);
            this.Controls.Add(this.lbTables);
            this.Controls.Add(this.rtbSql);
            this.Name = "FrmDbSqliteRunner";
            this.Text = "FrmDbSqliteRunner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqlResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSql;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.ListBox lbColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSqlResults;
        private System.Windows.Forms.Button btnExecuteSql;
        private System.Windows.Forms.ListBox lbFromSnipits;
        private UCDragDropTextBox ddtbMp3DbFile;
        private System.Windows.Forms.Button btnRefreshDb;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.ListBox lbSqlStatements;
    }
}