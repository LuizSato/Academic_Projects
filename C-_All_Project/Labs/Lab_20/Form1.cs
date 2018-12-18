using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_20
{
    public partial class Form1 : Form
    {
        Dictionary<string, Premier> PremierDictionary = new Dictionary<string, Premier>() { };
        List<Premier> premierList = new List<Premier>();
        public Form1()
        {
            InitializeComponent();
            ShowPremier();
        }
        public void ShowPremier()
        {
            premierList = Premier.GetPremiers();
            //PremierDictionary = new Dictionary<string, Premier>() { };
            foreach (var x in premierList)
            {
                PremierDictionary.Add(x.GetKey(), x);
                listBox.Items.Add(x.GetKey());
            }
        }

        public void FillForm(string listItem)
        {
            Premier premier = PremierDictionary[listItem];
            //string listItem = lstPremiers.SelectedItem.ToString();
            lblName.Text = PremierDictionary[listItem].name;
            lblBirth.Text = PremierDictionary[listItem].birth;
            lblRange.Text = PremierDictionary[listItem].range;
            //pictureBox1.Image = Image.FromFile(key + ".jpg");

        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listItem = listBox.SelectedItem.ToString();
            FillForm(listItem);
        }
    }
}
