using System;

namespace Lab2
{
    public class Square : Rectangle, IPrint
    {
        public Square(double side) : base(side, side)
        {
            Type = "Квадрат";
        }
    }
}