using Microsoft.Data.Sqlite;
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
    public class SqlIteDbContext : DbContext
    {
        private string _dbFileName;
        public SqlIteDbContext(string dbFileName) : base(GetConnection(dbFileName), false)
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
            return dbCon;
        }

        public DbSet<tbMp3Info> Mp3Info { get; set; }

        public DbSet<tbFileInfo> FileInfo { get; set; }

        public DbSet<tbArtist> tbArtist { get; set; }

    }
}
