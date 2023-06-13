using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical08
{
    public class CustomEx: Exception
    {
        public CustomEx(string message)
            : base(message)
        {
        }
        public CustomEx(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
