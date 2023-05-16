using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical08
{
    abstract class AbsATM
    {
        public abstract int pinEntry();
        public abstract void availableServices();
    }

    interface IATMProcessing
    {
        public void atmProcess(int pinNo);
    }
}
