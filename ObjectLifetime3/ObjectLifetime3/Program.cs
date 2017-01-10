using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            // Create a another refernce to the same object above 
            Car myOtherCar = myCar;

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White"); 

            myOtherCar = null;
            myCar = null;

            
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Theis class contains a Constructor to set the name of the car whenever the class is created...
        public Car()
        {
            this.Make = "Nissan";
        }

        // Add another method to the class - an overlaoded method
        public Car(String make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        //public Car(string someOtherInputParameter, string model, int year, string color)
        //{
        //    Make = someOtherInputParameter;
        //    Model = model;
        //    Year = year;
        //    Color = color;
        //}

        public static void MyMethod()
        {

        }
}
