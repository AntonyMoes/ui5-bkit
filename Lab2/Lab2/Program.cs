namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 4);
            Square square = new Square(5);
            Circle circle = new Circle(5);
            
            rect.Print();
            square.Print();
            circle.Print();
        }
    }
}