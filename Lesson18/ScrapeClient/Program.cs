using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string websiteUrl = "https://msdn.microsoft.com";
            string filepath = @"D:\ITStudying\BobTaborCourse\Lesson17\WriteText2.txt";

            Scrape myScrape = new Scrape();
            string urlValue = myScrape.ScrapeWebPage(websiteUrl, filepath);
            Console.WriteLine(urlValue);
            Console.ReadLine();
        }
    }
}
