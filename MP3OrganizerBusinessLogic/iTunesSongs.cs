using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.Xml.Linq;

namespace MP3OrganizerBusinessLogic
{
    public class iTunesSongs 
    {
        public List<iTunesSong> iTunesSongList = new List<iTunesSong>();

        public void FilliTunesSongList(string iTunesLibraryFilePath)
        {
            XDocument xDoc = XDocument.Load(iTunesLibraryFilePath);

            iTunesSongList = new List<iTunesSong>();

            var linqtoxml = from element in xDoc.Descendants("plist").Descendants("dict").Descendants("dict").Descendants("dict")
                            select element;
            int cnt = 0;

            foreach (var dict in linqtoxml)
            {

                try
                {
                    iTunesSong song = new iTunesSong();                    
                    song.SetProperties(dict);
                    if (song.Kind == "MPEG audio file")
                    {
                        song.SongCount = cnt++;
                        iTunesSongList.Add(song);
                    }
                }
                catch (Exception)
                {
                    // Something wasn't set, so skip the node ...
                }
            }

            if(iTunesSongList != null && iTunesSongList.Count > 0)
            {
                //iTunesSongList.Sort(
            }
        }



    }

    public class iTunesSongs_SortBySongCount : IComparer<iTunesSong>
    {

        int IComparer<iTunesSong>.Compare(iTunesSong x, iTunesSong y)
        {
            if (x.SongCount < y.SongCount) return 1;
            else if (x.SongCount > y.SongCount) return -1;
            else return 0;
        }
    }

    public class iTunesSongs_SortBySong : IComparer<iTunesSong>
    {
        int IComparer<iTunesSong>.Compare(iTunesSong x, iTunesSong y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }

    public class iTunesSongs_SortByArtist : IComparer<iTunesSong>
    {
        int IComparer<iTunesSong>.Compare(iTunesSong x, iTunesSong y)
        {
            return string.Compare(x.Artist, y.Artist);
        }
    }
}
