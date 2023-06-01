using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11
{
	class Program
	{
		static void Main(string[] args)
		{
			bool displayMenu = true;
			while (displayMenu)
			{
		//Collects the value that is returned to the MainMenu Method and puts it into the bool varDisplay, making the condition change
		//it's values according to its necessity.
				displayMenu = MainMenu();
			}
		}
		//the return lines are to see if the loop is still going to run or if the code will stop, if it returns true, the loop still runs, if
		//returns false, the loop breaks in and goes to the next line of code.
		//Important to remember you need to define to a method a type of value according to what you're gonna return, so if you return a bool value, 
		//define it a bool type.
		private static bool MainMenu()
		{
			Console.Clear();
			Console.WriteLine("Choose an option:");
			Console.WriteLine("1) Print Numbers");
			Console.WriteLine("2) Guessing Game");
			Console.WriteLine("3) Exit");
				string result = Console.ReadLine();
				if (result == "1"){
					PrintNumbers();
				return true;
				}
				else if (result == "2"){
					GuessingGame();
				return true;
				}
				else if (result == "3"){
				return false;	
				}
				else{
				return true;
				}
		}
		//Reads what the user typed, transforms it into a int and counts 1 to this number.
		//and prints it to the screen
			private static void PrintNumbers() {
				Console.Clear();
				Console.WriteLine("Print Numbers!");
				Console.WriteLine("Type a number: ");
					int result = int.Parse(Console.ReadLine());
					int counter = 1;
					while (counter <= result) {
						Console.Write(counter);
						Console.Write("-");
							counter++;	}
						Console.ReadLine(); }

		//Creates a random number between 1 and 11, creates a var to count your guesses and creates
		//a bool to see when the nextcoming loop should stop
		private static void GuessingGame() {
			Console.Clear();
			Console.WriteLine("Guessing game!");
			Random myRandom = new Random();
				int randomNumber = myRandom.Next(1, 11);
				int guesses = 0;
				bool incorrect = true;


		//Reads the guess the user typed, increase the number of guesses each time the user types
		//one more guess, checks if the guess is the random set number, if it's, break the loop and says
		//you win, and say how many guesses you did, if it isn't it says it's wrong and keep looking 
		//until you type the right random set number, while it increases the number of guesses
				do{
					Console.WriteLine("Guess a number between 1 and 10: ");
				string result = Console.ReadLine();
					guesses++;
				if (result == randomNumber.ToString()){
					incorrect = false;
				}
				else{
					Console.WriteLine("Wrong!");
					}	}
				while (incorrect);
					Console.WriteLine("Correct!");
					Console.WriteLine("Guesses: {0}", guesses);
					Console.ReadLine();	}
		
	}
}
