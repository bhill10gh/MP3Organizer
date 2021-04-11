namespace CopyFolderStructure
{
    partial class FrmCopyFilesToSameFolderStructure
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
            this.btnCopyFiles = new System.Windows.Forms.Button();
            this.DestinationFolder = new System.Windows.Forms.Button();
            this.tbDestinationFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetRootFolder = new System.Windows.Forms.Button();
            this.tbRootFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ckbOverwriteFile = new System.Windows.Forms.CheckBox();
            this.ckbCreateDir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCopyFiles
            // 
            this.btnCopyFiles.Location = new System.Drawing.Point(558, 152);
            this.btnCopyFiles.Name = "btnCopyFiles";
            this.btnCopyFiles.Size = new System.Drawing.Size(124, 23);
            this.btnCopyFiles.TabIndex = 13;
            this.btnCopyFiles.Text = "Copy Files";
            this.btnCopyFiles.UseVisualStyleBackColor = true;
            this.btnCopyFiles.Click += new System.EventHandler(this.btnCopyFiles_Click);
            // 
            // DestinationFolder
            // 
            this.DestinationFolder.Location = new System.Drawing.Point(558, 89);
            this.DestinationFolder.Name = "DestinationFolder";
            this.DestinationFolder.Size = new System.Drawing.Size(124, 23);
            this.DestinationFolder.TabIndex = 12;
            this.DestinationFolder.Text = "Get Root Folder";
            this.DestinationFolder.UseVisualStyleBackColor = true;
            this.DestinationFolder.Click += new System.EventHandler(this.DestinationFolder_Click);
            // 
            // tbDestinationFolder
            // 
            this.tbDestinationFolder.Location = new System.Drawing.Point(86, 89);
            this.tbDestinationFolder.Multiline = true;
            this.tbDestinationFolder.Name = "tbDestinationFolder";
            this.tbDestinationFolder.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDestinationFolder.Size = new System.Drawing.Size(465, 29);
            this.tbDestinationFolder.TabIndex = 11;
            this.tbDestinationFolder.Text = "C:\\TestFileStructure\\TestMainFolder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destination Folder";
            // 
            // btnGetRootFolder
            // 
            this.btnGetRootFolder.Location = new System.Drawing.Point(558, 28);
            this.btnGetRootFolder.Name = "btnGetRootFolder";
            this.btnGetRootFolder.Size = new System.Drawing.Size(124, 23);
            this.btnGetRootFolder.TabIndex = 9;
            this.btnGetRootFolder.Text = "Get Root Folder";
            this.btnGetRootFolder.UseVisualStyleBackColor = true;
            this.btnGetRootFolder.Click += new System.EventHandler(this.btnGetRootFolder_Click);
            // 
            // tbRootFolder
            // 
            this.tbRootFolder.Location = new System.Drawing.Point(86, 28);
            this.tbRootFolder.Multiline = true;
            this.tbRootFolder.Name = "tbRootFolder";
            this.tbRootFolder.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbRootFolder.Size = new System.Drawing.Size(465, 29);
            this.tbRootFolder.TabIndex = 8;
            this.tbRootFolder.Text = "C:\\TestFileStructure\\TestCopyToMainFolder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Root Folder";
            // 
            // ckbOverwriteFile
            // 
            this.ckbOverwriteFile.AutoSize = true;
            this.ckbOverwriteFile.Location = new System.Drawing.Point(86, 152);
            this.ckbOverwriteFile.Name = "ckbOverwriteFile";
            this.ckbOverwriteFile.Size = new System.Drawing.Size(90, 17);
            this.ckbOverwriteFile.TabIndex = 14;
            this.ckbOverwriteFile.Text = "Overwrite File";
            this.ckbOverwriteFile.UseVisualStyleBackColor = true;
            // 
            // ckbCreateDir
            // 
            this.ckbCreateDir.AutoSize = true;
            this.ckbCreateDir.Location = new System.Drawing.Point(182, 152);
            this.ckbCreateDir.Name = "ckbCreateDir";
            this.ckbCreateDir.Size = new System.Drawing.Size(102, 17);
            this.ckbCreateDir.TabIndex = 15;
            this.ckbCreateDir.Text = "Create Directory";
            this.ckbCreateDir.UseVisualStyleBackColor = true;
            // 
            // FrmCopyFilesToSameFolderStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 315);
            this.Controls.Add(this.ckbCreateDir);
            this.Controls.Add(this.ckbOverwriteFile);
            this.Controls.Add(this.btnCopyFiles);
            this.Controls.Add(this.DestinationFolder);
            this.Controls.Add(this.tbDestinationFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetRootFolder);
            this.Controls.Add(this.tbRootFolder);
            this.Controls.Add(this.label1);
            this.Name = "FrmCopyFilesToSameFolderStructure";
            this.Text = "FrmCopyFilesToSameFolderStructure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopyFiles;
        private System.Windows.Forms.Button DestinationFolder;
        private System.Windows.Forms.TextBox tbDestinationFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetRootFolder;
        private System.Windows.Forms.TextBox tbRootFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox ckbOverwriteFile;
        private System.Windows.Forms.CheckBox ckbCreateDir;
    }
}