using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dinero.Models
{
    class Transaction
    {
        #region Constructors
        public Transaction(Company company, decimal amount)
        {
            Company = company;
            Amount = amount;
        }
        #endregion

        #region Properties
        public Company Company { get; private set; }
        public decimal Amount { get; private set; }
        #endregion
    }
}
