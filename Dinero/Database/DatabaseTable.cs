using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.IO;

namespace Dinero.DB
{
    public class DatabaseTable
    {
        public DatabaseTable(long id)
        {
            Id = id;
        }

        #region Properties
        public long Id { get; private set; }
        #endregion
    }
}
