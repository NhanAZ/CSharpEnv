using System;

namespace B2PtB2 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("ax^2 + bx + c = 0");

			Console.WriteLine("Enter a:");
			double a = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter b:");
			double b = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter c:");
			double c = double.Parse(Console.ReadLine());

			double delta = Math.Pow(b, 2) - 4 * a * c;

			if (delta < 0) {
				Console.WriteLine("Equation with no solution");
			} else if (delta == 0) {
				Console.WriteLine("Equation with double solution");
				Console.WriteLine("x1 = x2 = " + (-b / 2 * a));
			} else if (delta > 0) {
				Console.WriteLine("Equation has two distinct solutions");
				double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
				double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
				Console.Write("x1 = " + x1 + " and x2 = " + x2);
			}
		}
	}
}
