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
    public class iTunesPlayLists
    {
        public List<iTunesPlayList> ITunesPlayLists { get; set; }

        public void FillPlayLists(string iTunesLibraryFilePath)
        {
            iTunesSongs songs = new iTunesSongs();
            songs.FilliTunesSongList(iTunesLibraryFilePath);

            FillPlayLists(songs, iTunesLibraryFilePath);
        }

        public void FillPlayLists(iTunesSongs songs, string iTunesLibraryFilePath)
        {
            XDocument xDoc = XDocument.Load(iTunesLibraryFilePath);

            ITunesPlayLists = new List<iTunesPlayList>();
            
            var linqtoxml = from element in xDoc.Descendants("plist").Descendants("dict").Descendants("array").Descendants("dict")
                            select element;

            foreach (var dict in linqtoxml)
            {
                string pli = BCHXMLUtilities.GetKeyValStr(dict, "key", "Playlist Items");
                if (pli.Trim().Length > 0)
                {
                    try
                    {
                        iTunesPlayList list = new iTunesPlayList();
                        list.FillPlayList(dict, songs);
                        ITunesPlayLists.Add(list);
                    }
                    catch (Exception)
                    {
                        // Something wasn't set, so skip the node ...
                    } 
                }
            }
        }
    }
}
