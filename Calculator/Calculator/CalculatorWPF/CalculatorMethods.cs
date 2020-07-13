using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWPF
{
    class CalculatorMethods
    {
        static public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        static public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        static public double Times(double num1, double num2)
        {
            return num1 * num2;
        }
        static public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        static public double Modulus(double num1, double num2)
        {
            return num1 % num2;
        }
    }
}
