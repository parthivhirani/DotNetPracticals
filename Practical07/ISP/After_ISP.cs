using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.ISP
{
    // interface IBank1 which has method to find interest
    interface IBank1
    {
        public void findInterest();
    }

    // interface IBank2 which has method to retrieve loan details
    interface IBank2
    {
        public void getLoanDetails();
    }

    // now only implement the necessary interface in the class
    // segregation of interface satisfy the rule of ISP
    class Interest: IBank1
    {
        public void findInterest()
        {
            // logic to find interest of the customer
        }
    }

    class Loan: IBank2
    {
        public void getLoanDetails()
        {
            // logic to get loan details of the customer
        }
    }
}
