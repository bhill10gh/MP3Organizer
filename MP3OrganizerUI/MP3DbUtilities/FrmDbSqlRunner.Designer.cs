using BCHControls;
using BCHFramework;
using MP3OrganizerBusinessLogic;
using MP3OrganizerUI.Controls;



namespace MP3OrganizerUI
{
    partial class FrmDbSqlRunner
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
            this.ucResultDisplay1 = new BCHControls.UCResultDisplay();
            this.lbFromSnipits = new System.Windows.Forms.ListBox();
            this.ucDatabaseFile1 = new MP3OrganizerUI.Controls.UCDatabaseFile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqlResults)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbSql
            // 
            this.rtbSql.Location = new System.Drawing.Point(123, 69);
            this.rtbSql.Name = "rtbSql";
            this.rtbSql.Size = new System.Drawing.Size(435, 172);
            this.rtbSql.TabIndex = 0;
            this.rtbSql.Text = "";
            // 
            // lbTables
            // 
            this.lbTables.FormattingEnabled = true;
            this.lbTables.Location = new System.Drawing.Point(583, 69);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(191, 69);
            this.lbTables.TabIndex = 1;
            this.lbTables.SelectedIndexChanged += new System.EventHandler(this.lbTables_SelectedIndexChanged);
            this.lbTables.DoubleClick += new System.EventHandler(this.lbTables_DoubleClick);
            // 
            // lbColumns
            // 
            this.lbColumns.FormattingEnabled = true;
            this.lbColumns.Location = new System.Drawing.Point(583, 172);
            this.lbColumns.Name = "lbColumns";
            this.lbColumns.Size = new System.Drawing.Size(191, 69);
            this.lbColumns.TabIndex = 2;
            this.lbColumns.DoubleClick += new System.EventHandler(this.lbColumns_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL";
            // 
            // dgvSqlResults
            // 
            this.dgvSqlResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSqlResults.Location = new System.Drawing.Point(123, 405);
            this.dgvSqlResults.Name = "dgvSqlResults";
            this.dgvSqlResults.Size = new System.Drawing.Size(651, 181);
            this.dgvSqlResults.TabIndex = 6;
            // 
            // btnExecuteSql
            // 
            this.btnExecuteSql.Location = new System.Drawing.Point(3, 85);
            this.btnExecuteSql.Name = "btnExecuteSql";
            this.btnExecuteSql.Size = new System.Drawing.Size(75, 23);
            this.btnExecuteSql.TabIndex = 7;
            this.btnExecuteSql.Text = "Execute SQL";
            this.btnExecuteSql.UseVisualStyleBackColor = true;
            this.btnExecuteSql.Click += new System.EventHandler(this.btnExecuteSql_Click);
            // 
            // ucResultDisplay1
            // 
            this.ucResultDisplay1.DisplayText = "";
            this.ucResultDisplay1.Location = new System.Drawing.Point(583, 277);
            this.ucResultDisplay1.Name = "ucResultDisplay1";
            this.ucResultDisplay1.Size = new System.Drawing.Size(191, 102);
            this.ucResultDisplay1.TabIndex = 8;
            // 
            // lbFromSnipits
            // 
            this.lbFromSnipits.FormattingEnabled = true;
            this.lbFromSnipits.Items.AddRange(new object[] {
            "From tbMp3Info and tbArtist ",
            "From tbMp3Info and tbFileInfo",
            "From tbMp3Info and tbArtist  and tbFileInfo"});
            this.lbFromSnipits.Location = new System.Drawing.Point(235, 277);
            this.lbFromSnipits.Name = "lbFromSnipits";
            this.lbFromSnipits.Size = new System.Drawing.Size(287, 69);
            this.lbFromSnipits.TabIndex = 9;
            this.lbFromSnipits.SelectedIndexChanged += new System.EventHandler(this.lbFromSnipits_SelectedIndexChanged);
            // 
            // ucDatabaseFile1
            // 
            this.ucDatabaseFile1.AllowDrop = true;
            this.ucDatabaseFile1.Location = new System.Drawing.Point(3, 12);
            this.ucDatabaseFile1.MP3DBExists = false;
            this.ucDatabaseFile1.MP3DBFileName = "";
            this.ucDatabaseFile1.Name = "ucDatabaseFile1";
            this.ucDatabaseFile1.Size = new System.Drawing.Size(555, 45);
            this.ucDatabaseFile1.TabIndex = 5;
            this.ucDatabaseFile1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ucDatabaseFile1_DragDrop);
            this.ucDatabaseFile1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ucDatabaseFile1_DragEnter);
            // 
            // FrmDbSqlRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 628);
            this.Controls.Add(this.lbFromSnipits);
            this.Controls.Add(this.ucResultDisplay1);
            this.Controls.Add(this.btnExecuteSql);
            this.Controls.Add(this.dgvSqlResults);
            this.Controls.Add(this.ucDatabaseFile1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbColumns);
            this.Controls.Add(this.lbTables);
            this.Controls.Add(this.rtbSql);
            this.Name = "FrmDbSqlRunner";
            this.Text = "FrmDbSqlRunner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqlResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSql;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.ListBox lbColumns;
        private System.Windows.Forms.Label label1;
        private UCDatabaseFile ucDatabaseFile1;
        private System.Windows.Forms.DataGridView dgvSqlResults;
        private System.Windows.Forms.Button btnExecuteSql;
        private UCResultDisplay ucResultDisplay1;
        private System.Windows.Forms.ListBox lbFromSnipits;
    }
}