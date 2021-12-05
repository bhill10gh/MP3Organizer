using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using BCHFramework;
using BCHControls;
using MP3OrganizerUI;

using ID3;


namespace MP3OrganizerUI
{
    public partial class FrmMp3TagEditor : Form
    {
        public FrmMp3TagEditor()
        {
            InitializeComponent();

            cbGenre3v1.DataSource = BCHMP3Utilities.GetGenre();
            cbGenre3v2.DataSource = BCHMP3Utilities.GetGenre();
        }

        #region Events

        private void btnGetMP3TagData_Click(object sender, EventArgs e)
        {
            if (!Path.GetExtension(ddtbMp3File.ItemText).ToLower().EndsWith(".mp3"))
            {
                MessageBox.Show("Please enter a valid MP3 file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GetMp3IdInfo();
        }

        private void btnEditTag_Click(object sender, EventArgs e)
        {
            if (!Path.GetExtension(ddtbMp3File.ItemText).ToLower().EndsWith(".mp3"))
            {
                MessageBox.Show("Please enter a valid MP3 file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveMp3IdInfo();
        }
               

        private void btnCopyFrom3v2_Click(object sender, EventArgs e)
        {
            tbAlbum3v1.Text = tbAlbum3v2.Text;
            tbArtist3v1.Text = tbArtist3v2.Text;
            tbComment3v1.Text = tbComment3v2.Text;
            tbTitle3v1.Text = tbTitle3v2.Text;
            tbTrack3v1.Text = tbTrack3v2.Text;
            tbYear3v1.Text = tbYear3v2.Text;
            cbGenre3v1.GenreIndex = cbGenre3v2.GenreIndex;


        }

        private void btnCopyFrom3v1_Click(object sender, EventArgs e)
        {
            tbAlbum3v2.Text = tbAlbum3v1.Text;
            tbArtist3v2.Text = tbArtist3v1.Text;
            tbComment3v2.Text = tbComment3v1.Text;
            tbTitle3v2.Text = tbTitle3v1.Text;
            tbTrack3v2.Text = tbTrack3v1.Text;
            tbYear3v2.Text = tbYear3v1.Text;
            cbGenre3v2.GenreIndex = cbGenre3v1.GenreIndex;
        }

        private void btnGetMusicInfo_Click(object sender, EventArgs e)
        {
            if (!Path.GetExtension(ddtbMp3File.ItemText).ToLower().EndsWith(".mp3"))
            {
                MessageBox.Show("Please enter a valid MP3 file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dddtbGetRootDir.ItemText.Trim().Length < 1)
            {
                MessageBox.Show("You must choose a music root folder!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationResult op = new OperationResult();

            string mscRtDir = dddtbGetRootDir.ItemText;
            string fileNamePath = ddtbMp3File.ItemText;

            try
            {
                MP3FileDataType me = ckbUseDirForInfo.Checked ? BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmtWithDirInfo(fileNamePath, mscRtDir, ref op)
                    : BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmt(fileNamePath, ref op);

                if (!op.Success)
                {
                    MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tbCalcTrack.Text = me.Track != null ? me.Track.ToString() : string.Empty;
                tbCalcTitle.Text = me.SongTitleAndNumeration ?? string.Empty;
                tbCalcArtists.Text = me.ArtistsStrList ?? string.Empty;
                tbCalcAlbum.Text = me.Album ?? string.Empty;
                tbcalcComment.Text = me.Comments ?? string.Empty;
                tbCalcGenre.Text = me.Genre ?? string.Empty;

            }
            catch (Exception ex)
            {
                op.AddException(ex);

                MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnPopWithNameInfo_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();

            if (!Path.GetExtension(ddtbMp3File.ItemText).ToLower().EndsWith(".mp3"))
            {
                MessageBox.Show("Please enter a valid MP3 file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MP3FileDataType me = ckbUseDirForInfo.Checked ? BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmtWithDirInfo(ddtbMp3File.ItemText, 
                dddtbGetRootDir.ItemText, ref op) : BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmt(ddtbMp3File.ItemText, ref op);

            if (!op.Success)
            {
                MessageBox.Show(op.GetAllMessages("\n"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbTrack3v1.Text = me.Track != null ? me.Track.ToString() : string.Empty;
            tbTitle3v1.Text = me.SongTitleAndNumeration ?? string.Empty;
            tbArtist3v1.Text = me.ArtistsStrList ?? string.Empty;
            tbAlbum3v1.Text = me.Album ?? string.Empty;
            tbComment3v1.Text = me.Comments ?? string.Empty;
            string genre = me.Genre ?? string.Empty;
            genre = string.IsNullOrEmpty(genre) || !BCHMP3Utilities.GetGenre().Contains(genre.Trim(),
                StringComparer.CurrentCultureIgnoreCase) ? "150" : genre;
            cbGenre3v1.Genre = genre;

            tbTrack3v2.Text = me.Track != null ? me.Track.ToString() : string.Empty;
            tbTitle3v2.Text = me.SongTitleAndNumeration ?? string.Empty;
            tbArtist3v2.Text = me.ArtistsStrList ?? string.Empty;
            tbAlbum3v2.Text = me.Album ?? string.Empty;
            tbComment3v2.Text = me.Comments ?? string.Empty;
            cbGenre3v2.Genre = me.Genre ?? string.Empty;
        }        

        #endregion

        #region Methods

        private void GetMp3IdInfo()
        {
            ID3Info id3 = new ID3Info(ddtbMp3File.ItemText, true);
            

            tbTrack3v1.Text = id3.ID3v1Info.TrackNumber.ToString();            
            tbTitle3v1.Text = id3.ID3v1Info.Title;
            tbArtist3v1.Text = id3.ID3v1Info.Artist;
            tbAlbum3v1.Text = id3.ID3v1Info.Album;
            tbYear3v1.Text = id3.ID3v1Info.Year;
            tbComment3v1.Text = id3.ID3v1Info.Comment;
            string genre = id3.ID3v1Info.Genre.ToString();
            genre = string.IsNullOrEmpty(genre) ? "150" : genre;
            cbGenre3v1.GenreIndex = int.Parse(genre);
            
            
            tbTrack3v2.Text = id3.ID3v2Info.GetTextFrame("TRCK");
            tbTitle3v2.Text = id3.ID3v2Info.GetTextFrame("TIT2");
            tbArtist3v2.Text = id3.ID3v2Info.GetTextFrame("TPE1");
            tbAlbum3v2.Text = id3.ID3v2Info.GetTextFrame("TALB");
            tbYear3v2.Text = id3.ID3v2Info.GetTextFrame("TYER");
            tbComment3v2.Text = id3.ID3v2Info.GetTextFrame("WCOM");
            cbGenre3v2.Genre = id3.ID3v2Info.GetTextFrame("TCON");
        }

        private void SaveMp3IdInfo()
        {
            ID3Info id3 = new ID3Info(ddtbMp3File.ItemText, true);


            try
            {
                id3.ID3v1Info.TrackNumber = BCHUtilities.IsNumeric(tbTrack3v1.Text) ? byte.Parse(tbTrack3v1.Text) : byte.Parse("1");
                id3.ID3v1Info.Title = tbTitle3v1.Text;
                id3.ID3v1Info.Artist = tbArtist3v1.Text;
                id3.ID3v1Info.Album = tbAlbum3v1.Text;
                id3.ID3v1Info.Year = tbYear3v1.Text;
                id3.ID3v1Info.Comment = tbComment3v1.Text;
                id3.ID3v1Info.Genre = Convert.ToByte(cbGenre3v1.GenreIndex);


                id3.ID3v2Info.SetTextFrame("TRCK", tbTrack3v2.Text);
                id3.ID3v2Info.SetTextFrame("TIT2", tbTitle3v2.Text);
                id3.ID3v2Info.SetTextFrame("TPE1", tbArtist3v2.Text);
                id3.ID3v2Info.SetTextFrame("TALB", tbAlbum3v2.Text);
                id3.ID3v2Info.SetTextFrame("TYER", tbYear3v2.Text);
                id3.ID3v2Info.SetTextFrame("WCOM", tbComment3v2.Text);
                id3.ID3v2Info.SetTextFrame("TCON", cbGenre3v2.Genre);

                id3.ID3v2Info.HaveTag = true;
                id3.ID3v1Info.HaveTag = true;

                id3.Save();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        #endregion 







    }
}
/*

 Data.ID3v2Info.SetMinorVersion(Ver);
                Data.ID3v2Info.SetTextFrame("TIT2", txt2Title.Text);
                Data.ID3v2Info.SetTextFrame("TRCK", txt2Track.Text);
                Data.ID3v2Info.SetTextFrame("TPOS", txt2Set.Text);
                Data.ID3v2Info.SetTextFrame("TPE1", txt2Artist.Text);
                Data.ID3v2Info.SetTextFrame("TALB", txt2Album.Text);
                Data.ID3v2Info.SetTextFrame("TCON", cmb2Genre.Genre);
                Data.ID3v2Info.SetTextFrame("TLAN", cmb2Language.Language);
 * 
 * 
 * Data.ID3v1Info.TrackNumber = Convert.ToByte(txt1Track.Text);
                Data.ID3v1Info.Title = txt1Title.Text;
                Data.ID3v1Info.Artist = txt1Artist.Text;
                Data.ID3v1Info.Album = txt1Album.Text;
                Data.ID3v1Info.Genre = Convert.ToByte(cmb1Genre.GenreIndex);
                Data.ID3v1Info.Year = txt1Year.Text;
                Data.ID3v1Info.Comment = txt1Comment.Text;
 * 
 * 
 * 
 *             if (chbContain1.Checked)
            {
                txt1Track.Text = Data.ID3v1Info.TrackNumber.ToString();
                txt1Title.Text = Data.ID3v1Info.Title;
                txt1Artist.Text = Data.ID3v1Info.Artist;
                txt1Album.Text = Data.ID3v1Info.Album;
                cmb1Genre.GenreIndex = Data.ID3v1Info.Genre;
                txt1Year.Text = Data.ID3v1Info.Year;
                txt1Comment.Text = Data.ID3v1Info.Comment;
            }

            if (chbContain2.Checked)
            {
                if (Data.ID3v2Info.VersionInfo.Minor != 3 && Data.ID3v2Info.VersionInfo.Minor != 4)
                    cmb2Ver.Text = "3";
                else
                    cmb2Ver.Text = Data.ID3v2Info.VersionInfo.Minor.ToString();

                txt2Track.Text = Data.ID3v2Info.GetTextFrame("TRCK");
                txt2Set.Text = Data.ID3v2Info.GetTextFrame("TPOS");
                txt2Title.Text = Data.ID3v2Info.GetTextFrame("TIT2");
                txt2Artist.Text = Data.ID3v2Info.GetTextFrame("TPE1");
                txt2Album.Text = Data.ID3v2Info.GetTextFrame("TALB");
                cmb2Genre.Genre = Data.ID3v2Info.GetTextFrame("TCON");
                cmb2Language.Language = Data.ID3v2Info.GetTextFrame("TLAN");

*/