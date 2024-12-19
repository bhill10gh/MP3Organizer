using Microsoft.Data.Sqlite;
using SqliteDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteDAL.DataContextObjects
{
    public class Mp3DbContext : DbContext
    {
        private string _dbFileName;
        private static DbConnection _connection;

        public Mp3DbContext(string dbFileName) : base(GetConnection(dbFileName), false)
        {
            _dbFileName = dbFileName;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public static DbConnection GetConnection(string dbFileName)
        {
            var connection = ConfigurationManager.ConnectionStrings["SqliteConnetion"];
            var factory = DbProviderFactories.GetFactory(connection.ProviderName);
            var dbCon = factory.CreateConnection();
            dbCon.ConnectionString = $"data source={dbFileName};initial catalog=tbFileInfo;App=EntityFramework;";// connection.ConnectionString;
            _connection = dbCon;
            return dbCon;
        }

        public DbSet<tbMp3Info> Mp3Info { get; set; }

        public DbSet<tbFileInfo> FileInfo { get; set; }

        public DbSet<tbArtist> Artist { get; set; }

        public DbSet<tbItunesPlaylist> ItunesPlaylist { get; set; }

        public DbSet<tbItunesPlaylistSong> ItunesPlaylistSong { get; set; }

        public DbSet<tbItunesSong> ItunesSong { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<YepYep> YepYep { get; set; }



    }
}
