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
            this.tbOutputFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportSongList = new System.Windows.Forms.Button();
            this.btnExportPlayLists = new System.Windows.Forms.Button();
            this.tbMessages = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCrtMu3FrmPlyLst = new System.Windows.Forms.Button();
            this.ucGetFilePath1 = new BCHControls.UCGetFilePath();
            this.iTunesSongsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDriveLetter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTunesSongsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadLibraryFile
            // 
            this.btnReadLibraryFile.Location = new System.Drawing.Point(801, 187);
            this.btnReadLibraryFile.Name = "btnReadLibraryFile";
            this.btnReadLibraryFile.Size = new System.Drawing.Size(111, 23);
            this.btnReadLibraryFile.TabIndex = 1;
            this.btnReadLibraryFile.Text = "Read Library File";
            this.btnReadLibraryFile.UseVisualStyleBackColor = true;
            this.btnReadLibraryFile.Click += new System.EventHandler(this.btnReadLibraryFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(51, 335);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(677, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(51, 511);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(677, 150);
            this.dataGridView3.TabIndex = 4;
            // 
            // tbOutputFilePath
            // 
            this.tbOutputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputFilePath.Location = new System.Drawing.Point(129, 67);
            this.tbOutputFilePath.Multiline = true;
            this.tbOutputFilePath.Name = "tbOutputFilePath";
            this.tbOutputFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbOutputFilePath.Size = new System.Drawing.Size(506, 38);
            this.tbOutputFilePath.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Output File Path";
            // 
            // btnExportSongList
            // 
            this.btnExportSongList.Location = new System.Drawing.Point(801, 227);
            this.btnExportSongList.Name = "btnExportSongList";
            this.btnExportSongList.Size = new System.Drawing.Size(156, 23);
            this.btnExportSongList.TabIndex = 26;
            this.btnExportSongList.Text = "Export Song List";
            this.btnExportSongList.UseVisualStyleBackColor = true;
            this.btnExportSongList.Click += new System.EventHandler(this.btnExportSongList_Click);
            // 
            // btnExportPlayLists
            // 
            this.btnExportPlayLists.Location = new System.Drawing.Point(801, 256);
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
            this.tbMessages.Location = new System.Drawing.Point(642, 23);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.Size = new System.Drawing.Size(407, 38);
            this.tbMessages.TabIndex = 131;
            this.tbMessages.Text = "";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(639, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 130;
            this.label13.Text = "Messages";
            // 
            // btnCrtMu3FrmPlyLst
            // 
            this.btnCrtMu3FrmPlyLst.Location = new System.Drawing.Point(801, 285);
            this.btnCrtMu3FrmPlyLst.Name = "btnCrtMu3FrmPlyLst";
            this.btnCrtMu3FrmPlyLst.Size = new System.Drawing.Size(156, 23);
            this.btnCrtMu3FrmPlyLst.TabIndex = 132;
            this.btnCrtMu3FrmPlyLst.Text = "Create MU3 From Plan List";
            this.btnCrtMu3FrmPlyLst.UseVisualStyleBackColor = true;
            this.btnCrtMu3FrmPlyLst.Click += new System.EventHandler(this.btnCrtMu3FrmPlyLst_Click);
            // 
            // ucGetFilePath1
            // 
            this.ucGetFilePath1.DialogTitle = null;
            this.ucGetFilePath1.FileName = "";
            this.ucGetFilePath1.Location = new System.Drawing.Point(12, 22);
            this.ucGetFilePath1.Name = "ucGetFilePath1";
            this.ucGetFilePath1.Size = new System.Drawing.Size(623, 39);
            this.ucGetFilePath1.TabIndex = 0;
            // 
            // iTunesSongsBindingSource
            // 
            this.iTunesSongsBindingSource.DataSource = typeof(MP3OrganizerBusinessLogic.iTunesSongs);
            // 
            // tbDriveLetter
            // 
            this.tbDriveLetter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDriveLetter.Location = new System.Drawing.Point(129, 111);
            this.tbDriveLetter.Multiline = true;
            this.tbDriveLetter.Name = "tbDriveLetter";
            this.tbDriveLetter.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDriveLetter.Size = new System.Drawing.Size(506, 38);
            this.tbDriveLetter.TabIndex = 133;
            this.tbDriveLetter.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 134;
            this.label2.Text = "Drive Letter";
            // 
            // FrmiTunesLibraryReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 711);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDriveLetter);
            this.Controls.Add(this.btnCrtMu3FrmPlyLst);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnExportPlayLists);
            this.Controls.Add(this.btnExportSongList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOutputFilePath);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReadLibraryFile);
            this.Controls.Add(this.ucGetFilePath1);
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

        private BCHControls.UCGetFilePath ucGetFilePath1;
        private System.Windows.Forms.Button btnReadLibraryFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource iTunesSongsBindingSource;
        private System.Windows.Forms.TextBox tbOutputFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportSongList;
        private System.Windows.Forms.Button btnExportPlayLists;
        private System.Windows.Forms.RichTextBox tbMessages;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCrtMu3FrmPlyLst;
        private System.Windows.Forms.TextBox tbDriveLetter;
        private System.Windows.Forms.Label label2;
    }
}