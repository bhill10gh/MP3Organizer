using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;
using System.Data.SqlTypes;

using BCHFramework;

namespace MP3OrganizerBusinessLogic
{
    public class CsvDb
    {
        public static void CreateCsvTable(DataTable dt, string fileName, ref OperationResult op, string colDelim, string rowDelim)
        {

            try
            {
                string pdbTable = AddColumnRow(dt, ref op, colDelim);

                if (op.Success)
                    pdbTable += AddDataRows(dt, ref op, rowDelim);
                if (op.Success)
                {
                    List<string> list = new List<string>();
                    list.Add(pdbTable);
                    BCHFileIO.WriteFullFile(fileName, list, ref op);
                }
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                return;
            }
        }

        public static string AddColumnRow(DataTable dt, ref OperationResult op, string colDelim)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataColumn column in dt.Columns)
            {
                Type t = column.DataType;
                sb.Append(column.ColumnName + colDelim);
            }

            if (sb.ToString().EndsWith(colDelim))
            {
                sb = new StringBuilder(sb.ToString().TrimEnd(colDelim.ToArray()[0]));
            }

            return sb.ToString();
        }

        public static string AddDataRows(DataTable dt, ref OperationResult op, string rowDelim)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string rowStr = "\n";

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    rowStr += (dt.Rows[i][j] == null ? "" : dt.Rows[i][j].ToString()) + rowDelim;
                }

                if (rowStr.EndsWith(rowDelim))
                {
                    rowStr = rowStr.TrimEnd(rowDelim.ToArray()[0]);
                }

                sb.Append(rowStr);
            }

            return sb.ToString();
        }
    }
}
