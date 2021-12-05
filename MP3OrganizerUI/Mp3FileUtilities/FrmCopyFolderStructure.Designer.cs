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
            this.btnCreateFolders = new System.Windows.Forms.Button();
            this.dddtbRootDir = new BCHControls.UCDragDropDirTextBox();
            this.dddrDestinationDir = new BCHControls.UCDragDropDirTextBox();
            this.SuspendLayout();
            // 
            // btnCreateFolders
            // 
            this.btnCreateFolders.Location = new System.Drawing.Point(5, 64);
            this.btnCreateFolders.Name = "btnCreateFolders";
            this.btnCreateFolders.Size = new System.Drawing.Size(114, 23);
            this.btnCreateFolders.TabIndex = 6;
            this.btnCreateFolders.Text = "Create Folders";
            this.btnCreateFolders.UseVisualStyleBackColor = true;
            this.btnCreateFolders.Click += new System.EventHandler(this.btnCreateFolders_Click);
            // 
            // dddtbRootDir
            // 
            this.dddtbRootDir.AllowDrop = true;
            this.dddtbRootDir.ButtonText = "Root Dir";
            this.dddtbRootDir.FileDialogTitle = null;
            this.dddtbRootDir.ItemFilters = null;
            this.dddtbRootDir.ItemText = "";
            this.dddtbRootDir.LeftRight = 40;
            this.dddtbRootDir.Location = new System.Drawing.Point(-3, 5);
            this.dddtbRootDir.Name = "dddtbRootDir";
            this.dddtbRootDir.Size = new System.Drawing.Size(661, 27);
            this.dddtbRootDir.TabIndex = 7;
            // 
            // dddrDestinationDir
            // 
            this.dddrDestinationDir.AllowDrop = true;
            this.dddrDestinationDir.ButtonText = "Destination Dir";
            this.dddrDestinationDir.FileDialogTitle = null;
            this.dddrDestinationDir.ItemFilters = null;
            this.dddrDestinationDir.ItemText = "";
            this.dddrDestinationDir.LeftRight = 40;
            this.dddrDestinationDir.Location = new System.Drawing.Point(-3, 31);
            this.dddrDestinationDir.Name = "dddrDestinationDir";
            this.dddrDestinationDir.Size = new System.Drawing.Size(661, 27);
            this.dddrDestinationDir.TabIndex = 8;
            // 
            // FrmCopyFolderStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 99);
            this.Controls.Add(this.dddrDestinationDir);
            this.Controls.Add(this.dddtbRootDir);
            this.Controls.Add(this.btnCreateFolders);
            this.Name = "FrmCopyFolderStructure";
            this.Text = "FrmCopyFolderStructure";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCreateFolders;
        private BCHControls.UCDragDropDirTextBox dddtbRootDir;
        private BCHControls.UCDragDropDirTextBox dddrDestinationDir;
    }
}