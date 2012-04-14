using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dinero.Controls
{
    /// <summary>
    /// Interaction logic for Transaction.xaml
    /// </summary>
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
        }

        #region Properties

        public string Date
        {
            get { return this.TransactionDate.Text; }
            set { value = TransactionDate.Text; }
        }
        public string Company
        {
            get { return this.TransactionCompany.Text; }
            set { value = TransactionCompany.Text; }
        }
        public string Credit
        {
            get { return this.TransactionCredit.Text; }
            set { value = TransactionCredit.Text; }
        }
        private string Debit
        {
            get { return this.TransactionDebit.Text; }
            set { value = TransactionDebit.Text; }
        }

        #endregion
    }
}
