using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BankSample
{
    public partial class BankForm : Form
    {
        List<Branch> branchesList = new List<Branch>() { };
        public static Bank bank;
        public Dictionary<string, Branch> branchDictionary;
        public BankForm()
        {
            InitializeComponent();
            if (File.Exists("bank.xml"))
            {
                Bank.ReadFromXML();
                ShowBranch();
                if(lstBranches.Items.Count > 0)
                {
                    lstBranches.SelectedIndex = 0;
                }
            }
            else
            {
                bank = new Bank();
                ShowBranch();
            }
        }
        public void ShowBranch()
        {
            lstBranches.Items.Clear();
            branchesList = Bank.GetBranches();
            branchDictionary = new Dictionary<string, Branch> { };

            for (int i = 0; i < branchesList.Count(); i++)
            {
                branchDictionary.Add(branchesList[i].Address.ToString(), branchesList[i]);
                lstBranches.Items.Add(branchesList[i].Address);
            }
            Bank.WriteToXML();
        }

        public void FillForm(string listItem)
        {
            txtStreetNum.Text = branchDictionary[listItem].Address.StreetNumber;
            txtStreetName.Text = branchDictionary[listItem].Address.StreetName;
            txtProvince.Text = branchDictionary[listItem].Address.Province;
            txtPostalCode.Text = branchDictionary[listItem].Address.PostalCode;
            txtPhone.Text = branchDictionary[listItem].Address.PhoneNumber;
            txtCity.Text = branchDictionary[listItem].Address.City;
            txtAptNum.Text = branchDictionary[listItem].Address.ApartmentNumber;
        }

        private void lstBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBranches.SelectedItem != null)
            {
                string listItem = lstBranches.SelectedItem.ToString();
                FillForm(listItem);
            }
        }
        public void ClearTextFields()
        {
            txtStreetNum.Clear();
            txtAptNum.Clear();
            txtStreetName.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtPostalCode.Clear();
            txtPhone.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string streetNum = txtStreetNum.Text;
                string aptNum = txtAptNum.Text;
                string streetName = txtStreetName.Text;
                string city = txtCity.Text;
                string province = txtProvince.Text;
                string postalCode = txtPostalCode.Text;
                string phoneNum = txtPhone.Text;
                Address address = new Address(streetNum, aptNum, streetName, city, province, postalCode, phoneNum);
                Branch branch = new Branch(address);

                if (!branchDictionary.ContainsKey(branch.Address.ToString()))
                {
                    Bank.AddBranch(branch);
                    ShowBranch();
                    lstBranches.SelectedIndex = branchesList.Count() - 1;
                }
                else
                {
                    MessageBox.Show("Branch with such address is already in the system! Try again...");
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string listItem = lstBranches.SelectedItem.ToString();

            if (branchDictionary.Count() > 0 && lstBranches.SelectedIndex != null)
            {
                if (branchDictionary.ContainsKey(listItem))
                {
                    Bank.DeleteBranch(branchDictionary[listItem]);
                }
                else
                {
                    MessageBox.Show("Branch with such address doesn't exist in the system! Try again...");
                }

                ShowBranch();
                ClearTextFields();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string streetNum = txtStreetNum.Text;
                string aptNum = txtAptNum.Text;
                string streetName = txtStreetName.Text;
                string city = txtCity.Text;
                string province = txtProvince.Text;
                string postalCode = txtPostalCode.Text;
                string phoneNum = txtPhone.Text;

                string listItem = lstBranches.SelectedItem.ToString();
                int selectedIndex = lstBranches.SelectedIndex;

                Address address = new Address(streetNum, aptNum, streetName, city, province, postalCode, phoneNum);
                if (branchesList.Count() > 0 && lstBranches.SelectedIndex != null)
                {
                    if (!branchDictionary.ContainsKey(address.ToString()))
                    {
                        Bank.UpdateBranch(branchDictionary[listItem], address);
                        ShowBranch();
                        lstBranches.SelectedIndex = branchesList.Count() - 1;
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
            Branch branch = branchDictionary[lstBranches.SelectedItem.ToString()];
            if (branchDictionary.ContainsKey(lstBranches.SelectedItem.ToString()))
            {
                BranchForm newForm = new BranchForm(branch);
                this.Hide();
                newForm.Show();
            }            
            
        }

        private void BankForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bank.WriteToXML();
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank.WriteToXML();
        }
        public bool ValidateFields()
        {
            if (txtAptNum.Text == string.Empty || txtCity.Text == string.Empty || txtPhone.Text == string.Empty || txtPostalCode.Text == string.Empty ||
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
    }
}
