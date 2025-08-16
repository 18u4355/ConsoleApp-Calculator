using System;
using System.Collections.Generic;

namespace ConsoleApp1   
{
    class Calculator
    {
        private double firstNumber;
        private double secondNumber;
        private string operation;

        List<string> validOperators = new List<string> { "+", "-", "*", "/" };

        public void GetInput()
        {
            Console.Write("Enter the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.Write("Enter an operator (+, -, *, /): ");
                operation = Console.ReadLine();

                if (!validOperators.Contains(operation))
                {
                    Console.WriteLine("Invalid operator. enter a valid operator.");
                }

            } while (!validOperators.Contains(operation));
        }

        public double Calculate()
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                    }
                    break;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = true;

            while (continueCalculation)
            {
                Calculator calc = new Calculator(); 
                calc.GetInput();                     
                double result = calc.Calculate();   

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
