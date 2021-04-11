using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.Xml.Linq;
using System.Web;

using BCHFramework;

namespace MP3OrganizerBusinessLogic
{
    public class iTunesSong
    {
        public int TrackId { get; set; }

        public string Name { get; set; }

        public string Artist { get; set; }

        public string AlbumArtist { get; set; }

        public string Album { get; set; }

        public string Genre { get; set; }

        public string Kind { get; set; }

        public int Size { get; set; }

        public int TotalTIme { get; set; }

        public int DiscNumber { get; set; }

        public int DiscCount { get; set; }

        public int TrackNumber { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateAdded { get; set; }

        public int BitRate { get; set; }

        public int SampleRate { get; set; }

        public string Comments { get; set; }

        public string PersistentId { get; set; }

        public string TrackType { get; set; }

        public string Location { get; set; }

        public int FileFolderCount { get; set; }

        public int LibraryFolderCount { get; set; }

        public string PlayListName { get; set; }

        public int SongCount { get; set; }


        public void SetProperties(XElement dict)
        {
            iTunesSong song = new iTunesSong();
            TrackId = BCHXMLUtilities.GetKeyValInt(dict, "key", "Track ID");
            Name = BCHXMLUtilities.GetKeyValStr(dict, "key", "Name");
            Artist = BCHXMLUtilities.GetKeyValStr(dict, "key", "Artist");
            AlbumArtist = BCHXMLUtilities.GetKeyValStr(dict, "key", "Album Artist");
            Album = BCHXMLUtilities.GetKeyValStr(dict, "key", "Album");
            Genre = BCHXMLUtilities.GetKeyValStr(dict, "key", "Genre");
            Kind = BCHXMLUtilities.GetKeyValStr(dict, "key", "Kind");
            Size = BCHXMLUtilities.GetKeyValInt(dict, "key", "Size");
            TotalTIme = BCHXMLUtilities.GetKeyValInt(dict, "key", "Total Time");
            DiscNumber = BCHXMLUtilities.GetKeyValInt(dict, "key", "Disc Number");
            DiscCount = BCHXMLUtilities.GetKeyValInt(dict, "key", "Disc Count");
            TrackNumber = BCHXMLUtilities.GetKeyValInt(dict, "key", "Track Number");
            DateModified = BCHXMLUtilities.GetKeyValDate(dict, "key", "Date Modified");
            DateAdded = BCHXMLUtilities.GetKeyValDate(dict, "key", "Date Added");
            BitRate = BCHXMLUtilities.GetKeyValInt(dict, "key", "Bit Rate");
            SampleRate = BCHXMLUtilities.GetKeyValInt(dict, "key", "Sample Rate");
            Comments = BCHXMLUtilities.GetKeyValStr(dict, "key", "Comments");
            PersistentId = BCHXMLUtilities.GetKeyValStr(dict, "key", "Persistent ID");
            TrackType = BCHXMLUtilities.GetKeyValStr(dict, "key", "Track Type");
            Location = BCHXMLUtilities.UrlDecode(BCHXMLUtilities.GetKeyValStr(dict, "key", "Location"));
            FileFolderCount = BCHXMLUtilities.GetKeyValInt(dict, "key", "File Folder Count");
            LibraryFolderCount = BCHXMLUtilities.GetKeyValInt(dict, "key", "Library Folder Count");
        }

        
       
    }

    

}
