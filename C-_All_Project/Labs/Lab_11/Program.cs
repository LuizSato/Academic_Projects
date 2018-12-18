using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c0 = new Complex(-1, 1);
            Complex c1 = new Complex(-1, 1);
            Complex c2 = new Complex(1, -1);
            Complex c3 = c1 + c2;
            Console.WriteLine($"{c1} + {c2} = {c3}");
            c3 = c1 - c2;
            Console.WriteLine($"{c1} - {c2} = {c3}");

            Console.WriteLine($"{c3} in polar form is {c3.Modulus:f2}cis({c3.Argument:f2})");


            Console.WriteLine($"{c0} {((c0 == c1) ? "==" : "!=")} {c1}");
            Console.WriteLine($"{c0} {((c0 == c2) ? "==" : "!=")} {c2}");
            Console.WriteLine($"{c3} * {c1} = {c3 * c1}");
        }
    }
}
