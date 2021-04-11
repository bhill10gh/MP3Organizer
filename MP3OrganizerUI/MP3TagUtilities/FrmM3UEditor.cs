using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Web;

using BCHFramework;
using MP3OrganizerBusinessLogic;

namespace MP3OrganizerUI
{
    public partial class FrmM3UEditor : Form
    {
        #region Public Properties

        public List<string> M3UList
        {
            get
            {
                return uftM3U.GetStrList(BCHControls.UCFromToEnum.To);
            }
        }
        
        #endregion
        

        #region Members

        private int _smallFormHeight = 450;

        private int _LargeFormHeight = 660;

        #endregion

        #region Ctor

        public FrmM3UEditor()
        {
            InitializeComponent();

            ucdfs.UCFileExts.Title = "File Extention Filter";
            uftM3U.SetListBoxTitle("Media Filses", BCHControls.UCFromToEnum.From);
            uftM3U.SetListBoxTitle("M3U List", BCHControls.UCFromToEnum.To);
            uftM3U.FromAllowDrop = false;

            pnlAddFiles.Height = 620;
            btnCloseFloPnl.Focus();

            List<string> extList = new List<string>();
            extList.Add("mp3");
            extList.Add("wav");
            extList.Add("flv");
            extList.Add("avi");

            uftM3U.FileTypes = extList;

            this.Height = 450;
        }

        #endregion

        #region Events

        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddFiles.Visible = true;
            pnlM3UPlayList.Visible = false;
            if (ucdfs.UCFileExts.StringList.Count < 1)
                SetGetFilesListBoxes();
            btnCloseFloPnl.Focus();

            this.Height = _LargeFormHeight;
        }

        private void btnCloseFloPnl_Click(object sender, EventArgs e)
        {
            pnlAddFiles.Visible = false;
            pnlM3UPlayList.Visible = true;

            AddMediaFiles();
            this.Height = _smallFormHeight;
        }

        private void btnGetM3UPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath.Length < 0)
            {
                MessageBox.Show("You must choose a folder!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbM3UDir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void saveM3uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlM3UPlayList.Visible)
            {
                return;
            }

            string msg = string.Empty;

            if (tbM3UDir.Text.Length < 0)
            {
                msg = "You must have a valid M3U path selected! \n";
            }

            if (tbM3UFileName.Text.Length < 0 || tbM3UFileName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                msg += "You must have a valid file name! \n File name cannot cantain any of these characters:" +
                        Path.GetInvalidFileNameChars().ToString();
            }

            if (ckbDoArchosFormat.Checked && string.IsNullOrEmpty(tbArchosMusicRootDir.Text))
            {
                msg += "You must have an Archos Directory";
            }

            if (msg.Length < 0)
            {
                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationResult op = new OperationResult();
            M3UEditor me = new M3UEditor();

            string fileName = Path.Combine(tbM3UDir.Text, tbM3UFileName.Text);

            me.SetM3U(fileName, uftM3U.GetStrList(BCHControls.UCFromToEnum.To), true, ref op);

            if (!op.Success)
            {
                MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (rbDoArchosM3UFormat.Checked || rbPlainM3U.Checked)
            {
                if (rbDoArchosM3UFormat.Checked)
                {
                    ConvertToArchosFormat(ref me, ref op);
                    if (!op.Success)
                    {
                        MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                me.CreateM3U(ref op);
            }
            else
            {
                SaveMediaPlayerFormat(fileName, ref me, ref op);
            }

            

            MessageBox.Show("M3U File Created.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openM3UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName.Trim().Length < 1 || !File.Exists(openFileDialog1.FileName))
            {
                MessageBox.Show("You must choose a file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationResult op = new OperationResult();

            M3UEditor me = new M3UEditor();

            me.SetM3U(openFileDialog1.FileName, new List<string>(), false, ref op);

            if (!op.Success)
            {
                MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            uftM3U.SetListBox(me.M3USongList, BCHControls.UCFromToEnum.To, true);

        }

        private void btnGetDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            if (folderBrowserDialog1.SelectedPath.Length < 0)
            {
                MessageBox.Show("You must choose a folder!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbMusicDirs.DataSource = BCHFileIO.GetDirPathsInPath(folderBrowserDialog1.SelectedPath);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddFiles.Visible = false;
            pnlM3UPlayList.Visible = true;
            this.Height = _smallFormHeight;
        }

        private void btnSortByArtist_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            uftM3U.SortListBox(BCHControls.UCFromToEnum.To, new CmpMP3Artist(), ref op);

            if (!op.Success)
            {
                MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSortBySong_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            uftM3U.SortListBox(BCHControls.UCFromToEnum.To, new CmpMP3Song(), ref op);

            if (!op.Success)
            {
                MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSortByDir_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            uftM3U.SortListBox(BCHControls.UCFromToEnum.To, new CmpMP3Path(), ref op);

            if (!op.Success)
            {
                MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSortByDirArtSng_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            uftM3U.SortListBox(BCHControls.UCFromToEnum.To, new CmpMP3PathArtistSong(), ref op);

            if (!op.Success)
            {
                MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCnvrtBckToPC_Click(object sender, EventArgs e)
        {
            if (uftM3U.GetStrList(BCHControls.UCFromToEnum.To).Count < 1)
                return;

            if (rbDoArchosM3UFormat.Checked)
            {
                ConvertFromArchosToPc();
            }
            else if (rbDoMediaPlayerFormat.Checked)
            {

            }
        }

        private void btnChngRootDir_Click(object sender, EventArgs e)
        {
            ChangeM3UListRootDir();
        }

        private void openWPLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWPL();
        }
        
        #endregion

        #region Methods

        private void ConvertToArchosFormat(ref M3UEditor me, ref OperationResult op)
        {
            List<string> list = new List<string>();

            string rootMusicDir = tbArchosMusicRootDir.Text;
            int rootPos = -1;
            string archosVer = string.Empty;


            foreach (string song in me.M3USongList)
            {
                archosVer = song;
                rootPos = archosVer.IndexOf(rootMusicDir, StringComparison.CurrentCultureIgnoreCase);

                if (rootPos > -1)
                {
                    list.Add(archosVer.Substring(rootPos).Replace("\\", "/"));
                }
                else
                {
                    op.AddError("One or more songs do not contain " + rootMusicDir + " in it's path");
                    return;
                }
            }

            me.SetM3USongs(list, false, ref op);
        }

        private void SaveMediaPlayerFormat(string fileName, ref M3UEditor me, ref OperationResult op)
        {
            List<string> list = new List<string>();
            XmlDocument wpl = new XmlDocument();

            XmlNode smil = wpl.CreateElement("smil");
            wpl.AppendChild(smil);

            XmlNode head = wpl.CreateElement("head");
            smil.AppendChild(head);

            XmlNode meta = wpl.CreateElement("meta");
            head.AppendChild(meta);
            XmlAttribute attribute = wpl.CreateAttribute("name");
            attribute.Value = "Generator";
            meta.Attributes.Append(attribute);
            attribute = wpl.CreateAttribute("content");
            attribute.Value = "Microsoft Windows Media Player -- 12.0.7600.20792";
            meta.Attributes.Append(attribute);

            meta = wpl.CreateElement("meta");
            head.AppendChild(meta);
            attribute = wpl.CreateAttribute("name");
            attribute.Value = "ItemCount";
            meta.Attributes.Append(attribute);
            attribute = wpl.CreateAttribute("content");
            attribute.Value = me.M3USongList.Count.ToString();
            meta.Attributes.Append(attribute);

            XmlNode title = wpl.CreateElement("title");
            head.AppendChild(title);
            title.AppendChild(wpl.CreateTextNode(Path.GetFileNameWithoutExtension(tbM3UFileName.Text)));

            XmlNode body = wpl.CreateElement("body");
            smil.AppendChild(body);

            XmlNode seq = wpl.CreateElement("seq");
            body.AppendChild(seq);
            
            string rootMusicDir = tbArchosMusicRootDir.Text;
            


            foreach (string song in me.M3USongList)
            {
                XmlNode media = wpl.CreateElement("media");
                seq.AppendChild(media);
                attribute = wpl.CreateAttribute("src");
                attribute.Value = HttpUtility.HtmlEncode(song);
                media.Attributes.Append(attribute);
            }

            wpl.Save(fileName + ".wpl");
    
        }

        private void SetGetFilesListBoxes()
        {
            List<string> extList = new List<string>();
            extList.Add("mp3");
            //extList.Add("wav");
            //extList.Add("flv");
            //extList.Add("avi");
            ucdfs.UCFileExts.SetListboxList(extList);

            List<string> mList = uftM3U.GetStrList(BCHControls.UCFromToEnum.From);
            ucdfs.AddToFileList(uftM3U.GetStrList(BCHControls.UCFromToEnum.From));
        }

        private void AddMediaFiles()
        {

            uftM3U.SetListBox(ucdfs.FileList, BCHControls.UCFromToEnum.From, false);
        }

        private void ConvertFromArchosToPc()
        {
            List<string> oldList = uftM3U.GetStrList(BCHControls.UCFromToEnum.To);
            List<string> newList = new List<string>();

            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath.Length < 1)
            {
                MessageBox.Show("A folder must be chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dir = folderBrowserDialog1.SelectedPath;

            foreach (string item in oldList)
            {
                string str = Path.Combine(dir, item.Replace("/", "\\"));
                newList.Add(str);
            }

            uftM3U.SetListBox(newList, BCHControls.UCFromToEnum.To, true);

        }

        private void ChangeM3UListRootDir()
        {
            List<string> list = uftM3U.GetStrList(BCHControls.UCFromToEnum.To);
            List<string> newList = new List<string>();

            if (tbArchosMusicRootDir.Text.Length < 1)
            {
                MessageBox.Show("A root folder must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            folderBrowserDialog1.Description = "Choose the new root";
            folderBrowserDialog1.ShowDialog();

            if (folderBrowserDialog1.SelectedPath.Length < 1)
            {
                MessageBox.Show("A folder must be chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newDir = folderBrowserDialog1.SelectedPath;
            string rootDir = tbArchosMusicRootDir.Text.Trim();

            for (int i = 0; i < list.Count; i++)
            {
                string item = list[i];
                if (item.ToUpper().Contains(rootDir.ToUpper()))
                {
                    int rtPos = item.IndexOf(rootDir, 0);
                    newList.Add(Path.Combine(newDir, item.Substring(rtPos)));
                }
            }

            uftM3U.SetListBox(newList, BCHControls.UCFromToEnum.To, true);
        }

        private void OpenWPL()
        {
            OperationResult op = new OperationResult();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Windows Media Player Play List|*.wpl";
            openFileDialog1.Title = "Choose a wpl file.";
            openFileDialog1.ShowDialog();

            if(!File.Exists(openFileDialog1.FileName))
            {
                return;
            }

            try
            {
                //XmlDocument wpl = new XmlDocument();
                //wpl.Load(openFileDialog1.FileName);

                XPathDocument wpl = new XPathDocument(openFileDialog1.FileName);
                XPathNavigator nav = wpl.CreateNavigator();

                // Compile a standard XPath expression
                XPathExpression expr;
                expr = nav.Compile("/smil/body/seq/media/@src");
                XPathNodeIterator iterator = nav.Select(expr);

                // Iterate on the node set
                List<string> list = new List<string>();

                while (iterator.MoveNext())
                {
                    XPathNavigator nav2 = iterator.Current.Clone();
                    string nav2str = "";
                    nav2.MoveToFirstChild();
                    if (nav2.Name.Length < 1)
                        nav2str = string.Empty; // nav2.Value;
                    else
                        nav2str = nav2.Value; // nav2.Name + ": " + nav2.Value;
                    list.Add(nav2str);
                    while (nav2.MoveToNext())
                    {
                        if (nav2.Name.Length < 1)
                            nav2str = string.Empty; // nav2.Value;
                        else
                            nav2str = nav2.Value; // nav2.Name + ": " + nav2.Value;
                        list.Add(nav2str);
                    }
                }
                this.uftM3U.SetListBox(list, BCHControls.UCFromToEnum.To, true);
            }
            catch (Exception ex)
            {                
                op.AddException(ex);
                MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        #endregion

        

    }
}
