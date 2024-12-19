using BCHFramework;
using SqliteDAL.DataContextObjects;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Net.Http.Headers;

namespace SqliteDAL.DataObjects
{
    public class YepYepTableStatusGroup
    {
        public bool HasYepYep { get; set; }

        public bool AnyMissngTables(ref OperationResult op)
        {
            if (!HasYepYep)
            {
                op.AddInformation("Missing YepYep table\n");
                return true;
            }
            return false;
        }
    }

    public class YepYepRepository
    {

        private readonly Mp3DbContext _mp3Context;
        private readonly string _dbFileName;
        //private readonly SQLiteConnection conn;
        public YepYepRepository(string dbFileName, ref OperationResult op)
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
            string createYepYepTableSql = "CREATE TABLE \"YepYep\" ( \"Ethnicities\"\t, \"Tags\"\t, \"Url\"\t, \"Actors\"\t, PRIMARY KEY(\"Url\") );";

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                {
                    conn.Open();

                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = createYepYepTableSql;
                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        public void InsertYepYep(YepYep yepYep, ref OperationResult op)
        {
            using (DbContextTransaction transaction = _mp3Context.Database.BeginTransaction())
            {
                try
                {
                    if(CheckUrlExists(yepYep))
                    {
                        return;
                    }

                    _mp3Context.YepYep.Add(yepYep);
                    _mp3Context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    op.AddError($"Error inserting mp3 file: {yepYep.Url}");
                    op.AddException(ex);
                }
            }
        }

        public bool CheckUrlExists(YepYep yepYep)
        {
            int count = (from y in _mp3Context.YepYep
                              where (y.Url) == yepYep.Url
                              select y).Count();

            return count > 0;
        }

        public YepYepTableStatusGroup CheckIfTableExists(ref OperationResult op)
        {
            string sql = "SELECT name FROM sqlite_master WHERE type='table';";
            YepYepTableStatusGroup yepYepTableStatusGroup = new YepYepTableStatusGroup();

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
                        if (dt.Rows[i][0].ToString() == "tbYepYep")
                        {
                            yepYepTableStatusGroup.HasYepYep = true;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }

            return yepYepTableStatusGroup;
        }

        public void DropAllMp3Tables(ref OperationResult op)
        {
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={_dbFileName}; Version = 3; New = True; Compress = True; Journal Mode=Off;"))
                {
                    SQLiteCommand sqlite_cmd;

                    var checkTables = CheckIfTableExists(ref op);
                    if (!op.Success)
                    {
                        return;
                    }

                    string sql = "";

                    conn.Open();

                    if (checkTables.HasYepYep)
                    {
                        sql = "DROP TABLE tbYepYep;";
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
    }
}
