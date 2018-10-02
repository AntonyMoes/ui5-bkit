using System;

namespace Lab_1 {
    class MainClass {
		public static void Main(string[] args) {
			const int Size = 3;
			double[] arr = new double[Size];
			char[] names = new char[Size] { 'A', 'B', 'C' };

			for (int i = 0; i < Size; ++i) {
				arr[i] = ReadDouble("Введите коэффициент " + names[i]);
			}

			double discriminant = arr[1] * arr[1] - 4 * arr[0] * arr[2];
			if (arr[0] == 0)
			{
				Console.WriteLine("Корень уравнения : {0}.", -arr[2] / arr[1]);
			}
			else if (discriminant < 0) {
				Console.WriteLine("Действительных корней нет.");
			} else if (discriminant == 0) {
				Console.WriteLine("Корни уравнения равны между собой и равны {0}.", -arr[1] / (2 * arr[0]));
			} else {
				Console.WriteLine("Корни уравнения: {0} и {1}.", (-arr[1] + Math.Sqrt(discriminant)) / (2 * arr[0]), (-arr[1] - Math.Sqrt(discriminant)) / (2 * arr[0]));
			}
        }

		private static double ReadDouble(string message) {
			double d = 0;
			Console.WriteLine(message);

			while (double.TryParse(Console.ReadLine(), out d) is false) {
				Console.WriteLine("Ввод некорректен. Повторите попытку.");
			}

			return d;
		}
    }
}
