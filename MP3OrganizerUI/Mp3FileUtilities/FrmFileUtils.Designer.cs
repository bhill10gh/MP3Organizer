namespace MP3OrganizerUI.Mp3FileUtilities
{
    partial class FrmFileUtils
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFileUtils));
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlDirFileSearch = new System.Windows.Forms.Panel();
            this.btnCancelFileAdd = new System.Windows.Forms.Button();
            this.btnClosePanelAddMP3Files = new System.Windows.Forms.Button();
            this.ucDirFileSearch1 = new BCHControls.UCDirFileSearch();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlDirFileSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.HorizontalScrollbar = true;
            this.lbFiles.Location = new System.Drawing.Point(3, 36);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(796, 238);
            this.lbFiles.TabIndex = 16;
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(4, 7);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(75, 23);
            this.btnGetFiles.TabIndex = 17;
            this.btnGetFiles.Text = "Get Files";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblFileCount);
            this.pnlMain.Controls.Add(this.lbFiles);
            this.pnlMain.Controls.Add(this.btnGetFiles);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(808, 709);
            this.pnlMain.TabIndex = 18;
            // 
            // pnlDirFileSearch
            // 
            this.pnlDirFileSearch.Controls.Add(this.btnCancelFileAdd);
            this.pnlDirFileSearch.Controls.Add(this.btnClosePanelAddMP3Files);
            this.pnlDirFileSearch.Controls.Add(this.ucDirFileSearch1);
            this.pnlDirFileSearch.Location = new System.Drawing.Point(8, 10);
            this.pnlDirFileSearch.Name = "pnlDirFileSearch";
            this.pnlDirFileSearch.Size = new System.Drawing.Size(830, 700);
            this.pnlDirFileSearch.TabIndex = 19;
            this.pnlDirFileSearch.Visible = false;
            // 
            // btnCancelFileAdd
            // 
            this.btnCancelFileAdd.Location = new System.Drawing.Point(156, 5);
            this.btnCancelFileAdd.Name = "btnCancelFileAdd";
            this.btnCancelFileAdd.Size = new System.Drawing.Size(126, 23);
            this.btnCancelFileAdd.TabIndex = 2;
            this.btnCancelFileAdd.Text = "Cancel";
            this.btnCancelFileAdd.UseVisualStyleBackColor = true;
            this.btnCancelFileAdd.Click += new System.EventHandler(this.btnCancelFileAdd_Click);
            // 
            // btnClosePanelAddMP3Files
            // 
            this.btnClosePanelAddMP3Files.Location = new System.Drawing.Point(5, 5);
            this.btnClosePanelAddMP3Files.Name = "btnClosePanelAddMP3Files";
            this.btnClosePanelAddMP3Files.Size = new System.Drawing.Size(126, 23);
            this.btnClosePanelAddMP3Files.TabIndex = 1;
            this.btnClosePanelAddMP3Files.Text = "Add MP3 Files";
            this.btnClosePanelAddMP3Files.UseVisualStyleBackColor = true;
            this.btnClosePanelAddMP3Files.Click += new System.EventHandler(this.btnClosePanelAddMP3Files_Click);
            // 
            // ucDirFileSearch1
            // 
            this.ucDirFileSearch1.AutoScroll = true;
            this.ucDirFileSearch1.FileList = ((System.Collections.Generic.List<string>)(resources.GetObject("ucDirFileSearch1.FileList")));
            this.ucDirFileSearch1.FileTypeEnabled = true;
            this.ucDirFileSearch1.FileTypeList = ((System.Collections.Generic.List<string>)(resources.GetObject("ucDirFileSearch1.FileTypeList")));
            this.ucDirFileSearch1.Location = new System.Drawing.Point(3, 44);
            this.ucDirFileSearch1.Name = "ucDirFileSearch1";
            this.ucDirFileSearch1.SearchString = "";
            this.ucDirFileSearch1.Size = new System.Drawing.Size(697, 518);
            this.ucDirFileSearch1.TabIndex = 0;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(660, 281);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(47, 13);
            this.lblFileCount.TabIndex = 18;
            this.lblFileCount.Text = "Count: 0";
            // 
            // FrmFileUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 720);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlDirFileSearch);
            this.Name = "FrmFileUtils";
            this.Text = "FrmFileUtils";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlDirFileSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlDirFileSearch;
        private System.Windows.Forms.Button btnCancelFileAdd;
        private System.Windows.Forms.Button btnClosePanelAddMP3Files;
        private BCHControls.UCDirFileSearch ucDirFileSearch1;
        private System.Windows.Forms.Label lblFileCount;
    }
}