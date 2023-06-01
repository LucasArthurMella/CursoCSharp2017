using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_15
{
	class Program
	{
		static void Main(string[] args)
		{
			//Referencing to an instance of Car, that in memory has some values. Inside the parenthesis () i could leave
			//it empty, too refer to the first class method, or i could store the second class method values in it.
			Car myCar = new Car();

			//Calling a Static Method, so no need to instantiate.
			Console.WriteLine(myCar.Make);
			//Car.MyMethod();
			
			/*
			//Setting the values of the instance of the Class "Car"
			myCar.Make = "Oldmobile";
			myCar.Model = "Cutlas Supreme";
			myCar.Year = 1986;
			myCar.Color = "Silver";
			//	

			// Making the values to the operand of the instance myOtherCar equal to the of myCar in its assignment.
			Car myOtherCar = myCar;
			Console.WriteLine("{0} {1} {2} {3}",
				myOtherCar.Make,
				myOtherCar.Model,
				myOtherCar.Year, 
				myOtherCar.Color);
			//

			//Just changing the Model value.
				myOtherCar.Model = "98";
				Console.WriteLine("{0} {1} {2} {3}",
				myCar.Make,
				myCar.Model,
				myCar.Year,
				myCar.Color);
			//
			myOtherCar = null;


			//As the myOtherCar = null there will be an error saying that myOtherCar has no value in its instance.
			Console.WriteLine("{0} {1} {2} {3}",
				myOtherCar.Make,
				myOtherCar.Model,
				myOtherCar.Year,myOtherCar.Color);
			//
			*/
			Console.ReadLine();
		}

	}

	//Creating a class and setting its properties.
	class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }

		// Here you're setting the value of a property of the class.
			public Car(){
				Make = "Nissan";
		}

		//Here you are actually creating a method with vars inside parenthesis that 
		//will have its values set in their calls.
		/*
		public Car(string make, string model, int year, string color) {
			Make = make;
			Model = model;
			Year = year;
			Color = color;
		//
		}*/

			//Here it's just testing the instance members and the static member.
		public static void MyMethod() {
			Car car = new Car();
			Console.WriteLine("Called the static MyMethod");
			Console.WriteLine(car.Make);

		}

	}

}
