using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ID3;
using MP3OrganizerBusinessLogic;
using System.IO;
using BCHControls;
using BCHFramework;
using DAL;

namespace MP3OrganizerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PopulateUcftddf();
            //textBox1.Text = @"c:\artist 01-artist 02-33-artist03--song title~rendition_comment.mp3";
            //textBox1.Text = "song title~rendition";
            //textBox1.Text = @"F:\SimpleTech\Computer Science\C Sharp\Projects\MP3Organizer";
            //textBox1.Text = @"F:\SimpleTech\Computer Science\C Sharp\Projects\MP3Organizer\MP3OrganizerUI\bin\Debug\Copy of Babyface-06--Where Will You Go.mp3";
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestDALXML();
        }

        private void TestDALXML()
        {
            OperationResult op = new OperationResult();

            //SqlScripts ss = new SqlScripts();
            //string xmlFileName = @"F:\Barry Hill\Computer Science\C Sharp\Projects\MP3Organizer\DAL\SqlScripts.xml";
            //ss.Load(xmlFileName, ref op);

            DAL.DataStore dal = new DataStore();

            
        }

        private void PopulateUcftddf()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 12; i++)
            {
                list.Add("Item #" + i.ToString());
            }
            ucftddf.SetListBox(list,UCFromToEnum.From, true);
            ucftddf.SetListBox(list, UCFromToEnum.To, true);
        }

        private void TestMP3Parcing()
        {
            OperationResult op = new OperationResult();
            string fileNamePath = @"H:\Barry Hill\My Music\Music\R&B\Anita Baker\Giving You the Best That I Got\Anita Baker-01--Priceless.mp3";
            string mscRtDir = @"H:\Barry Hill\My Music\Music";
            textBox1.Text = fileNamePath;
            MP3FileDataType mp3 = BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmtWithDirInfo(fileNamePath, mscRtDir, ref op);

            Dictionary<string, string> dict = BCHUtilities.GetObjectNamePropDict<MP3FileDataType>(mp3, ref op);
            textBox2.Text = BCHUtilities.DictionaryToString(dict,";");
            listBox1.DataSource = dict.Values.ToList<string>();
        }

        private void TestGetDirFormPath()
        {
            textBox1.Text = @"H:\Barry Hill\My Music\Music\R&B\Anita Baker\Giving You the Best That I Got\Anita Baker-01--Priceless.mp3";

            //MP3FileDataType mp3 = BCHMP3Utilities.GetMp3InfoByDir(

            textBox2.Text = Path.GetDirectoryName(textBox1.Text);
        }

        private void TestCode01()
        {
            string fileName = textBox1.Text; // @"F:\SimpleTech\Computer Science\C Sharp\Projects\MP3Organizer\MP3OrganizerUI\bin\Debug\Copy of Babyface-06--Where Will You Go.mp3";

            FileSearch fs = new FileSearch();
            fs.SearchString = "M*3";
            fs.StartDir = textBox1.Text;
            //fs.StartSearch();
            List<string> strList = fs.Files;//DirPathUtilities.GetDirPathsInPath(fileName);
            listBox1.DataSource = strList;

            //openFileDialog1.ShowDialog();
            //fileName = openFileDialog1.FileName;
            //ExecCodeProj(fileName);

            //string[] strLst = textBox1.Text.Split('~');
            //textBox2.Text = strLst[0] + ";" + strLst[1];
            //AbstractMP3Info mp3Info = new MP3InfoBCHFrmt();
            //mp3Info.LoadMp3File(fileName);
            //textBox2.Text = mp3Info.GetAllArtist() + " | " + mp3Info.Track + " | " + mp3Info.SongTitle + " | " + mp3Info.SongNumeration
            //                + " | " + mp3Info.Comments + " | " + Path.GetExtension(mp3Info.FileName);

            //folderBrowserDialog1.ShowDialog();
            //textBox2.Text += " | " + folderBrowserDialog1.SelectedPath;

            //FileSearch fs = new FileSearch();

            //fs.FileFilters.Add(".mp3");

            //fs.StartDir = @"F:\SimpleTech\Audio Visual\My Music\Formated"; // folderBrowserDialog1.SelectedPath;
            //fs.StartDir = @"H:\SimpleTech\Audio Visual\My Music";
            //fs.StartSearch();
            //listBox1.DataSource = fs.Files;
            //textBox3.Text = fs.Files.Count.ToString();

        }

        private void TestCode02()
        {
            List<string> listFrom = new List<string>();

            for (int i = 0; i < 15; i++)
            {
                listFrom.Add("Item {0}" + i.ToString());
            }

            FrmFromTo tf = new FrmFromTo();

            tf.UCFromTo.SetListBox(listFrom, UCFromToEnum.From, true);

            tf.ShowDialog();

        }

        private void TestMP3FileNameConverter()
        {
            OperationResult op = new OperationResult();

            MP3FileDataType me = BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmt(textBox1.Text, ref op);

            if (!op.Success)
            {
                MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox2.Text = me.FileName + "; " + me.FilePath + "; ";
        }

        private void ExecCodeProj(string fileName)
        {
            ID3Info id3Info = new ID3Info(fileName, true);
            id3Info.Load();
            textBox1.Text = id3Info.ID3v2Info.GetTextFrame("TIT2") + ";" + id3Info.ID3v1Info.Title;

            id3Info.ID3v2Info.SetTextFrame("TIT2", id3Info.ID3v1Info.Title.Trim());
            id3Info.ID3v1Info.Title = id3Info.ID3v1Info.Title.Trim() + "";
            id3Info.Save();

            textBox2.Text = id3Info.ID3v2Info.GetTextFrame("TIT2") + ";" + id3Info.ID3v1Info.Title;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }
        
        private void MakeArchosCompatible()
        {
            string origMp3 = textBox1.Text;
            string rootMusicDir = textBox2.Text;
            string archosVer = string.Empty;
            int rootPos = origMp3.IndexOf(rootMusicDir, StringComparison.CurrentCultureIgnoreCase);
            archosVer = origMp3.Substring(rootPos).Replace("\\", "/");
            textBox4.Text = archosVer;


        }


         //txt2Track.Text = Data.ID3v2Info.GetTextFrame("TRCK");
         //       txt2Set.Text = Data.ID3v2Info.GetTextFrame("TPOS");
         //       txt2Title.Text = Data.ID3v2Info.GetTextFrame("TIT2");
         //       txt2Artist.Text = Data.ID3v2Info.GetTextFrame("TPE1");
         //       txt2Album.Text = Data.ID3v2Info.GetTextFrame("TALB");
         //       cmb2Genre.Genre = Data.ID3v2Info.GetTextFrame("TCON");
         //       cmb2Language.Language = Data.ID3v2Info.GetTextFrame("TLAN");

        
    }
}
