using System;

namespace B4ForInSoChan {
	class Program {
		static void Main(string[] args) {
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
