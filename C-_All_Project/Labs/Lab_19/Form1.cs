using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }
        private void btnCalculate_KeyPress(object sender, KeyPressEventArgs e)
        {
            DoCalculation();
        }
        private void DoCalculation()
        {
            if (txtFirstNume.Text == "" || txtFirstDeno.Text == "" || txtSecondNume.Text == "" || txtSecondDeno.Text == "")
            {
                MessageBox.Show("Please enter all the numbers:");
            }
            else
            {
                int firstNume = Convert.ToInt32(txtFirstNume.Text);
                int firstDeno = Convert.ToInt32(txtFirstDeno.Text);
                int secondNume = Convert.ToInt32(txtSecondNume.Text);
                int secondDeno = Convert.ToInt32(txtSecondDeno.Text);
                Fraction First = new Fraction(firstNume, firstDeno);
                Fraction Second = new Fraction(secondNume, secondDeno);
                if (rdoAdd.Checked)
                {
                    Fraction Result = First + Second;
                    txtResultNume.Text = Result.Numerator.ToString();
                    txtResultDeno.Text = Result.Denominator.ToString();
                }
                else if (rdoSub.Checked)
                {
                    Fraction Result = First - Second;
                    txtResultNume.Text = Result.Numerator.ToString();
                    txtResultDeno.Text = Result.Denominator.ToString();
                }
                else if (rdoMulti.Checked)
                {
                    Fraction Result = First * Second;
                    txtResultNume.Text = Result.Numerator.ToString();
                    txtResultDeno.Text = Result.Denominator.ToString();
                }
                else if (rdoDiv.Checked)
                {
                    Fraction Result = First / Second;
                    txtResultNume.Text = Result.Numerator.ToString();
                    txtResultDeno.Text = Result.Denominator.ToString();
                }
            }
        }
        public class Fraction
        {
            public int Numerator { get; private set; }
            public int Denominator { get; private set; }
            public Fraction(int num, int deno)
            {
                Numerator = num;
                Denominator = deno;
            }
            public static Fraction operator +(Fraction left, Fraction right)
            {
                Fraction Result;
                if (left.Denominator == right.Denominator)
                    Result = new Fraction(left.Numerator + right.Numerator, left.Denominator);
                else
                    Result = new Fraction(left.Numerator * right.Denominator + right.Numerator * left.Denominator, right.Denominator * left.Denominator);
                    return Simplify(Result);
            }
            public static Fraction operator -(Fraction left, Fraction right)
            {
                Fraction Result;
                if (left.Denominator == right.Denominator)
                    Result = new Fraction(left.Numerator = right.Numerator, left.Denominator);
                else
                    Result = new Fraction(left.Numerator * right.Denominator - right.Numerator * left.Denominator, right.Denominator * left.Denominator);
                    return Simplify(Result);
            }
            public static Fraction operator *(Fraction left, Fraction right)
            {
                Fraction Result = new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator);
                return Simplify(Result);
            }
            public static Fraction operator /(Fraction left, Fraction right)
            {
                Fraction Result = new Fraction(left.Numerator * right.Denominator, left.Denominator * right.Numerator);
                return Simplify(Result);
            }
            public static Fraction Simplify(Fraction first)
            {
                while (true)
                {
                    if(first.Numerator % 2 == 0 && first.Denominator % 2 == 0)
                    {
                        first.Denominator = first.Denominator / 2;
                        first.Numerator = first.Numerator / 2;
                    }
                    else if(first.Denominator % 3 == 0 && first.Numerator % 3 == 0)
                    {
                        first.Denominator = first.Denominator / 3;
                        first.Numerator = first.Numerator / 3;
                    }
                    else if (first.Denominator % 5 == 0 && first.Numerator % 5 == 0)
                    {
                        first.Denominator = first.Denominator / 5;
                        first.Numerator = first.Numerator / 5;
                    }
                    else if (first.Denominator % 7 == 0 && first.Numerator % 7 == 0)
                    {
                        first.Denominator = first.Denominator / 7;
                        first.Numerator = first.Numerator / 7;
                    }
                    else if (first.Denominator % 11 == 0 && first.Numerator % 11 == 0)
                    {
                        first.Denominator = first.Denominator / 11;
                        first.Numerator = first.Numerator / 11;
                    }
                    else
                    {
                        break;
                    }
                }
                return new Fraction(first.Numerator, first.Denominator);
            }
            public override string ToString()
            {
                return string.Format($"[{Numerator} / {Denominator}]");
            }
        }
        public void NoDigit(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Space)
            //    e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            else
                e.Handled = true;

        }
    }
}
