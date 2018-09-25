using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01
{
    [Flags]

    enum DrugForm
    {
        Liquid = 0,
        Cream = 0b1,
        Gel = 0b10,
        Paste = 0b100,
        Tablet = 0b1000,
        Capsule = 0b10000,
        Powder = 0b100000,
        Aerosol = 0b1000000
    }
    class Drug
    {
        public int NEXT_NUMBER = 101;
        public string Din { get; }
        public int Dosage { get; }
        public DrugForm Form { get; }
        public string Name { get; }

        public Drug(string name, DrugForm form, int dosage)
        {
            Name = name;
            Form = form;
            Dosage = dosage;
            Din = Convert.ToString(NEXT_NUMBER++);
        }
        public override string ToString()
        {
            return $"{Din} {Form} {Name} {Dosage}";
        }
    }
}
