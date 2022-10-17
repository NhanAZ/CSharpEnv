using System;

namespace Ex3 {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1031265366871134260/unknown.png
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Vui lòng nhập 2 số nguyên a và b:");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine($"{a} + {b} = " + (a + b));
			Console.WriteLine($"{a} - {b} = " + (a - b));
			Console.WriteLine($"{a} * {b} = " + (a * b));
			Console.WriteLine($"{a} / {b} = " + (a / b));
			Console.WriteLine($"{a} % {b} = " + (a % b));
		}
	}
}
