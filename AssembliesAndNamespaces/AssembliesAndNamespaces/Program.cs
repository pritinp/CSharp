using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"D:\ITStudying\BobTaborCourse\Lesson17\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
