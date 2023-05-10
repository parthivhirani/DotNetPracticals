using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.SRP
{
    // bank process class doing more than one jobs
    // 1. Credit Amount
    // 2. Debit Amount
    // 3. Display Amount
    // which is violating the rule of SRP
    class BankProcess
    {
        public double Amount { get; set; }
        public double Account_No { get; set; }

        // method to perform transaction of credit amount in the account
        public void creditAmount(int amt)
        {
            if(amt > 0 && amt < 50000)
            {
                // code to credit amount to bank account
            }
        }

        // method to perform transaction of debit amount in the account
        public void debitAmount(int amt)
        {
            if (amt > 0 && amt < Amount)
            {
                // code to withdraw amount from bank account
            }
        }

        // method to display bank balance in the account
        public void displayAmount(int account_no)
        {
            Console.WriteLine($"Your bank balance is...");
        }
    }

























    //class Area
    //{
    //    public double Radius { get; set; }
    //    public double Width { get; set; }
    //    public double Height { get; set; }
    //    public static void getCircleArea(double rad)
    //    {
    //        Console.WriteLine($"Area of Circle is {Math.Round(Math.PI * rad * rad, 2)}");
    //    }

    //    public static void getTriangleArea(double height, double width)
    //    {
    //        Console.WriteLine($"Area of Triangle is {Math.Round(0.5 * width * height, 2)}");
    //    }
    //}

    //class Circumference
    //{
    //    public static void getCircleCircumference(double rad)
    //    {
    //        Console.WriteLine($"Circumference of Circle is {Math.Round(2 * Math.PI * rad, 2)}");
    //    }

    //    public static void getTriangleCircumference(double width)
    //    {
    //        Console.WriteLine($"Circumference of Triangle is {Math.Round(3.0 * width, 2)}");
    //    }
    //}

    //class Driver
    //{
    //    static void Main(string[] args)
    //    {
    //        Area shape1 = new Area();
    //        Console.Write("Enter radius of circle: ");
    //        shape1.Radius = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Enter width of triangle: ");
    //        shape1.Width = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Enter height of triangle: ");
    //        shape1.Height = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine();
    //        Area.getCircleArea(shape1.Radius);
    //        Area.getTriangleArea(shape1.Width, shape1.Height);

    //        Console.WriteLine();
    //        Circumference.getCircleCircumference(shape1.Radius);
    //        Circumference.getTriangleCircumference(shape1.Width);

    //    }
    //}
}
