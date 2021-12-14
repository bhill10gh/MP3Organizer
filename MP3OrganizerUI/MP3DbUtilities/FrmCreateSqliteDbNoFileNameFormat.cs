using BCHFramework;
using ID3;
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

namespace MP3OrganizerUI.MP3DbUtilities
{
    public partial class FrmCreateSqliteDbNoFileNameFormat : Form
    {
        public FrmCreateSqliteDbNoFileNameFormat()
        {
            InitializeComponent();
        }


        private void DoSomething()
        {
            //string dir = ddlbMp3Files.ItemText;
            OperationResult op = new OperationResult();
            try
            {
                string dir = ""; 
                var extFilters = new List<string> { ".mp3" };
                var mp3s = BCHFileIO.GetAllFilesInDir(dir, ref extFilters, true, ref op);
                MP3FileDataType mP3FileDataType = GetMp3IdInfo(ddlbMp3Files.LbList[0]);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private MP3FileDataType GetMp3IdInfo(string mp3FileName)
        {
            ID3Info id3 = new ID3Info(mp3FileName, true);

            int track;

            bool isTrackGood = int.TryParse(id3.ID3v2Info.GetTextFrame("TRCK"), out track);

            MP3FileDataType mP3FileDataType = new MP3FileDataType
            {
                Album = id3.ID3v1Info.Album,
                Artists = new List<string> { id3.ID3v1Info.Artist },
                Comments = id3.ID3v1Info.Comment,
                FileName = Path.GetFileName(mp3FileName),
                FileNameNoExt = Path.GetFileNameWithoutExtension(mp3FileName),
                FileExt = Path.GetExtension(mp3FileName),
                FileNamePath = Path.GetFullPath(mp3FileName),
                FilePath = Path.GetDirectoryName(mp3FileName),
                Genre = id3.ID3v2Info.GetTextFrame("TCON"),
                SongTitle = id3.ID3v1Info.Title,
                Track = id3.ID3v1Info.TrackNumber
            };

            return mP3FileDataType;


            //tbTrack3v1.Text = id3.ID3v1Info.TrackNumber.ToString();
            //tbTitle3v1.Text = id3.ID3v1Info.Title;
            //tbArtist3v1.Text = id3.ID3v1Info.Artist;
            //tbAlbum3v1.Text = id3.ID3v1Info.Album;
            //tbYear3v1.Text = id3.ID3v1Info.Year;
            //tbComment3v1.Text = id3.ID3v1Info.Comment;
            //string genre = id3.ID3v1Info.Genre.ToString();
            //genre = string.IsNullOrEmpty(genre) ? "150" : genre;
            //cbGenre3v1.GenreIndex = int.Parse(genre);


            //tbTrack3v2.Text = id3.ID3v2Info.GetTextFrame("TRCK");
            //tbTitle3v2.Text = id3.ID3v2Info.GetTextFrame("TIT2");
            //tbArtist3v2.Text = id3.ID3v2Info.GetTextFrame("TPE1");
            //tbAlbum3v2.Text = id3.ID3v2Info.GetTextFrame("TALB");
            //tbYear3v2.Text = id3.ID3v2Info.GetTextFrame("TYER");
            //tbComment3v2.Text = id3.ID3v2Info.GetTextFrame("WCOM");
            //cbGenre3v2.Genre = id3.ID3v2Info.GetTextFrame("TCON");
        }
    }
}
