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
        // static Main() method from which execution begins.
        static void Main(string[] args)
        {
            ATMImplementation atm = new();
            var pin = atm.pinEntry();
            atm.availableServices(pin);
            ATMImplementation.takeChoice();
            atm.atmProcess(pin);
        }
    }
}
