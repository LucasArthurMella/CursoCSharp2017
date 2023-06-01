using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
	public class Scrape
	{
		//Returns the value of the function Webpage, and defines its variable value, which is the value of url var.
		public string ScrapeWebpage(string url)
		{
			return GetWebpage(url);
		}

		public string ScrapeWebpage(string url, string filepath)
		{
			string reply = GetWebpage(url); 


			File.WriteAllText(filepath, reply);
			return reply;
		}

		//Creates new instance of Webclient, creates variable "content" which donwload string of a website which is 
		//defined according to url var value, add a little phrase and return the value of content to the function.
		private string GetWebpage(string url)
		{
			WebClient client = new WebClient();
			string content = client.DownloadString(url);
			content += "THAT'S ALL FOLKS!!!!";
			return content;
		}
	}
}
