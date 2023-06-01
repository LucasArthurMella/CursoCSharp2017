using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9
{
	class Program
	{
		static void Main(string[] args)
		{
			//In this case, i'm using an array that has the length size already set in his assignment.
			/*
			int[] numbers = new int[5];

			numbers[0] = 4;
			numbers[1] = 8;
			numbers[2] = 15;
			numbers[3] = 16;
			numbers[4] = 23;
			
			Console.WriteLine(numbers[4]);
			Console.WriteLine(numbers.Length);
			Console.ReadLine();
			*/
			//

			//In this case i'm not setting the length, but i'm setting already the values in the assigment, which can determinate the length.
			/*
			int[] numbers = new int[] { 12, 13 };
			numbers[0] = 2;
			Console.WriteLine(numbers[1]);
			Console.ReadLine();
			//
			*/

			//Using For to loop
			string[] games = new string[] {"L4D2", "Minecraft", "CSGO", "Terraria"};

			for (int i = 0; i < games.Length; i++)
			{
			Console.WriteLine(games[i]);}
			//

			Console.WriteLine("========");

			//Using ForEach to loop
			foreach (string name in games)
			{
			Console.WriteLine(name);
			}
			//

			Console.WriteLine("========");

			string zip = "You can own mate whaterver you wish to own if you twat other people's dank";
			char[] charArray = zip.ToCharArray();
			Array.Reverse(charArray);
			foreach (char charct in charArray)
			{
				Console.Write(charct);
			}
			Console.ReadLine();
		}
	}
}
