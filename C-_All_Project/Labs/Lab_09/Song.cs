using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_09
{
    [Flags]
    public enum SongGenre
    {
        Unclasified = 0x00,
        Pop = 0x01,
        Rock = 2,
        Blues = 0x04,
        Country = 0x08,
        Metal = 0x16,
        Soul = 0x32
    }
    public class Song
    {
        public string Artist { get; }
        public SongGenre Genre { get; }
        public double Length { get; }
        public string Title { get; }
        //???????????????????
        //static SongGenre SONG_GENRE = SongGenre.Unclasified;

        public Song(string title, string artist, double length, SongGenre genre)
        {
            Title = title; Artist = artist; Length = length; Genre = genre;
        }
        public override string ToString()
        {
            return $"{Title} by {Artist} ({Genre}) {Length}";
        }

    }
    public static class Library
    {
        static List<Song> listSongs = new List<Song>();
        public static void DisplaySongs()
        {
            foreach (Song x in listSongs)
            {
                Console.WriteLine(x);
            }
        }
        public static void DisplaySongs(double longerThan)
        {
            foreach (Song x in listSongs)
            {
                if (x.Length > longerThan)
                {
                    Console.WriteLine($"{x}");
                }
            }
        }
        public static void DisplaySongs(SongGenre genre)
        {
            foreach (Song x in listSongs)
            {
                if (x.Genre == genre)
                {
                    Console.WriteLine($"{x}");
                }
            }
        }
        public static void DisplaySongs(string artist)
        {
            foreach (Song x in listSongs)
            {
                if (x.Artist == artist)
                {
                    Console.WriteLine($"{x}");
                }
            }
        }
        public static void LoadSongs(string filename)
        {
            TextReader reader = new StreamReader(filename);

            while (true)
            {
                string songTitle = reader.ReadLine();
                string songArtist = reader.ReadLine();
                string songLenght = reader.ReadLine();
                string songGenre = reader.ReadLine();
                if (songTitle == null)
                {
                    break;
                }
                else
                {
                    Song record = new Song(songTitle.ToString(), songArtist.ToString(), Convert.ToDouble(songLenght), (SongGenre)Enum.Parse(typeof(SongGenre), songGenre));
                    listSongs.Add(record);
                }
            }
            reader.Close();
        }
        
        //public static void LoadSongs(string filename)
        //{
        //    TextReader reader = new StreamReader(filename);
        //    string title;
        //    while ((title = reader.ReadLine()) != null)
        //    {
        //        string artist = reader.ReadLine();
        //        string lenght = reader.ReadLine();
        //        string genre = reader.ReadLine();
        //        Song record = new Song(title.ToString(), artist.ToString(), Convert.ToDouble(lenght), (SongGenre)Enum.Parse(typeof(SongGenre), genre));
        //        listSongs.Add(record);
        //    }
        //}
    }

}

