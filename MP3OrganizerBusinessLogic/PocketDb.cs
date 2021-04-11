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
    public class PocketDb
    {
        public static void CreatePdbTable(DataTable dt, string fileName, ref OperationResult op)
        {

            string pdbTable = AddColumnRow(dt, ref op);

            if (op.Success)
                pdbTable += AddDataRows(dt, ref op);
            if (op.Success)
            {
                List<string> list = new List<string>();
                list.Add(pdbTable);
                BCHFileIO.WriteFullFile(fileName, list, ref op);
            }
        }

        public static string AddColumnRow(DataTable dt, ref OperationResult op)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataColumn column in dt.Columns)
            {
                Type t = column.DataType;
                sb.Append(column.ColumnName + "||" + BCHUtilities.GetPdbType(column.DataType) + "\t");
            }

            if (sb.ToString().EndsWith("\t"))
            {
                sb = new StringBuilder( sb.ToString().TrimEnd('\t'));
            }

            return sb.ToString();
        }

        public static string AddDataRows(DataTable dt, ref OperationResult op)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string rowStr = "\n";

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    rowStr += (dt.Rows[i][j] == null ? "" : dt.Rows[i][j].ToString()) + "\t";
                }

                if (rowStr.EndsWith("\t"))
                {
                    rowStr = rowStr.TrimEnd('\t');
                }

                sb.Append(rowStr);
            }

            return sb.ToString();
        }
    }
}
