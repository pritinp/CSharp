using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string myValue = superSecretFormula("world");
        //    Console.WriteLine(myValue);
        //    Console.ReadLine();
        //}

        //private static string superSecretFormula()
        //{
        //    // some cool stuff here
        //    return "Hello World!";
        //}

        //private static string superSecretFormula(string name)
        //{
        //    return String.Format("Hello, {0}!", name);
        //}


// this version of the code passes an integer, and c#/VS automaticaly knows to pass this to the 'integer' method - an Overloaded method!
        static void Main(string[] args)
        {
            string myValue = superSecretFormula(123);
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        // Overloaded Method 1
        private static string superSecretFormula(int aNumber)
        {
            // some cool stuff here
            return String.Format("Hello World!, {0}", aNumber);
        }

        // Overloaded Method 2
        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}!", name);
        }

        private static void superSecretFormula2()
        {

        }
    }
}
