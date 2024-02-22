using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutationTestingDemo
{
    public static class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b) // Adding the multiplication method
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new ArgumentException("Cannot divide by zero");
            }
        }

        public static double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number");
            }

            return Math.Sqrt(a);
        }
    }
}
