using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Program {
		static void Main(string[] args) {
			string YourName;
			//Console.BackgroundColor=ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Hello, world!");

			Console.WriteLine("What is your name?");

			YourName = Console.ReadLine();

			Console.WriteLine("Hello {0}", YourName);
		}
	}
}
