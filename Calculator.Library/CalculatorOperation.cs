using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library
{
    public class CalculationOperation
    {
        public static int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static int Substract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

    }
}
