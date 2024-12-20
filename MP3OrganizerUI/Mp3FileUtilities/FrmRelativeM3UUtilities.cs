using BCHControls;
using BCHFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3OrganizerUI.Mp3FileUtilities
{
    public partial class FrmRelativeM3UUtilities : Form
    {


        public FrmRelativeM3UUtilities()
        {
            InitializeComponent();
            ddlbMediaList.BeforeDragAndDropListBoxEvent += BeforeDragAndDropListBoxEvent;
        }

        private void Item_DragEnter(object sender, DragEventArgs e)
        {
            DragEnter(sender, e);
        }

        private void Item_DragDrop(object sender, DragEventArgs e)
        {
            AddDroppedFiles(sender, e);
        }

        private new void DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void AddDroppedFiles(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string f = ((string[])e.Data.GetData(DataFormats.FileDrop))?[0];

                List<string> extList = new List<string>();
                int extCnt = extList != null && extList.Count > 0 ? extList.Count : 0;

                if (string.IsNullOrWhiteSpace(f))
                    return;

                FileAttributes attr = File.GetAttributes(f);

                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    return;
                }

                bool isGood = false;

                if (extCnt > 0 && extList != null && extList.Any())
                {
                    foreach (string ext in extList)
                    {
                        if (f.EndsWith(ext, StringComparison.CurrentCultureIgnoreCase))
                        {
                            tbM3uName.Text = f;
                            isGood = true;
                        }
                    }
                }
                else
                {
                    tbM3uName.Text = f;
                    isGood = true;
                }

                if (!isGood)
                {
                    tbMessages.Text = "Error: Drag and drop failed";
                }

                if (isGood)
                {
                    AfterTextDragEvent(f);
                }
            }
        }

        private void AfterTextDragEvent(string f)
        {
            tbM3uName.Text = Path.GetFileName(f);
            dddtbM3uPath.ItemText = Path.GetDirectoryName(f);
        }

        private void btnSaveM3uFile_Click(object sender, EventArgs e)
        {
            if(ddlbMediaList.LbList.Count > 0)
            {
                OperationResult op = new OperationResult();
                try
                {
                    string file = Path.Combine(dddtbM3uPath.ItemText, tbM3uName.Text);
                    BCHFileIO.WriteFullFile(file, ddlbMediaList.LbList, ref op);
                    tbMessages.Text = ("M3U file saved!");
                }
                catch (Exception ex)
                {

                    op.AddException(ex);
                    tbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                }
            }
        }

        private void btnGetM3uEntries_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            try
            {
                string file = Path.Combine(dddtbM3uPath.ItemText, tbM3uName.Text);
                if (File.Exists(file))
                {
                    var m3uPlaylist = BCHFileIO.ReadFullFile(file, ref op);
                    if(!op.Success)
                    {
                        tbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                        return;
                    }
                    ddlbMediaList.LbList = m3uPlaylist;
                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                tbMessages.Text = op.GetAllErrorsAndExceptions("\n");
            }
        }

        private List<string> BeforeDragAndDropListBoxEvent(ref List<string> files)
        {
            OperationResult op = new OperationResult();
            try
            {
                List<string> playListItems = new List<string>();
                foreach (string file in files)
                {
                    string f = file.Replace(dddMusicDirPath.ItemText + "\\", "");
                    f = tbDirAdjustment.Text + f;
                    f = f.Replace("\\", "/");
                    playListItems.Add(f);
                }

                return playListItems;
            }
            catch (Exception ex)
            {

                op.AddException(ex);
                tbMessages.Text = op.GetAllErrorsAndExceptions("\n");
                return new List<string>();
            }
        }
    }
}
