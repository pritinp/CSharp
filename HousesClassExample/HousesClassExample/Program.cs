using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Property myNewHouse = new Property();

            myNewHouse.propertyType = "House";
            myNewHouse.Bedrooms = 3;
            myNewHouse.Bathrooms = 1;
            myNewHouse.Garden = "Yes";
            myNewHouse.Garage = "No";

            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", 
                myNewHouse.propertyType,
                myNewHouse.Bedrooms,
                myNewHouse.Bathrooms,
                myNewHouse.Garden,
                myNewHouse.Garage);

            Console.WriteLine("This property has: {0}", myNewHouse.DetermineStairs());

            Console.ReadLine();
        }
    }

    class Property
    {
        public string propertyType { get; set; }
        public int Bedrooms{ get; set; }
        public int Bathrooms { get; set; }
        public string Garden { get; set; }
        public string Garage { get; set; }

        public string DetermineStairs()
        {
            string stairStatus = "test";

            if (this.propertyType == "House")
            {
                stairStatus = "Property has stairs";
            }
            else
            {
                stairStatus = "Property has no stairs";
            }

            return stairStatus;
        }
    }
}
