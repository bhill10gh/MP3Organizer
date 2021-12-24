using System.ComponentModel.DataAnnotations;

namespace SqliteDAL.DataObjects
{
    public class tbItunesPlaylist
    {
        #region Instance Properties

        [Key]
        public int Playlist_Id { get; set; }

        public string Name { get; set; }

        #endregion Instance Properties
    }
}
