using Practical07.LSP;

namespace Practical07.LSP
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Employee cashier = new Cashier();
            cashier.getEmployee();
        }
    }

    // Employee is base class which has getEmployee() method to return details of the employee
    public class Employee
    {
        public virtual void getEmployee()
        {
            Console.WriteLine("Employee Details.");
        }
    }

    // Cashier class is derived from the Employee class and overriding the method of Employee class
    public class Cashier : Employee
    {
        public override void getEmployee()
        {
            Console.WriteLine("Name: XYZ\nType: Technical\nPosition: Cashier\nExperience: 2 years");
        }
    }

    // Peon class is derived class from the Employee class and overriding the method of Employee class
    class Peon : Employee
    {
        public override void getEmployee()
        {
            Console.WriteLine("Name: MNO\nType: Non-Technical\nPosition: Peon\nExperience: 1 years");
        }
    }
}