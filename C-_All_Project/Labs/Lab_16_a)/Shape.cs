using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16_a_
{
    abstract class Shape
    {
        public string Name { get; private set; }
        public virtual double Area
        {
            get;
        }
        public Shape(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Name: {Name} Area: {Area:f2}";
        }
    }
    class Square:Shape
    {
        public double Length { get; private set; }
        public override double Area
        {
            get { return Math.Pow(Length, 2); }
        }
        public Square(string name, double length) : base(name)
        {
            Length = length;
        }
    }
    class Circle:Square
    {
        public override double Area
        {
            get { return Math.PI * base.Area; }
        }
        public Circle(string name, double length) : base(name,length)
        { }
    }
    class Rectangle:Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public override double Area
        {
            get { return Width * Height; }
        }
        public Rectangle(string name, double length, double width):base(name)
        {
            Width = width;
            Height = length;
        }
    }
    class Ellipse:Rectangle
    {
        public override double Area
        {
            get { return Math.PI * base.Area; }
        }
        public Ellipse(string name, double height, double width) : base(name,height,width)
        { }
    }
    class Triangle:Rectangle
    {
        public override double Area
        {
            get { return base.Area * 0.5; }
        }
        public Triangle(string name, double height, double width):base(name, height, width)
        { }
    }
    class Diamond:Rectangle
    {
        public override double Area
        {
            get { return base.Area * 0.5; }
        }
        public Diamond(string name, double height, double width):base(name, height, width)
        { }
    }
}
