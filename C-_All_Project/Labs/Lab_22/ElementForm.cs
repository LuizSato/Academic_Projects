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

namespace Lab_22
{
    public partial class ElementForm : Form
    {
        public List<Elements> elements = new List<Elements>() { };
        Dictionary<int, Elements> elementsDictionary = new Dictionary<int, Elements>() { };
        public ElementForm()
        {
            InitializeComponent();
            DisplayElements();
        }
        public void DisplayElements()
        {
            elements = Elements.ReadAllFromTxt("Elements.txt");
            dataGridView1.DataSource = elements;
        }
        public void RefreshDataGridView()
        {
            elements = Elements.listElements;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = elements;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addElement = new AddForm();
            addElement.ShowDialog();
            RefreshDataGridView();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Elements.WriteAllToJson();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search newSearch = new Search();
            newSearch.ShowDialog();
        }
        //there is no need to use dictionary is your using List<>
        //you can use either one or another.
        public void ListToDictionary()
        {
            foreach (var x in elements)
            {
                elementsDictionary.Add(x.NumberOfElement, x);
            }
        }

        //two different method on how to use delete button.
        private void btnDel_Click(object sender, EventArgs e)
        {
            int choosedRow = Convert.ToInt32(dataGridView1.SelectedRows[0].Index);
            //int choosedRow = Convert.ToInt32(elements[dataGridView1.SelectedRows]);
            try
            {
                //Elements.DeleteElement(elementsDictionary[choosedRow]);
                Elements.DeleteElement(elements[choosedRow]);

                //if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
                //{
                //    //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                //    Elements.DeleteElement(elementsDictionary[Convert.ToInt32(dataGridView1.SelectedRows.Count)]);
                //}
            }
            catch (Exception expection)
            {
                MessageBox.Show(expection.Message);
            }
            RefreshDataGridView();
        }
        //this method will open another form, which ask the user for the index to be deleted.
        private void btnDel_Click_List(object sender, EventArgs a)
        {
            DeleteForm DeleteForm = new DeleteForm();
            DeleteForm.ShowDialog();
            RefreshDataGridView();

        }
    }
}
