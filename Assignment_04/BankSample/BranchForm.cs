using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankSample
{
    public partial class BranchForm : Form
    {
        List<Customer> customerList = new List<Customer>() { };
        public Dictionary<string, Customer> customerDictionary;
        //Bank bank = BankForm.bank;
        public Branch branch;
        public BranchForm(Branch name)
        {
            InitializeComponent();
            if (File.Exists("Bank.xml"))
            {
                //bank.ReadFromXML();
                branch = name;
                Branch.GetBranchCustomers(branch);
                ShowCustomers();
                if (lstCustomers.Items.Count > 0)
                {
                    lstCustomers.SelectedIndex = 0;
                }
            }
            else
            {
                ShowCustomers();
            }
            lblBranchName.Text = "Branch: " + branch.Address;
        }


        public void ShowCustomers()
        {
            lstCustomers.Items.Clear();
            if (branch != null)
            {
                customerList = Branch.GetCustomers();
            }
            customerDictionary = new Dictionary<string, Customer> { };

            for (int i = 0; i < customerList.Count(); i++)
            {
                customerDictionary.Add(customerList[i].ToString(), customerList[i]);
                lstCustomers.Items.Add(customerList[i].ToString());
            }
            Bank.WriteToXML();
        }
        public void FillForm(string listItem)
        {
            txtFIrstName.Text = customerDictionary[listItem].FirstName;
            txtLastName.Text = customerDictionary[listItem].LastName;
            txtStreetName.Text = customerDictionary[listItem].Address.StreetName;
            txtStreetNum.Text = customerDictionary[listItem].Address.StreetNumber;
            txtAptNum.Text = customerDictionary[listItem].Address.ApartmentNumber;
            txtCity.Text = customerDictionary[listItem].Address.City;
            txtProvince.Text = customerDictionary[listItem].Address.Province;
            txtPostalCode.Text = customerDictionary[listItem].Address.PostalCode;
            txtPhone.Text = customerDictionary[listItem].Address.PhoneNumber;
        }
        public void ClearTextFields()
        {
            txtAptNum.Clear();
            txtCity.Clear();
            txtFIrstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtPostalCode.Clear();
            txtProvince.Clear();
            txtStreetName.Clear();
            txtStreetNum.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string firstName = txtFIrstName.Text;
                string lastName = txtLastName.Text;
                string streetName = txtStreetName.Text;
                string streetNum = txtStreetNum.Text;
                string aptNum = txtAptNum.Text;
                string city = txtCity.Text;
                string province = txtProvince.Text;
                string postalCode = txtPostalCode.Text;
                string phoneNum = txtPhone.Text;
                Address address = new Address(streetNum, aptNum, streetName, city, province, postalCode, phoneNum);
                Customer customer = new Customer(firstName, lastName, address);

                if (!customerDictionary.ContainsKey(customer.ToString()))
                {
                    branch.AddCustomer(customer);
                    ShowCustomers();
                    lstCustomers.SelectedIndex = customerList.Count() - 1;
                }
                else
                {
                    MessageBox.Show("Customer with such address is already in the system! Try again...");
                }
            }
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string listItem = lstCustomers.SelectedItem.ToString();

            if (customerDictionary.Count() > 0 && lstCustomers.SelectedIndex != null)
            {
                if (customerDictionary.ContainsKey(listItem))
                {
                    branch.DeleteCustomer(customerDictionary[listItem]);
                }
                else
                {
                    MessageBox.Show("Branch with such address doesn't exist in the system! Try again...");
                }

                ShowCustomers();
                ClearTextFields();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string firstName = txtFIrstName.Text;
                string lastName = txtLastName.Text;
                string streetName = txtStreetName.Text;
                string streetNum = txtStreetNum.Text;
                string aptNum = txtAptNum.Text;
                string city = txtCity.Text;
                string province = txtProvince.Text;
                string postalCode = txtPostalCode.Text;
                string phoneNum = txtPhone.Text;

                string listItem = lstCustomers.SelectedItem.ToString();
                int selectedIndex = lstCustomers.SelectedIndex;

                Address address = new Address(streetNum, aptNum, streetName, city, province, postalCode, phoneNum);
                if (customerList.Count() > 0 && lstCustomers.SelectedIndex != null)
                {
                    if (!customerDictionary.ContainsKey(address.ToString()))
                    {
                        branch.UpdateCustomer(customerDictionary[listItem], address, firstName, lastName);
                        ShowCustomers();
                        lstCustomers.SelectedIndex = customerList.Count() - 1;
                    }
                    else
                    {
                        MessageBox.Show("Branch with such address is already in the system! Try again...");
                    }
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Customer customer = customerDictionary[lstCustomers.SelectedItem.ToString()];
            CustomerForm customerForm = new CustomerForm(customer);
            this.Hide();
            customerForm.Show();
        }
        public bool ValidateFields()
        {
            if (txtFIrstName.Text == string.Empty ||txtLastName.Text == string.Empty || txtAptNum.Text == string.Empty || txtCity.Text == string.Empty || txtPhone.Text == string.Empty || txtPostalCode.Text == string.Empty ||
                txtProvince.Text == string.Empty || txtStreetName.Text == string.Empty || txtStreetNum.Text == string.Empty)
            {
                MessageBox.Show("All fields should be filled!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItem != null)
            {
                string listItem = lstCustomers.SelectedItem.ToString();
                FillForm(listItem);
            }
        }

        private void BranchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bank.WriteToXML();
            Application.Exit();
        }

        private void bankFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BankForm bankForm = new BankForm();
            this.Hide();
            bankForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank.WriteToXML();  
        }
    }
}
