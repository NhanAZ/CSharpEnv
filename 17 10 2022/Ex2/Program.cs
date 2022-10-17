using System;

namespace Ex2 {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1031265366871134260/unknown.png
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Vui lòng nhập chuỗi số nguyên:");
			string stringNumber = Console.ReadLine();
			int intNumber = int.Parse(stringNumber);
			Console.WriteLine("\"stringNumber\" value & type: " + stringNumber + ", " + stringNumber.GetType());
			Console.WriteLine("\"intNumber\" value & type: " + intNumber + ", " + intNumber.GetType());
		}
	}
}
