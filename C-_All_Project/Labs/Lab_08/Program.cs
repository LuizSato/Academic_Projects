using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Test_IO.txt");
            Read("Test_IO.txt");

        }
        static void Write(string filename)
        {
            //When using System.IO; you need to change Console.Write / Console.WriteLine 
            //                               to         writer.Write / writer.WriteLine

            TextWriter writer = new StreamWriter(filename);
            writer.WriteLine("Luiz");
            writer.WriteLine(DateTime.Now);
            for (int i = 1; i < 10; i++)
            {
                writer.WriteLine(" * ");
            }
            writer.Close();
        }
        static void Read(string filename)
        {
            TextReader reader = new StreamReader(filename);

            string input;
            while((input = reader.ReadLine()) != null )
            {
                Console.WriteLine(input); //process the file
                
            }

            // You can use this too

            //string input = read.ReadLine();
            //hile(input != null)
            //{
            //  Console.WriteLine(input);
            //  input = read.ReadLine();
            //}
            reader.Close();
        }
    }
}
