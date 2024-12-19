using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteDAL.DataObjects
{
    public class YepYep
    {
        [Key] public int Id { get; set; }
        public string Ethnicities { get; set; }
        public string Tags { get; set; }

        public string Url { get; set; }
        public string Actors { get; set; }
    }
}
