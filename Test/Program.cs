using System;
namespace Test {
	class Program {
		static void Main(string[] args) {
			Console.Write("Nhap vao mot so : ");
			int number = int.Parse(Console.ReadLine());
			int initialNumber = number;
			int reminder, reverse = 0;
			while (number > 0) {
				reminder = number % 10;
				Console.WriteLine("reminder : " + reminder);

				reverse = (reverse * 10) + reminder;
				Console.WriteLine("reverse : " + reverse);

				number = number / 10;
				Console.WriteLine("number : " + number + "\n");

			}
			Console.WriteLine($"So dao nguoc cua {initialNumber} la : {reverse}");
			Console.ReadKey();

		}
	}
}