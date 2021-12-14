
namespace MP3OrganizerUI.MP3DbUtilities
{
    partial class FrmCreateSqliteDbNoFileNameFormat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateSqliteDbNoFileNameFormat));
            this.ddlbMp3Files = new BCHControls.UCDragDropListBox();
            this.SuspendLayout();
            // 
            // ddlbMp3Files
            // 
            this.ddlbMp3Files.AllowDragDrop = true;
            this.ddlbMp3Files.AllowDrop = true;
            this.ddlbMp3Files.AllowDupes = false;
            this.ddlbMp3Files.FileFilter = ((System.Collections.Generic.List<string>)(resources.GetObject("ddlbMp3Files.FileFilter")));
            this.ddlbMp3Files.IsCaseSensitive = false;
            this.ddlbMp3Files.LbTitle = "List";
            this.ddlbMp3Files.Location = new System.Drawing.Point(52, 152);
            this.ddlbMp3Files.Name = "ddlbMp3Files";
            this.ddlbMp3Files.ShowCountLbl = true;
            this.ddlbMp3Files.ShowDeleteButtons = true;
            this.ddlbMp3Files.ShowMoveButtons = true;
            this.ddlbMp3Files.Size = new System.Drawing.Size(696, 147);
            this.ddlbMp3Files.TabIndex = 3;
            // 
            // FrmCreateSqliteDbNoFileNameFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddlbMp3Files);
            this.Name = "FrmCreateSqliteDbNoFileNameFormat";
            this.Text = "FrmCreateSqliteDbNoFileNameFormat";
            this.ResumeLayout(false);

        }

        #endregion

        private BCHControls.UCDragDropListBox ddlbMp3Files;
    }
}