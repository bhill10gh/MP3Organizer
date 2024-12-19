namespace MP3OrganizerUI.MP3DbUtilities
{
    partial class FrmYepYepUrlManager
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
            this.btnImportYYFile = new System.Windows.Forms.Button();
            this.ddtbYepYepUrlFile = new BCHControls.UCDragDropTextBox();
            this.ddtbDbFile = new BCHControls.UCDragDropTextBox();
            this.tbEthnicity = new System.Windows.Forms.TextBox();
            this.btnAddYepYep = new System.Windows.Forms.Button();
            this.rtErrors = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnImportYYFile
            // 
            this.btnImportYYFile.Location = new System.Drawing.Point(24, 59);
            this.btnImportYYFile.Name = "btnImportYYFile";
            this.btnImportYYFile.Size = new System.Drawing.Size(75, 23);
            this.btnImportYYFile.TabIndex = 60;
            this.btnImportYYFile.Text = "Import YY File";
            this.btnImportYYFile.UseVisualStyleBackColor = true;
            this.btnImportYYFile.Click += new System.EventHandler(this.btnImportYYFile_Click);
            // 
            // ddtbYepYepUrlFile
            // 
            this.ddtbYepYepUrlFile.AllowDrop = true;
            this.ddtbYepYepUrlFile.ButtonText = "Get YY Url File";
            this.ddtbYepYepUrlFile.FileDialogTitle = null;
            this.ddtbYepYepUrlFile.ItemFilters = null;
            this.ddtbYepYepUrlFile.ItemText = "";
            this.ddtbYepYepUrlFile.LeftRight = 60;
            this.ddtbYepYepUrlFile.Location = new System.Drawing.Point(24, 14);
            this.ddtbYepYepUrlFile.Margin = new System.Windows.Forms.Padding(5);
            this.ddtbYepYepUrlFile.Name = "ddtbYepYepUrlFile";
            this.ddtbYepYepUrlFile.Size = new System.Drawing.Size(901, 36);
            this.ddtbYepYepUrlFile.TabIndex = 59;
            // 
            // ddtbDbFile
            // 
            this.ddtbDbFile.AllowDrop = true;
            this.ddtbDbFile.ButtonText = "Get DB File";
            this.ddtbDbFile.FileDialogTitle = null;
            this.ddtbDbFile.ItemFilters = null;
            this.ddtbDbFile.ItemText = "";
            this.ddtbDbFile.LeftRight = 40;
            this.ddtbDbFile.Location = new System.Drawing.Point(24, 195);
            this.ddtbDbFile.Margin = new System.Windows.Forms.Padding(5);
            this.ddtbDbFile.Name = "ddtbDbFile";
            this.ddtbDbFile.Size = new System.Drawing.Size(901, 36);
            this.ddtbDbFile.TabIndex = 58;
            this.ddtbDbFile.Load += new System.EventHandler(this.ddtbDbFile_Load);
            // 
            // tbEthnicity
            // 
            this.tbEthnicity.Location = new System.Drawing.Point(24, 120);
            this.tbEthnicity.Name = "tbEthnicity";
            this.tbEthnicity.Size = new System.Drawing.Size(100, 22);
            this.tbEthnicity.TabIndex = 61;
            this.tbEthnicity.Text = "White";
            // 
            // btnAddYepYep
            // 
            this.btnAddYepYep.Location = new System.Drawing.Point(36, 288);
            this.btnAddYepYep.Name = "btnAddYepYep";
            this.btnAddYepYep.Size = new System.Drawing.Size(150, 23);
            this.btnAddYepYep.TabIndex = 62;
            this.btnAddYepYep.Text = "Add Yep Yep Urls";
            this.btnAddYepYep.UseVisualStyleBackColor = true;
            this.btnAddYepYep.Click += new System.EventHandler(this.btnAddYepYep_Click);
            // 
            // rtErrors
            // 
            this.rtErrors.AcceptsTab = true;
            this.rtErrors.Location = new System.Drawing.Point(36, 328);
            this.rtErrors.Name = "rtErrors";
            this.rtErrors.Size = new System.Drawing.Size(809, 124);
            this.rtErrors.TabIndex = 63;
            this.rtErrors.Text = "";
            // 
            // FrmYepYepUrlManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 464);
            this.Controls.Add(this.rtErrors);
            this.Controls.Add(this.btnAddYepYep);
            this.Controls.Add(this.tbEthnicity);
            this.Controls.Add(this.btnImportYYFile);
            this.Controls.Add(this.ddtbYepYepUrlFile);
            this.Controls.Add(this.ddtbDbFile);
            this.Name = "FrmYepYepUrlManager";
            this.Text = "FrmYepYepUrlManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportYYFile;
        private BCHControls.UCDragDropTextBox ddtbYepYepUrlFile;
        private BCHControls.UCDragDropTextBox ddtbDbFile;
        private System.Windows.Forms.TextBox tbEthnicity;
        private System.Windows.Forms.Button btnAddYepYep;
        private System.Windows.Forms.RichTextBox rtErrors;
    }
}