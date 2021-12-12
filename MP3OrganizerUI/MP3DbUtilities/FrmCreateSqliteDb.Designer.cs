
namespace MP3OrganizerUI.MP3DbUtilities
{
    partial class FrmCreateSqliteDb
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbProgress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLoadSqliteDb = new System.Windows.Forms.Button();
            this.tbSqliteDbFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMP3s = new System.Windows.Forms.ListBox();
            this.btnGetMp3s = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMp3Count = new System.Windows.Forms.Label();
            this.dddtbGetDbDir = new BCHControls.UCDragDropDirTextBox();
            this.dddtbGetMp3RootDir = new BCHControls.UCDragDropDirTextBox();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(386, 414);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.ReadOnly = true;
            this.tbProgress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbProgress.Size = new System.Drawing.Size(188, 20);
            this.tbProgress.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Status:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(126, 414);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 23);
            this.progressBar1.TabIndex = 37;
            // 
            // btnLoadSqliteDb
            // 
            this.btnLoadSqliteDb.Location = new System.Drawing.Point(5, 374);
            this.btnLoadSqliteDb.Name = "btnLoadSqliteDb";
            this.btnLoadSqliteDb.Size = new System.Drawing.Size(115, 23);
            this.btnLoadSqliteDb.TabIndex = 40;
            this.btnLoadSqliteDb.Text = "Load Sqlite DB";
            this.btnLoadSqliteDb.UseVisualStyleBackColor = true;
            this.btnLoadSqliteDb.Click += new System.EventHandler(this.btnLoadSqliteDb_Click);
            // 
            // tbSqliteDbFileName
            // 
            this.tbSqliteDbFileName.Location = new System.Drawing.Point(122, 145);
            this.tbSqliteDbFileName.Name = "tbSqliteDbFileName";
            this.tbSqliteDbFileName.Size = new System.Drawing.Size(454, 20);
            this.tbSqliteDbFileName.TabIndex = 41;
            this.tbSqliteDbFileName.Text = "MP3DB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sqlite Db File Name";
            // 
            // lbMP3s
            // 
            this.lbMP3s.FormattingEnabled = true;
            this.lbMP3s.HorizontalScrollbar = true;
            this.lbMP3s.Location = new System.Drawing.Point(126, 186);
            this.lbMP3s.Name = "lbMP3s";
            this.lbMP3s.Size = new System.Drawing.Size(452, 173);
            this.lbMP3s.TabIndex = 44;
            // 
            // btnGetMp3s
            // 
            this.btnGetMp3s.Location = new System.Drawing.Point(5, 186);
            this.btnGetMp3s.Name = "btnGetMp3s";
            this.btnGetMp3s.Size = new System.Drawing.Size(115, 23);
            this.btnGetMp3s.TabIndex = 45;
            this.btnGetMp3s.Text = "Get Mp3 Songs";
            this.btnGetMp3s.UseVisualStyleBackColor = true;
            this.btnGetMp3s.Click += new System.EventHandler(this.btnGetMp3s_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbMessages.Location = new System.Drawing.Point(5, 26);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(686, 62);
            this.rtbMessages.TabIndex = 46;
            this.rtbMessages.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Messages";
            // 
            // lblMp3Count
            // 
            this.lblMp3Count.AutoSize = true;
            this.lblMp3Count.Location = new System.Drawing.Point(8, 216);
            this.lblMp3Count.Name = "lblMp3Count";
            this.lblMp3Count.Size = new System.Drawing.Size(71, 13);
            this.lblMp3Count.TabIndex = 48;
            this.lblMp3Count.Text = "Mp3 Count: 0";
            // 
            // dddtbGetDbDir
            // 
            this.dddtbGetDbDir.AllowDrop = true;
            this.dddtbGetDbDir.ButtonText = "Get DB Root Dir";
            this.dddtbGetDbDir.FileDialogTitle = null;
            this.dddtbGetDbDir.ItemFilters = null;
            this.dddtbGetDbDir.ItemText = "";
            this.dddtbGetDbDir.LeftRight = 40;
            this.dddtbGetDbDir.Location = new System.Drawing.Point(-4, 118);
            this.dddtbGetDbDir.Name = "dddtbGetDbDir";
            this.dddtbGetDbDir.Size = new System.Drawing.Size(580, 27);
            this.dddtbGetDbDir.TabIndex = 43;
            // 
            // dddtbGetMp3RootDir
            // 
            this.dddtbGetMp3RootDir.AllowDrop = true;
            this.dddtbGetMp3RootDir.ButtonText = "Get Mp3 Root Dir";
            this.dddtbGetMp3RootDir.FileDialogTitle = null;
            this.dddtbGetMp3RootDir.ItemFilters = null;
            this.dddtbGetMp3RootDir.ItemText = "";
            this.dddtbGetMp3RootDir.LeftRight = 40;
            this.dddtbGetMp3RootDir.Location = new System.Drawing.Point(-4, 94);
            this.dddtbGetMp3RootDir.Name = "dddtbGetMp3RootDir";
            this.dddtbGetMp3RootDir.Size = new System.Drawing.Size(580, 27);
            this.dddtbGetMp3RootDir.TabIndex = 36;
            // 
            // FrmCreateSqliteDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 491);
            this.Controls.Add(this.lblMp3Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnGetMp3s);
            this.Controls.Add(this.lbMP3s);
            this.Controls.Add(this.dddtbGetDbDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSqliteDbFileName);
            this.Controls.Add(this.btnLoadSqliteDb);
            this.Controls.Add(this.tbProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dddtbGetMp3RootDir);
            this.Name = "FrmCreateSqliteDb";
            this.Text = "FrmCreateSqliteDb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BCHControls.UCDragDropDirTextBox dddtbGetMp3RootDir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLoadSqliteDb;
        private System.Windows.Forms.TextBox tbSqliteDbFileName;
        private System.Windows.Forms.Label label1;
        private BCHControls.UCDragDropDirTextBox dddtbGetDbDir;
        private System.Windows.Forms.ListBox lbMP3s;
        private System.Windows.Forms.Button btnGetMp3s;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMp3Count;
    }
}