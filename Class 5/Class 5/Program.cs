using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_5
{
	class Program
	{
		static void Main(string[] args)
		{

			//int x;
			//int y;

			// Assigns a value to the variable x, and retrieve the valuable x, adding it 3 and assigning it in the variable y.
			/*
			x = 7;
			y = x + 3;
			*/
			//
			//Retrieves the value of y and writes it into the console.
			/*
			Console.WriteLine(y);
			Console.ReadLine();
			*/
			Console.WriteLine("What's your name?");

			Console.WriteLine("Type your first name: ");
			string MyFirstName = Console.ReadLine();
			Console.WriteLine("======================");

			Console.WriteLine("Type your last name");
			string myLastName = Console.ReadLine();
			Console.WriteLine("======================");

			Console.WriteLine("Hello " + MyFirstName +" "+ myLastName);
			Console.ReadLine();

		}
	}
}
