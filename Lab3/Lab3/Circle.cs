using System;

namespace Lab2
{
    public class Circle : Figure, IPrint
    {
        public Circle(double radius)
        {
            Type = "Круг";
            Radius = radius;
        }
        
        public double Radius { get; private set; }
        
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}