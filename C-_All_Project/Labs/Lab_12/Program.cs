using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            Random rand = new Random();

            accounts.Add(Account.CreateAccount("Narendra", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Ilia", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Yin", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Arben", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Patrick", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Joanne", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Nicoleta", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Mohammed", rand.Next(50, 500)));

            Console.WriteLine("\nAll accounts");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            foreach (Account account in accounts)
            {
                account.Deposit(55.55);
            }

            Console.WriteLine("\nAfter $55.55 deposit ");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            foreach (Account account in accounts)
            {
                try
                {
                    account.Withdraw(500);
                }
                //without the class
                // cathc (Exception e)
                catch (WithdrawException e)
                {
                    Console.WriteLine(e.Message);
                }
                if (account.Balance > 300)
                    account.AddName("(Hacked)");
            }

            Console.WriteLine("\nAfter $1.11 withdrawal");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

        }
    }
}
