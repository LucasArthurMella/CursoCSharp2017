using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6
{
	class Program
	{
		static void Main(string[] args)
		{/*
			string message = "";

			Console.WriteLine("Placer big giveaway");
			Console.WriteLine("Choose a door 1, 2 or 3: ");
			string userValue = Console.ReadLine();

			//Checks which number the user typed.
			if (userValue == "1")
				message = "You won a new car!";
			else if (userValue == "2")
			{
				message = "You won a new cup!";
			}
			else if (userValue == "3")
			{
				message = "You won a new game!";
				//

				//Makes the user get warned if he typed a wrong or invalid value.
			}
			else {
				message = "You didn't type a correct value. ";
				message += "You lose";}
			Console.WriteLine(message);
			Console.ReadLine();
			*/
			Console.WriteLine("Placer big giveaway");
			Console.WriteLine("Choose a door 1, 2 or 3: ");
			string userValue = Console.ReadLine();

			string message = (userValue == "1") ? "boat" : "strand of lint";
			/*Console.Write("You won a ");
			Console.Write(message);
			Console.Write(".");*/

			Console.WriteLine("You entered: {0} You won a {1}.",userValue, message);

			Console.ReadLine();
		}
	}
}
