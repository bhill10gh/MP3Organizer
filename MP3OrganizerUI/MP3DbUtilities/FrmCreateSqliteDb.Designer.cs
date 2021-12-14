
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateSqliteDb));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbProgress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLoadSqliteDb = new System.Windows.Forms.Button();
            this.tbSqliteDbFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetMp3s = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMp3Count = new System.Windows.Forms.Label();
            this.dddtbGetDbDir = new BCHControls.UCDragDropDirTextBox();
            this.dddtbGetMp3RootDir = new BCHControls.UCDragDropDirTextBox();
            this.gbMp3Source = new System.Windows.Forms.GroupBox();
            this.rbtnNonFileNameFormat = new System.Windows.Forms.RadioButton();
            this.rbtnBHFileNameFormat = new System.Windows.Forms.RadioButton();
            this.ckbAddToDb = new System.Windows.Forms.CheckBox();
            this.ddlbMp3s = new BCHControls.UCDragDropListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ddtbDbFile = new BCHControls.UCDragDropTextBox();
            this.gbDirOrFileList = new System.Windows.Forms.GroupBox();
            this.rbtnUseFileList = new System.Windows.Forms.RadioButton();
            this.rbtnUseDir = new System.Windows.Forms.RadioButton();
            this.ckbMakeDbCopyIfExist = new System.Windows.Forms.CheckBox();
            this.gbMp3Source.SuspendLayout();
            this.gbDirOrFileList.SuspendLayout();
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
            this.tbProgress.Location = new System.Drawing.Point(380, 467);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.ReadOnly = true;
            this.tbProgress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbProgress.Size = new System.Drawing.Size(188, 20);
            this.tbProgress.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Status:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(127, 467);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(243, 20);
            this.progressBar1.TabIndex = 37;
            // 
            // btnLoadSqliteDb
            // 
            this.btnLoadSqliteDb.Location = new System.Drawing.Point(5, 404);
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
            this.tbSqliteDbFileName.Size = new System.Drawing.Size(553, 20);
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
            // btnGetMp3s
            // 
            this.btnGetMp3s.Location = new System.Drawing.Point(3, 199);
            this.btnGetMp3s.Name = "btnGetMp3s";
            this.btnGetMp3s.Size = new System.Drawing.Size(101, 23);
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
            this.rtbMessages.Size = new System.Drawing.Size(671, 62);
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
            this.lblMp3Count.Location = new System.Drawing.Point(134, 445);
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
            this.dddtbGetDbDir.Location = new System.Drawing.Point(-5, 118);
            this.dddtbGetDbDir.Name = "dddtbGetDbDir";
            this.dddtbGetDbDir.Size = new System.Drawing.Size(680, 27);
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
            this.dddtbGetMp3RootDir.Size = new System.Drawing.Size(680, 27);
            this.dddtbGetMp3RootDir.TabIndex = 36;
            // 
            // gbMp3Source
            // 
            this.gbMp3Source.Controls.Add(this.rbtnNonFileNameFormat);
            this.gbMp3Source.Controls.Add(this.rbtnBHFileNameFormat);
            this.gbMp3Source.Location = new System.Drawing.Point(5, 352);
            this.gbMp3Source.Name = "gbMp3Source";
            this.gbMp3Source.Size = new System.Drawing.Size(283, 46);
            this.gbMp3Source.TabIndex = 50;
            this.gbMp3Source.TabStop = false;
            this.gbMp3Source.Text = "Mp3 File Name Format Type";
            // 
            // rbtnNonFileNameFormat
            // 
            this.rbtnNonFileNameFormat.AutoSize = true;
            this.rbtnNonFileNameFormat.Location = new System.Drawing.Point(138, 19);
            this.rbtnNonFileNameFormat.Name = "rbtnNonFileNameFormat";
            this.rbtnNonFileNameFormat.Size = new System.Drawing.Size(130, 17);
            this.rbtnNonFileNameFormat.TabIndex = 1;
            this.rbtnNonFileNameFormat.Text = "Non File Name Format";
            this.rbtnNonFileNameFormat.UseVisualStyleBackColor = true;
            // 
            // rbtnBHFileNameFormat
            // 
            this.rbtnBHFileNameFormat.AutoSize = true;
            this.rbtnBHFileNameFormat.Checked = true;
            this.rbtnBHFileNameFormat.Location = new System.Drawing.Point(7, 19);
            this.rbtnBHFileNameFormat.Name = "rbtnBHFileNameFormat";
            this.rbtnBHFileNameFormat.Size = new System.Drawing.Size(125, 17);
            this.rbtnBHFileNameFormat.TabIndex = 0;
            this.rbtnBHFileNameFormat.TabStop = true;
            this.rbtnBHFileNameFormat.Text = "BH File Name Format";
            this.rbtnBHFileNameFormat.UseVisualStyleBackColor = true;
            // 
            // ckbAddToDb
            // 
            this.ckbAddToDb.AutoSize = true;
            this.ckbAddToDb.Location = new System.Drawing.Point(460, 361);
            this.ckbAddToDb.Name = "ckbAddToDb";
            this.ckbAddToDb.Size = new System.Drawing.Size(118, 17);
            this.ckbAddToDb.TabIndex = 51;
            this.ckbAddToDb.Text = "Add To Existing DB";
            this.ckbAddToDb.UseVisualStyleBackColor = true;
            // 
            // ddlbMp3s
            // 
            this.ddlbMp3s.AllowDragDrop = true;
            this.ddlbMp3s.AllowDrop = true;
            this.ddlbMp3s.AllowDupes = false;
            this.ddlbMp3s.FileFilter = ((System.Collections.Generic.List<string>)(resources.GetObject("ddlbMp3s.FileFilter")));
            this.ddlbMp3s.IsCaseSensitive = false;
            this.ddlbMp3s.LbTitle = "List";
            this.ddlbMp3s.Location = new System.Drawing.Point(108, 199);
            this.ddlbMp3s.Name = "ddlbMp3s";
            this.ddlbMp3s.ShowCountLbl = true;
            this.ddlbMp3s.ShowDeleteButtons = true;
            this.ddlbMp3s.ShowMoveButtons = false;
            this.ddlbMp3s.Size = new System.Drawing.Size(574, 147);
            this.ddlbMp3s.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ddtbDbFile
            // 
            this.ddtbDbFile.AllowDrop = true;
            this.ddtbDbFile.ButtonText = "Get DB File";
            this.ddtbDbFile.FileDialogTitle = null;
            this.ddtbDbFile.ItemFilters = null;
            this.ddtbDbFile.ItemText = "";
            this.ddtbDbFile.LeftRight = 40;
            this.ddtbDbFile.Location = new System.Drawing.Point(0, 171);
            this.ddtbDbFile.Name = "ddtbDbFile";
            this.ddtbDbFile.Size = new System.Drawing.Size(676, 29);
            this.ddtbDbFile.TabIndex = 54;
            // 
            // gbDirOrFileList
            // 
            this.gbDirOrFileList.Controls.Add(this.rbtnUseFileList);
            this.gbDirOrFileList.Controls.Add(this.rbtnUseDir);
            this.gbDirOrFileList.Location = new System.Drawing.Point(294, 355);
            this.gbDirOrFileList.Name = "gbDirOrFileList";
            this.gbDirOrFileList.Size = new System.Drawing.Size(160, 46);
            this.gbDirOrFileList.TabIndex = 55;
            this.gbDirOrFileList.TabStop = false;
            this.gbDirOrFileList.Text = "Use Dir or File List";
            // 
            // rbtnUseFileList
            // 
            this.rbtnUseFileList.AutoSize = true;
            this.rbtnUseFileList.Location = new System.Drawing.Point(73, 19);
            this.rbtnUseFileList.Name = "rbtnUseFileList";
            this.rbtnUseFileList.Size = new System.Drawing.Size(82, 17);
            this.rbtnUseFileList.TabIndex = 1;
            this.rbtnUseFileList.Text = "Use File List";
            this.rbtnUseFileList.UseVisualStyleBackColor = true;
            // 
            // rbtnUseDir
            // 
            this.rbtnUseDir.AutoSize = true;
            this.rbtnUseDir.Checked = true;
            this.rbtnUseDir.Location = new System.Drawing.Point(7, 19);
            this.rbtnUseDir.Name = "rbtnUseDir";
            this.rbtnUseDir.Size = new System.Drawing.Size(60, 17);
            this.rbtnUseDir.TabIndex = 0;
            this.rbtnUseDir.TabStop = true;
            this.rbtnUseDir.Text = "Use Dir";
            this.rbtnUseDir.UseVisualStyleBackColor = true;
            // 
            // ckbMakeDbCopyIfExist
            // 
            this.ckbMakeDbCopyIfExist.AutoSize = true;
            this.ckbMakeDbCopyIfExist.Checked = true;
            this.ckbMakeDbCopyIfExist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMakeDbCopyIfExist.Location = new System.Drawing.Point(460, 384);
            this.ckbMakeDbCopyIfExist.Name = "ckbMakeDbCopyIfExist";
            this.ckbMakeDbCopyIfExist.Size = new System.Drawing.Size(154, 17);
            this.ckbMakeDbCopyIfExist.TabIndex = 56;
            this.ckbMakeDbCopyIfExist.Text = "Make a copy of Db if exists";
            this.ckbMakeDbCopyIfExist.UseVisualStyleBackColor = true;
            // 
            // FrmCreateSqliteDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 504);
            this.Controls.Add(this.ckbMakeDbCopyIfExist);
            this.Controls.Add(this.gbDirOrFileList);
            this.Controls.Add(this.ddtbDbFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ddlbMp3s);
            this.Controls.Add(this.ckbAddToDb);
            this.Controls.Add(this.gbMp3Source);
            this.Controls.Add(this.lblMp3Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnGetMp3s);
            this.Controls.Add(this.dddtbGetDbDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSqliteDbFileName);
            this.Controls.Add(this.btnLoadSqliteDb);
            this.Controls.Add(this.tbProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dddtbGetMp3RootDir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreateSqliteDb";
            this.Text = "FrmCreateSqliteDb";
            this.gbMp3Source.ResumeLayout(false);
            this.gbMp3Source.PerformLayout();
            this.gbDirOrFileList.ResumeLayout(false);
            this.gbDirOrFileList.PerformLayout();
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
        private System.Windows.Forms.Button btnGetMp3s;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMp3Count;
        private System.Windows.Forms.GroupBox gbMp3Source;
        private System.Windows.Forms.RadioButton rbtnNonFileNameFormat;
        private System.Windows.Forms.RadioButton rbtnBHFileNameFormat;
        private System.Windows.Forms.CheckBox ckbAddToDb;
        private BCHControls.UCDragDropListBox ddlbMp3s;
        private System.Windows.Forms.Button button1;
        private BCHControls.UCDragDropTextBox ddtbDbFile;
        private System.Windows.Forms.GroupBox gbDirOrFileList;
        private System.Windows.Forms.RadioButton rbtnUseFileList;
        private System.Windows.Forms.RadioButton rbtnUseDir;
        private System.Windows.Forms.CheckBox ckbMakeDbCopyIfExist;
    }
}