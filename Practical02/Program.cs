using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // instance of Customer_Account class using parameterized constructor
            Customer_Account customer1 = new Customer_Account(101, "ABC");
            Customer_Account customer2 = new Customer_Account(102, "XYZ");
            Customer_Account customer3 = new Customer_Account(204, "MNO");


            // calling printInfo() method to print customer details
            customer1.printInfo();
            customer2.printInfo();
        }
    }
}
