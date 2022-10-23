using System;

namespace B4While {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Vui lòng nhập n:");

			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];

			int i = 0;
			int sum = 0;
			while (i < n) {
				Console.WriteLine($"Vui lòng nhập a[{i + 1}]");
				a[i] = int.Parse(Console.ReadLine());
				sum = sum + a[i];
				i++;
			}

			Console.WriteLine("Sum: " + sum);
		}
	}
}
