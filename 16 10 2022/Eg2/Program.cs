using System;

namespace Eg2 {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1031106111580946442/unknown.png
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("+-------------------+---------------------+");
			Console.WriteLine("| Salary            | Increase Percentage |");
			Console.WriteLine("+===================+=====================+");
			Console.WriteLine("| 0       - 400.00  |         15%         |");
			Console.WriteLine("| 400.01  - 800.00  |         12%         |");
			Console.WriteLine("| 800.01  - 1200.00 |         10%         |");
			Console.WriteLine("| 1200.01 - 2000.00 |          7%         |");
			Console.WriteLine("| >2.000            |          4%         |");
			Console.WriteLine("+-------------------+---------------------+");
			Console.WriteLine("Vui lòng nhập mức lương hiện tại của nhân viên:");
			double salary = double.Parse(Console.ReadLine());
			switch (salary) {
				case >= 0 and <= 400.00:
					Console.WriteLine("Lương mới: " + Math.Round(salary * (100 + 15) / 100));
					break;
				case 800.00:
					Console.WriteLine("Lương mới: " + Math.Round(salary * (100 + 12) / 100));
					break;
				case 1200.00:
					Console.WriteLine("Lương mới: " + Math.Round(salary * (100 + 10) / 100));
					break;
				case <= 2000.00:
					Console.WriteLine("Lương mới: " + Math.Round(salary * (100 + 7) / 100));
					break;
				case > 2.000:
					Console.WriteLine("Lương mới: " + Math.Round(salary * (100 + 4) / 100));
					break;
			}
		}
	}
}
