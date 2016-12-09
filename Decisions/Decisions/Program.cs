using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the Enter Key.");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();

            //string message = "";

            //if(userValue == "1")
            //    message = "You won a new car!";
            //else if (userValue == "2")
            //    message = "You won a new boat!";
            //else if (userValue == "3")
            //    message = "You won a new cat!";
            //else
            //    message = "Sorry, we didn't understand. You lose!";

            //Console.WriteLine(message);
            //Console.ReadLine();

            string message1 = (userValue == "1") ? "boat" : "lint";
            //string message2 = (userValue == "2") ? "cat" : "a bit of fluff";
            Console.WriteLine("You won a {0}", message1);



            //string name1 = "Pritin";
            //string name2 = "Sean";
            //int age = 46;
            //string sFinal = string.Format("{0} is {2} yrs old. {1} is old.", name1, name2, age);
            //Console.WriteLine(sFinal);



            Console.ReadLine();

         }
    }
}
