using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Practical08
{
    class Driver
    {
        static void Main(string[] args)
        {
            ATMImplementation atm = new();
            int pin = atm.pinEntry();
            atm.availableServices();
            ATMImplementation.takeChoice();
            atm.atmProcess(pin);
        }
    }
}
