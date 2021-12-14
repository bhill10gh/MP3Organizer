
namespace MP3OrganizerUI.MP3DbUtilities
{
    partial class TestUnformatedFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestUnformatedFile));
            this.ucDragDropDirTextBox1 = new BCHControls.UCDragDropDirTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ucDragDropListBox1 = new BCHControls.UCDragDropListBox();
            this.SuspendLayout();
            // 
            // ucDragDropDirTextBox1
            // 
            this.ucDragDropDirTextBox1.AllowDrop = true;
            this.ucDragDropDirTextBox1.ButtonText = "Add Item";
            this.ucDragDropDirTextBox1.FileDialogTitle = null;
            this.ucDragDropDirTextBox1.ItemFilters = null;
            this.ucDragDropDirTextBox1.ItemText = "";
            this.ucDragDropDirTextBox1.LeftRight = 0;
            this.ucDragDropDirTextBox1.Location = new System.Drawing.Point(13, 13);
            this.ucDragDropDirTextBox1.Name = "ucDragDropDirTextBox1";
            this.ucDragDropDirTextBox1.Size = new System.Drawing.Size(746, 27);
            this.ucDragDropDirTextBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucDragDropListBox1
            // 
            this.ucDragDropListBox1.AllowDragDrop = true;
            this.ucDragDropListBox1.AllowDrop = true;
            this.ucDragDropListBox1.AllowDupes = false;
            this.ucDragDropListBox1.FileFilter = ((System.Collections.Generic.List<string>)(resources.GetObject("ucDragDropListBox1.FileFilter")));
            this.ucDragDropListBox1.IsCaseSensitive = false;
            this.ucDragDropListBox1.LbTitle = "List";
            this.ucDragDropListBox1.Location = new System.Drawing.Point(63, 75);
            this.ucDragDropListBox1.Name = "ucDragDropListBox1";
            this.ucDragDropListBox1.ShowCountLbl = true;
            this.ucDragDropListBox1.ShowDeleteButtons = true;
            this.ucDragDropListBox1.ShowMoveButtons = true;
            this.ucDragDropListBox1.Size = new System.Drawing.Size(696, 147);
            this.ucDragDropListBox1.TabIndex = 2;
            // 
            // TestUnformatedFile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucDragDropListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucDragDropDirTextBox1);
            this.Name = "TestUnformatedFile";
            this.Text = "TestUnformatedFile";
            this.ResumeLayout(false);

        }

        #endregion

        private BCHControls.UCDragDropDirTextBox ucDragDropDirTextBox1;
        private System.Windows.Forms.Button button1;
        private BCHControls.UCDragDropListBox ucDragDropListBox1;
    }
}