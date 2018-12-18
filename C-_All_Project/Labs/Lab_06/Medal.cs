using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class Medal
    {
        public string Color { get; private set; }
        public bool IsRecord { get; private set; }
        public string Name { get; private set; }
        public string TheEvent { get; private set; }
        public int Year { get; private set; }

        public Medal(string name, string theEvent, string color, int year, bool isRecord)
        {
            Name = name;
            TheEvent = theEvent;
            Color = color;
            Year = year;
            IsRecord = isRecord;
        }
        public override string ToString()
        {
            return $"{Year} - {TheEvent}({(IsRecord ? "R" : "")}) {Name}({Color}) ";
        }
        
    }
}
