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
            printVehicleDetails(myCar);


            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;
            // Notice that we can still pass in the Truck to the print helper method even though the datatype in the method is defined
            //          as car, because the Truck class inherits from the Car class.
            printVehicleDetails(myTruck);

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
        // the myCar object is passed into this 'helper' method as a parameter (you need t pass it in as '<datatype> <variable>' 
        //      where the variable holds the myCar object
        // the helper method utiliss the built in method of the car class called 'FormatMe'
        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the vehicle's details: {0}",
                vehicle.FormatMe());
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


    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // this line states that every class that is derived from this abstract base class must have 
        //     an implementation of the FormatMe() method (but that implementation is not defined here).
        public abstract string FormatMe();
    }

    class Car : Vehicle
    {
        // virtual means that child classes can override this method with their own implementation
        // later in this tutorial this is changed to 'override' since the car class is now inheriting from the Vehicle class
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
    }

    // this line says that the truck class is going to inherit from the car class
    sealed class Truck : Vehicle
    {
        //we set some properties that are specfic to just the truck class
        public int TowingCapacity { get; set; }

        // override means that this method will override the method in the parent class with the same name
        // The printCarDetails helper method will automatically use the Truck classes implementation of this method 
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing Units",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }

    }
}
