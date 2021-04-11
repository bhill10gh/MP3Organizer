using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.Xml.Linq;

using BCHFramework;

namespace MP3OrganizerBusinessLogic
{
    public class iTunesPlayList
    {
        public string Name { get; set; }
        public iTunesSongs Songs {get; set;}

        public void FillPlayList(XElement dict, iTunesSongs songsList)
        {
            Name = BCHXMLUtilities.GetKeyValStr(dict, "key", "Name");

            var xSongs = from element in dict.Descendants("array").Descendants("dict")
                         select element;
            Songs = new iTunesSongs();
            int id = 0;
            int cnt = 0;

            foreach (var xSong in xSongs)
            {

                try
                {
                    id = BCHXMLUtilities.GetKeyValInt(xSong, "key",  "Track ID");
                    iTunesSong song = songsList.iTunesSongList.Find(s=> s.TrackId == id);
                    if (song != null)
                    {   
                        song.SongCount = cnt++;
                        song.PlayListName = Name;
                        Songs.iTunesSongList.Add(song);
                    }
                }
                catch (Exception)
                {
                    // Something wasn't set, so skip the node ...
                }
            }
        }

        public object GetKeyVal(XElement dict, string keyName, string keyValue)
        {
            try
            {
                var element = dict.Descendants(keyName).Where(key => key.Value == keyValue).Select(x => x.NextNode).SingleOrDefault();
                if (element != null)
                    return ((XElement)element).Value;
                return null;


            }
            catch (Exception)
            {
                // Something wasn't set, so skip the node ...
            }
            return null;
        }

        
    }
}
