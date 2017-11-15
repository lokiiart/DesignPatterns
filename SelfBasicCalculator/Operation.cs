using System;
using System.Collections.Generic;
using System.Text;

namespace SelfBasicCalculator
{
    class Operation
    {
        public static double GetResult(double numA, double numB, string operate)
        {
            double result = 0.0d;
            switch (operate)
            {
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
                case "*":
                    result = numA * numB;
                    break;
                case "/":
                    result = numA / numB;
                    break;
                default:
                    Console.WriteLine("you input a wrong operation");
                    break;
            }
            return result;
        }
    }
}
