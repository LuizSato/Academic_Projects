using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Astronaut> astronauts = new List<Astronaut>();
            astronauts.Add(Astronaut.CreateAstronaut("Yuri Gagarin", "Russian"));       // 1
            astronauts.Add(Astronaut.CreateAstronaut("Alan Shepard", "American"));      // 2
            astronauts.Add(Astronaut.CreateAstronaut("Virgil Grissom", "American"));    // 3
            astronauts.Add(Astronaut.CreateAstronaut("Gherman Titov", "Russian"));      // 4
            astronauts.Add(Astronaut.CreateAstronaut("John Glenn", "American"));        // 5
            astronauts.Add(Astronaut.CreateAstronaut("Scott Carpenter", "American"));   // 6

            //only 5 astronaut created
            Console.WriteLine("Only 5 astronauts created");
            foreach (var astronaut in astronauts)
            {
                Console.WriteLine(astronaut);
            }

            Astronaut.SetMax(6);
            astronauts.Add(Astronaut.CreateAstronaut("Scott Carpenter", "American"));   // 6
                                                                                        //now 6 astronaut created
            Console.WriteLine("Now 6 astronauts created");
            foreach (var astronaut in astronauts)
            {
                Console.WriteLine(astronaut);
            }

        }
    }
}
