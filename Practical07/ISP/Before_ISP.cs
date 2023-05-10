using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.ISP
{
    // IBank interface which has method to find interest and get loan details
    interface IBank
    {
        public void findInterest();
        public void getLoanDetails();
    }

    // now in any class if we implement IBank interface we have to give
    // implementation of all the methods of the interface.
    // this violates rule of ISP
    class LoanAndInterest: IBank
    {
        public void findInterest()
        {
            // logic to find interest of the customer
        }

        public void getLoanDetails()
        {
            // logic to get loan details of the customer
        }
    }
}
