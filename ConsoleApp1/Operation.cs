using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public abstract class Operation
    {
        public abstract double Calculate(double firstNumber, double secondNumber);
    }
    public class Addition : Operation
    {
        public override double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

    }
    public class Subtraction : Operation
    {
        public override double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
    class Multiplication : Operation
    {
        public override double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
    public class division : Operation
    {
        public override double Calculate(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return firstNumber / secondNumber;
        }
    }

}
