namespace MP3OrganizerUI
{
    partial class FrmLoadMP3DB
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbMP3s = new System.Windows.Forms.ListBox();
            this.btnGetMP3s = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMP3Count = new System.Windows.Forms.Label();
            this.ckbUseFolderInfo = new System.Windows.Forms.CheckBox();
            this.btnLoadMP3DB = new System.Windows.Forms.Button();
            this.btnDeleteAllMp3s = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbProgress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.ddtbMp3DbFile = new BCHControls.UCDragDropTextBox();
            this.dddtbGetMp3RootDir = new BCHControls.UCDragDropDirTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbMP3s
            // 
            this.lbMP3s.FormattingEnabled = true;
            this.lbMP3s.HorizontalScrollbar = true;
            this.lbMP3s.Location = new System.Drawing.Point(121, 79);
            this.lbMP3s.Name = "lbMP3s";
            this.lbMP3s.Size = new System.Drawing.Size(448, 173);
            this.lbMP3s.TabIndex = 18;
            // 
            // btnGetMP3s
            // 
            this.btnGetMP3s.Location = new System.Drawing.Point(6, 79);
            this.btnGetMP3s.Name = "btnGetMP3s";
            this.btnGetMP3s.Size = new System.Drawing.Size(112, 23);
            this.btnGetMP3s.TabIndex = 19;
            this.btnGetMP3s.Text = "Get MP3s";
            this.btnGetMP3s.UseVisualStyleBackColor = true;
            this.btnGetMP3s.Click += new System.EventHandler(this.btnGetMP3s_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "MP3 Count:";
            // 
            // lblMP3Count
            // 
            this.lblMP3Count.AutoSize = true;
            this.lblMP3Count.Location = new System.Drawing.Point(72, 109);
            this.lblMP3Count.Name = "lblMP3Count";
            this.lblMP3Count.Size = new System.Drawing.Size(35, 13);
            this.lblMP3Count.TabIndex = 21;
            this.lblMP3Count.Text = "label2";
            // 
            // ckbUseFolderInfo
            // 
            this.ckbUseFolderInfo.AutoSize = true;
            this.ckbUseFolderInfo.Checked = true;
            this.ckbUseFolderInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseFolderInfo.Location = new System.Drawing.Point(6, 125);
            this.ckbUseFolderInfo.Name = "ckbUseFolderInfo";
            this.ckbUseFolderInfo.Size = new System.Drawing.Size(98, 17);
            this.ckbUseFolderInfo.TabIndex = 22;
            this.ckbUseFolderInfo.Text = "Use Folder Info";
            this.ckbUseFolderInfo.UseVisualStyleBackColor = true;
            // 
            // btnLoadMP3DB
            // 
            this.btnLoadMP3DB.Location = new System.Drawing.Point(6, 148);
            this.btnLoadMP3DB.Name = "btnLoadMP3DB";
            this.btnLoadMP3DB.Size = new System.Drawing.Size(112, 23);
            this.btnLoadMP3DB.TabIndex = 23;
            this.btnLoadMP3DB.Text = "Load MP3 DB";
            this.btnLoadMP3DB.UseVisualStyleBackColor = true;
            this.btnLoadMP3DB.Click += new System.EventHandler(this.btnLoadMP3DB_Click);
            // 
            // btnDeleteAllMp3s
            // 
            this.btnDeleteAllMp3s.Location = new System.Drawing.Point(6, 175);
            this.btnDeleteAllMp3s.Name = "btnDeleteAllMp3s";
            this.btnDeleteAllMp3s.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteAllMp3s.TabIndex = 24;
            this.btnDeleteAllMp3s.Text = "Delete All MP3s";
            this.btnDeleteAllMp3s.UseVisualStyleBackColor = true;
            this.btnDeleteAllMp3s.Click += new System.EventHandler(this.btnDeleteAllMp3s_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(381, 258);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.ReadOnly = true;
            this.tbProgress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbProgress.Size = new System.Drawing.Size(188, 20);
            this.tbProgress.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Status:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(121, 258);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 23);
            this.progressBar1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 31;
            this.button1.Text = "Compact and Repare DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCmpctRprDB_Click);
            // 
            // ddtbMp3DbFile
            // 
            this.ddtbMp3DbFile.AllowDrop = true;
            this.ddtbMp3DbFile.ButtonText = "Get Mp3 Db File";
            this.ddtbMp3DbFile.FileDialogTitle = null;
            this.ddtbMp3DbFile.ItemFilters = "mdb";
            this.ddtbMp3DbFile.ItemText = "";
            this.ddtbMp3DbFile.LeftRight = 40;
            this.ddtbMp3DbFile.Location = new System.Drawing.Point(3, 25);
            this.ddtbMp3DbFile.Name = "ddtbMp3DbFile";
            this.ddtbMp3DbFile.Size = new System.Drawing.Size(574, 29);
            this.ddtbMp3DbFile.TabIndex = 33;
            // 
            // dddtbGetMp3RootDir
            // 
            this.dddtbGetMp3RootDir.AllowDrop = true;
            this.dddtbGetMp3RootDir.ButtonText = "Get Mp3 Root Dir";
            this.dddtbGetMp3RootDir.FileDialogTitle = null;
            this.dddtbGetMp3RootDir.ItemFilters = null;
            this.dddtbGetMp3RootDir.ItemText = "";
            this.dddtbGetMp3RootDir.LeftRight = 40;
            this.dddtbGetMp3RootDir.Location = new System.Drawing.Point(-3, 50);
            this.dddtbGetMp3RootDir.Name = "dddtbGetMp3RootDir";
            this.dddtbGetMp3RootDir.Size = new System.Drawing.Size(580, 27);
            this.dddtbGetMp3RootDir.TabIndex = 35;
            // 
            // FrmLoadMP3DB
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 292);
            this.Controls.Add(this.dddtbGetMp3RootDir);
            this.Controls.Add(this.ddtbMp3DbFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDeleteAllMp3s);
            this.Controls.Add(this.btnLoadMP3DB);
            this.Controls.Add(this.ckbUseFolderInfo);
            this.Controls.Add(this.lblMP3Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetMP3s);
            this.Controls.Add(this.lbMP3s);
            this.Name = "FrmLoadMP3DB";
            this.Text = "FrmLoadMP3DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox lbMP3s;
        private System.Windows.Forms.Button btnGetMP3s;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMP3Count;
        private System.Windows.Forms.CheckBox ckbUseFolderInfo;
        private System.Windows.Forms.Button btnLoadMP3DB;
        private System.Windows.Forms.Button btnDeleteAllMp3s;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private BCHControls.UCDragDropTextBox ddtbMp3DbFile;
        private BCHControls.UCDragDropDirTextBox dddtbGetMp3RootDir;
    }
}