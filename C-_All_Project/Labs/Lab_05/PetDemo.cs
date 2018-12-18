using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class PetDemo
    {
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public int Age { get; private set; }
        public string Description { get; private set; }
        public bool IsHouseTrained { get; private set; }

        public PetDemo(string name, int age, string description)
        {
            Name = name; Age = age; Description = description;
            Owner = "no one";
            IsHouseTrained = false;
        }
        public override string ToString()
        {
            return $"I am {Name}, I am {Age} years, My owner is {Owner}. I am {(IsHouseTrained ? "" : "not")} house trained";
        }
        public void SetOwner(string owner)
        {
            Owner = owner;
        }
    }
}
