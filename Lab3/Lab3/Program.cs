using System;
using System.Collections;
using System.Collections.Generic;
using Lab2;

namespace Lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 4);
            Square square = new Square(5);
            Circle circle = new Circle(5);
            
            Console.WriteLine("ArrayList");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(circle);
            arrayList.Add(rect);
            arrayList.Add(square);
            
            foreach (var fig in arrayList)
            {
                Console.WriteLine(fig.ToString());
            }
            
            arrayList.Sort();
            
            Console.WriteLine("\nArrrayList после сортировки");
            
            foreach (var fig in arrayList)
            {
                Console.WriteLine(fig.ToString());
            }

            Console.WriteLine("\nList");
            List<Figure> list= new List<Figure>();
            list.Add(circle);
            list.Add(rect);
            list.Add(square);
            
            foreach (var fig in list)
            {
                Console.WriteLine(fig.ToString());
            }
            
            list.Sort();
            
            Console.WriteLine("\nList после сортировки");
            
            foreach (var fig in list)
            {
                Console.WriteLine(fig.ToString());
            }
            
            Console.WriteLine("\nМатрица");
            Matrix3D<Figure> cube = new Matrix3D<Figure>(3, 3, 3, new FigureMatrixCheckEmpty());
            cube[0, 0, 0] = rect;
            cube[1, 1, 1] = square;
            cube[2, 2, 2] = circle;
            Console.WriteLine(cube.ToString());
            Console.WriteLine("\nСписок");
            
            SimpleList<Figure> simpleList = new SimpleList<Figure>();
            simpleList.Add(square);
            simpleList.Add(rect);
            simpleList.Add(circle);
            foreach (var x in simpleList) Console.WriteLine(x);
            simpleList.Sort();
            Console.WriteLine("\nСортировка списка");
            foreach (var x in simpleList) Console.WriteLine(x);
            
            
            Console.WriteLine("\nСтек");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }
            
        }
    }
}