using Practical08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

// sealed class which implements all methods of ATM and contains data of user.
sealed class ATMImplementation: AbsATM, IATMProcessing
{
    int pinNo;
    int oldPIN;
    int newPIN;
    int confNewPIN;
    static int choice;
    double withdrawAmt = 0;
    double creditAmt = 0;

    // user bank details
    // Generic Dictionary to store user details
    static Dictionary<int, Customer> userList = new Dictionary<int, Customer>()
    {
        {1234, new Customer() { AccountNo = 123456, FirstName = "Parthiv", LastName = "H", Balance = 36259 } },
        {5675, new Customer() { AccountNo = 343243, FirstName = "Jay", LastName = "G", Balance = 48567 } },
        {7867, new Customer() { AccountNo = 123259, FirstName = "Abhay", LastName = "C" , Balance = 78217} },
        {6787, new Customer() { AccountNo = 343459, FirstName = "Jil", LastName = "P" , Balance = 32600} },
        {7897, new Customer() { AccountNo = 566890, FirstName = "Kinjal", LastName = "S" , Balance = 42930} }
    };
    // --------------------------------------------------------------------------------------------
    // PIN entry method which takes input from the user and authenticate the user.
    protected internal override int pinEntry()
    {
        Console.WriteLine("entering ATM Card....");
        Thread.Sleep(1500);
        Console.WriteLine("verifying card no...");
        Thread.Sleep(1000);

        while (true)
        {
            try
            {
                Console.Write("Enter PIN Number: ");
                pinNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("verifying PIN..");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                if (userList.ContainsKey(pinNo))
                    break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPlease enter valid PIN!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter valid input.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        return pinNo;
    }

    // --------------------------------------------------------------------------------------------
    // availableServices() method for customer that prints all the services of ATM machine.
    protected internal override void availableServices(int pin)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n------------------------");
        Console.WriteLine($"---Welcome {userList[pinNo].FirstName} to MyATM---");
        Console.WriteLine("1. Check balance");
        Console.WriteLine("2. Withdraw amount");
        Console.WriteLine("3. Credit amount");
        Console.WriteLine("4. Change PIN");
        Console.WriteLine("------------------------");
        Console.ForegroundColor = ConsoleColor.White;
    }

    // --------------------------------------------------------------------------------------------
    // availableServices() method for admin that prints all the services of admin.
    protected internal override void availableServices(string pin)
    {
        try
        {
            if (pin.ToLower() == "admin")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n------------------------");
                Console.WriteLine($"---This is Admin Login---");
                Console.WriteLine("You can handle all customers from here");
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        catch(CustomEx ce)
        {
            Console.WriteLine(ce.Message);
        }
    }

    // --------------------------------------------------------------------------------------------
    // takeChoice() method which takes choice from user according to available services.
    public static void takeChoice()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 4)
                    break;
                else
                {
                    throw new CustomEx("You have entered invalid choice!");
                }
            }
            catch(CustomEx ce)
            {
                Console.WriteLine(ce.Message);
            }
        }
    }

    // --------------------------------------------------------------------------------------------
    // atmProcess() method which processes ATM services as per the user inputs.
    public void atmProcess(int pinNo)
    {
        try
        {
            switch (choice)
            {
                case 1:
                    Console.Write("fetching balance..");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.WriteLine($"\nYour bank balance is {userList[pinNo].Balance}");
                    break;

                case 2:
                    Console.Write("Enter debit amount: ");
                    withdrawAmt = Convert.ToInt32(Console.ReadLine());
                    if (withdrawAmt > userList[pinNo].Balance)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are exceeding the total balance!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        userList[pinNo].Balance -= withdrawAmt;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Withdraw success.");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write("fetching balance..");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);

                        Console.WriteLine($"\nYour current balance is: {userList[pinNo].Balance}");
                    }
                    break;
                case 3:
                    Console.Write("Enter credit amount: ");
                    creditAmt = Convert.ToInt32(Console.ReadLine());
                    
                    userList[pinNo].Balance += creditAmt;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Amount credited successfully.");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("fetching balance..");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);

                    Console.WriteLine($"\nYour current balance is: {userList[pinNo].Balance}");
                    break;

                case 4:
                    while (true)
                    {
                        Console.Write("Enter old PIN: ");
                        oldPIN = Convert.ToInt32(Console.ReadLine());
                        if (pinNo == oldPIN)
                        {
                            Console.Write("Enter new PIN: ");
                            newPIN = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Confirm new PIN: ");
                            confNewPIN = Convert.ToInt32(Console.ReadLine());
                            if (newPIN == confNewPIN)
                            {
                                Customer temp = userList[oldPIN];
                                userList.Remove(oldPIN);
                                userList[newPIN] = temp;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your PIN has changed.");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                            else
                            {
                                throw new CustomEx("PIN doesn't match");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter correct PIN.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    break;
            }
        }
        catch(CustomEx ce)
        {
            Console.WriteLine(ce.Message);
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Thank You. Visit Again!");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
