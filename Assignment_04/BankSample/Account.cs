using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankSample
{
    [XmlInclude(typeof(CheckingAccount))]
    [XmlInclude(typeof(SavingAccount))]
    [Serializable]
    public abstract class Account
    {
        public double Balance;
        public string AccountNumber;
        private static List<double> transaticons = new List<double>() { };
        public List<double> Transactions { get; set; }
        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
            Transactions = transaticons;
        }
        public Account() { }
        public void Debit(double amount)
        {
            Transactions.Add(-amount);
            Balance = Balance - amount;
        }
        public void Deposit(double amount)
        {
            Transactions.Add(amount);
            Balance = Balance + amount;
        }
        public List<double> GetTransactions()
        {
            return Transactions;
        }
    }
}
