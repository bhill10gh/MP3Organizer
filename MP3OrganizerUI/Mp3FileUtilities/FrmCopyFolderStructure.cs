using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace CopyFolderStructure
{
    public partial class FrmCopyFolderStructure : Form
    {
        public FrmCopyFolderStructure()
        {
            InitializeComponent();
        }

        private void btnCreateFolders_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            string rootDir = dddtbRootDir.ItemText;
            string destDir = dddrDestinationDir.ItemText;

            if (!Directory.Exists(rootDir))
            {
                msg = "Root folder does not exist.\n";
            }

            if (!Directory.Exists(destDir))
            {
                msg += "Destination folder does not exist.";
            }

            if (msg.Trim().Length > 0)
            {
                ShowMsg(msg, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateFolders(rootDir, destDir);
        }


        private void CreateFolders(string rootDir, string destDir)
        {

            string msg = string.Empty;

            try
            {
                ProcessDirectory(rootDir);
            }
            catch (Exception ex)
            {

                ShowMsg(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowMsg("Success.", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void ProcessDirectory(string targetDirectory)
        {

            foreach (string subdirectory in Directory.GetDirectories(targetDirectory))
                ProcessDirectory(subdirectory);

            // Here is called for each directory and sub directory
            string copyFolder = targetDirectory.Replace(dddtbRootDir.ItemText, string.Empty);

            if (copyFolder.StartsWith("\\"))
                copyFolder = copyFolder.Substring(1);

            string newFolder = Path.Combine(dddrDestinationDir.ItemText, copyFolder);

            if (!Directory.Exists(newFolder))
            {
                Directory.CreateDirectory(newFolder);
            }
        }

        private void ShowMsg(string msg, string caption, MessageBoxButtons btn, MessageBoxIcon icon)
        {
            MessageBox.Show(msg, caption, btn, icon);
        }

        
    }
}
