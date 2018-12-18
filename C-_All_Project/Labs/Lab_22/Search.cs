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
    public partial class Search : Form
    {
        List<Elements> getElements = new List<Elements>() { };
        public Search()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int choosedElement = Convert.ToInt32(txtSearch.Text);
                Elements search = SearchElement(choosedElement);
                lblResultNumber.Text = $"Number: {search.NumberOfElement.ToString()}";
                lblResultName.Text = $"Name: {search.Name.ToString()}";
                lblResultSymbol.Text = $"Symbol: {search.Symbol.ToString()}";
                lblResultDescription.Text = $"Description: {search.Description.ToString()}";
            }
            catch //(Exception exception)
            {
                MessageBox.Show("Search element not in the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //foreach (var x in getElements)
            //{
            //    ElementDictionary.Add(x.NumberOfElement, x);
            //}
        }
        public Elements SearchElement(int choosed)
        {

            getElements = Elements.listElements;
            int numberchoosed = 0;
            bool found = false;
            foreach (Elements x in getElements)
            {
                if (choosed == x.NumberOfElement)
                {
                    numberchoosed = getElements.IndexOf(x);
                    found = true;
                }
            }
            if(found)
            {
                return getElements[numberchoosed];
            }
            else
            {
                return null;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
