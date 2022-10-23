using System;

namespace B4ForInSoChan {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1033802356552388648/unknown.png
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập n:");
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++) {
				if (i % 2 == 0) {
					Console.Write(i + " ");
				}
			}
		}
	}
}
