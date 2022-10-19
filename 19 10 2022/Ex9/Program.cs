using System;

namespace Ex9 {
	class Program {
		static void Main(string[] args) {
			// https://cdn.discordapp.com/attachments/1007656285853990912/1032323137855033456/unknown.png
			Console.WriteLine("Input time (s):");
			int seconds = int.Parse(Console.ReadLine());

			int hours = seconds / (60 * 60);
			seconds = seconds % (60 * 60);

			int minutes = seconds / 60;
			seconds = seconds % 60;

			Console.WriteLine(hours + " : " + minutes + " : " + seconds);
		}
	}
}
