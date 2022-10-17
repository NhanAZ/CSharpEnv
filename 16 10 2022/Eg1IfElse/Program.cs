using System;

namespace CSharpEnv {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1031106046556635176/unknown.png
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Vui lòng nhập giá trị của a, b, c:");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			if (a > b && a > c) {
				Console.WriteLine("a là giá trị lớn nhất trong ba số.");
			} else if (b > a && b > c) {
				Console.WriteLine("b là giá trị lớn nhất trong ba số.");
			} else {
				Console.WriteLine("c là giá trị lớn nhất trong ba số.");
			}
		}
	}
}
