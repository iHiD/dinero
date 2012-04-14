using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dinero.DB;

namespace Dinero.Models
{
    public class Company : DatabaseTable
    {
        #region Constructor
        public Company(long id, string name) : base(id)
        {
            Name = name;
        }
        #endregion

        #region Properties
        public string Name { get; private set; }
        #endregion
    }
}
