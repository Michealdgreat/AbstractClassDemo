using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryItem item = new Book();


            item.productName = "Huh?";
            
            vehicle Corolla = new Car();

            Car corolla = new Car();

            corolla.NumberOfwheels = 4;

            Console.ReadLine();
        }
    }

    // Abstract
    public abstract class vehicle 
    {
        // Methods
        public string VINNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public int YearofManufacturer { get; set; }

    }

    // Class inheriting from Abstract class vehicle
    public class Car : vehicle
    {
        public int NumberOfwheels { get; set; } = 4;

    }
}
