namespace CopyFolderStructure
{
    partial class FrmCopyFolderStructure
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRootFolder = new System.Windows.Forms.TextBox();
            this.btnGetRootFolder = new System.Windows.Forms.Button();
            this.tbDestinationFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DestinationFolder = new System.Windows.Forms.Button();
            this.btnCreateFolders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Root Folder";
            // 
            // tbRootFolder
            // 
            this.tbRootFolder.Location = new System.Drawing.Point(81, 26);
            this.tbRootFolder.Multiline = true;
            this.tbRootFolder.Name = "tbRootFolder";
            this.tbRootFolder.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbRootFolder.Size = new System.Drawing.Size(465, 29);
            this.tbRootFolder.TabIndex = 1;
            this.tbRootFolder.Text = "C:\\TestFileStructure\\TestMainFolder";
            // 
            // btnGetRootFolder
            // 
            this.btnGetRootFolder.Location = new System.Drawing.Point(553, 26);
            this.btnGetRootFolder.Name = "btnGetRootFolder";
            this.btnGetRootFolder.Size = new System.Drawing.Size(124, 23);
            this.btnGetRootFolder.TabIndex = 2;
            this.btnGetRootFolder.Text = "Get Root Folder";
            this.btnGetRootFolder.UseVisualStyleBackColor = true;
            this.btnGetRootFolder.Click += new System.EventHandler(this.btnGetRootFolder_Click);
            // 
            // tbDestinationFolder
            // 
            this.tbDestinationFolder.Location = new System.Drawing.Point(81, 87);
            this.tbDestinationFolder.Multiline = true;
            this.tbDestinationFolder.Name = "tbDestinationFolder";
            this.tbDestinationFolder.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDestinationFolder.Size = new System.Drawing.Size(465, 29);
            this.tbDestinationFolder.TabIndex = 4;
            this.tbDestinationFolder.Text = "C:\\TestFileStructure\\TestCopyFolder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Folder";
            // 
            // DestinationFolder
            // 
            this.DestinationFolder.Location = new System.Drawing.Point(553, 87);
            this.DestinationFolder.Name = "DestinationFolder";
            this.DestinationFolder.Size = new System.Drawing.Size(124, 23);
            this.DestinationFolder.TabIndex = 5;
            this.DestinationFolder.Text = "Get Root Folder";
            this.DestinationFolder.UseVisualStyleBackColor = true;
            this.DestinationFolder.Click += new System.EventHandler(this.DestinationFolder_Click);
            // 
            // btnCreateFolders
            // 
            this.btnCreateFolders.Location = new System.Drawing.Point(553, 150);
            this.btnCreateFolders.Name = "btnCreateFolders";
            this.btnCreateFolders.Size = new System.Drawing.Size(124, 23);
            this.btnCreateFolders.TabIndex = 6;
            this.btnCreateFolders.Text = "Create Folders";
            this.btnCreateFolders.UseVisualStyleBackColor = true;
            this.btnCreateFolders.Click += new System.EventHandler(this.btnCreateFolders_Click);
            // 
            // FrmCopyFolderStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 199);
            this.Controls.Add(this.btnCreateFolders);
            this.Controls.Add(this.DestinationFolder);
            this.Controls.Add(this.tbDestinationFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetRootFolder);
            this.Controls.Add(this.tbRootFolder);
            this.Controls.Add(this.label1);
            this.Name = "FrmCopyFolderStructure";
            this.Text = "FrmCopyFolderStructure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRootFolder;
        private System.Windows.Forms.Button btnGetRootFolder;
        private System.Windows.Forms.TextBox tbDestinationFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DestinationFolder;
        private System.Windows.Forms.Button btnCreateFolders;
    }
}