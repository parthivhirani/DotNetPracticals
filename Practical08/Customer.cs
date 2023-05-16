using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical08
{
    class Customer
    {
        public int AccountNo { get; set; }
        public int pinNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname { get { return FirstName + " " + LastName; } }
        public double Balance { get; set; }
    }
}
