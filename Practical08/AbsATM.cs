using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical08
{
    // Abstract class which has method of ATM PIN entry and services of ATM.
    abstract class AbsATM
    {
        public abstract int pinEntry();
        public abstract void availableServices();
    }

    // Interface which has method to process ATM services.
    interface IATMProcessing
    {
        public void atmProcess(int pinNo);
    }
}
