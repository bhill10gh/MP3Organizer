using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public enum SqlRepositoryType
    {
        CheckFileExists
    }

    public class SqlRepository
    {
        public Dictionary<string, string> SqlScripts { get; set; }

        public SqlRepository()
        {
            SqlScripts = new Dictionary<string, string>();
        }


    }
}
