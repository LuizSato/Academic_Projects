using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace BankSample
{
    [Serializable()]
    public class Bank
    {
        public static List<Branch> branches = new List<Branch>() { };
        public string Name { get; set; }
        List<Branch> Branches { get; set; }
        public Bank(string name = "TD-Scotia Bank")
        {
            Name = name;
            Branches = branches;
        }
        public Bank() { }
        public static void AddBranch(Branch branch)
        {
            branch.Customers = new List<Customer>() { };
            branches.Add(branch);
        }
        public static void DeleteBranch(Branch branch)
        {
            branches.Remove(branch);
        }
        public static void UpdateBranch(Branch branch, Address address)
        {
            for (int i = 0; i < branches.Count(); i++)
            {
                if (branches[i] == branch)
                {
                    branches[i].Address = address;
                }
            }
        }
        public static List<Branch> GetBranches()
        {
            return branches;
        }
        public static void WriteToXML()
        {
            using (TextWriter writer = new StreamWriter("Bank.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Branch>));
                serializer.Serialize(writer, Bank.GetBranches());
            }
        }
        public static void ReadFromXML()
        {
            using (TextReader reader = new StreamReader("Bank.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Branch>));
                branches = (List<Branch>)serializer.Deserialize(reader);
            }
        }
    }
}
