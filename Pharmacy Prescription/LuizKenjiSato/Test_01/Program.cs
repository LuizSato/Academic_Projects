using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //test the Drug class
            Console.WriteLine("\n*****Testing the Drug Class");
            Console.WriteLine(new Drug("Aspirin", DrugForm.Tablet, 85));
            Console.WriteLine(new Drug("Tylenol", DrugForm.Capsule, 125));
            Console.WriteLine(new Drug("Metformin", DrugForm.Tablet, 250));
            //test the Prescription class
            Console.WriteLine("\n*****Testing the Prescription Class");
            Console.WriteLine(new Prescription("Narendra Pershad", "Markham Road", true));
            //testing InsertDrug method of the Prescription class
            Console.WriteLine("\n*****Testing the InsertDrug()");
            Prescription p0 = new Prescription("Ilia Nika", "Morningside Avenue", false);
            p0.AddDrug(new Drug("Oxycontin", DrugForm.Gel, 150));
            p0.AddDrug(new Drug("Marjuana", DrugForm.Paste, 200));
            p0.AddDrug(new Drug("Amoxicillin", DrugForm.Capsule, 324));
            p0.AddDrug(new Drug("Fentanyl", DrugForm.Aerosol, 120));
            Console.WriteLine(p0);
            Console.WriteLine("\n*****Testing the InsertDrug()");
            Prescription p1 = new Prescription("Arben Tapia", "Williams Parkway");
            p1.AddDrug(new Drug("Warfarin", DrugForm.Gel, 34));
            p1.AddDrug(new Drug("Prozac", DrugForm.Paste, 634));
            p1.AddDrug(new Drug("Ibuprofen", DrugForm.Tablet, 62));
            p1.AddDrug(new Drug("Oxycodone", DrugForm.Liquid, 85));
            p1.AddDrug(new Drug("Ropinirole", DrugForm.Cream, 124));
            p1.AddDrug(new Drug("Tramadol", DrugForm.Powder, 254));
            Console.WriteLine(p1);
            //testing the RemoveDrug method of the prescription class
            //check the previous display to verify that atleast
            //two of the item numbers are used below
            Console.WriteLine("\n*****Testing the RemoveDrug()");
            p1.RemoveDrug("109");
            p1.RemoveDrug("110");
            try
            {
                p1.RemoveDrug("109"); //this should cause an exception
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(p1);
            p1.Save("Arben.json"); //this saves all the drugs to the json file "Arben.json"
            Console.Write("... Press enter to exit");
            Console.ReadLine(); //keeps the window open
        }
    }
}
