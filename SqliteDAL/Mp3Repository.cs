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

namespace SqliteDAL
{
    public class Mp3TableStatusGroup
    {
        public bool HasFileInfoTable { get; set; }
        public bool HasMp3InfoTable { get; set; }
        public bool HasArtistTable { get; set; }

        public bool AnyMissngTablds(ref OperationResult op) 
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
    public class Mp3Repository
    {
        private readonly Mp3DbContext _mp3Context;
        private readonly string _dbFileName;
        private readonly SQLiteConnection _sqliteConnection;
        public Mp3Repository(string dbFileName, ref OperationResult op)
        {
            try
            {
                _dbFileName = dbFileName;
                _mp3Context = new Mp3DbContext(dbFileName);

                // Create a new database connection:
                _sqliteConnection = new SQLiteConnection($"Data Source={dbFileName}; Version = 3; New = True; Compress = True; ");
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
                _sqliteConnection.Open();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = _sqliteConnection.CreateCommand();
                sqlite_cmd.CommandText = createArtistTableSql;
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd = _sqliteConnection.CreateCommand();
                sqlite_cmd.CommandText = createFileInfoTableSql;
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd = _sqliteConnection.CreateCommand();
                sqlite_cmd.CommandText = createMp3InfoTableSql;
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
            finally
            {
                _sqliteConnection.Close();
            }
        }

        public Mp3TableStatusGroup CheckIfAllTablesExists(ref OperationResult op)
        {
            string sql = "SELECT name FROM sqlite_master WHERE type='table';";
            Mp3TableStatusGroup mp3TableStatusGroup = new Mp3TableStatusGroup();

            try
            {
                _sqliteConnection.Open();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = _sqliteConnection.CreateCommand();
                sqlite_cmd.CommandText = sql;
                sqlite_cmd.ExecuteNonQuery();
                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sqlite_cmd);
                DataTable dt = new DataTable();
                sQLiteDataAdapter.Fill(dt);

                if (dt == null || dt.Rows.Count < 1)
                {
                    return mp3TableStatusGroup;
                }

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
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
            finally
            {
                _sqliteConnection.Close();
            }
            return mp3TableStatusGroup;
        }

        public void DropAllTables(ref OperationResult op)
        {
            try
            {
                _sqliteConnection.Open();

                SQLiteCommand sqlite_cmd;



                string sql = "DROP TABLE IF EXISTS tbArtist;";
                sqlite_cmd = _sqliteConnection.CreateCommand();
                sqlite_cmd.CommandText = sql;
                sqlite_cmd.ExecuteNonQuery();

                sql = "DROP TABLE IF EXISTS tbMp3Info;";
                sqlite_cmd = _sqliteConnection.CreateCommand();
                sqlite_cmd.CommandText = sql;
                sqlite_cmd.ExecuteNonQuery();

                sql = "DROP TABLE IF EXISTS tbFileInfo;";
                sqlite_cmd = _sqliteConnection.CreateCommand();
                sqlite_cmd.CommandText = sql;
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }
            finally
            {
                _sqliteConnection.Close();
            }
        }

        public List<tbFileInfo> GetAllMp3FileInfo()
        {
            return (from f in _mp3Context.FileInfo select f).ToList();
        }

        public void InsertMp3(MP3FileDataType mP3FileDataType, ref OperationResult op)
        {
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
                            Artist_Name = mP3FileDataType.Album,
                            Mp3Info_Id = miId
                        };
                        _mp3Context.tbArtist.Add(tbArtist);
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
    }
}
