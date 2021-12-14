
namespace MP3OrganizerUI.MP3DbUtilities
{
    partial class FrmMp3DbFileCreater
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
            this.ddtbMp3DbFile = new BCHControls.UCDragDropTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnComa = new System.Windows.Forms.RadioButton();
            this.rbtnTab = new System.Windows.Forms.RadioButton();
            this.btnCreateDbFile = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dddtbTargetDir = new BCHControls.UCDragDropDirTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddtbMp3DbFile
            // 
            this.ddtbMp3DbFile.AllowDrop = true;
            this.ddtbMp3DbFile.ButtonText = "Get Mp3 Db File";
            this.ddtbMp3DbFile.FileDialogTitle = null;
            this.ddtbMp3DbFile.ItemFilters = "mdb";
            this.ddtbMp3DbFile.ItemText = "";
            this.ddtbMp3DbFile.LeftRight = 40;
            this.ddtbMp3DbFile.Location = new System.Drawing.Point(12, 69);
            this.ddtbMp3DbFile.Name = "ddtbMp3DbFile";
            this.ddtbMp3DbFile.Size = new System.Drawing.Size(650, 29);
            this.ddtbMp3DbFile.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnComa);
            this.groupBox1.Controls.Add(this.rbtnTab);
            this.groupBox1.Location = new System.Drawing.Point(129, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 50);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delimiter";
            // 
            // rbtnComa
            // 
            this.rbtnComa.AutoSize = true;
            this.rbtnComa.Location = new System.Drawing.Point(57, 19);
            this.rbtnComa.Name = "rbtnComa";
            this.rbtnComa.Size = new System.Drawing.Size(52, 17);
            this.rbtnComa.TabIndex = 1;
            this.rbtnComa.Text = "Coma";
            this.rbtnComa.UseVisualStyleBackColor = true;
            // 
            // rbtnTab
            // 
            this.rbtnTab.AutoSize = true;
            this.rbtnTab.Checked = true;
            this.rbtnTab.Location = new System.Drawing.Point(7, 20);
            this.rbtnTab.Name = "rbtnTab";
            this.rbtnTab.Size = new System.Drawing.Size(44, 17);
            this.rbtnTab.TabIndex = 0;
            this.rbtnTab.TabStop = true;
            this.rbtnTab.Text = "Tab";
            this.rbtnTab.UseVisualStyleBackColor = true;
            // 
            // btnCreateDbFile
            // 
            this.btnCreateDbFile.Location = new System.Drawing.Point(16, 147);
            this.btnCreateDbFile.Name = "btnCreateDbFile";
            this.btnCreateDbFile.Size = new System.Drawing.Size(107, 23);
            this.btnCreateDbFile.TabIndex = 40;
            this.btnCreateDbFile.Text = "Create DB File";
            this.btnCreateDbFile.UseVisualStyleBackColor = true;
            this.btnCreateDbFile.Click += new System.EventHandler(this.btnCreateDbFile_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbMessages.Location = new System.Drawing.Point(16, 17);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(646, 46);
            this.rtbMessages.TabIndex = 41;
            this.rtbMessages.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Messages";
            // 
            // dddtbTargetDir
            // 
            this.dddtbTargetDir.AllowDrop = true;
            this.dddtbTargetDir.ButtonText = "Target Dir";
            this.dddtbTargetDir.FileDialogTitle = null;
            this.dddtbTargetDir.ItemFilters = null;
            this.dddtbTargetDir.ItemText = "";
            this.dddtbTargetDir.LeftRight = 40;
            this.dddtbTargetDir.Location = new System.Drawing.Point(3, 104);
            this.dddtbTargetDir.Name = "dddtbTargetDir";
            this.dddtbTargetDir.Size = new System.Drawing.Size(659, 27);
            this.dddtbTargetDir.TabIndex = 43;
            // 
            // FrmMp3DbFileCreater
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 217);
            this.Controls.Add(this.dddtbTargetDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnCreateDbFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ddtbMp3DbFile);
            this.Name = "FrmMp3DbFileCreater";
            this.Text = "Mp3DbFileCreatercs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BCHControls.UCDragDropTextBox ddtbMp3DbFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnComa;
        private System.Windows.Forms.RadioButton rbtnTab;
        private System.Windows.Forms.Button btnCreateDbFile;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Label label2;
        private BCHControls.UCDragDropDirTextBox dddtbTargetDir;
    }
}