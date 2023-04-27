using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical04
{
    internal class Student
    {
        // string type variable name to store student's name
        public string Name;
        // decimal array to store student's 5 subject marks
        static decimal[] Marks = new decimal[5];
        // static variable to store average mark of student
        static decimal AverageMarks=0;
        static int choice;


        // static method to calculate average marks of student
        public static decimal CalculateAverageMarks()
        {
            decimal sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += Marks[i];
            }
            AverageMarks = sum/5;

            return AverageMarks;

        }


        // static method to calculate grade of student based on average marks using switch-case
        public static string CalculateGrade(decimal[] marks)
        {
            CalculateAverageMarks();

            switch (AverageMarks)
            {
                case (>90):
                    return "A";

                case (>80):
                    return "B";

                case (>70):
                    return "C";

                case (<70):
                    return "D";

                default:
                    return "Invalid Input";
            }
        }


        // enum data type for choice of output
        enum Options
        {
            Aggregate =1,
            MinMark = 2,
            MaximumMark = 3,
            Grade = 4
        }


        // void method which gives option to user to get particular output
        static void selectChoice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("--Select option from below--");
            Console.WriteLine("1. Show Average marks");
            Console.WriteLine("2. Show minimum marks");
            Console.WriteLine("3. Show maximum marks");
            Console.WriteLine("4. Display student's grade");
            Console.WriteLine("Enter '#' to exit.");
        }


        // Main method
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                Console.ForegroundColor= ConsoleColor.White;
                // taking student's name from user
                Console.Write("Enter Student's Name: ");
                string Name = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                // taking student's 5 subject marks using for loop
                Console.WriteLine("--Enter Student's Marks--");
                for (int i = 0; i < 5; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Enter subject {i+1} mark: ");
                    Marks[i] = Convert.ToDecimal(Console.ReadLine());
                }

                // taking choice from user until they don't want to exit using while loop
                while (true)
                {
                    // calling selectChoice() method to print available options
                    selectChoice();
                    Console.ForegroundColor= ConsoleColor.White;
                    // taking choice from user
                    Console.Write("Input your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    // giving output for user specified choice using if-else
                    if (choice == (int)Options.Aggregate)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        // printing average marks using CalculateAveragemarks() method
                        Console.WriteLine($"Average mark: {CalculateAverageMarks()}");
                        
                    }
                    else if (choice == (int)Options.MinMark)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        // printing minimum mark using inbuilt function
                        Console.WriteLine($"Minimum mark: {Marks.Min()}");
                    }
                    else if (choice == (int)Options.MaximumMark)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        // printing maximum mark using inbuilt function
                        Console.WriteLine($"Maximum mark: {Marks.Max()}");
                    }
                    else if (choice == (int)Options.Grade)
                    {
                        Console.ForegroundColor= ConsoleColor.Green;
                        // printing student's grade using CalculateGrade() method
                        Console.WriteLine($"Student's Grade is {CalculateGrade(Marks)}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        // printing appropriate message if user input invalid choice
                        Console.WriteLine("Please enter valid option!");
                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Green;
                // ending the program if user inputs '#'
                Console.WriteLine("THANK YOU.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
