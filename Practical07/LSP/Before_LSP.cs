using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.LSP
{
    class Driver
    {
        static void Main(string[] args)
        {
            // creating instance of withKYC class and calling getKYCDetails() method
            withKYC adult = new withKYC();
            adult.getKYCDetails();
            adult.getCustomerDetails();

            // creating instance of withoutKYC class and calling getCustomerDetails() method
            withoutKYC minor = new withoutKYC();
            minor.getCustomerDetails();
        }
    }

    // creating Customer class with following properties and methods
    public class Customer
    {
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ContactNo { get; set; }
        public string PAN { get; set; }
        public bool isKYCDone { get; set; }
        public DateOnly KYCDate { get; set; }
        public virtual void getKYCDetails() { }
        public virtual void getCustomerDetails() { }
    }

    // class withKYC which implements getKYCDetails() and getCustomerDetails() methods
    class withKYC : Customer
    {
        public void getKYCDetails()
        {
            Console.WriteLine("Name: XYZ\nAccountNo: 123456789\nAge: 21\nContactNo: 9999999999\n" +
                "KYC Date: 01/01/2023\nPAN No: 234567FG6");
        }
        public void getCustomerDetails()
        {
            Console.WriteLine("Name: XYZ\nAccountNo: 123456789\nAge: 21\nContactNo: 9999999999");
        }
    }

    // class withoutKYC which implements only getCustomerDetails() method
    class withoutKYC : Customer
    {
        public void getCustomerDetails()
        {
            Console.WriteLine("Name: XYZ\nAccountNo: 123456789\nAge: 21\nContactNo: 9999999999");
        }
    }
}
