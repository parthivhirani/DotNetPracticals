using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical04
{
    internal class Student
    {
        public string Name;
        static decimal[] Marks = new decimal[5];
        static decimal AverageMarks=0;

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

        public static string CalculateGrade(decimal[] marks)
        {
            decimal sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += marks[i];
            }
            AverageMarks = sum / 5;

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

        enum Options
        {
            Aggregate =1,
            MinMark = 2,
            MaximumMark = 3,
            Grade = 4
        }

        static void Main(string[] args)
        {
            // Student student = new Student();

            Console.Write("Enter Student's Name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Student's Marks");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter subject {i+1} mark: ");
                Marks[i] = Convert.ToDecimal(Console.ReadLine());
            }

            static void selectChoice()
            {
                Console.WriteLine("--Select option from below--");
                Console.WriteLine("1. Show Average marks");
                Console.WriteLine("2. Show minimum marks");
                Console.WriteLine("3. Show maximum marks");
                Console.WriteLine("4. Display student's grade");

                Console.Write("Input your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (choice == (int)Options.Aggregate)
                {
                    Console.WriteLine($"Average marks: {CalculateAverageMarks()}");
                    selectChoice();
                }
                else if (choice == (int)Options.MinMark)
                {
                    Console.WriteLine($"Minimum marks: {Marks.Min()}");
                    selectChoice();
                }
                else if (choice == (int)Options.MaximumMark)
                {
                    Console.WriteLine($"Maximum marks: {Marks.Max()}");
                    selectChoice();
                }
                else if (choice == (int)Options.Grade)
                {
                    Console.WriteLine($"Student's Grade: {CalculateGrade(Marks)}");
                    selectChoice();
                }
                else if (choice == '#')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter valid option!");
                    selectChoice();
                }
            }
            
        }
    }
}
