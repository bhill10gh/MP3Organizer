using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Configuration;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Schema;
using BCHFramework;

/*
 * "Provider=Microsoft.Jet.OLEDB.4.0;" & _
    " Data Source=" & dbpath & dbname & ";" '"Audio-Video-image.mdb;"



conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        @"Data source= C:\Documents and Settings\username\" +
        @"My Documents\AccessFile.mdb";
 * 
 "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=yourdbfile.mdb;Jet OLEDB:Database Password=yourpassword;";* 
   
 */

namespace DAL
{
    public enum SqlScriptEnum
    {
        DynamicSQL,
        CheckFileExists,
        InsertFileInfo,
        GetFileInfo,
        CheckMP3Exists,
        InsertMP3,
        GetMP3byFilePath,
        GetMP3bySongTitle,
        GetMP3byGenre,
        SelectMP3s,
        CheckArtistExists,
        GetArtist,
        InsertArtist,
        SelectAllArtists,
        SelectAllGenres,
        SelectAllSongs,
        SelectAllAlbums,
        SelectAllComments,
        SelectAllFileNames,
        GetArtistBySongTitle,
        GetArtistByGenre,
        GetMP3FilesByArtists,
        GetMP3Files_EnterWhereClause,
        GetMP3Data_EnterWhereClause,
        DeleteAllFiles,
        DeleteAllMp3s,
        DeleteAllArtists
    }

    public enum SqlParamScriptEnum
    {
        DynamicSQL_Sql,
        CheckFileExists_File,
        CheckFileExists_Path,
        InsertFileInfo_File,
        InsertFileInfo_Path,
        GetFileInfo_File,
        GetFileInfo_Path,
        CheckMP3Exists_File,
        CheckMP3Exists_Path,
        InsertMP3_FileInfo_Id,
        InsertMP3_Song_Tile,
        InsertMP3_Album,
        InsertMP3_Genre,
        InsertMP3_Comments,
        InsertMP3_Track,
        InsertMP3_Song_Numeraton,
        GetMP3byFilePath_File,
        GetMP3byFilePath_Path,
        GetMP3bySongTitle_SongTitle,
        GetMP3byGenre_Genre,
        CheckArtistExists_File,
        CheckArtistExists_Path,
        CheckArtistExists_Artist,
        GetArtist_File,
        GetArtist_Path,
        GetArtist_Artist,
        InsertArtist_Mp3Info_Id,
        InsertArtist_Artist,
        GetArtistBySongTitle_SongTitle,
        GetArtistByGenre_Genre,
        GetMP3FilesByArtists_Artists_InsertDoubleQouatsComas,
        GetMP3Files_EnterWhereClause_Where_Clause,
        GetMP3Data_EnterWhereClause
    }


    public class SqlScriptHolder
    {
        public SqlScriptEnum SqlScript { get; set; }
        public Dictionary<string, string> SqlPrmNameValueList { get; set; }
    }


    public class DataStore
    {

        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public SqlScripts SqlScripts { get; private set; }
        public bool IsSqlScriptsSet { get; private set; }
        private CommandType CommandType { get; set; }
        public Dictionary<string, string> SqlScriptParamDict { get; set; }

        public OleDbConnection Conn { get; set; }

        public DataStore()
        {
            IsSqlScriptsSet = false;
            this.CommandType = CommandType.Text;
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            InitializeSqlScriptParamDict();
            string ssFile = string.Empty;
            bool finished = false;
            foreach (string appKey in appSettings.AllKeys)
            {
                foreach (string val in appSettings.GetValues(appKey))
                {
                    string appValue = appSettings[appKey];
                    string xmlFile = appValue;
                    if (!string.IsNullOrEmpty(xmlFile) && appKey.StartsWith("SqlScriptsXml") && File.Exists(xmlFile))
                    {
                        ssFile = xmlFile;
                        finished = true;
                        break;
                    }
                }
                if (finished)
                {
                    break;
                }

            }

            if (!string.IsNullOrEmpty(ssFile) && ssFile.Length > 0)
            {
                OperationResult op = new OperationResult();
                try
                {
                    this.SqlScripts = new SqlScripts();
                    SqlScripts.Load(ssFile, ref op);
                    IsSqlScriptsSet = op.Success ? true : false;
                }
                catch
                {
                    return;
                }
            }

        }

        public void LoadSqlScripts(string sqlScriptXml, ref OperationResult op)
        {
            this.SqlScripts = new SqlScripts();
            SqlScripts.Load(sqlScriptXml, ref op);
            IsSqlScriptsSet = op.Success ? true : false;
        }

        public void SetConnectionStringForAccessDB(string dbFileAndPath, ref OperationResult op)
        {
            if (!File.Exists(dbFileAndPath))
            {
                op.AddError(dbFileAndPath + " db file does not exist.");
                return;
            }

            this.DatabaseName = dbFileAndPath;

            this.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source= " + dbFileAndPath;

        }

        public void TruncateTable(string tableName, string idName, ref OperationResult op)
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                op.AddError("The connection string is not set.");
                return;
            }

            string connStr = string.Empty;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(ConnectionString))
                {

                    using (OleDbCommand cmd = new OleDbCommand("ALTER TABLE [" + tableName + "] ALTER COLUMN " + idName + " COUNTER (1, 1)" , conn))
                    {
                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }

            return ;
        }

        public DataTable ExecSql(string sql, ref OperationResult op)
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                op.AddError("The connection string is not set.");
                return null;
            }

            string connStr = string.Empty;
            DataTable table = null;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(ConnectionString))
                {

                    using (OleDbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        conn.Open();
                        cmd.CommandType = this.CommandType;

                        table = new DataTable();
                        new OleDbDataAdapter(cmd).Fill(table);
                        return table;
                    }

                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }

            return null;
        }

        public DataTable GetDbTables(ref OperationResult op)
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                op.AddError("The connection string is not set.");
                return null;
            }

            string connStr = string.Empty;
            DataTable table = null;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(ConnectionString))
                {

                    using (OleDbCommand cmd = conn.CreateCommand())
                    {
                        conn.Open();

                        table = new DataTable();

                        // We only want user tables, not system tables
                        string[] restrictions = new string[4];
                        restrictions[3] = "Table";


                        // Get list of user tables
                        table =
                            conn.GetSchema("Tables", restrictions);
                        return table;
                    }

                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }

            return null;
        }

        public DataTable GetDbTableColumns(string tableName, ref OperationResult op)
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                op.AddError("The connection string is not set.");
                return null;
            }

            string connStr = string.Empty;
            DataTable table = null;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(ConnectionString))
                {

                    using (OleDbCommand cmd = new OleDbCommand("select * from " + tableName, conn))
                    {
                        conn.Open();

                        table = new DataTable();

                        using (var reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly))
                        {
                            table = reader.GetSchemaTable();
                            var nameCol = table.Columns["ColumnName"];
                        }

                        return table;
                    }

                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }

            return null;
        }

        public DataTable ExecuteSql(OleDbConnection conn, SqlScriptEnum sqlScript, Dictionary<string, string> sqlPrmNameValueList,
                 ref OperationResult op)
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                op.AddError("The connection string is not set.");
                return null;
            }

            DataTable dt = new DataTable();

            SqlScriptMembers sqlScrptMem = SqlScripts.SqlScriptDict[sqlScript.ToString()];

            Dictionary<string, SqlScriptParameter> paramList = sqlScrptMem.Parameters;
            string sql = ValidateAndInsertParamList(sqlScrptMem.Sql, ref paramList, ref sqlPrmNameValueList, ref op);

            if (!op.Success)
            {
                return null;
            }

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = this.CommandType;

                    dt = new DataTable();
                    new OleDbDataAdapter(cmd).Fill(dt);
                }

                return dt;
            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }

            return null;
        }

        public List<T> ExecSql<T>(string sql, ref OperationResult op)
        {
            if (!op.Success)
            {
                return null;
            }

            try
            {
                DataTable table = ExecSql(sql, ref op);
                if (!op.Success)
                {
                    return null;
                }

                List<T> ts = DataSchemaDataTableUtilities.ConvertTo<T>(table).ToList();
                return ts;
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }

            return null;
        }

        public DataTable ExecuteSql(SqlScriptEnum sqlScript, Dictionary<string, string> sqlPrmNameValueList, ref OperationResult op)
        {
            DataTable dt = new DataTable();

            SqlScriptMembers sqlScrptMem = SqlScripts.SqlScriptDict[sqlScript.ToString()];

            Dictionary<string, SqlScriptParameter> paramList = sqlScrptMem.Parameters;
            string sql = ValidateAndInsertParamList(sqlScrptMem.Sql, ref paramList, ref sqlPrmNameValueList, ref op);

            if (!op.Success)
            {
                return null;
            }

            dt = ExecSql(sql, ref op);

            if (!op.Success)
            {
                return null;
            }

            return dt ?? new DataTable();
        }

        public List<T> ExecuteSql<T>(SqlScriptEnum sqlScript, Dictionary<string, string> sqlPrmNameValueList, ref OperationResult op)
        {
            try
            {
                DataTable table = ExecuteSql(sqlScript, sqlPrmNameValueList, ref op);
                if (!op.Success)
                {
                    return null;
                }

                List<T> ts = DataSchemaDataTableUtilities.ConvertTo<T>(table).ToList();
                return ts;
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }

            return null;
        }

        private string ValidateAndInsertParamList(string sql, ref Dictionary<string, SqlScriptParameter> paramList, ref Dictionary<string, string> sqlPrmNameValueList, ref OperationResult op)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(sql);

            if (paramList.Count != sqlPrmNameValueList.Count)
            {
                op.AddError("Number of given parameters do not match what is needed!");
                return string.Empty;
            }

            foreach (KeyValuePair<string, SqlScriptParameter> item in paramList)
            {
                if (!sqlPrmNameValueList.ContainsKey(item.Key))
                {
                    op.AddError("One or more parameters are missing");
                    return string.Empty;
                }

                string val = sqlPrmNameValueList[item.Key];

                if ((item.Value.Type == SqlScriptParameterTypeEnum.Decimal && !BCHUtilities.IsNumeric(val)) ||
                        (item.Value.Type == SqlScriptParameterTypeEnum.Integer && !BCHUtilities.IsInteger(val)))
                {
                    op.AddError("One or more parameters are not the correct type");
                    return string.Empty;
                }

                sb.Replace(item.Value.Marker, val);
            }

            return sb.ToString();
        }

        private void InitializeSqlScriptParamDict()
        {
            SqlScriptParamDict = new Dictionary<string, string>();
            SqlScriptParamDict.Add("DynamicSQL_Sql", "Sql");
            SqlScriptParamDict.Add("CheckFileExists_File", "File");
            SqlScriptParamDict.Add("CheckFileExists_Path", "Path");
            SqlScriptParamDict.Add("InsertFileInfo_File", "File");
            SqlScriptParamDict.Add("InsertFileInfo_Path", "Path");
            SqlScriptParamDict.Add("GetFileInfo_File", "File");
            SqlScriptParamDict.Add("GetFileInfo_Path", "Path");
            SqlScriptParamDict.Add("CheckMP3Exists_File", "File");
            SqlScriptParamDict.Add("CheckMP3Exists_Path", "Path");
            SqlScriptParamDict.Add("InsertMP3_FileInfo_Id", "FileInfo_Id");
            SqlScriptParamDict.Add("InsertMP3_Song_Tile", "Song_Tile");
            SqlScriptParamDict.Add("InsertMP3_Album", "Album");
            SqlScriptParamDict.Add("InsertMP3_Genre", "Genre");
            SqlScriptParamDict.Add("InsertMP3_Comments", "Comments");
            SqlScriptParamDict.Add("InsertMP3_Track", "Track");
            SqlScriptParamDict.Add("InsertMP3_Song_Numeraton", "Song_Numeraton");
            SqlScriptParamDict.Add("GetMP3byFilePath_File", "File");
            SqlScriptParamDict.Add("GetMP3byFilePath_Path", "Path");
            SqlScriptParamDict.Add("GetMP3bySongTitle_SongTitle", "SongTitle");
            SqlScriptParamDict.Add("GetMP3byGenre_Genre", "Genre");
            SqlScriptParamDict.Add("CheckArtistExists_File", "File");
            SqlScriptParamDict.Add("CheckArtistExists_Path", "Path");
            SqlScriptParamDict.Add("CheckArtistExists_Artist", "Artist");
            SqlScriptParamDict.Add("GetArtist_File", "File");
            SqlScriptParamDict.Add("GetArtist_Path", "Path");
            SqlScriptParamDict.Add("GetArtist_Artist", "Artist");
            SqlScriptParamDict.Add("InsertArtist_Mp3Info_Id", "Mp3Info_Id");
            SqlScriptParamDict.Add("InsertArtist_Artist", "Artist");
            SqlScriptParamDict.Add("GetArtistBySongTitle_SongTitle", "SongTitle");
            SqlScriptParamDict.Add("GetArtistByGenre_Genre", "Genre");
            SqlScriptParamDict.Add("GetMP3FilesByArtists_Artists_InsertDoubleQouatsComas", "Artists_InsertDoubleQouatsComas");//
            SqlScriptParamDict.Add("GetMP3Files_EnterWhereClause_Where_Clause", "Where_Clause");
            SqlScriptParamDict.Add("GetMP3Data_EnterWhereClause", "Where_Clause");
        }

        //public Dictionary<string, string> GetSqlScriptParamInfoList(SqlScriptEnum scrptName, ref List<string> vals, ref OperationResult op)
        //{
        //    Dictionary<string, string> parms = ( from d in SqlScriptParamDict
        //                                         where d.Key.StartsWith(scrptName.ToString())
        //                                         select d).ToDictionary(kv => kv.Key, kv => kv.Value);
        //    parms = parms == null ? new Dictionary<string, string>() : parms;

        //    Dictionary<string, string> parmVals = new Dictionary<string, string>();

        //    if (vals.Count != parms.Count)
        //    {
        //        op.AddError("Parameters are not complete.");
        //        parms = null;
        //    }

        //    foreach (var item in parms)
        //    {
        //        parmVals.Add(parms.
        //    }

        //    return parms;
        //}

        public string GetSqlScriptParam(SqlParamScriptEnum sqse)
        {
            SqlScriptParamDict = new Dictionary<string, string>();
            if (sqse == SqlParamScriptEnum.DynamicSQL_Sql)
            {
                return "Sql";
            }

            if (sqse == SqlParamScriptEnum.CheckFileExists_File)
            {
                return "File";
            }

            if (sqse == SqlParamScriptEnum.CheckFileExists_Path)
            {
                return "Path";
            }

            if (sqse == SqlParamScriptEnum.InsertFileInfo_File)
            {
                return "File";
            }

            if (sqse == SqlParamScriptEnum.InsertFileInfo_Path)
            {
                return "Path";
            }

            if (sqse == SqlParamScriptEnum.GetFileInfo_File)
            {
                return "File";
            }

            if (sqse == SqlParamScriptEnum.GetFileInfo_Path)
            {
                return "Path";
            }

            if (sqse == SqlParamScriptEnum.CheckMP3Exists_File)
            {
                return "File";
            }

            if (sqse == SqlParamScriptEnum.CheckMP3Exists_Path)
            {
                return "Path";
            }

            if (sqse == SqlParamScriptEnum.InsertMP3_FileInfo_Id)
            {
                return "FileInfo_Id";
            }

            if (sqse == SqlParamScriptEnum.InsertMP3_Song_Tile)
            {
                return "Song_Tile";
            }

            if (sqse == SqlParamScriptEnum.InsertMP3_Album)
            {
                return "Album";
            }

            if (sqse == SqlParamScriptEnum.InsertMP3_Genre)
            {
                return "Genre";
            }

            if (sqse == SqlParamScriptEnum.InsertMP3_Comments)
            {
                return "Comments";
            }

            if (sqse == SqlParamScriptEnum.InsertMP3_Track)
            {
                return "Track";
            }

            if (sqse == SqlParamScriptEnum.InsertMP3_Song_Numeraton)
            {
                return "Song_Numeraton";
            }

            if (sqse == SqlParamScriptEnum.GetMP3byFilePath_File)
            {
                return "File";
            }

            if (sqse == SqlParamScriptEnum.GetMP3byFilePath_Path)
            {
                return "Path";
            }

            if (sqse == SqlParamScriptEnum.GetMP3bySongTitle_SongTitle)
            {
                return "SongTitle";
            }

            if (sqse == SqlParamScriptEnum.GetMP3byGenre_Genre)
            {
                return "Genre";
            }

            if (sqse == SqlParamScriptEnum.CheckArtistExists_File)
            {
                return "File";
            }

            if (sqse == SqlParamScriptEnum.CheckArtistExists_Path)
            {
                return "Path";
            }

            if (sqse == SqlParamScriptEnum.CheckArtistExists_Artist)
            {
                return "Artist";
            }

            if (sqse == SqlParamScriptEnum.GetArtist_File)
            {
                return "File";
            }

            if (sqse == SqlParamScriptEnum.GetArtist_Path)
            {
                return "Path";
            }

            if (sqse == SqlParamScriptEnum.GetArtist_Artist)
            {
                return "Artist";
            }

            if (sqse == SqlParamScriptEnum.InsertArtist_Mp3Info_Id)
            {
                return "Mp3Info_Id";
            }

            if (sqse == SqlParamScriptEnum.InsertArtist_Artist)
            {
                return "Artist";
            }

            if (sqse == SqlParamScriptEnum.GetArtistBySongTitle_SongTitle)
            {
                return "SongTitle";
            }

            if (sqse == SqlParamScriptEnum.GetArtistByGenre_Genre)
            {
                return "Genre";
            }

            if (sqse == SqlParamScriptEnum.GetMP3FilesByArtists_Artists_InsertDoubleQouatsComas)
            {
                return "Artists_InsertDoubleQouatsComas";
            }

            if (sqse == SqlParamScriptEnum.GetMP3Files_EnterWhereClause_Where_Clause)
            {
                return "Where_Clause";
            }

            return string.Empty;
        }

        public void CompactJetDatabase(ref OperationResult op)
        {

            try
            {
                if (string.IsNullOrEmpty(ConnectionString))
                {
                    op.AddError("The connection string is not set.");
                    return;
                }
                object[] oParams;

                //create an inctance of a Jet Replication Object
                object objJRO =
                  Activator.CreateInstance(Type.GetTypeFromProgID("JRO.JetEngine"));

                //filling Parameters array
                //change "Jet OLEDB:Engine Type=5" to an appropriate value
                // or leave it as is if you db is JET4X format (access 2000,2002)
                //(yes, jetengine5 is for JET4X, no misprint here)
                oParams = new object[] {this.ConnectionString,
                        "Provider=Microsoft.Jet.OLEDB.4.0;Data" + 
                        " Source=C:\\tempdb.mdb;Jet OLEDB:Engine Type=5"};

                //invoke a CompactDatabase method of a JRO object
                //pass Parameters array
                objJRO.GetType().InvokeMember("CompactDatabase",
                    System.Reflection.BindingFlags.InvokeMethod,
                    null,
                    objJRO,
                    oParams);

                //database is compacted now
                //to a new file C:\\tempdb.mdw
                //let's copy it over an old one and delete it

                System.IO.File.Delete(this.DatabaseName);
                System.IO.File.Move("C:\\tempdb.mdb", DatabaseName);

                //clean up (just in case)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(objJRO);
                objJRO = null;

            }
            catch (Exception ex)
            {
                op.AddException(ex);
            }
        }

    }


}

