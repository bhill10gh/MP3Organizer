using System.ComponentModel.DataAnnotations;

namespace SqliteDAL.DataObjects
{
    public class tbItunesPlaylistSong
    {
        #region Instance Properties

        [Key]
        public int? PlaylistSong_Id { get; set; }

        public int Playlist_Id { get; set; }

        public int Song_Id { get; set; }

        public int TrackId { get; set; }

        public string Name { get; set; }

        #endregion Instance Properties
    }
}
