using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteDAL.DataContextObjects
{

    public class tbMp3Info
    {
        #region Instance Properties

        [Key]
        public int Mp3Info_Id { get; set; }

        public int FileInfo_Id { get; set; }

        public string Song_Title { get; set; }

        public string Album { get; set; }

        public string Genre { get; set; }

        public string Comments { get; set; }

        public int? Track { get; set; }

        public string Song_Numeraton { get; set; }

        #endregion Instance Properties
    }
    }
