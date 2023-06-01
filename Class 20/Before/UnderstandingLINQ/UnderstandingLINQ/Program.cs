using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
			//Just Making generic list.
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

			//-LINQ query
			//-The LINQ Query is a type of LINQ where you just write the LINQ
			//-Normally with lines without no parenthesis or methods.

			/*var bmws = from car in myCars
					   where car.Make == "BMW"
					   && car.Year == 2010
					   select car;

			//-In this case the returned values would be returned
			//-By descending order due to the OrderByDescending command.

			var orderedCars = from car in myCars
							  orderby car.Year.OrderByDescending
							  select car;
					*/

			//-The LINQ method is just like the other one but it's declared of
			//-a different way, it just make all the conditions and lambda expressions
			//-inside of the methods ()
			//-LINQ method

			/*var bmws = myCars.Where(p => p.Make == "BMW" && p.Year==2008);

			//-Making the same thing of descending more above but with LINQ Method.

			var orderedCars = myCars.OrderByDescending(p => p.Year);
			*/



			//-It gets all the elements in the orderedCars collection and
			//-write the choosen one in the Console.WriteLine

			/*foreach (var car in orderedCars)
			{
				Console.WriteLine("{0} {1}",car.Year, car.Model, car.VIN);
			}
			*/

			//-It gets by orderdescending everything in his right, after it, it returns all the
			//-year in myCars, and return the instances that has the Make = "BMW"

			/*var FirstBmws = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
			Console.WriteLine(FirstBmws.Make+FirstBmws.Year);*/

			//-It checks if a certain condition for all the instances is true or false, if it's
			//-false, it says False, if true, Says True

			//Console.WriteLine(myCars.TrueForAll(p => p.Year != 2010));

			//-It diminishes all the StickerPrices of all the instances in myCarList, and after it
			//-Prints the VIN Followed by it's respective StickerPrice

			//myCars.ForEach(p => p.StickerPrice -= 3000);
			//myCars.ForEach(P => Console.WriteLine("{0} {1:C}", P.VIN, P.StickerPrice));

			//-See if an certain value exists in an certain instance of a list.

			//Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

			//-Sums all the StickerPrice values of all the instances.

			//Console.WriteLine(myCars.Sum(p => p.StickerPrice));

			//-It gets the type of myCars list, and after it it declares var
			//-orderedCars and check what type it's.
			Console.WriteLine(myCars.GetType());
			var orderedCars = myCars.OrderByDescending(p => p.Year);
			Console.WriteLine(orderedCars.GetType());

			//-It declarates a normal Method LINQ and check his type.
			var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2008);
			Console.WriteLine(bmws.GetType());

			//-It declarates a Query LINQ, which  return only certain types of values
			//-with the operators select new, and after theses operator select the values
			//-that will be returned, and after it, it checks its type.
			var newCars = from car in myCars
					   where car.Make == "BMW"
					   && car.Year == 2010
					   select new { car.Make, car.Model};
			Console.WriteLine(newCars.GetType());

			Console.ReadLine();
		}
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
