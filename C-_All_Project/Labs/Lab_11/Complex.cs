using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Complex
    {
        //Perimeter (Auto-Implementation)
        public int Real { get; }
        public int Imaginary { get; }
        //Perimeter (Non Auto-Implementation)
        public double Modulus
        {
            get
            {
                return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
            }
        }
        public double Argument
        {
            get
            {
                return Math.Pow(Math.Tan(Real / Imaginary),-1);
            }
        }
        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"{Real} | {Imaginary}"; 
        }
        //Overloading Operators
        //this can allow the "+" of "int" and "double"
        //return a class into int
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            if (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary)
                return true;
            else
                return false;
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            if (lhs.Real != rhs.Real && lhs.Imaginary != rhs.Imaginary)
                return true;
            else
                return false;

            //return (!(lhs == rhs));
        }
        public static Complex operator *(Complex lhs, Complex rhs)
        {
            int real = lhs.Real * rhs.Real - lhs.Imaginary * rhs.Imaginary;
            int imaginary = lhs.Real * rhs.Imaginary + lhs.Imaginary * rhs.Real;
            return new Complex(real, imaginary);
        }
    }
}
