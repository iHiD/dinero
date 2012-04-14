using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dinero.Models
{
    class Transaction
    {
        #region Constructors
        public Transaction(decimal amount)
        {
            Amount = amount;
        }
        #endregion

        #region Properties
        public decimal Amount { get; private set; }
        #endregion
    }
}
