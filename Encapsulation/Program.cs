using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point();
			//Console.WriteLine($"X = {A.GetX()}\tY = {A.GetY()}");
			//A.SetX(2000);
			//A.SetY(3000);

			Console.Write("Введите координату X первой точки: ");
			A.X = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите координату Y первой точки: ");
			A.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            A.Print();
            Console.WriteLine("Дистанция до точки A: " + A.Distance());
            Console.WriteLine();

			Point B = new Point();
            Console.Write("Введите координату X второй точки: ");
			B.X = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите координату Y второй точки: ");
			B.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            B.Print();
            Console.WriteLine("Дистанция до точки B: " + B.Distance());
            Console.WriteLine();

			Console.WriteLine("Дистанция от точки A до точки B: " + Distance(A.Distance(), B.Distance()));
        }

		static double Distance(double a, double b)
		{
			if (a > b) return a - b;
			else return b - a;
		}
	}
}
