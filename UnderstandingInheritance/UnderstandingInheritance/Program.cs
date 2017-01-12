using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            // calls method 'printCarDetails'
            printCarDetails(myCar);

            Console.ReadLine();
        }

        /*
         -this method doesn't return anything as it's set to 'void'
         -why are the parameters 'Car car' passed in here? The small case 'car' is the input parameter, and the large case 'Car' is the datatype.Google Passing datatypes into methods.
         -Therefore, I think it's essentialy doing the same as the following...
              private static void printCarDetails(string inputParameter) // where 'string' is the 'data type'
         - When passing objects into methods as parameters you need to state it's 'data type' first....
            private static void printCarDetails(<datatype variable_name)    
            eg.
            private static void printCarDetails(Car _car)
         -reference from video: Video 15 @ 18m 43sec - input parameter names
         */
        private static void printCarDetails(Car _car)
        {
            Console.WriteLine("Here are the Car's details: {0}",
                _car.FormatMe());
        }

        // the variable in the helper method above could also be prefixed with a underscore to make it clearer it is an Input Parameter
        /*
        private static void printCarDetails(Car _car)
        {
            Console.WriteLine("Here are the Car's details: {0}",
                _car.FormatMe());
        }
        */
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public virtual string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
    }

    //class Truck : Car
    //{
    //    public int TowingCapacity { get; set; }

    //    public string FormatMe()
    //    {
    //        return String.Format("{0} - {1} - {2} Towing Units",
    //            this.Make,
    //            this.Model,
    //            this.TowingCapacity);
    //    }

    //}
}
