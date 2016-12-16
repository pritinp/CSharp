using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Go to your c:\\ drive";
            //string myString = "My \"so called\" life";
            //string myString = "What if I need \n a new line";

            //string myString = string.Format("{0}!", "Bonzai");
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");

            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:N}", 123456789);
            //string myString = string.Format("{0:P}", .70);
            string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
