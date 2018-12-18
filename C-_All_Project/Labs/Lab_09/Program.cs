using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //To test the constructor and the ToString method

            Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));
            Console.WriteLine(new Song("The Promise", "Chris Cornell ", 4.26, SongGenre.Country | SongGenre.Rock));

            Library.LoadSongs("Week_03_lab_09_songs4.txt");     //Class methods are invoke with the class name
            Console.WriteLine("\n\nAll songs");
            Library.DisplaySongs();

            SongGenre genre = SongGenre.Rock;
            Console.WriteLine("\n\n{0} songs", genre);
            Library.DisplaySongs(genre);

            string artist = "Bob Dylan";
            Console.WriteLine("\n\nSongs by {0}", artist);
            Library.DisplaySongs(artist);

            double length = 5.0;
            Console.WriteLine("\n\nSongs more than {0}mins", length);
            Library.DisplaySongs(length);





        }
    }
}
