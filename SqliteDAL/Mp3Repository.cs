//using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using SqliteDAL.DataContextObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCHFramework;
using System.Data;
using System.Data.Entity;
using MP3OrganizerBusinessLogic;
using SqliteDAL.DataObjects;
using System.IO;

namespace SqliteDAL
{
    public class Mp3TableStatusGroup
    {
        public bool HasFileInfoTable { get; set; } 
        public bool HasMp3InfoTable { get; set; }
        public bool HasArtistTable { get; set; }

        public bool AnyMissngTables(ref OperationResult op) 
        {
            if (!HasFileInfoTable || !HasMp3InfoTable || !HasArtistTable)
            {
                op.AddInformation("Missing Table)s:\n");

                if (!HasFileInfoTable)
                {
                    op.AddInformation("Missing tbFileInfo table.\n");
                }

                if (!HasMp3InfoTable)
                {
                    op.AddInformation("Missing tbMp3Info table.\n");
                }

                if (!HasArtistTable)
                {
                    op.AddInformation("Missing tbArtist table.\n");
                }
                return true;
            }
            return false;
        }
    }

    public class ItunesTableStatusGroup
    {
        public bool HastunesSongTable { get; set; }
        public bool HasItunesPlaylistTable { get; set; }
        public bool HasItunesPlaylistSongTable { get; set; }

        public bool AnyMissngTables(ref OperationResult op)
        {
            if (!HastunesSongTable || !HasItunesPlaylistTable || !HasItunesPlaylistSongTable)
            {
                op.AddInformation("Missing Table)s:\n");

                if (!HastunesSongTable)
                {
                    op.AddInformation("Missing tbItunesSong table.\n");
                }

                if (!HasItunesPlaylistTable)
                {
                    op.AddInformation("Missing tbMp3Info table.\n");
                }

                if (!HasItunesPlaylistSongTable)
                {
                    op.AddInformation("Missing tbItunesPlaylistSong table.\n");
                }
                return true;
            }
            return false;
        }
    }

    public class Mp3Repository
    {
        private readonly Mp3DbContext _mp3Context;
        private readonly string _dbFileName;
        //private readonly SQLiteConnection conn;
        public Mp3Repository(string dbFileName, ref OperationResult op)
        {
            try
            {
                _dbFileName = dbFileName;
                _mp3Context = new Mp3DbContext(dbFileName);

                // Create a new database connection:
                //conn = new SQLiteConnection($"Data Source={dbFileName}; Version = 3; New = True; Compress = True; ");
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        public void CreateDatabaseTables(ref OperationResult op)
        {
            string createArtistTableSql = "CREATE TABLE [tbArtist]([Artist_Id][INTEGER] PRIMARY KEY, [Mp3Info_Id] [INTEGER] NOT NULL, [Artist_Name] [nvarchar](255) NOT NULL)";
            string createFileInfoTableSql = "CREATE TABLE [tbFileInfo]([FileInfo_Id][INTEGER] PRIMARY KEY, [File_Name] [nvarchar](250) NOT NULL, [Path] [nvarchar](255) NOT NULL)";
            string createMp3InfoTableSql = "CREATE TABLE [tbMp3Info]( [Mp3Info_Id] [INTEGER] PRIMARY KEY, [FileInfo_Id] [INTEGER] NOT NULL, [Song_Title] [nvarchar](255) NOT NULL, [Album] [nvarchar](255) NULL, [Genre] [nvarchar](255) NULL, [Comments] [nvarchar](255) NULL, [Track] [INTEGER] NULL, [Song_Numeraton] [nvarchar](255) NULL) ";

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                {
                    conn.Open();

                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = createArtistTableSql;
                    sqlite_cmd.ExecuteNonQuery();

                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = createFileInfoTableSql;
                    sqlite_cmd.ExecuteNonQuery();

                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = createMp3InfoTableSql;
                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        public Mp3TableStatusGroup CheckIfAllMp3TablesExists(ref OperationResult op)
        {
            string sql = "SELECT name FROM sqlite_master WHERE type='table';";
            Mp3TableStatusGroup mp3TableStatusGroup = new Mp3TableStatusGroup();

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                {
                    conn.Open();

                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = sql;
                    sqlite_cmd.ExecuteNonQuery();
                    SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sqlite_cmd);
                    DataTable dt = new DataTable();
                    sQLiteDataAdapter.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][0].ToString() == "tbArtist")
                        {
                            mp3TableStatusGroup.HasArtistTable = true;
                        }

                        if (dt.Rows[i][0].ToString() == "tbFileInfo")
                        {
                            mp3TableStatusGroup.HasFileInfoTable = true;
                        }

                        if (dt.Rows[i][0].ToString() == "tbMp3Info")
                        {
                            mp3TableStatusGroup.HasMp3InfoTable = true;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }

            return mp3TableStatusGroup;
        }

        public ItunesTableStatusGroup CheckIfAllITunesTablesExists(ref OperationResult op)
        {
            string sql = "SELECT name FROM sqlite_master WHERE type='table';";
            ItunesTableStatusGroup itunesTableStatusGroup = new ItunesTableStatusGroup();

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                {
                    conn.Open();

                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = sql;
                    sqlite_cmd.ExecuteNonQuery();
                    SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sqlite_cmd);
                    DataTable dt = new DataTable();
                    sQLiteDataAdapter.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][0].ToString() == "tbItunesSong")
                        {
                            itunesTableStatusGroup.HastunesSongTable = true;
                        }

                        if (dt.Rows[i][0].ToString() == "tbItunesPlaylist")
                        {
                            itunesTableStatusGroup.HasItunesPlaylistTable = true;
                        }

                        if (dt.Rows[i][0].ToString() == "tbItunesPlaylistSong")
                        {
                            itunesTableStatusGroup.HasItunesPlaylistSongTable = true;
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }

            return itunesTableStatusGroup;
        }

        public void DropAllMp3Tables(ref OperationResult op)
        {
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                {
                    SQLiteCommand sqlite_cmd;

                    var checkTables = CheckIfAllMp3TablesExists(ref op);
                    if (!op.Success)
                    {
                        return;
                    }

                    string sql = "";

                    conn.Open();

                    if (checkTables.HasArtistTable)
                    {
                        sql = "DROP TABLE tbArtist;";
                        sqlite_cmd = conn.CreateCommand();
                        sqlite_cmd.CommandText = sql;
                        sqlite_cmd.ExecuteNonQuery();
                    }

                    if (checkTables.HasMp3InfoTable)
                    {
                        sql = "DROP TABLE tbMp3Info;";
                        sqlite_cmd = conn.CreateCommand();
                        sqlite_cmd.CommandText = sql;
                        sqlite_cmd.ExecuteNonQuery();
                    }

                    if (checkTables.HasFileInfoTable)
                    {
                        sql = "DROP TABLE tbFileInfo;";
                        sqlite_cmd = conn.CreateCommand();
                        sqlite_cmd.CommandText = sql;
                        sqlite_cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }
        }

        public void DropAllITunesTables(ref OperationResult op)
        {
            try
            {
                var checkTables = CheckIfAllITunesTablesExists(ref op);
                if (!op.Success)
                {
                    return;
                }

                using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                {
                    conn.Open();

                    SQLiteCommand sqlite_cmd;

                    string sql = "";

                    if (checkTables.HastunesSongTable)
                    {
                        sql = "DROP TABLE tbItunesSong;";
                        sqlite_cmd = conn.CreateCommand();
                        sqlite_cmd.CommandText = sql;
                        sqlite_cmd.ExecuteScalar();
                    }

                    if (checkTables.HasItunesPlaylistTable)
                    {
                        sql = "DROP TABLE tbItunesPlaylist;";
                        sqlite_cmd = conn.CreateCommand();
                        sqlite_cmd.CommandText = sql;
                        sqlite_cmd.ExecuteScalar();
                    }

                    if (checkTables.HasItunesPlaylistSongTable)
                    {
                        sql = "DROP TABLE tbItunesPlaylistSong;";
                        sqlite_cmd = conn.CreateCommand();
                        sqlite_cmd.CommandText = sql;
                        sqlite_cmd.ExecuteScalar();
                    } 
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }
        }

        public void InsertMp3(MP3FileDataType mP3FileDataType, ref OperationResult op)
        {
            if (!mP3FileDataType.FileName.EndsWith("mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }
            using (DbContextTransaction transaction = _mp3Context.Database.BeginTransaction())
            {
                try
                {
                    var tbFileInfo = new tbFileInfo
                    {
                        File_Name = mP3FileDataType.FileName,
                        Path = mP3FileDataType.FilePath
                    };
                    _mp3Context.FileInfo.Add(tbFileInfo);
                    _mp3Context.SaveChanges();
                    var fiId = tbFileInfo.FileInfo_Id;

                    tbMp3Info tbMp3Info = new tbMp3Info
                    {
                        Album = mP3FileDataType.Album,
                        Comments = mP3FileDataType.Comments,
                        FileInfo_Id = fiId,
                        Genre = mP3FileDataType.Genre,
                        Song_Numeraton = mP3FileDataType.SongNumeration,
                        Song_Title = mP3FileDataType.SongTitle,
                        Track = mP3FileDataType.Track
                    };
                    _mp3Context.Mp3Info.Add(tbMp3Info);
                    _mp3Context.SaveChanges();
                    var miId = tbMp3Info.Mp3Info_Id;

                    foreach (var artist in mP3FileDataType.Artists)
                    {
                        tbArtist tbArtist = new tbArtist
                        {
                            Artist_Name = artist,
                            Mp3Info_Id = miId
                        };
                        _mp3Context.Artist.Add(tbArtist);
                        _mp3Context.SaveChanges();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    op.AddError($"Error inserting mp3 file: {mP3FileDataType.FilePath}");
                    op.AddException(ex);
                }
            }
        }

        public DataTable GetAllTables(ref OperationResult op)
        {
            string sql = "SELECT name from sqlite_master WHERE type='table';";

            return RunSql(sql, ref op);
        }
        public DataTable GetTableColumns(string tableName, ref OperationResult op)
        {
            string sql = $"PRAGMA table_info('{tableName}');";

            return RunSql(sql, ref op);
        }

        public DataTable RunSql(string sql, ref OperationResult op)
        {
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; "))
                {
                    conn.Open();

                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = sql;
                    sqlite_cmd.ExecuteNonQuery();
                    SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sqlite_cmd);
                    DataTable dt = new DataTable();
                    sQLiteDataAdapter.Fill(dt);
                    conn.Close();

                    return dt; 
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }

            return null;
        }

        public void CreateItunesTables(ref OperationResult op)
        {
            using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
            {
                conn.Open();

                SQLiteCommand sqlite_cmd;

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = CreatetbITunesSongSql;
                sqlite_cmd.ExecuteNonQuery();
                if (!op.Success)
                {
                    return;
                }

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = CreatetbItunesPlaylistSql;
                sqlite_cmd.ExecuteNonQuery();
                if (!op.Success)
                {
                    return;
                }

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = CreatetbItunesPlaylistSongs;
                sqlite_cmd.ExecuteNonQuery();
                if (!op.Success)
                {
                    return;
                } 
            }
        }

        private void InsertITunesDataEF(iTunesSongs iTunesSongs, iTunesPlayLists iTunesPlayLists, ref OperationResult op)
        {
            using (DbContextTransaction transaction = _mp3Context.Database.BeginTransaction())
            {
                try
                {

                    foreach (iTunesSong song in iTunesSongs.iTunesSongList)
                    {
                        string path = (from f in _mp3Context.FileInfo
                                       where f.FileInfo_Id == 1
                                       select f.Path + "\\" + f.File_Name).FirstOrDefault();

                        string location = song.Location.Replace("file://localhost/", "").Replace("/", "\\");
                        int fileInfoId = (from f in _mp3Context.FileInfo
                                          where (f.Path + "\\" + f.File_Name) == location
                                          select f.FileInfo_Id).FirstOrDefault();

                        tbItunesSong itunesSong = new tbItunesSong
                        {
                            Album = song.Album,
                            AlbumArtist = song.AlbumArtist,
                            Artist= song.Artist,
                            BitRate = song.BitRate,
                            Comments = song.Comments,
                            DateAdded = song.DateAdded,
                            DateModified = song.DateModified,
                            DiscCount= song.DiscCount,
                            DiscNumber = song.DiscNumber,
                            FileFolderCount= song.FileFolderCount,
                            FileInfo_Id = fileInfoId,
                            Genre = song.Genre,
                            Kind = song.Kind,
                            LibraryFolderCount = song.LibraryFolderCount,
                            Location= location,
                            Name = song.Name,
                            PersistentId = song.PersistentId,
                            SampleRate = song.SampleRate,
                            Size = song.Size,
                            TotalTIme= song.TotalTIme,
                            TrackId = song.TrackId,
                            TrackNumber= song.TrackNumber,
                            TrackType = song.TrackType
                        };

                        _mp3Context.ItunesSong.Add(itunesSong);
                        _mp3Context.SaveChanges();
                    }

                    foreach (var playlist in iTunesPlayLists.ITunesPlayLists)
                    {
                        tbItunesPlaylist tbItunesPlaylist = new tbItunesPlaylist
                        {
                            Name = playlist.Name
                        };

                        _mp3Context.ItunesPlaylist.Add(tbItunesPlaylist);
                        _mp3Context.SaveChanges();
                        int id = tbItunesPlaylist.Playlist_Id;

                        foreach (var song in playlist.Songs.iTunesSongList)
                        {
                            int songId = (from s in _mp3Context.ItunesSong
                                          where s.TrackId == song.TrackId
                                          select s.TrackId).FirstOrDefault().Value;

                            tbItunesPlaylistSong tbItunesPlaylistSong = new tbItunesPlaylistSong
                            {
                                Name = song.Name,
                                Playlist_Id = id,
                                TrackId = song.TrackId,
                                Song_Id = songId
                            };


                            _mp3Context.ItunesPlaylistSong.Add(tbItunesPlaylistSong);
                            _mp3Context.SaveChanges();
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    op.AddException(ex);
                }
            }
        }

        public void InsertITunesData(iTunesSongs iTunesSongs, iTunesPlayLists iTunesPlayLists, ref OperationResult op)
        {
            try
            {
                SQLiteCommand sqlite_cmd;

                string sql = "";                

                foreach (iTunesSong song in iTunesSongs.iTunesSongList)
                {
                    string location = song.Location.Replace("file://localhost/", "").Replace("/", "\\");
                    int fileInfoId = (from f in _mp3Context.FileInfo
                                      where (f.Path + "\\" + f.File_Name) == location
                                      select f.FileInfo_Id).FirstOrDefault();

                    using (var conn = new  SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                    {
                        sql = @"
	                        INSERT INTO [tbItunesSong] ([FileInfo_Id],[Name],[Artist],[TrackId],[AlbumArtist],[Album],[Genre],[Kind],[Size],[TotalTIme],[DiscNumber],[DiscCount],[TrackNumber],
		                        [DateModified],[DateAdded],[BitRate],[SampleRate],[Comments],[PersistentId],[TrackType],[Location],[FileFolderCount],[LibraryFolderCount]
	                        )
	                        VALUES (
		                        " + fileInfoId.ToString() + @",'" + song.Name.Replace("'", "''") + @"', '" + song.Artist.Replace("'", "''") + @"'," + song.TrackId + @", '" + song.AlbumArtist.Replace("'", "''") + @"','" + song.Album.Replace("'", "''") + @"',
		                        '" + song.Genre.Replace("'", "''") + @"','" + song.Kind.Replace("'", "''") + @"'," + song.Size + @"," + song.TotalTIme + @",'" + song.DiscNumber + @"','" + song.DiscCount + @"',
		                        '" + song.TrackNumber + @"','" + song.DateModified.ToString("yyyy-MM-dd HH:mm:ss") + @"','" + song.DateAdded.ToString("yyyy-MM-dd HH:mm:ss") + @"',
		                        " + song.BitRate + @"," + song.SampleRate + @",'" + song.Comments.Replace("'", "''") + @"','" + song.PersistentId.Replace("'", "''") + @"','" + song.TrackType.Replace("'", "''") + @"','" + location.Replace("'", "''") + @"',
		                        " + song.FileFolderCount + @"," + song.LibraryFolderCount + @")";

                        conn.Open();
                        sqlite_cmd = conn.CreateCommand();
                        sqlite_cmd.CommandText = sql;
                        sqlite_cmd.ExecuteNonQuery();
                        conn.Close(); 
                    }
                }

                int playlistId = 0;
                foreach (var playlist in iTunesPlayLists.ITunesPlayLists)
                {
                    if(playlist.Name == "Library" || playlist.Name == "Downloaded" || playlist.Name == "Music")
                    {
                        continue;
                    }

                    using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                    {
                        sql = @"INSERT INTO[tbItunesPlaylist] ([Name] ) VALUES( '" + playlist.Name.Replace("'", "''") + @"'); select last_insert_rowid();";

                        conn.Open();
                        sqlite_cmd = conn.CreateCommand();
                        sqlite_cmd.CommandText = sql;
                        playlistId = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
                        conn.Close(); 
                    }

                    foreach (var song in playlist.Songs.iTunesSongList)
                    {
                        int songId = (from s in _mp3Context.ItunesSong
                                      where s.TrackId == song.TrackId
                                      select s.Song_Id).FirstOrDefault();

                        using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                        {
                            sql = @" INSERT INTO [tbItunesPlaylistSong] ( [Playlist_Id], [Song_Id], [TrackId], [Name] ) 
                            VALUES ( " + playlistId.ToString() + @", " + songId.ToString() + @"," + song.TrackId.ToString() + @", '" + song.Name.Replace("'", "''") + @"' ) ";

                            conn.Open();
                            sqlite_cmd = conn.CreateCommand();
                            sqlite_cmd.CommandText = sql;
                            sqlite_cmd.ExecuteNonQuery();
                            conn.Close(); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }
        }

        public void SyncITunesDataWithMp3s(ref OperationResult op)
        {
            try
            {
                SQLiteCommand sqlite_cmd;

                string sql = "";

                var mp3Files = (from f in _mp3Context.FileInfo
                                  select f).ToList();

                var itunesSong = (from s in _mp3Context.ItunesSong select s).ToList();

                foreach (var song in itunesSong)
                {
                    string location = song.Location.Replace("file://localhost/", "").Replace("/", "\\");
                    int fileInfoId = (from f in mp3Files
                                      where (f.Path + "\\" + f.File_Name) == location
                                      select f.FileInfo_Id).FirstOrDefault();

                    using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                    {
                        sql = $"UPDATE [tbItunesSong] SET [FileInfo_Id] = {fileInfoId.ToString()} WHERE Song_Id = {song.Song_Id} ";

                        conn.Open();
                        sqlite_cmd = conn.CreateCommand();
                        sqlite_cmd.CommandText = sql;
                        sqlite_cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }
        }

        #region Sql Code


        readonly string CreatetbITunesSongSql = @"
CREATE TABLE tbItunesSong (
	""Song_Id"" INTEGER,
	""FileInfo_Id""  INTEGER NULL,
	""Name""	nvarchar(255) NULL,
	""Artist"" nvarchar(255) NULL,
	""TrackId"" INTEGER NULL,
	""AlbumArtist"" nvarchar(255) NULL,
	""Album""	nvarchar(255) NULL,
	""Genre""	nvarchar(255) NULL,
	""Kind""	nvarchar(255) NULL,
	""Size"" INTEGER NULL,
	""TotalTIme"" INTEGER NULL,
	""DiscNumber"" INTEGER NULL,
	""DiscCount"" INTEGER NULL,
	""TrackNumber"" INTEGER NULL,
	""DateModified"" datetime NULL,
	""DateAdded"" datetime NULL,
	""BitRate"" INTEGER NULL,
	""SampleRate"" INTEGER NULL,
	""Comments""	nvarchar(255) NULL,
	""PersistentId""	nvarchar(255) NULL,
	""TrackType""	nvarchar(255) NULL,
	""Location""	nvarchar(255) NULL,
	""FileFolderCount"" INTEGER NULL,
	""LibraryFolderCount"" INTEGER NULL,
	PRIMARY KEY(""Song_Id"")
);";

        readonly string CreatetbItunesPlaylistSql = @"
CREATE TABLE tbItunesPlaylist (
	""Playlist_Id"" INTEGER,
	""Name"" nvarchar(255) NOT NULL,
	PRIMARY KEY(""Playlist_Id"")
);
";

        readonly string CreatetbItunesPlaylistSongs = @"
CREATE TABLE tbItunesPlaylistSong (
	""PlaylistSong_Id"" INTEGER,
	""Playlist_Id"" INTEGER NOT NULL,
	""Song_Id"" INTEGER NOT NULL,
    ""TrackId"" INTEGER NOT NULL,
	""Name"" 	nvarchar(255) NOT NULL,
	PRIMARY KEY(""PlaylistSong_Id"")
);
";


        #endregion
    }


}
