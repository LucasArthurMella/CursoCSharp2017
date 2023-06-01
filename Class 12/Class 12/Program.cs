using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12
{
	class Program
	{
		static void Main(string[] args)
		{
			//-> String Special Characters <-
			//string myString = "My \"so-called\" Life";
			//string myString = "What if i need \na new line?";
			//string myString = "Go to c://drive";
			//string myString = "Go to your c:\ drive";
			//string myString = String.Format("{0} = {1}", "First", "Second");
			//string myString = String.Format("{0:C}",92);
			//string myString = string.Format("{0:N}", 10232);
			//string myString = string.Format("Percentage: {0:P}", .123);
			//string myString = string.Format("Phone Number:{0:(###) ####-####}", 12345678900);
			//string myString = " That summer we took thress across the board ";


			//-> String Modifiers <-
			//myString = myString.Substring(6,14);
			//myString = myString.ToUpper();
			//myString = myString.Replace(" ", "--");
			//myString = myString.Remove(6, 14);
			//myString = String.Format("Length before: {0} -- Length after: {1}",
			//myString.Length, myString.Trim().Length);
			/*string myString = "";
			for (int i = 0; i < 101; i++)
			{
				myString += "--" + i.ToString();


			}*/
			//->String Adding <-
			StringBuilder myString = new StringBuilder();

			for (int i = 0; i < 100; i++)
			{
				myString.Append("--");
				myString.Append(i);
			}

			Console.WriteLine(myString);
			Console.ReadLine();


		}
	}
}
