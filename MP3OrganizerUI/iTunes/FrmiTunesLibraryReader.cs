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
using System.Xml.Linq;

using MP3OrganizerBusinessLogic;
using BCHFramework;

namespace MP3OrganizerUI.iTunes
{
    public partial class FrmiTunesLibraryReader : Form
    {
        public FrmiTunesLibraryReader()
        {
            InitializeComponent();

            ucGetFilePath1.SetControlFromConfig("iTunesLibraryFile", 0, "", 2, true);

            tbOutputFilePath.Text = BCHUtilities.GetConfigValue("iTunesPlayListFolder", 0, "", 2, false);
        }


        #region Members

        iTunesSongs iTuneSongs { get; set; }
        iTunesPlayLists iTunesPlayLists { get; set; }

        #endregion

        #region Events

        private void btnReadLibraryFile_Click(object sender, EventArgs e)
        {
            tbMessages.Text = "";

            OperationResult op = new OperationResult();

            try
            {
                GetiTunesLibXml();
            }
            catch (Exception ex)
            {
                op.AddException(ex);

                tbMessages.Text = op.GetAllErrorsAndExceptionsWthNl();
                return;
            }

            if(!op.Success)
            {
                tbMessages.Text = op.GetAllErrorsAndExceptionsWthNl();
                return;
            }

            tbMessages.Text = "Finished";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[0];

                string plName = cell.Value.ToString();

                iTunesPlayList pl = this.iTunesPlayLists.ITunesPlayLists.Find(s => s.Name == plName);
                if (pl != null)
                {
                    dataGridView3.DataSource = pl.Songs.iTunesSongList;
                    dataGridView3.Refresh();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnExportSongList_Click(object sender, EventArgs e)
        {
            if (this.iTuneSongs == null || iTuneSongs.iTunesSongList.Count < 1)
            {
                GetiTunesLibXml();
            }

            List<string> list = GetSongsList(this.iTuneSongs);

            OperationResult op = new OperationResult();

            string path = this.tbOutputFilePath.Text;
            string fName = Path.Combine(path, "iTunesSongs.txt");

            BCHFileIO.WriteFullFile(fName, list, ref op);

            if (!op.Success)
            {
                tbMessages.Text = op.GetAllErrorsAndExceptionsWthNl();
                return;
            }

            tbMessages.Text = "Finished";
        }

        private void btnExportPlayLists_Click(object sender, EventArgs e)
        {
            tbMessages.Text = "";

            OperationResult op = new OperationResult();

            if (this.iTuneSongs == null || iTuneSongs.iTunesSongList.Count < 1 ||
                this.iTunesPlayLists == null || this.iTunesPlayLists.ITunesPlayLists.Count < 1)
            {
                GetiTunesLibXml();
            }

            List<Tuple<string, List<string>>> pls = GetPlayListSongsTuple();

            foreach (var kv in pls)
            {
                string path = this.tbOutputFilePath.Text;
                string fName = Path.Combine(path, kv.Item1 + ".txt");

                BCHFileIO.WriteFullFile(fName, kv.Item2, ref op);

                if (!op.Success)
                {
                    tbMessages.Text = op.GetAllErrorsAndExceptionsWthNl();
                    return;
                }
            }

            if (!op.Success)
            {
                tbMessages.Text = op.GetAllErrorsAndExceptionsWthNl();
                return;
            }

            tbMessages.Text = "Finished";
        }

        private void btnCrtMu3FrmPlyLst_Click(object sender, EventArgs e)
        {
            tbMessages.Text = "";

            OperationResult op = new OperationResult();

            try
            {
                if (this.iTuneSongs == null || iTuneSongs.iTunesSongList.Count < 1 ||
                        this.iTunesPlayLists == null || this.iTunesPlayLists.ITunesPlayLists.Count < 1)
                {
                    GetiTunesLibXml();
                }

                foreach (var pl in this.iTunesPlayLists.ITunesPlayLists)
                {
                    List<string> songs = GetPlayListSongPathsList(pl);

                    string path = this.tbOutputFilePath.Text;
                    string fName = Path.Combine(path, pl.Name + ".m3u");

                    if (!string.IsNullOrWhiteSpace(tbDriveLetter.Text))
                    {
                        songs = ReplaceDrive(tbDriveLetter.Text, songs);
                    }

                    BCHFileIO.WriteFullFile(fName, songs, ref op);

                    if (!op.Success)
                    {
                        tbMessages.Text = op.GetAllErrorsAndExceptionsWthNl();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                tbMessages.Text = ex.Message ;
                return;
            }

            tbMessages.Text = "Finished";
        }

        private List<string> ReplaceDrive(string drive, List<string> songs)
        {
            List<string> songsNew = new List<string>();
            foreach (var song in songs)
            {
                songsNew.Add(drive + song.Substring(1, song.Length - 1));
            }
            return songsNew;
        }

        #endregion

        #region Methods

        protected void GetiTunesLibXml()
        {
            string fileName = ucGetFilePath1.FileName;

            iTunesSongs songs = new iTunesSongs();

            songs.FilliTunesSongList(fileName);

            iTunesPlayLists playLists = new iTunesPlayLists();

            playLists.FillPlayLists(songs, fileName);

            this.dataGridView1.DataSource = songs.iTunesSongList;

            List<NameValue> listNames = new List<NameValue>();
            playLists.ITunesPlayLists.ForEach(x => { listNames.Add(new NameValue(x.Name)); });

            this.dataGridView2.DataSource = listNames;

            this.iTuneSongs = songs;
            this.iTunesPlayLists = playLists;

        }

        private string GetSongs(iTunesSongs songs, string plName = "", string delim = "\t")
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;

            if (plName.Trim().Length > 0)
                sb.Append(plName + "\n");

            foreach (var song in songs.iTunesSongList)
            {
                Dictionary<string, string> dict = BCHUtilities.GetObjectPropertyValueList(song);
                if (i == 0)
                {
                    foreach (var pair in dict)
                    {
                        sb.Append(pair.Key + delim);
                    }
                    sb.Append("\n");
                }
                i++;

                foreach (var pair in dict)
                {
                    sb.Append(pair.Value + delim);
                }

                sb.Append("\n");
            }

            return sb.ToString();
        }


        private List<string> GetSongsList(iTunesSongs songs, string plName = "", string delim = "\t")
        {
            List<string> songList = new List<string>();
            int i = 0;
            StringBuilder sb = new StringBuilder();

            if (plName.Trim().Length > 0)
                songList.Add(plName + "\n");

            foreach (var song in songs.iTunesSongList)
            {
                Dictionary<string, string> dict = BCHUtilities.GetObjectPropertyValueList(song);
                if (i == 0)
                {
                    sb = new StringBuilder();
                    foreach (var pair in dict)
                    {
                        sb.Append(pair.Key + delim);
                    }

                    songList.Add(sb.ToString());
                }
                i++;

                sb = new StringBuilder();

                foreach (var pair in dict)
                {
                    sb.Append(pair.Value + delim);
                }

                songList.Add(sb.ToString());
            }

            return songList;
        }
        private Dictionary<string, StringBuilder> GetPlayListSongs(string delim = "\t")
        {
            Dictionary<string, StringBuilder> sbs = new Dictionary<string, StringBuilder>();
            foreach (var playList in this.iTunesPlayLists.ITunesPlayLists)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(GetSongs(playList.Songs, playList.Name));

                string name = playList.Name;

                if (sbs.ContainsKey(playList.Name))
                {
                    bool end = false;
                    int i = 1;
                    do
                    {
                        if (sbs.ContainsKey(playList.Name + " " + i.ToString("00")))
                            i++;
                        else
                        {
                            end = false;
                            name += " " + i.ToString("00");
                        }
                    } while (end);
                }

                sbs.Add(name, sb);
            }

            return sbs;
        }

        private List<Tuple<string, List<string>>> GetPlayListSongsTuple(string delim = "\t")
        {
            List<Tuple<string, List<string>>> sbs = new List<Tuple<string, List<string>>>();
            List<string> list = new List<string>();

            foreach (var playList in this.iTunesPlayLists.ITunesPlayLists)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(GetSongs(playList.Songs, playList.Name));

                list = GetSongsList(playList.Songs, playList.Name);

                string name = playList.Name;

                if (sbs.SingleOrDefault(x => x.Item1 == playList.Name) != null)
                {
                    bool end = false;
                    int i = 1;
                    do
                    {
                        if (sbs.SingleOrDefault(x => x.Item1 == playList.Name + " " + i.ToString("00")) != null)
                            i++;
                        else
                        {
                            end = false;
                            name += " " + i.ToString("00");
                        }
                    } while (end);
                }

                sbs.Add(Tuple.Create(name, list));
            }

            return sbs;
        }

        private string GetPlayListSongPathsStr(iTunesPlayList ipl, string delimiter = "\n")
        {
            StringBuilder songs = new StringBuilder();

            for (int i = 0; i < ipl.Songs.iTunesSongList.Count; i++)
            {
                songs.Append(ipl.Songs.iTunesSongList[i].Location + delimiter);
            }

            return songs.ToString();
        }

        private List<string> GetPlayListSongPathsList(iTunesPlayList ipl, string delimiter = "\n")
        {
            List<string> songs = new List<string>();

            for (int i = 0; i < ipl.Songs.iTunesSongList.Count; i++)
            {
                songs.Add(ipl.Songs.iTunesSongList[i].Location.Replace(@"file://localhost/", "") + delimiter);
            }

            return songs;
        }


        #endregion

        private class NameValue
        {
            public NameValue(string name)
            {
                Name = name;
            }
            public string Name { get; set; }
        }

    }


}
