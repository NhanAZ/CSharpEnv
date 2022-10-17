using System;

namespace Eg1SwitchCase {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1031106137665323048/unknown.png
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("+-------+------------------+----------+");
			Console.WriteLine("| Code  | Specification    | Price    |");
			Console.WriteLine("+-------+------------------+----------+");
			Console.WriteLine("| 1     | Cachorro Quente  | R$ 4.00  |");
			Console.WriteLine("| 2     | X-Salada         | R$ 4.50  |");
			Console.WriteLine("| 3     | X-Bacon          | R$ 5.00  |");
			Console.WriteLine("| 4     | Torrada simples  | R$ 2.00  |");
			Console.WriteLine("| 5     | Refrigerante     | R$ 1.50  |");
			Console.WriteLine("+-------+------------------+----------+");
			Console.WriteLine("Vui lòng nhập mã và số lượng của mặt hàng:");
			int code = int.Parse(Console.ReadLine());
			int amount = int.Parse(Console.ReadLine());
			switch (code) {
				case 1:
					Console.WriteLine("Số tiền phải trả là: " + (amount * 4.00));
					break;
				case 2:
					Console.WriteLine("Số tiền phải trả là: " + (amount * 4.50));
					break;
				case 3:
					Console.WriteLine("Số tiền phải trả là: " + (amount * 5.00));
					break;
				case 4:
					Console.WriteLine("Số tiền phải trả là: " + (amount * 3.00));
					break;
				case 5:
					Console.WriteLine("Số tiền phải trả là: " + (amount * 1.50));
					break;
				default:
					Console.WriteLine("Mã hàng không tồn tại!");
					break;
			}
		}
	}
}
