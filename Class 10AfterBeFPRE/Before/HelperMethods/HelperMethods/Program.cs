using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("The Name Game");

			Console.Write("What's your first name? ");
			string firstName = Console.ReadLine();

			Console.Write("What's your last name? ");
			string lastName = Console.ReadLine();

			Console.Write("In what city were you born? ");
			string city = Console.ReadLine();

			//Does what is written in WriteMessage function, taking 3 calls of ReverseString (3 times the same 
			//method) which is a string method, so it can be used inside parenthesis, and taking in the three three different
			//variables that had each value asked in the beggining, then it prints each variable reversed.
			WriteMessage(
			ReverseString(firstName), //Takes as argument the method reverse string that takes as input parameter the variable firstName 
			ReverseString(firstName), 
			ReverseString(city)
			);

			WriteMessage(
			ReverseString(firstName) +" ",
			ReverseString(firstName) +" ",
			ReverseString(city) + " "
			);

			Console.ReadLine();
		}
		//Reverses an array of chars and returns it into the method.
		private static string ReverseString(string message){
			char[] messageArray = message.ToCharArray();
			Array.Reverse(messageArray);
			return String.Concat(messageArray);
			}
		//Takes as arguments 3 different strings, that will have their values dependend on what is going to be put in the call
		//and them is going to be print these 3 string according to what was put in their values.
		private static void WriteMessage(
			string Reversed1stName,
			string ReversedLastName,
			string ReversedCity)
		{
			Console.Write("Results: ");
			Console.WriteLine(String.Format("{0} {1} {2}",
				Reversed1stName,
				ReversedLastName,
				ReversedCity));
		}
    }
}
