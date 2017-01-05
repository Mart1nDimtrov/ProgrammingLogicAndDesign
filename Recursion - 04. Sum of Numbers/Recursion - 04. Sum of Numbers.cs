/*
4. Sum of Numbers
Design a function that accepts an integer argument and returns the sum of all the
integers from 1 up to the number passed as an argument. For example, if 50 is
passed as an argument, the function will return the sum of 1, 2, 3, 4, . . . 50. Use
recursion to calculate the sum.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion___04.Sum_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The sum of all the numbers up to that number is: {0}", NumberSum(number));

        }
        public static int NumberSum(int number)
        {
            if (number == 0)
            {
                return number;
            }

            var sum = number + NumberSum(number - 1);
            return sum;

        }
    }
}
