using System;
using System.IO;
using System.Net;

namespace Class_17
{
	class Program
	{
		static void Main(string[] args)
		{


			WebClient client = new WebClient();
			string reply = client.DownloadString("http://msdn.microsoft.com");

			Console.WriteLine(reply);
			File.WriteAllText(@"P:\", reply);
			Console.ReadLine();

		}
	}
}
