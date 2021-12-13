using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteDAL.DataContextObjects
{
    public class tbFileInfo
    {
        #region Instance Properties

        [Key]
        public int FileInfo_Id { get; set; }

        public string File_Name { get; set; }

        public string Path { get; set; }

        #endregion Instance Properties
    }
}
