using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace Test_01
{
    class Prescription
    {
        private List<Drug> drugs = new List<Drug>() { };
        public string Address { get; }
        public bool ForRepeat { get; }
        public string Patient { get; }
        public Prescription(string patient, string address, bool forRepeat = false)
        {
            Patient = patient;
            Address = address;
            ForRepeat = forRepeat;
        }
        public void AddDrug (Drug drug)
        {
            drugs.Add(drug);
        }
        public void RemoveDrug (string din)
        {
            for (int i = 0; i < drugs.Count; i++)
            {
                if(drugs[i].Din == din)
                {
                    drugs.RemoveAt(i);
                }

            }
        }
        private string GetDrugs()
        {
            return string.Join("\n", drugs);
        }
        public void Save(string filename)
        {
            using(TextWriter writer = new StreamWriter(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                writer.WriteLine(serializer.Serialize(drugs));
            }
        }
        public override string ToString()
        {
            return $"{GetDrugs()} {Patient} {Address} {(ForRepeat ? "(R)" : "")}"; ;
        }
    }
}
