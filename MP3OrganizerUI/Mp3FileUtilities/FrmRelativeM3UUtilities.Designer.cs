namespace MP3OrganizerUI.Mp3FileUtilities
{
    partial class FrmRelativeM3UUtilities
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
            this.tbMessages = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dddMusicDirPath = new BCHControls.UCDragDropDirTextBox();
            this.dddtbM3uPath = new BCHControls.UCDragDropDirTextBox();
            this.ddlbMediaList = new BCHControls.UCDragDropListBox();
            this.tbM3uName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilters = new System.Windows.Forms.TextBox();
            this.btnGetM3uEntries = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDirAdjustment = new System.Windows.Forms.TextBox();
            this.btnSaveM3uFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(13, 32);
            this.tbMessages.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.Size = new System.Drawing.Size(869, 53);
            this.tbMessages.TabIndex = 133;
            this.tbMessages.Text = "";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 132;
            this.label13.Text = "Messages";
            // 
            // dddMusicDirPath
            // 
            this.dddMusicDirPath.AllowDrop = true;
            this.dddMusicDirPath.ButtonText = "Music Dir Path";
            this.dddMusicDirPath.FileDialogTitle = null;
            this.dddMusicDirPath.ItemFilters = null;
            this.dddMusicDirPath.ItemText = "E:\\OneDrive\\My Music\\Music";
            this.dddMusicDirPath.LeftRight = 60;
            this.dddMusicDirPath.Location = new System.Drawing.Point(1, 124);
            this.dddMusicDirPath.Margin = new System.Windows.Forms.Padding(5);
            this.dddMusicDirPath.Name = "dddMusicDirPath";
            this.dddMusicDirPath.Size = new System.Drawing.Size(883, 33);
            this.dddMusicDirPath.TabIndex = 142;
            // 
            // dddtbM3uPath
            // 
            this.dddtbM3uPath.AllowDrop = true;
            this.dddtbM3uPath.ButtonText = "M3U Path";
            this.dddtbM3uPath.FileDialogTitle = null;
            this.dddtbM3uPath.ItemFilters = null;
            this.dddtbM3uPath.ItemText = "E:\\OneDrive\\My Music\\Music\\Playlists";
            this.dddtbM3uPath.LeftRight = 60;
            this.dddtbM3uPath.Location = new System.Drawing.Point(1, 96);
            this.dddtbM3uPath.Margin = new System.Windows.Forms.Padding(5);
            this.dddtbM3uPath.Name = "dddtbM3uPath";
            this.dddtbM3uPath.Size = new System.Drawing.Size(883, 33);
            this.dddtbM3uPath.TabIndex = 141;
            // 
            // ddlbMediaList
            // 
            this.ddlbMediaList.AllowDragDrop = true;
            this.ddlbMediaList.AllowDrop = true;
            this.ddlbMediaList.AllowDupes = false;
            this.ddlbMediaList.DoRecursive = false;
            this.ddlbMediaList.IsCaseSensitive = false;
            this.ddlbMediaList.ItemFilters = null;
            this.ddlbMediaList.LbTitle = "M3U Media List";
            this.ddlbMediaList.Location = new System.Drawing.Point(12, 297);
            this.ddlbMediaList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddlbMediaList.Name = "ddlbMediaList";
            this.ddlbMediaList.ShowCountLbl = true;
            this.ddlbMediaList.ShowDeleteButtons = true;
            this.ddlbMediaList.ShowMoveButtons = true;
            this.ddlbMediaList.Size = new System.Drawing.Size(859, 181);
            this.ddlbMediaList.TabIndex = 143;
            // 
            // tbM3uName
            // 
            this.tbM3uName.AllowDrop = true;
            this.tbM3uName.Location = new System.Drawing.Point(172, 202);
            this.tbM3uName.Name = "tbM3uName";
            this.tbM3uName.Size = new System.Drawing.Size(705, 22);
            this.tbM3uName.TabIndex = 144;
            this.tbM3uName.DragDrop += new System.Windows.Forms.DragEventHandler(this.Item_DragDrop);
            this.tbM3uName.DragEnter += new System.Windows.Forms.DragEventHandler(this.Item_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 145;
            this.label1.Text = "M3U File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 147;
            this.label2.Text = "Media Filters";
            // 
            // tbFilters
            // 
            this.tbFilters.AllowDrop = true;
            this.tbFilters.Location = new System.Drawing.Point(172, 174);
            this.tbFilters.Name = "tbFilters";
            this.tbFilters.Size = new System.Drawing.Size(705, 22);
            this.tbFilters.TabIndex = 146;
            this.tbFilters.Text = "mp3";
            // 
            // btnGetM3uEntries
            // 
            this.btnGetM3uEntries.Location = new System.Drawing.Point(18, 267);
            this.btnGetM3uEntries.Name = "btnGetM3uEntries";
            this.btnGetM3uEntries.Size = new System.Drawing.Size(136, 23);
            this.btnGetM3uEntries.TabIndex = 148;
            this.btnGetM3uEntries.Text = "Get M3U Entries";
            this.btnGetM3uEntries.UseVisualStyleBackColor = true;
            this.btnGetM3uEntries.Click += new System.EventHandler(this.btnGetM3uEntries_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 150;
            this.label3.Text = "Dir Adjustment";
            // 
            // tbDirAdjustment
            // 
            this.tbDirAdjustment.AllowDrop = true;
            this.tbDirAdjustment.Location = new System.Drawing.Point(172, 230);
            this.tbDirAdjustment.Name = "tbDirAdjustment";
            this.tbDirAdjustment.Size = new System.Drawing.Size(705, 22);
            this.tbDirAdjustment.TabIndex = 149;
            this.tbDirAdjustment.Text = "../";
            // 
            // btnSaveM3uFile
            // 
            this.btnSaveM3uFile.Location = new System.Drawing.Point(172, 267);
            this.btnSaveM3uFile.Name = "btnSaveM3uFile";
            this.btnSaveM3uFile.Size = new System.Drawing.Size(121, 23);
            this.btnSaveM3uFile.TabIndex = 151;
            this.btnSaveM3uFile.Text = "Save M3U File";
            this.btnSaveM3uFile.UseVisualStyleBackColor = true;
            this.btnSaveM3uFile.Click += new System.EventHandler(this.btnSaveM3uFile_Click);
            // 
            // FrmRelativeM3UUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 527);
            this.Controls.Add(this.btnSaveM3uFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDirAdjustment);
            this.Controls.Add(this.btnGetM3uEntries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbM3uName);
            this.Controls.Add(this.ddlbMediaList);
            this.Controls.Add(this.dddMusicDirPath);
            this.Controls.Add(this.dddtbM3uPath);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.label13);
            this.Name = "FrmRelativeM3UUtilities";
            this.Text = "FrmRelativeM3UUtilities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbMessages;
        private System.Windows.Forms.Label label13;
        private BCHControls.UCDragDropDirTextBox dddMusicDirPath;
        private BCHControls.UCDragDropDirTextBox dddtbM3uPath;
        private BCHControls.UCDragDropListBox ddlbMediaList;
        private System.Windows.Forms.TextBox tbM3uName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilters;
        private System.Windows.Forms.Button btnGetM3uEntries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDirAdjustment;
        private System.Windows.Forms.Button btnSaveM3uFile;
    }
}