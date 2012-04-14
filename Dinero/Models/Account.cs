using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dinero.Models
{
    class Account
    {
        #region Static Methods
        public static List<Account> GetAccounts()
        {
            return new List<Account>() {
                new Account("HSBC Current"),
                new Account("HSBC Savings"),
                new Account("Santandar"),
                new Account("Natwest"),
            };
        }
        #endregion

        #region Constructors
        public Account(string name) 
        {
            Name = name;
        }
        #endregion

        #region Properties
        public string Name { get; private set; }
        #endregion
    }
}
