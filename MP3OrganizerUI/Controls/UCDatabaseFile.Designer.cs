namespace MP3OrganizerUI.Controls
{
    partial class UCDatabaseFile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMP3DBFile = new System.Windows.Forms.TextBox();
            this.btnGetMP3DBFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // tbMP3DBFile
            // 
            this.tbMP3DBFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMP3DBFile.Location = new System.Drawing.Point(128, 3);
            this.tbMP3DBFile.Multiline = true;
            this.tbMP3DBFile.Name = "tbMP3DBFile";
            this.tbMP3DBFile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbMP3DBFile.Size = new System.Drawing.Size(427, 38);
            this.tbMP3DBFile.TabIndex = 21;
            // 
            // btnGetMP3DBFile
            // 
            this.btnGetMP3DBFile.Location = new System.Drawing.Point(0, 1);
            this.btnGetMP3DBFile.Name = "btnGetMP3DBFile";
            this.btnGetMP3DBFile.Size = new System.Drawing.Size(112, 23);
            this.btnGetMP3DBFile.TabIndex = 18;
            this.btnGetMP3DBFile.Text = "Get MP3 DB File";
            this.btnGetMP3DBFile.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UCDatabaseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbMP3DBFile);
            this.Controls.Add(this.btnGetMP3DBFile);
            this.Name = "UCDatabaseFile";
            this.Size = new System.Drawing.Size(555, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMP3DBFile;
        private System.Windows.Forms.Button btnGetMP3DBFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
