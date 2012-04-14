using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dinero.Models
{
    class Company
    {
        #region Constructor
        public Company(string name)
        {
            Name = name;
        }
        #endregion

        #region Properties
        public string Name { get; private set; }
        #endregion
    }
}
