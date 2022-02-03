using SqliteDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SqliteDAL.DataObjects
{
    public class AdminDbContext : DbContext
    {
        private string _dbFileName;
        private static DbConnection _connection;
        public AdminDbContext(string dbFileName) : base(GetConnection(dbFileName), false)
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
            var connection = ConfigurationManager.ConnectionStrings["SqliteAdminConnetion"];
            var factory = DbProviderFactories.GetFactory(connection.ProviderName);
            var dbCon = factory.CreateConnection();
            dbCon.ConnectionString = $"data source={dbFileName};initial catalog=tbFileInfo;App=EntityFramework;";// connection.ConnectionString;
            _connection = dbCon;
            return dbCon;
        }

        public DbSet<User> User { get; set; }

    }
}
