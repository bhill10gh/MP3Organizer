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
            this.tbMP3RootDir = new System.Windows.Forms.TextBox();
            this.btnGetMP3RootDir = new System.Windows.Forms.Button();
            this.ucDatabaseFile1 = new MP3OrganizerUI.Controls.UCDatabaseFile();
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
            this.lbMP3s.Location = new System.Drawing.Point(141, 103);
            this.lbMP3s.Name = "lbMP3s";
            this.lbMP3s.Size = new System.Drawing.Size(428, 121);
            this.lbMP3s.TabIndex = 18;
            // 
            // btnGetMP3s
            // 
            this.btnGetMP3s.Location = new System.Drawing.Point(3, 103);
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
            this.label1.Location = new System.Drawing.Point(3, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "MP3 Count:";
            // 
            // lblMP3Count
            // 
            this.lblMP3Count.AutoSize = true;
            this.lblMP3Count.Location = new System.Drawing.Point(72, 133);
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
            this.ckbUseFolderInfo.Location = new System.Drawing.Point(3, 163);
            this.ckbUseFolderInfo.Name = "ckbUseFolderInfo";
            this.ckbUseFolderInfo.Size = new System.Drawing.Size(98, 17);
            this.ckbUseFolderInfo.TabIndex = 22;
            this.ckbUseFolderInfo.Text = "Use Folder Info";
            this.ckbUseFolderInfo.UseVisualStyleBackColor = true;
            // 
            // btnLoadMP3DB
            // 
            this.btnLoadMP3DB.Location = new System.Drawing.Point(3, 186);
            this.btnLoadMP3DB.Name = "btnLoadMP3DB";
            this.btnLoadMP3DB.Size = new System.Drawing.Size(112, 23);
            this.btnLoadMP3DB.TabIndex = 23;
            this.btnLoadMP3DB.Text = "Load MP3 DB";
            this.btnLoadMP3DB.UseVisualStyleBackColor = true;
            this.btnLoadMP3DB.Click += new System.EventHandler(this.btnLoadMP3DB_Click);
            // 
            // btnDeleteAllMp3s
            // 
            this.btnDeleteAllMp3s.Location = new System.Drawing.Point(3, 213);
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
            this.tbProgress.Location = new System.Drawing.Point(444, 226);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.ReadOnly = true;
            this.tbProgress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbProgress.Size = new System.Drawing.Size(125, 20);
            this.tbProgress.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Status:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(184, 237);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 23);
            this.progressBar1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 31;
            this.button1.Text = "Compact and Repare DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCmpctRprDB_Click);
            // 
            // tbMP3RootDir
            // 
            this.tbMP3RootDir.Location = new System.Drawing.Point(138, 64);
            this.tbMP3RootDir.Multiline = true;
            this.tbMP3RootDir.Name = "tbMP3RootDir";
            this.tbMP3RootDir.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbMP3RootDir.Size = new System.Drawing.Size(431, 33);
            this.tbMP3RootDir.TabIndex = 15;
            this.tbMP3RootDir.TextChanged += new System.EventHandler(this.tbMP3RootDir_TextChanged);
            // 
            // btnGetMP3RootDir
            // 
            this.btnGetMP3RootDir.Location = new System.Drawing.Point(6, 62);
            this.btnGetMP3RootDir.Name = "btnGetMP3RootDir";
            this.btnGetMP3RootDir.Size = new System.Drawing.Size(112, 23);
            this.btnGetMP3RootDir.TabIndex = 16;
            this.btnGetMP3RootDir.Text = "Get MP3 Root Dir";
            this.btnGetMP3RootDir.UseVisualStyleBackColor = true;
            this.btnGetMP3RootDir.Click += new System.EventHandler(this.btnGetMP3RootDir_Click);
            // 
            // ucDatabaseFile1
            // 
            this.ucDatabaseFile1.Location = new System.Drawing.Point(3, 13);
            this.ucDatabaseFile1.MP3DBExists = false;
            this.ucDatabaseFile1.MP3DBFileName = "";
            this.ucDatabaseFile1.Name = "ucDatabaseFile1";
            this.ucDatabaseFile1.Size = new System.Drawing.Size(574, 45);
            this.ucDatabaseFile1.TabIndex = 32;
            // 
            // FrmLoadMP3DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 491);
            this.Controls.Add(this.ucDatabaseFile1);
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
            this.Controls.Add(this.btnGetMP3RootDir);
            this.Controls.Add(this.tbMP3RootDir);
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
        private System.Windows.Forms.TextBox tbMP3RootDir;
        private System.Windows.Forms.Button btnGetMP3RootDir;
        private Controls.UCDatabaseFile ucDatabaseFile1;
    }
}