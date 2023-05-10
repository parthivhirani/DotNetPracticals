using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.OCP
{
    // Loan1 class which has functionalities of process for different types of loan
    class Loan1
    {
        public int Account_No { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public void procesForPersonalLoan()
        {
            // business logic
        }
        public void procesForVehicleLoan()
        {
            // business logic
        }

        // here adding new functionalities in the same class (modifying the class)
        // 1. Process for Car Loan
        // 2. Process for Bike Loan
        // this will violate the rule of OCP
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
