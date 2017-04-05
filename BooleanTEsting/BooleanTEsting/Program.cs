using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanTEsting
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;

            if (a && b)
            {
                Console.WriteLine("Line 1 - Condition is true");
            }
            else
            {
                Console.WriteLine("Line 1 - Condition is false");
            }

            if (b && a)
            {
                Console.WriteLine("Line 2 - Condition is true");
            }
            else
            {
                Console.WriteLine("Line 2 - Condition is false");
            }

            //change the vlaue of b to false
            bool c = true;
            bool d = false;

            if (c && d)
            {
                Console.WriteLine("Line 3 - Condition is true");
            }
            else
            {
                Console.WriteLine("Line 3 - Condition is false");
            }

            if (d && c)
            {
                Console.WriteLine("Line 4 - Condition is true");
            }
            else
            {
                Console.WriteLine("Line 4 - Condition is false. The && operator only evaluates the first condition because it's false. The & operator would evluate both conditons");
            }

            Console.ReadLine();
        }
    }
}
