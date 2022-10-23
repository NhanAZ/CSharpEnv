using System;

namespace B4VongLapLongNhau {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1033802511288651869/unknown.png
			Console.WriteLine("Enter n:");
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++) {
				for (int j = 1; j <= n; j++) {
					Console.Write("* ");
				}
				Console.WriteLine("\n");
			}
		}
	}
}
