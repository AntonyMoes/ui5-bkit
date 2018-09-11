using System;

namespace Lab2
{
    public class Rectangle : Figure, IPrint
    {
        public Rectangle(double height, double width)
        {
            Type = "Прямугольник";
            Height = height;
            Width = width;
        }

        public double Height { get; protected set; }
        public double Width { get; protected set; }
            
        public override double Area()
        {
            return Height * Width;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}