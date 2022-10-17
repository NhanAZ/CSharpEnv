using System;

namespace Ex5 {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1031265387435790357/unknown.png
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Vui lòng nhập bán kính của hình tròn r:");
			double r = double.Parse(Console.ReadLine());
			Console.WriteLine("P = " + Math.Round((2 * Math.PI * r), 2));
			Console.WriteLine("A = " + Math.Round((Math.PI * Math.Pow(r, 2)), 2));
		}
	}
}
