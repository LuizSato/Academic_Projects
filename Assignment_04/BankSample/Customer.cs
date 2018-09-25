using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSample
{
    public class Customer
    {
        private static List<Account> accounts = new List<Account>() { };
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public List<Account> Accounts { get; set; }

        public Customer(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Accounts = accounts;
        }
        public Customer() { }
        public void AddAccount(Account account)
        {
            account.Transactions = new List<double>() { };
            accounts.Add(account);
        }
        public void DeleteAccount(Account account)
        {
            accounts.Remove(account);
        }
        public void UpdateAccount(Account account, string accountNumber, double property)
        {
            for (int i = 0; i < accounts.Count(); i++)
            {
                if (accounts[i] == account)
                {
                    if (account is CheckingAccount)
                    {
                        CheckingAccount checking = account as CheckingAccount;
                        checking.MonthlyFee = property;
                        accounts[i] = checking;
                        accounts[i].AccountNumber = accountNumber;
                    }
                    else if (account is SavingAccount)
                    {
                        SavingAccount saving = account as SavingAccount;
                        saving.InterestRate = property;
                        accounts[i] = saving;
                        accounts[i].AccountNumber = accountNumber;
                    }

                }
            }
        }
        public List<Account> GetAccounts()
        {
            return accounts;
        }
        public static void GetCustomerAccounts(Customer customer)
        {
            List<Customer> customers = Branch.GetCustomers();

            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i] == customer)
                {
                    accounts = customer.Accounts;
                }
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, Address:{Address.ToString()}";
        }
    }
}
