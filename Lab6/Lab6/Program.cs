using System;
using System.Security.Cryptography.X509Certificates;

namespace Lab6
{
    delegate string StringJob(string p1, int p2);
    
    internal class Program
    {
        static void TestFunction(string desription, string p1, int p2, StringJob func)
        {
            Console.Write(desription + ": ");
            Console.WriteLine(func(p1, p2));
        }
        
        static void TestFunction1(string desription, string p1, int p2, Func<string, int, string> func)
        {
            Console.Write(desription + ": ");
            Console.WriteLine(func(p1, p2));
        }

        static string StringJobFunc(string p1, int p2)
        {
            string tmp = "";
            for (int i = 0; i < p2; ++i)
            {
                tmp += p1;
            }

            return tmp;
        }
        
        public static void Main(string[] args)
        {
            string p1 = "Привет";
            int p2 = 3;
            
            Console.WriteLine("Делегат StringJob:");

            TestFunction("Передача функции", p1, p2, StringJobFunc);
            TestFunction("Передача лямбда-выражения", p1, p2, (x,y) => x + y.ToString());
            
            Console.WriteLine("\nОбобщенный делегат:");

            TestFunction1("Передача функции", p1, p2, StringJobFunc);
            TestFunction1("Передача лямбда-выражения", p1, p2, (x,y) => x + y.ToString());
        }
    }
}