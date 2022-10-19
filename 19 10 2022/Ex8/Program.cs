using System;

namespace Ex8 {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1032316154779287634/unknown.png
			Console.WriteLine("Enter amount of money:");
			int amount = int.Parse(Console.ReadLine());

			int type100 = amount / 100;
			amount = amount - type100 * 100;
			Console.WriteLine("100: " + type100);

			int type50 = amount / 50;
			amount = amount - type50 * 50;
			Console.WriteLine("50: " + type50);

			int type20 = amount / 20;
			amount = amount - type20 * 20;
			Console.WriteLine("20: " + type20);

			int type10 = amount / 10;
			amount = amount - type10 * 10;
			Console.WriteLine("10: " + type10);

			int type5 = amount / 5;
			amount = amount - type5 * 5;
			Console.WriteLine("5: " + type5);

			int type2 = amount / 2;
			amount = amount - type2 * 2;
			Console.WriteLine("2: " + type2);

			int type1 = amount / 1;
			amount = amount - type1 * 1;
			Console.WriteLine("1: " + type1);
		}
	}
}
