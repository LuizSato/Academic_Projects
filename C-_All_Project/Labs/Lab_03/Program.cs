using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Date luiz_Bday;
            luiz_Bday = new Date(1999, 04, 05);
            Console.WriteLine(luiz_Bday);

            Date May;
            May = new Date(2018, 05, 10);
            Console.WriteLine(May);

            May.AddMonthDay(10, 35);
            Console.WriteLine(May);

            May.AddAnotherDate(luiz_Bday);
            Console.WriteLine(May);
        }
    }
}
