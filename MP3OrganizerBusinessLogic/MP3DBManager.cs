using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;

using BCHFramework;
using DAL;

namespace MP3OrganizerBusinessLogic
{
    public delegate void CountChangeHandler(int cnt);

    public class MP3DBManager
    {
        public event CountChangeHandler onCountChange;

        private DataStore DataStore { get; set; }

        ~MP3DBManager()
        {
            OperationResult op = new OperationResult();

            CloseDBConn(ref op);
        }

        public void SetDataStore(string mp3DbFile, ref OperationResult op)
        {
            this.DataStore = new DataStore();
            this.DataStore.SetConnectionStringForAccessDB(mp3DbFile, ref op);
            if (!op.Success)
            {
                return;
            }
        }

        public void CloseDBConn(ref OperationResult op)
        {
            try
            {
                if (this.DataStore != null && DataStore.Conn != null && DataStore.Conn.State == ConnectionState.Open)
                {
                    DataStore.Conn.Close();
                }
            }
            catch (Exception ex)
            {
                
                op.AddException(ex);
            }
        }

        private void SetConnection( ref OperationResult op)
        {
            if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return;
            }

            if (this.DataStore.Conn == null)
            {
                this.DataStore.Conn = new System.Data.OleDb.OleDbConnection(this.DataStore.ConnectionString);
            }
        }

        public void InsertMP3FileInfo(MP3FileDataType mp3,  ref OperationResult op)
        {
            if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return;
            }

            SetConnection(ref op);            
            
            if (!op.Success)
            {
                return;
            }

            DataStore ds = this.DataStore;

            Dictionary<string,string> parms = new Dictionary<string, string>();
            parms.Add(ds.GetSqlScriptParam( SqlParamScriptEnum.GetFileInfo_File),mp3.FileName);
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetFileInfo_Path),mp3.FilePath);

            DataTable dt = ds.ExecuteSql(ds.Conn, SqlScriptEnum.GetFileInfo, parms, ref op);
            if(!op.Success)
            {
                return;
            }

            if (dt.Rows.Count > 0)
            {
                op.AddError(mp3.FileNamePath + " mp3 already exists!");
                return;
            }

            parms = new Dictionary<string, string>();
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertFileInfo_File), mp3.FileName);
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertFileInfo_Path), mp3.FilePath);

            ds.ExecuteSql(ds.Conn, SqlScriptEnum.InsertFileInfo, parms, ref op);
            if (!op.Success)
            {
                return;
            }
        }

        public void InsertMP3Info(MP3FileDataType mp3, ref OperationResult op)
        {
            if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return;
            }

            SetConnection(ref op);

            if (!op.Success)
            {
                return;
            }

            DataStore ds = this.DataStore;

            Dictionary<string, string> parms = new Dictionary<string, string>();
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetFileInfo_File), mp3.FileName);
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetFileInfo_Path), mp3.FilePath);

            DataTable dt = ds.ExecuteSql(ds.Conn, SqlScriptEnum.GetFileInfo, parms, ref op);
            if (!op.Success)
            {
                return;
            }

            if (dt.Rows.Count < 1)
            {
                op.AddError(mp3.FileNamePath + " mp3 file info does not exists!");
                return;
            }

            int? fid = BCHUtilities.GetInteger(dt.Rows[0]["FileInfo_Id"].ToString());

            parms = new Dictionary<string, string>();
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetMP3byFilePath_File), mp3.FileName);
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetMP3byFilePath_Path), mp3.FilePath);

            dt = ds.ExecuteSql(ds.Conn, SqlScriptEnum.GetMP3byFilePath, parms, ref op);
            if (!op.Success)
            {
                return;
            }

            if (dt.Rows.Count > 0)
            {
                op.AddError(mp3.FileNamePath + " mp3 already exists!");
                return;
            }


            parms = new Dictionary<string, string>();
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertMP3_Album), string.IsNullOrEmpty( mp3.Album) ? null : mp3.Album.Trim());
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertMP3_Comments), string.IsNullOrEmpty(mp3.Comments) ? null : mp3.Comments.Trim());
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertMP3_FileInfo_Id),fid.ToString());
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertMP3_Genre), string.IsNullOrEmpty(mp3.Genre) ? null : mp3.Genre.Trim());
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertMP3_Song_Numeraton), string.IsNullOrEmpty(mp3.SongNumeration) ? null : mp3.SongNumeration.Trim());
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertMP3_Song_Tile), string.IsNullOrEmpty(mp3.SongTitle) ? null : mp3.SongTitle.Trim());
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertMP3_Track), mp3.Track == null ? null : mp3.Track.ToString());

            ds.ExecuteSql(ds.Conn, SqlScriptEnum.InsertMP3, parms, ref op);
            if (!op.Success)
            {
                return;
            }
        }

        public void InsertMP3Artists(MP3FileDataType mp3, ref OperationResult op)
        {
            if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return;
            }

            DataStore ds = this.DataStore;

            Dictionary<string, string> parms = new Dictionary<string, string>();
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetFileInfo_File), mp3.FileName);
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetFileInfo_Path), mp3.FilePath);

            DataTable dt = ds.ExecuteSql(ds.Conn, SqlScriptEnum.GetFileInfo, parms, ref op);
            if (!op.Success)
            {
                return;
            }

            if (dt.Rows.Count < 1)
            {
                op.AddError(mp3.FileNamePath + " mp3 file info does not exists!");
                return;
            }

            parms = new Dictionary<string, string>();
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetMP3byFilePath_File), mp3.FileName);
            parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetMP3byFilePath_Path), mp3.FilePath);

            dt = ds.ExecuteSql(ds.Conn, SqlScriptEnum.GetMP3byFilePath, parms, ref op);
            if (!op.Success)
            {
                return;
            }

            if (dt.Rows.Count < 1)
            {
                op.AddError(mp3.FileNamePath + " mp3 info not exists!");
                return;
            }

            int? mid = BCHUtilities.GetInteger(dt.Rows[0]["Mp3Info_Id"].ToString());

            foreach (string artist in mp3.Artists)
            {
                parms = new Dictionary<string, string>();
                parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetArtist_File), mp3.FileName);
                parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetArtist_Path), mp3.FilePath);
                parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.GetArtist_Artist), artist.Trim());

                dt = ds.ExecuteSql(ds.Conn, SqlScriptEnum.GetArtist, parms, ref op);
                if (!op.Success)
                {
                    return;
                }

                if (dt.Rows.Count > 0)
                {
                    op.AddError(mp3.FileNamePath + ", Artist: " + artist + " mp3 already exists!");
                    break;
                }

                parms = new Dictionary<string, string>();
                parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertArtist_Mp3Info_Id), mid.ToString());
                parms.Add(ds.GetSqlScriptParam(SqlParamScriptEnum.InsertArtist_Artist), string.IsNullOrEmpty(artist.Trim()) ? null : artist.Trim());

                ds.ExecuteSql(ds.Conn, SqlScriptEnum.InsertArtist, parms, ref op);
                if (!op.Success)
                {
                    return;
                }
            }
        }

        public void InsertMP3(MP3FileDataType mp3, ref OperationResult op)
        {
            if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return;
            }

            InsertMP3FileInfo(mp3, ref op);

            if (!op.Success)
            {
                return;
            }

            InsertMP3Info(mp3, ref op);

            if (!op.Success)
            {
                return;
            }

            InsertMP3Artists(mp3, ref op);

            if (!op.Success)
            {
                return;
            }
        }

        public void InsertMP3s(List<string> mp3List, string mp3RtDir, bool useFolderInfo, ref OperationResult op)
        {
            try
            {
                
                int cnt = 0;

                foreach (string mp3Item in mp3List)
                {
                    cnt++;
                    if(onCountChange != null)
                    {
                        onCountChange(cnt);
                    }

                    OperationResult _op = new OperationResult();
                    MP3FileDataType mp3 = useFolderInfo ?
                        BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmtWithDirInfo(mp3Item, mp3RtDir, ref _op)
                        : BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmt(mp3Item, ref _op);

                    if (!_op.Success)
                    {
                        op.AddOperationResult(ref _op);
                        continue;
                    }


                    InsertMP3(mp3, ref _op);

                    if (!_op.Success)
                    {
                        op.AddOperationResult(ref _op);
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                
                op.AddException(ex);
            }

        }

        public void DeleteallMP3s( ref OperationResult op)
        {
            if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return;
            }

            DataStore ds = this.DataStore;

            Dictionary<string, string> parms = new Dictionary<string, string>();
            

            DataTable dt = ds.ExecuteSql(SqlScriptEnum.DeleteAllArtists, parms, ref op);
            if (!op.Success)
            {
                return;
            }

            ds.TruncateTable("tbArtist", "Artist_Id", ref op);
            if (!op.Success)
            {
                return;
            }

            dt = ds.ExecuteSql(SqlScriptEnum.DeleteAllMp3s, parms, ref op);
            if (!op.Success)
            {
                return;
            }

            ds.TruncateTable("tbMp3Info", "Mp3Info_Id", ref op);
            if (!op.Success)
            {
                return;
            }

            dt = ds.ExecuteSql(SqlScriptEnum.DeleteAllFiles, parms, ref op);
            if (!op.Success)
            {
                return;
            }

            ds.TruncateTable("tbFileInfo", "FileInfo_Id", ref op);
            if (!op.Success)
            {
                return;
            }

        }

        public DataTable RunSqlScript(ref Dictionary<string, string> parms, SqlScriptEnum sqlScriptEnum, ref OperationResult op)
        {
           if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return null;
            }


            DataStore ds = this.DataStore;

            DataTable dt = ds.ExecuteSql(sqlScriptEnum, parms, ref op);

            return dt;
        }

        public static string BuildSearchWhereClause(List<string> whereParts, bool isAnd)
        {
            StringBuilder whereSql = new StringBuilder();
            string andOr = isAnd ? " and " : " or ";

            whereSql.Append(" where ");

            foreach (var val in whereParts)
            {
                string str = " " + val + andOr;
                whereSql.Append(str);
            }

            if (whereSql.ToString().EndsWith(andOr))
            {
                string str = whereSql.ToString();
                whereSql = (new StringBuilder((str.Substring(0, str.Length - andOr.Length))));
            }

            string whereOut = whereSql.ToString() == " where " ? string.Empty : whereSql.ToString();

            return whereOut;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldValue"> List of field and values, i.e. "fieldA = 'Value'"</param>
        /// <param name="isAnd"> true = and, else false</param>
        /// <returns></returns>
        public static string BuildSearchWhereClausePart(string field, List<string> values, bool isString, bool isAnd, bool useLike)
        {
            StringBuilder whereSql = new StringBuilder();
            
            string strQuote = isString ? "'" : "";
            string strPercent = useLike ? "%" : "";
            string andOr = isAnd ? " and " : " or ";
            string equalLike = useLike ? " like " : " = ";

            whereSql.Append("(");

            foreach (var val in values)
            {
                if (val != "None")
                {
                    string str = " " + field + equalLike + strQuote + strPercent + val + strPercent + strQuote + andOr;

                    whereSql.Append(str);
                }
            }

            if (whereSql.ToString().EndsWith(andOr))
            {
                string str = whereSql.ToString();
                whereSql = (new StringBuilder((str.Substring(0, str.Length - andOr.Length))));
            }

            whereSql.Append(")");

            return whereSql.ToString();
        }

        public void CompactRepareDB(ref OperationResult op)
        {
            if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return;
            }

            DataStore ds = this.DataStore;

            ds.CompactJetDatabase(ref op);
        }

        public DataTable GetDbTables(ref OperationResult op)
        {
            if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return null;
            }


            DataStore ds = this.DataStore;

            DataTable dt = ds.GetDbTables(ref op);

            return dt;
        }

        public DataTable GetDbTableColumns(string tableName, ref OperationResult op)
        {
            if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return null;
            }


            DataStore ds = this.DataStore;

            DataTable dt = ds.GetDbTableColumns(tableName, ref op);

            return dt;
        }

        public void TruncateTable(string tableName, string idName, ref OperationResult op)
        {
            if (this.DataStore == null)
            {
                op.AddError("DataStore not set!");
                return;
            }

            DataStore ds = this.DataStore;

            ds.TruncateTable(tableName, idName, ref op);
            
        }
    }
}
