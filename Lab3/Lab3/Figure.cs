using System;

namespace Lab2
{
    public abstract class Figure : IComparable
    {
        public string Type { get; protected set; }

        public abstract double Area();

        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }

        public int CompareTo(object obj)
        {
            Figure p = (Figure) obj;

            if (this.Area() < p.Area())
                return -1;
            else if (this.Area() == p.Area())
                return 0;
            else
                return 1;
        }
    }
}