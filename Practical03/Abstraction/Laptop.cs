using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical03.Abstraction
{
    // definition of Laptop class
    public class Laptop
    {
        // defining properties for brand and method for Laptop class
        public string brand { get; set; }
        public string modal { get; set; }

        // LaptopDetails method to print Brand and Modal
        public void LaptopDetails()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Modal: {modal}");
        }

        // defining MotherBoardInfo() method
        private void MotherBoardInfo()
        {
            Console.WriteLine("Mother Board Information");
        }

        // main method which creates instance of Laptop class and print laptop details
        static void Main(string[] args)
        {
            Laptop myLaptop = new Laptop();
            myLaptop.brand = "Dell";
            myLaptop.modal = "Vostro";

            myLaptop.LaptopDetails();
            myLaptop.MotherBoardInfo();
        }
    }
}
