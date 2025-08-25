using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculator
    {
        private double firstNumber;
        private double secondNumber;
        private string operation;

        //public Calculator(string operation, double firstNumber, double secondNumber)
        //{
        //    this.operation = operation;
        //    this.firstNumber = firstNumber;
        //    this.secondNumber = secondNumber;
        //}

        List<string> validOperators = new List<string> { "+", "-", "*", "/" };


        public void GetInput()
        {
            while (true)
            {
                Console.Write("Enter the first number: ");
                string input1 = Console.ReadLine();
                if (double.TryParse(input1, out firstNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            while (true)
            {
                Console.Write("Enter the second number: ");
                string input2 = Console.ReadLine();
                if (double.TryParse(input2, out secondNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
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

        public double PerformCalculation()
        {
            Operation op;
            switch (operation)
            {
                case "+":
                    op = new Addition();
                    break;
                case "-":
                    op = new Subtraction();
                    break;
                case "*":
                    op = new Multiplication();
                    break;
                case "/":
                    op = new division();
                    break;
                default:
                    throw new InvalidOperationException("Invalid operator");
            }
            return op.Calculate(firstNumber, secondNumber);
        }


    }
}
