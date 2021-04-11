using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Schema
{
    [Serializable]
    public class BusinessObject
    {
        public BusinessObject()
        {
            MarkedForDelete = false;
            IsNew = true;
        }

        public bool MarkedForDelete;

        public bool IsNew;

    }
}
