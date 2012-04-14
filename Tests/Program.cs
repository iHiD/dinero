using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Dinero.Models;
using Dinero.DB;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinero.DB.Database.CreateDatabase();

            List<Account> accounts = Account.GetAccounts();
            Console.WriteLine(accounts[0].Name);
            Console.ReadLine();
        }
    }
}
