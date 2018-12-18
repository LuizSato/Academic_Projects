using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Lab_17
{
    interface IDrawable
    {
        void Draw(Graphics G);
    }
    interface IWritable
    {
        void Write(TextWriter writer);
    }
    public abstract class Primitive
    {
        protected Color color;
        protected bool filled;
        protected Rectangle BoundingRectangle;
        public Primitive(Color color, bool filled, Rectangle rectangle)
        {
            this.color = color;
            this.filled = filled;
            BoundingRectangle = rectangle;
        }
    }
    class DrawableRectangle:Primitive, IDrawable, IWritable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle):base(color, filled, rectangle)
        { }
        public void Draw(Graphics g)
        {
            if(filled == true)
            {
                SolidBrush solidColor = new SolidBrush(color);
                g.FillRectangle(solidColor, BoundingRectangle);
            }
            else
            {
                Pen penColor = new Pen(color);
                g.DrawRectangle(penColor, BoundingRectangle);
            }
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine(color);
            writer.WriteLine(filled);
            writer.WriteLine(BoundingRectangle);
        }
    }
    class DrawableEllipse:Primitive, IDrawable
    {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle):base(color, filled, rectangle)
        { }
        public void Draw(Graphics g)
        {
            if(filled == true)
            {
                SolidBrush solidColor = new SolidBrush(color);
                g.FillEllipse(solidColor, BoundingRectangle);
            }
            else
            {
                Pen penColor = new Pen(color);
                g.DrawEllipse(penColor, BoundingRectangle);
            }
        }
    }
    class DrawableLine:IDrawable, IWritable
    {
        protected Color Color;
        protected Point lineStart;
        protected Point lineEnd;
        public DrawableLine(Color color, Point start, Point end)
        {
            Color = color;
            lineStart = start;
            lineEnd = end;
        }
        public void Draw(Graphics g)
        {
            Pen penColor = new Pen(Color);
            g.DrawLine(penColor, lineStart, lineEnd);
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine(Color);
            writer.WriteLine(lineStart);
            writer.WriteLine(lineEnd);
        }
    }
    class DrawableBezier: IDrawable, IWritable
    {
        protected Color color;
        protected Point curveStart;
        protected Point controlFirst;
        protected Point controlSecond;
        protected Point curveEnd;
        public DrawableBezier(Color color, Point start, Point first, Point second, Point end)
        {
            this.color = color;
            curveStart = start;
            controlFirst = first;
            controlSecond = second;
            curveEnd = end;
        }
        public void Draw(Graphics g)
        {
            Pen pencolor = new Pen(color);
            g.DrawBezier(pencolor, curveStart, controlFirst, controlSecond, curveEnd);
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine(color);
            writer.WriteLine(curveStart);
            writer.WriteLine(controlFirst);
            writer.WriteLine(controlSecond);
            writer.WriteLine(curveEnd);
        }
    }
    class DrawableArc:Primitive, IDrawable, IWritable
    {
        protected float Start;
        protected float End;
        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end):base(color, filled, rectangle)
        {
            Start = start;
            End = end;
        }
        public void Draw(Graphics g)
        {
            Pen penColor = new Pen(color);
            g.DrawArc(penColor, BoundingRectangle, Start, End);
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine(color);
            writer.WriteLine(filled);
            writer.WriteLine(BoundingRectangle);
            writer.WriteLine(Start);
            writer.WriteLine(End);
        }
    }
}
