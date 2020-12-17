using System;
using System.Globalization;

namespace school_test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: Write a program in C# Sharp to read any Month Number in integer and display Month name in the word.");
            Console.WriteLine("Please enter Test Data:");
            var EnteredNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Output Using System.Globalization: " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(EnteredNumber));
            Console.Write("Output via switch: ");
            switch (EnteredNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("The number you have entered is not a month.");
                    break;
            }
        }
    }
}
