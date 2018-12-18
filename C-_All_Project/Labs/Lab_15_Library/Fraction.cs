using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15_Library
{
    public class Fraction
    {
        public int Top { get; private set; }
        public int Bottom { get; private set; }
        public override string ToString()
        {
            return $"{Top} | {Bottom}";
        }
        public Fraction(int top = 0, int bottom = 1)
        {
            Top = top;
            Bottom = bottom;
        }
        public static Fraction operator +(Fraction left, Fraction right)
        {
            int top = left.Top * right.Bottom + right.Top * left.Bottom;
            int bottom = left.Bottom * right.Bottom;
            return new Fraction(top, bottom);
        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            int top = left.Top * right.Bottom - right.Top * left.Bottom;
            int bottom = left.Bottom * right.Bottom;
            if (top < 0)
            {
                throw new Exception("Right number should not be bigger than left one");
            }
            else
            {
                return new Fraction(top, bottom);
            }
        }
    }
}