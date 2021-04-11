namespace MP3OrganizerUI
{
    partial class FrmBCHUnformatedMp3Files
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
            this.tbMP3RootDir = new System.Windows.Forms.TextBox();
            this.btnGetMP3RootDir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetAllUnFormatedMp3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbBadFileCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateFiles = new System.Windows.Forms.Button();
            this.btnInsertDash = new System.Windows.Forms.Button();
            this.ckbUpdateTagInfo = new System.Windows.Forms.CheckBox();
            this.ckbUseDirInfo = new System.Windows.Forms.CheckBox();
            this.ckbWithNoDblDash = new System.Windows.Forms.CheckBox();
            this.ckbWithNoDash = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMP3RootDir
            // 
            this.tbMP3RootDir.Location = new System.Drawing.Point(202, 12);
            this.tbMP3RootDir.Multiline = true;
            this.tbMP3RootDir.Name = "tbMP3RootDir";
            this.tbMP3RootDir.ReadOnly = true;
            this.tbMP3RootDir.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbMP3RootDir.Size = new System.Drawing.Size(478, 33);
            this.tbMP3RootDir.TabIndex = 15;
            this.tbMP3RootDir.Text = "H:\\Barry Hill\\Audio Visual\\MusicTest";
            // 
            // btnGetMP3RootDir
            // 
            this.btnGetMP3RootDir.Location = new System.Drawing.Point(12, 12);
            this.btnGetMP3RootDir.Name = "btnGetMP3RootDir";
            this.btnGetMP3RootDir.Size = new System.Drawing.Size(149, 23);
            this.btnGetMP3RootDir.TabIndex = 14;
            this.btnGetMP3RootDir.Text = "Get MP3 Root Dir";
            this.btnGetMP3RootDir.UseVisualStyleBackColor = true;
            this.btnGetMP3RootDir.Click += new System.EventHandler(this.btnGetMP3RootDir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(461, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "File Format: Artist 1-Artist 2-..Artist n[-Track #]--Song Title[~Numeration][_Com" +
                "ments].mp3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            // 
            // btnGetAllUnFormatedMp3
            // 
            this.btnGetAllUnFormatedMp3.Location = new System.Drawing.Point(12, 42);
            this.btnGetAllUnFormatedMp3.Name = "btnGetAllUnFormatedMp3";
            this.btnGetAllUnFormatedMp3.Size = new System.Drawing.Size(149, 23);
            this.btnGetAllUnFormatedMp3.TabIndex = 21;
            this.btnGetAllUnFormatedMp3.Text = "Get All Unformated MP3\'s";
            this.btnGetAllUnFormatedMp3.UseVisualStyleBackColor = true;
            this.btnGetAllUnFormatedMp3.Click += new System.EventHandler(this.btnGetAllUnFormatedMp3_Click);
            // 
            // tbBadFileCount
            // 
            this.tbBadFileCount.Location = new System.Drawing.Point(695, 96);
            this.tbBadFileCount.Name = "tbBadFileCount";
            this.tbBadFileCount.ReadOnly = true;
            this.tbBadFileCount.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbBadFileCount.Size = new System.Drawing.Size(81, 20);
            this.tbBadFileCount.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bad File Count";
            // 
            // btnUpdateFiles
            // 
            this.btnUpdateFiles.Location = new System.Drawing.Point(202, 94);
            this.btnUpdateFiles.Name = "btnUpdateFiles";
            this.btnUpdateFiles.Size = new System.Drawing.Size(149, 23);
            this.btnUpdateFiles.TabIndex = 24;
            this.btnUpdateFiles.Text = "Update MP3\'s";
            this.btnUpdateFiles.UseVisualStyleBackColor = true;
            this.btnUpdateFiles.Click += new System.EventHandler(this.btnUpdateFiles_Click);
            // 
            // btnInsertDash
            // 
            this.btnInsertDash.Location = new System.Drawing.Point(12, 94);
            this.btnInsertDash.Name = "btnInsertDash";
            this.btnInsertDash.Size = new System.Drawing.Size(149, 23);
            this.btnInsertDash.TabIndex = 25;
            this.btnInsertDash.Text = "Insert Dash";
            this.btnInsertDash.UseVisualStyleBackColor = true;
            this.btnInsertDash.Click += new System.EventHandler(this.btnInsertDash_Click);
            // 
            // ckbUpdateTagInfo
            // 
            this.ckbUpdateTagInfo.AutoSize = true;
            this.ckbUpdateTagInfo.Checked = true;
            this.ckbUpdateTagInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUpdateTagInfo.Location = new System.Drawing.Point(358, 96);
            this.ckbUpdateTagInfo.Name = "ckbUpdateTagInfo";
            this.ckbUpdateTagInfo.Size = new System.Drawing.Size(104, 17);
            this.ckbUpdateTagInfo.TabIndex = 26;
            this.ckbUpdateTagInfo.Text = "Update Tag Info";
            this.ckbUpdateTagInfo.UseVisualStyleBackColor = true;
            // 
            // ckbUseDirInfo
            // 
            this.ckbUseDirInfo.AutoSize = true;
            this.ckbUseDirInfo.Checked = true;
            this.ckbUseDirInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseDirInfo.Location = new System.Drawing.Point(485, 96);
            this.ckbUseDirInfo.Name = "ckbUseDirInfo";
            this.ckbUseDirInfo.Size = new System.Drawing.Size(76, 17);
            this.ckbUseDirInfo.TabIndex = 27;
            this.ckbUseDirInfo.Text = "UseDirInfo";
            this.ckbUseDirInfo.UseVisualStyleBackColor = true;
            // 
            // ckbWithNoDblDash
            // 
            this.ckbWithNoDblDash.AutoSize = true;
            this.ckbWithNoDblDash.Checked = true;
            this.ckbWithNoDblDash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbWithNoDblDash.Location = new System.Drawing.Point(12, 71);
            this.ckbWithNoDblDash.Name = "ckbWithNoDblDash";
            this.ckbWithNoDblDash.Size = new System.Drawing.Size(84, 17);
            this.ckbWithNoDblDash.TabIndex = 28;
            this.ckbWithNoDblDash.Text = "With No \"--\"";
            this.ckbWithNoDblDash.UseVisualStyleBackColor = true;
            // 
            // ckbWithNoDash
            // 
            this.ckbWithNoDash.AutoSize = true;
            this.ckbWithNoDash.Location = new System.Drawing.Point(102, 71);
            this.ckbWithNoDash.Name = "ckbWithNoDash";
            this.ckbWithNoDash.Size = new System.Drawing.Size(93, 17);
            this.ckbWithNoDash.TabIndex = 29;
            this.ckbWithNoDash.Text = "With No Dash";
            this.ckbWithNoDash.UseVisualStyleBackColor = true;
            // 
            // FrmBCHUnformatedMp3Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 342);
            this.Controls.Add(this.ckbWithNoDash);
            this.Controls.Add(this.ckbWithNoDblDash);
            this.Controls.Add(this.ckbUseDirInfo);
            this.Controls.Add(this.ckbUpdateTagInfo);
            this.Controls.Add(this.btnInsertDash);
            this.Controls.Add(this.btnUpdateFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBadFileCount);
            this.Controls.Add(this.btnGetAllUnFormatedMp3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbMP3RootDir);
            this.Controls.Add(this.btnGetMP3RootDir);
            this.Name = "FrmBCHUnformatedMp3Files";
            this.Text = "FrmBCHUnformatedMp3Files";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMP3RootDir;
        private System.Windows.Forms.Button btnGetMP3RootDir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetAllUnFormatedMp3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbBadFileCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateFiles;
        private System.Windows.Forms.Button btnInsertDash;
        private System.Windows.Forms.CheckBox ckbUpdateTagInfo;
        private System.Windows.Forms.CheckBox ckbUseDirInfo;
        private System.Windows.Forms.CheckBox ckbWithNoDblDash;
        private System.Windows.Forms.CheckBox ckbWithNoDash;
    }
}