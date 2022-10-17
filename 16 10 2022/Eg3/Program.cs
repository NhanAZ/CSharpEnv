using System;

namespace Eg3 {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1031252593760026685/unknown.png
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Vui lòng nhập tọa độ x và y của điểm trong mặt phẳng:");
			double x = double.Parse(Console.ReadLine());
			double y = double.Parse(Console.ReadLine());
			if (x > 0 && y > 0) {
				Console.WriteLine($"x = {x}, y = {y} => Điểm thuộc Q1");
				return;
			}
			if (x < 0 && y > 0) {
				Console.WriteLine($"x = {x}, y = {y} => Điểm thuộc Q2");
				return;
			}
			if (x < 0 && y < 0) {
				Console.WriteLine($"x = {x}, y = {y} => Điểm thuộc Q3");
				return;
			}
			if (x > 0 && y < 0) {
				Console.WriteLine($"x = {x}, y = {y} => Điểm thuộc Q3");
				return;
			}
			if (x == 0 && y == 0) {
				Console.WriteLine($"x = {x}, y = {y} => Điểm nằm ở gốc tọa độ");
				return;
			}
		}
	}
}
