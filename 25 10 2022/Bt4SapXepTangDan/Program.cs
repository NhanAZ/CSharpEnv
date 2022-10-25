using System;

namespace Bt4SapXepTangDan {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Enter a:");
			double a = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter b:");
			double b = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter c:");
			double c = double.Parse(Console.ReadLine());

			double temp;

			if (a > b) {
				temp = a;
				a = b;
				b = temp;
			}

			if (a > c) {
				temp = a;
				a = c;
				c = temp;
			}

			if (b > c) {
				temp = b;
				b = c;
				c = temp;
			}

			Console.WriteLine($"a({a}) < b({b}) < c({c})");
		}
	}
}
