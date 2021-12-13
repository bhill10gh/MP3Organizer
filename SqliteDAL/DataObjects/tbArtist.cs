using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteDAL.DataContextObjects
{
    public class tbArtist
    {
        #region Instance Properties

        [Key]
        public int Artist_Id { get; set; }

        public int Mp3Info_Id { get; set; }

        public string Artist_Name { get; set; }

        #endregion Instance Properties
    }
}
