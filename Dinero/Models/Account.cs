using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using Dinero.DB;

namespace Dinero.Models
{
    public class Account : DatabaseTable
    {
        #region Static Methods
        public static List<Account> GetAccounts()
        {
            SqlCeCommand command = new SqlCeCommand("SELECT * FROM accounts", Database.GetConnection());
            SqlCeDataReader reader = command.ExecuteReader();

            List<Account> accounts = new List<Account>();
            while(reader.Read()) {
                accounts.Add(new Account((long)reader["id"], (string)reader["name"]));
            }

            return accounts;
        }
        #endregion

        #region Constructors
        public Account(long id, string name) : base(id)  
        {
            Name = name;
        }
        #endregion

        #region Properties
        public string Name { get; private set; }
        public List<Transaction> Transactions
        {
            get 
            {
                return new List<Transaction>()
                {
                    //new Transaction(new Company("Starbucks"), -2.10m),
                    //new Transaction(new Company("Parents"), 150m),
                    //new Transaction(new Company("Sainsburys"), -38.20m)
                };
            }
        }
        #endregion
    }
}
