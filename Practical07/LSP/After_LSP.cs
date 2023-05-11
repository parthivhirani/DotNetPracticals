using Practical07.LSP;

namespace Practical07.LSP
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            // creating instance of KYC class and calling methods depends on the condition
            KYC customer = new KYC();
            if (customer.isKYCDone)
            {
                customer.getKYCDetails();
            }
            else
            {
                customer.getCustomerDetails();
            }
        }
    }

    // KYC class is derived from the Customer class and overriding both the methods of Customer class
    public class KYC : Customer
    {
        public override void getKYCDetails()
        {
            Console.WriteLine("Name: XYZ\nAccountNo: 123456789\nAge: 21\nContactNo: 9999999999" +
                "\nKYC Date: 21/01/2023\nPAN: 98798FG89");
        }
        public override void getCustomerDetails()
        {
            Console.WriteLine("Name: XYZ\nAccountNo: 123456789\nAge: 21\nContactNo: 9999999999");
        }
    }
}