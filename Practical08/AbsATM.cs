using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practical08
{
    // Abstract class which has method of ATM PIN entry and services of ATM.
    abstract class AbsATM
    {
        protected internal abstract int pinEntry();
        protected internal abstract void availableServices(int pin);
        protected internal abstract void availableServices(string pin);
    }

    // Interface which has method to process ATM services.
    interface IATMProcessing
    {
        public void atmProcess(int pinNo);
    }
}
