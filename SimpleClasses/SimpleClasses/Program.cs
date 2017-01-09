using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initialize an object called Car, and assign this to a variable called 'myNewCar'
            Car myNewCar = new Car();

            // then set the properties of the 'Car' object
            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            Console.WriteLine("{0} - {1} - {2}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Color);

            //double marketValueOfCar = determineMarketValue(myNewCar);

            // this line of code first calls the 'DetermineMarketValue' method that is defined in the 'Car' class...
            // and uses the 'this.Year' to pass in the year of the car (as defined in this instance of the car class)...
            // and then determines the correct market value according to the resutls of the If-Else statement.
            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());

            Console.ReadLine();
        }

        private static double determineMarketValue(Car car)
        {
            double carValue = 100.0;

            // Someday while come to go online and look up the car's value
            // and retrieve its value into the carValue variable
            return carValue;
        }
    }

    class Car
    {
        //define properties of car in the class
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //include a method in the car class
        public double DetermineMarketValue()
        {
            // double represents a 'double-precision' floating number
            double carValue = 100.0;

            if (this.Year > 1990)
                carValue = 1000.0;
            else
                carValue = 2000.0;

            
            // return the car's value
            return carValue;
        }

    }

}
