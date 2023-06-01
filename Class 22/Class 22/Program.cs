using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Class_22
{
	class Program
	{
		static void Main(string[] args)
		{
			//-;Sees if the code in the brackets is executable without having any exceptions, if it is, it will execute it
			//if it's not, it will go to the catches and do whatever the catches say it should be done, in case of some catch has 
			//an specific exception as argument, and the exception that happened in the try{} is the same one of this catch{} argument exception
			//it will execute this catch in specific.
			try
			{
				string content = File.ReadAllText(@"P:\example\Example.txt");
				Console.WriteLine(content);
				Console.ReadLine();
			}
			//;-

			//-;The catches are the codes that will be excecuted in case there is some exception in the try{} statement, it can
			//have an specific argument to get executed in case of an specific exception
			catch (FileNotFoundException ex)
			{
				Console.WriteLine("There was a problem!");
				Console.WriteLine("Make sure the name of the file is named correctly: Exampl.txt");
			}
			catch (DirectoryNotFoundException ex)
			{
				Console.WriteLine("There was a problem!");
				Console.WriteLine(@"Make sure the name of the directory P:\example' exists.");
			}
			catch (Exception ex)
			{
				Console.WriteLine("There was a problem!");
				Console.WriteLine(ex.Message);

			}
			//;-
			//-;Is the code that executes independently of anything
			finally
			{
				// Code to finalize 
				// Setting objects to null
				// Closing database connections
				Console.WriteLine("Closing Application now ...");

			}
			//;-
			Console.ReadLine();

		}
	}
}
