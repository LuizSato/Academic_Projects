using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class WithdrawException : Exception
    {
        public string ErroMessage { get; }
        public WithdrawException(string error, string message)
            :base(error)
        {
            ErroMessage = message;
        }
    }
    class Account
    {
        static int CURRENT_ACCOUNT_NUMBER;
        readonly public string Number;
        static int TRANSIT_NUMBER;

        public double Balance { get; private set; }
        public List<string> Names { get; private set; }
        static Account()
        {
            CURRENT_ACCOUNT_NUMBER = 10000;
            TRANSIT_NUMBER = 314;
        }
        private Account(string number, string name, double balance)
        {
            Number = number;
            Balance = balance;
            Names = new List<string>() { };
            Names.Add(name);
        }
        public void AddName(string name)
        {
            Names.Add(name);
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance - amount < 0)
            {
                //without the class
                //throw new Exception($"EXCEPTION: Cannot withdraw {amount:C} from your account, Current balance: {Balance:C}");
                //with the class
                throw new WithdrawException($"EXCEPTION: Cannot withdraw {amount:C} from your account, Current balance: {Balance:C}", "Please enter another amount");
            }
            else
            {
                Balance -= amount;
            }
            //another method to do EXCEPTION in the beginning of the class
            
        }
        public override string ToString()
        {
            return $"{Number} {string.Join(", ", Names)} {Balance:C}";
        }
        public static Account CreateAccount(string name, double balance = 0)
        {
            string number = string.Format($"[AC - {TRANSIT_NUMBER} - {CURRENT_ACCOUNT_NUMBER++}]");
            Account NewAccount = new Account(number, name, balance);
            return NewAccount;
        }
    }
}
