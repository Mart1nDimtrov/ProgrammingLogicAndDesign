/*
5. Recursive Power Method
Design a function that uses recursion to raise a number to a power. The function
should accept two arguments: the number to be raised and the exponent. Assume
that the exponent is a nonnegative integer.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion___05.Recursive_Power_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number to be raised:");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the power:");
            var power = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} raised to the power of {1} is {2}", number, power, RaisePower(number, power));
        }
        public static int RaisePower(int number, int power)
        {
            if (power == 1) // n^1 = n
            {
                return number;
            }

            var product = number * RaisePower(number, power - 1);
            return product;
        }
    }
}
