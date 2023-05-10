using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.OCP
{
    // already created class Loan1 which provides functionalities for process of different loan
    class Loan
    {
        public int Account_No { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public void processForPersonalLoan()
        {
            // business logic
        }
        public void processForVehicleLoan()
        {
            // business logic
        }
    }

    // adding new functionalities of Car and Bike loan into the project(module)
    // implement new functionalities by extending base class
    // now this will satisfies rule of OCP
    class VehicleLoan: Loan
    {
        public void processForCarLoan()
        {
            // business logic
        }

        public void processForBikeLoan()
        {
            // business logic
        }
    }
}
