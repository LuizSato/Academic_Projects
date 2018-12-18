using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Astronaut
    {
        static int COUNT = 0;
        static int MAX = 5;
        public string Name { get; }
        public string Nationality { get; }
        Astronaut(string name, string nationality)
        {
            Name = name;
            Nationality = nationality;
            COUNT++;
        }
        public static Astronaut CreateAstronaut(string name, string nationality)
        {
            if (COUNT < MAX)
            {
                Astronaut austronat = new Astronaut(name, nationality);
                return austronat;
            }
            else
            {
                return null;
            }
        }
        public override string ToString()
        {
            return $"{Name} - {Nationality}";
        }

        public static void SetMax(int max)
        {
            MAX = max;
        }
    }
}
