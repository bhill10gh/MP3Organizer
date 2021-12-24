using System;
using System.ComponentModel.DataAnnotations;

namespace SqliteDAL.DataObjects
{
    public class tbItunesSong
    {
        #region Instance Properties

        [Key]
        public int Song_Id { get; set; }

        public int? FileInfo_Id { get; set; }

        public string Name { get; set; }

        public string Artist { get; set; }

        public int? TrackId { get; set; }

        public string AlbumArtist { get; set; }

        public string Album { get; set; }

        public string Genre { get; set; }

        public string Kind { get; set; }

        public int? Size { get; set; }

        public int? TotalTIme { get; set; }

        public int? DiscNumber { get; set; }

        public int? DiscCount { get; set; }

        public int? TrackNumber { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateAdded { get; set; }

        public int? BitRate { get; set; }

        public int? SampleRate { get; set; }

        public string Comments { get; set; }

        public string PersistentId { get; set; }

        public string TrackType { get; set; }

        public string Location { get; set; }

        public int? FileFolderCount { get; set; }

        public int? LibraryFolderCount { get; set; }

        #endregion Instance Properties
    }
}
