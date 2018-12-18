using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sphere> shapes = new List<Sphere>();
            shapes.Add(new Sphere(2));
            shapes.Add(new Cylinder(1.5, 2));
            shapes.Add(new Cone(.75, 1.5));
            shapes.Add(new Cube(1.2));
            foreach (Sphere shape in shapes)
            {
                Console.WriteLine("{0:f2}", shape.Volume);
            }

        }
    }
}
