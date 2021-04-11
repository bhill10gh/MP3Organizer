namespace MP3OrganizerUI.iTunes
{
    partial class FrmCopyiPhoneBackupFIles
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
            this.ucGetFromPath = new BCHControls.UCGetFilePath();
            this.ucGetToPath = new BCHControls.UCGetFilePath();
            this.ucResultDisplay1 = new BCHControls.UCResultDisplay();
            this.btnCopyFiles = new System.Windows.Forms.Button();
            this.cbxDeleteToDir = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblProgStat = new System.Windows.Forms.Label();
            this.btnOpenFromDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenToDIr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucGetFromPath
            // 
            this.ucGetFromPath.DialogTitle = null;
            this.ucGetFromPath.FileName = "";
            this.ucGetFromPath.Location = new System.Drawing.Point(12, 39);
            this.ucGetFromPath.Name = "ucGetFromPath";
            this.ucGetFromPath.Size = new System.Drawing.Size(915, 39);
            this.ucGetFromPath.TabIndex = 0;
            // 
            // ucGetToPath
            // 
            this.ucGetToPath.DialogTitle = null;
            this.ucGetToPath.FileName = "";
            this.ucGetToPath.Location = new System.Drawing.Point(12, 109);
            this.ucGetToPath.Name = "ucGetToPath";
            this.ucGetToPath.Size = new System.Drawing.Size(915, 39);
            this.ucGetToPath.TabIndex = 1;
            // 
            // ucResultDisplay1
            // 
            this.ucResultDisplay1.DisplayText = "";
            this.ucResultDisplay1.Location = new System.Drawing.Point(126, 154);
            this.ucResultDisplay1.Name = "ucResultDisplay1";
            this.ucResultDisplay1.Size = new System.Drawing.Size(801, 112);
            this.ucResultDisplay1.TabIndex = 2;
            // 
            // btnCopyFiles
            // 
            this.btnCopyFiles.Location = new System.Drawing.Point(12, 154);
            this.btnCopyFiles.Name = "btnCopyFiles";
            this.btnCopyFiles.Size = new System.Drawing.Size(108, 23);
            this.btnCopyFiles.TabIndex = 3;
            this.btnCopyFiles.Text = "Copy Files";
            this.btnCopyFiles.UseVisualStyleBackColor = true;
            this.btnCopyFiles.Click += new System.EventHandler(this.btnCopyFiles_Click);
            // 
            // cbxDeleteToDir
            // 
            this.cbxDeleteToDir.AutoSize = true;
            this.cbxDeleteToDir.Location = new System.Drawing.Point(13, 184);
            this.cbxDeleteToDir.Name = "cbxDeleteToDir";
            this.cbxDeleteToDir.Size = new System.Drawing.Size(89, 17);
            this.cbxDeleteToDir.TabIndex = 4;
            this.cbxDeleteToDir.Text = "Delete To Dir";
            this.cbxDeleteToDir.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(126, 272);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(801, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblProgStat
            // 
            this.lblProgStat.AutoSize = true;
            this.lblProgStat.Location = new System.Drawing.Point(12, 245);
            this.lblProgStat.Name = "lblProgStat";
            this.lblProgStat.Size = new System.Drawing.Size(0, 13);
            this.lblProgStat.TabIndex = 6;
            // 
            // btnOpenFromDir
            // 
            this.btnOpenFromDir.Location = new System.Drawing.Point(12, 317);
            this.btnOpenFromDir.Name = "btnOpenFromDir";
            this.btnOpenFromDir.Size = new System.Drawing.Size(108, 23);
            this.btnOpenFromDir.TabIndex = 7;
            this.btnOpenFromDir.Text = "Open From Dir";
            this.btnOpenFromDir.UseVisualStyleBackColor = true;
            this.btnOpenFromDir.Click += new System.EventHandler(this.btnOpenFromDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To Directory";
            // 
            // btnOpenToDIr
            // 
            this.btnOpenToDIr.Location = new System.Drawing.Point(136, 317);
            this.btnOpenToDIr.Name = "btnOpenToDIr";
            this.btnOpenToDIr.Size = new System.Drawing.Size(108, 23);
            this.btnOpenToDIr.TabIndex = 10;
            this.btnOpenToDIr.Text = "Open To Dir";
            this.btnOpenToDIr.UseVisualStyleBackColor = true;
            this.btnOpenToDIr.Click += new System.EventHandler(this.btnOpenToDIr_Click);
            // 
            // FrmCopyiPhoneBackupFIles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 426);
            this.Controls.Add(this.btnOpenToDIr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFromDir);
            this.Controls.Add(this.lblProgStat);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cbxDeleteToDir);
            this.Controls.Add(this.btnCopyFiles);
            this.Controls.Add(this.ucResultDisplay1);
            this.Controls.Add(this.ucGetToPath);
            this.Controls.Add(this.ucGetFromPath);
            this.Name = "FrmCopyiPhoneBackupFIles";
            this.Text = "CopyiPhoneBackupFIles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BCHControls.UCGetFilePath ucGetFromPath;
        private BCHControls.UCGetFilePath ucGetToPath;
        private BCHControls.UCResultDisplay ucResultDisplay1;
        private System.Windows.Forms.Button btnCopyFiles;
        private System.Windows.Forms.CheckBox cbxDeleteToDir;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblProgStat;
        private System.Windows.Forms.Button btnOpenFromDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenToDIr;

    }
}