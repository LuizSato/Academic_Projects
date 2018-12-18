using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    class Car
    {
        public int Year { get; private set; }// read access is public; write access is private

        public string Manufacturer { get; private set; }

        public string Model { get; private set; }

        public bool IsDrivable { get; private set; }

        public double Price { get; private set; }

        public Car(int year, string manufacture, string model, double price, bool isDrivable = true)
        {
            Year = year;
            Manufacturer = manufacture; Model = model;
            IsDrivable = isDrivable;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Year} | {Manufacturer} | {Model} | {Price} | {(IsDrivable ? "Is Working" : "Is not Working")}";
        }
    }
}
