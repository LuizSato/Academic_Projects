using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_22
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNumberElement.Text != null && txtName.Text != null && txtSymbol.Text != null && txtDescription.Text != null)
                {
                    int number;
                    if(int.TryParse(txtNumberElement.Text, out number))
                    {
                        if(!string.IsNullOrEmpty(txtName.Text) && (!string.IsNullOrEmpty(txtSymbol.Text)) && (!string.IsNullOrEmpty(txtDescription.Text)))
                        {
                            Elements newElement = new Elements(Convert.ToInt32(txtNumberElement.Text), txtName.Text, txtSymbol.Text, txtDescription.Text);
                            Elements.CreateElement(newElement);

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please fill Name, Symbol, and Description with letters.");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Please Number of Element must be a interger");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the inputs.");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            //Elements newElement = new Elements(Convert.ToInt32(txtNumberElement.Text), txtName.Text, txtSymbol.Text, txtDescription.Text);
            //Elements.CreateElement(newElement);

            //List<Elements> existingElements = ((ElementForm)form).elements;
            //List<int> numberOfElement = new List<int>() { };
            //foreach (var x in )
            //{
            //    numberOfElement.Add(x.NumberOfElement);
            //}
            //if (numberOfElement.Contains(newElement.NumberOfElement))
            //{
            //    MessageBox.Show("Current Element Already Exist");
            //}
            //else
            //{
            //    existingElements.Add(newElement);
            //((ElementForm)form).elements = existingElements;
            //this.Close();
            //form.Show();
            //}
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
