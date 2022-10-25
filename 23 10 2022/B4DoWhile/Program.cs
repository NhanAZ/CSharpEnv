using System;

namespace B4DoWhile {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Enter n:");
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			int i = 0;
			while (sum + i < n) {
				sum += i;
				i++;
			}
			Console.WriteLine("Sum: " + sum);
		}

	}
}
