using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declaring a new car in memory, then create an instance of a car and put in memory.
			Car myCar = new Car();
			//Setting the value of the different properties of the Class Car in the myCar var.
			myCar.Make = "Oldsmobile";
			myCar.Model = "Cutlas Supreme";
			myCar.Year = 1989;
			myCar.Color = "Silver";

			//Prints out the variable myCar with the different properties of the class Car.
			Console.WriteLine("{0}, {1}, {2}, {3}",
			myCar.Make,
			myCar.Model,
			myCar.Year,
			myCar.Color);

			//decimal value = DetermineMarketValue(myCar);
			//Console.WriteLine("{0:C}",value);


			//Writes the value of the method that had its value returned according
			//of what the conditions said to.
			Console.WriteLine("{0:C}",myCar.DetermineMarketValue());
			Console.ReadLine();
		}



	}
	class Car {
		//Set different properties of the class car, that will be later have
		//each value set.
		public string Make {get;set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }


		//Checks if the Year of the car is bigger than 1990, depending on the result the car 
		//value will be different, after the result the carValue is returned to the method.
		public decimal DetermineMarketValue() {
			decimal carValue;
			if (Year > 1990)
				carValue = 10000;
			else
				carValue = 2000;
			return carValue;
		}
	}




}
