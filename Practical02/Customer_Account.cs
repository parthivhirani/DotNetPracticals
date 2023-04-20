using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practical02
{
    // defining class Customer_Account
    public class Customer_Account
    {
        // parameterized constructor of Customer_Account class
        public Customer_Account(long customer_accountNo, string customer_name)
        {
            this.customer_accountNo = customer_accountNo;
            this.customer_name = customer_name;
        }


        // variable definition for Customer_Account class
        // access modifier will be default: internal
        string bank_name = "SBI";
        long customer_accountNo;
        string customer_name;


        // printInfo() method will take object's properties and print customer object details in the console
        internal void printInfo()
        {
            Console.WriteLine($"CUSTOMER DETAILS\n------------------\n" +
                $"Bank Name: {bank_name}\n" +
                $"Account No.: {customer_accountNo}\n" +
                $"Customer Name: {customer_name}\n\n");
        }
    }
}
