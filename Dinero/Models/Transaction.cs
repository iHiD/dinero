using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dinero.DB;

namespace Dinero.Models
{
    public class Transaction : DatabaseTable
    {
        #region Constructors
        public Transaction(long id, Company company, decimal amount) : base(id)  
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
