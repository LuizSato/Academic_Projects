using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_Library
{
    public class Atom
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Proton { get; set; }
        public int Neutron { get; set; }
        public double Weight { get; set; }
        public Atom()
        {
        }
        public Atom(string name, int proton, int neutron, double weight, string symbol)
        {
            Name = name;
            Proton = proton;
            Neutron = neutron;
            Weight = weight;
            Symbol = symbol;
        }
        public static Atom Parse(string line)
        {
            string[] atom = line.Split();
            if(atom.Length != 5)
            {
                throw new Exception("The atom have unnecessary information");
            }
            else
            {
                return new Atom(atom[0], Convert.ToInt32(atom[1]), Convert.ToInt32(atom[2]), Convert.ToDouble(atom[3]), atom[4]);
            }
        }
        public override string ToString()
        {
            return $"Symbol: {Symbol,3} | Name: {Name,13} | Neutron: {Neutron,3} | Proton: {Proton,3} | Weight: {Weight:F3}";
        }
    }
}
