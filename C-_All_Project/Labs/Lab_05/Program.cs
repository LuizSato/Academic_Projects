using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
            PetDemo pet1 = new PetDemo("Garfield", 2, "a fat cat");
            pet1.SetOwner("Luiz");
            Console.WriteLine(pet1);

            PetDemo pet2 = new PetDemo("Garu", 2, "a quiet cat");
            pet2.SetOwner("Gio");
            Console.WriteLine(pet2);

            PetDemo pet3 = new PetDemo("Harrold", 2, "a nice cat");
            pet3.SetOwner("Luiz");
            Console.WriteLine(pet3);

            PetDemo pet4 = new PetDemo("Timmy", 2, "a lovely cat");
            pet4.SetOwner("Gio");
            Console.WriteLine(pet4);

            List<PetDemo> petlist = new List<PetDemo> { pet1, pet2, pet3, pet4 };
            Console.WriteLine("-------------------");
            foreach (var x in petlist)
            {
                Console.WriteLine($"{x} ");
            }
            Console.WriteLine("-------------------");
            foreach (var x in petlist)
            {
                Console.WriteLine($"{x.Name} {x.Owner}");
            }
            Console.WriteLine("-------------------");
            foreach (var x in petlist)
            {
                if (x.Owner == "Gio")
                {
                    Console.WriteLine($"{x} ");
                }
            };
        }
    }
}
