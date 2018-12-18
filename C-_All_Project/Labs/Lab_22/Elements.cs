using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Web.Script.Serialization;

namespace Lab_22
{
    public class Elements
    {
        public static List<Elements> listElements = new List<Elements>() { };
        public int NumberOfElement { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        List<Elements> ListElements { get; set; }
        public Elements(int numberOfElement, string name, string symbol, string description)
        {
            NumberOfElement = numberOfElement;
            Name = name;
            Symbol = symbol;
            Description = description;
            ListElements = listElements;
        }
        public Elements() { }
        public static Elements Parse(string line)
        {
            string[] ele = line.Split('|');
            if (ele.Length != 4)
                throw new Exception("The atom have unnecessary information");
            else
                return new Elements(Convert.ToInt32(ele[0]), ele[1], ele[2], ele[3]);
        } 
        public override string ToString()
        {
            return $"Number: {NumberOfElement} Symbol: {Symbol} Name: {Name} Description: {Description}";
        }
        public static void CreateElement(Elements element)
        {
            listElements.Add(element);
        }
        public static void DeleteElement(Elements element)
        {
            if (listElements.Contains(element))
            {
                listElements.Remove(element);
            }
            else
            {
                throw new Exception("Please select a element to be deleted.");
            }
        }
        public static void DeleteElement_List(int number)
        {
            int numberChoosed = 0;
            bool found = false;
            foreach (Elements x in listElements)
            {
                if (number == x.NumberOfElement)
                {
                    numberChoosed = listElements.IndexOf(x);
                    found = true;
                }
            }
            if (found)
            {
                listElements.RemoveAt(numberChoosed);
            }
            else
            {
                throw new Exception("Please select a Elemento to be Deleted.");
            }
        }
        //this will read the .txt which contain all the Elements.
        public static List<Elements> ReadAllFromTxt(string filename)
        {
            using (TextReader reader = new StreamReader("Elements.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Parse(line); //this will read all the line and pass to the parse method
                    listElements.Add(Elements.Parse(line));

                    //this substitute Parse(line)
                    //string[] atom = line.Split('|');
                    //Elements elements = new Elements(Convert.ToInt32(atom[0]), atom[1], atom[2], atom[3]);
                    //listElements.Add(elements);
                }
            }
            return listElements;
        }
        public static void WriteAllToJson()
        {
            using (TextWriter writer = new StreamWriter("Elements.json"))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                writer.Write(serializer.Serialize(listElements));
            }
        }
    }
}
