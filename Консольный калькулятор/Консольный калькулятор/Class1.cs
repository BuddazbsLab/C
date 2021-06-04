using System;
using System.Collections.Generic;
using System.Text;

namespace Консольный_калькулятор
{
    public class MathOperations
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }

        public static double Percentage_of_separation(double a, double b)
        {
            return a % b;
        }
    }
}
