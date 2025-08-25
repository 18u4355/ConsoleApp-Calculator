using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = true;
            while (continueCalculation)
            {
                Calculator calc = new Calculator();
                calc.GetInput();
                
                var result = calc.PerformCalculation();

                if (!double.IsNaN(result))
                    Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to perform another calculation? (yes/no): ");
                string choice = Console.ReadLine().ToLower();

                if (choice != "yes")
                {
                    continueCalculation = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }


}