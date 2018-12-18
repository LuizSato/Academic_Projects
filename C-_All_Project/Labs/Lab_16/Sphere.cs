using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16
{
    class Sphere
    {
        public double Length { get; private set; }
        public virtual double Volume
        {
            get { return (4 * Math.PI * Math.Pow(Length, 3)) / 3; }
        }
        public Sphere(double length)
        {
            Length = length;
        }

    }
    class Cylinder:Sphere
    {
        public double Height { get; private set; }
        public override double Volume
        {
            get { return Math.PI * Math.Pow(Length, 2) * Height; }
        }
        public Cylinder(double length, double height): base(length)
        {
            Height = height;
        }
    }
    class Cone : Cylinder
    {
        public override double Volume
        {
            get { return base.Volume / 3; }
        }
        public Cone(double length, double height) : base(length, height)
        {
        }
    }
    class Cube: Sphere
    {
        public override double Volume
        {
            get { return Math.Pow(Length, 3); }
        }
        public Cube(double lenght) : base(lenght)
        {
        }
    }
}
