using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.LSP
{
    // creating IBankEmployee interface which has getEmployee() method
    public interface IBankEmployee
    {
        public void getEmployee() { }
    }
    class Driver
    {
        static void Main(string[] args)
        {
            // creating instance of Cashier class and giving its reference to the interface
            IBankEmployee employee = new Cashier();
            employee.getEmployee();
        }
    }

    // implementing method of interface in the Manager class
    class Manager : IBankEmployee
    {
        public void getEmployee()
        {
            Console.WriteLine("Name: ABC\nType: Technical\nPosition: Branch Manager\nExperience: 7 years");
        }
    }

    // implementing method of interface in the Cashier class
    class Cashier : IBankEmployee
    {
        public void getEmployee()
        {
            Console.WriteLine("Name: XYZ\nType: Technical\nPosition: Cashier\nExperience: 2 years");
        }
    }

    // implementing method of interface in the Peon class
    class Peon : IBankEmployee
    {
        public void getEmployee()
        {
            Console.WriteLine("Name: MNO\nType: Non-Technical\nPosition: Peon\nExperience: 1 years");
        }
    }
}
