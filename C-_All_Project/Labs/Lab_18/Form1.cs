using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_18
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Calculator();
        }

        private void btnCalculate_MouseClick(object sender, MouseEventArgs e)
        {
            Calculator();
        }

        private void Calculator()
        {
            if (txtFirst.Text == "" || txtSecond.Text == "")
            {
                MessageBox.Show("Please enter all the numbers:");
            }
            else
            {
                double first = Convert.ToDouble(txtFirst.Text);
                double second = Convert.ToDouble(txtSecond.Text);
                if (rdoAdd.Checked)
                {
                    txtResult.Text = (first + second).ToString();
                }
                else if (rdoSub.Checked)
                {
                    txtResult.Text = (first - second).ToString();
                }
                else if (rdoMulti.Checked)
                {
                    txtResult.Text = (first * second).ToString();
                }
                else if (rdoDiv.Checked)
                {
                    txtResult.Text = (first / second).ToString();
                }
            }
        }

        private void btnCalculate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                Calculator();
            }
        }
    }
}
