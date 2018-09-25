using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSample
{
    public class Branch
    {
        private static List<Customer> customers = new List<Customer>() { };
        public Address Address { get; set; }
        public List<Customer> Customers { get; set; }
        public Branch(Address address)
        {
            Address = address;
            Customers = customers;
        }
        public Branch() { }
        public void AddCustomer(Customer customer)
        {
            customer.Accounts = new List<Account>() { };
            customers.Add(customer);
        }
        public void DeleteCustomer(Customer customer)
        {
            customers.Remove(customer);
        }
        public void UpdateCustomer(Customer customer, Address address, string firstName, string lastName)
        {
            for (int i = 0; i < customers.Count(); i++)
            {
                if (customers[i] == customer)
                {
                    customers[i].FirstName = firstName;
                    customers[i].LastName = lastName;
                    customers[i].Address = address;
                }
            }
        }
        public static List<Customer> GetCustomers()
        {
            return customers;
        }
        public static void GetBranchCustomers(Branch branch)
        {
            List<Branch> branches = Bank.GetBranches();

            for (int i = 0; i < branches.Count; i++)
            {
                if (branches[i].Address == branch.Address)
                {
                    customers = branch.Customers;
                }
            }
        }
    }
}
