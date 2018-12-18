using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //To create and use the class name after use this code.
            Car Honda;
            Honda = new Car(2017, "Honda", "HR-V", 29030.00);
            Console.WriteLine(Honda);

            //If use the code above (line 14) you only print the information
            Console.WriteLine(new Car(2018, "Honda", "HR-V", 29030.00, true));

            Car Toyota;
            Toyota = new Car(2015, "Toyota", "Toyota-01", 21320.00, true);
            Console.WriteLine(Toyota);

            //i.g about public get and private set.
            //This code (line 23) is get (read) public
            Console.WriteLine(Honda.Model);
            //But we cannot change since the set (write) is private..level of security

            
            Honda.Manufacturer - "Nissan";
        }
    }
}
