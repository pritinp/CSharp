using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            // set properties

            Car myOtherCar = myCar;

            // frees up memory by removing these objects 
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
        public double OriginalPrice { get; set; }

        public Car()
        {
            // You could this from a configuation file, a database, etc.
            // I'll just hardcode in this instance.
            this.Make = "Nissan";
        }
    }

}
