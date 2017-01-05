/*
12. Calculating the Factorial of a Number
In mathematics, the notation n! represents the factorial of the nonnegative integer
n. The factorial of nis the product of all the nonnegative integers from 1 up
through n. For example:
7! = 1 ×2 ×3 ×4 ×5 ×6 ×7 = 5,040
and
4! = 1 ×2 ×3 ×4 = 24
Design a program that asks the user to enter a nonnegative integer and then displays the factorial of that number.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_the_Factorial_of_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var factorial = 1;
            Console.WriteLine("Please enter a nonnegative number:");
            var number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of {0} is {1}", number, factorial);


        }
    }
}
