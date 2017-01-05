/*
4. Sum of Digits in a String
Design a program that asks the user to enter a string containing a series of single
digit numbers with nothing separating them. The program should display the sum
of all the single digit numbers in the string. For example, if the user enters 2514,
the method should return 12, which is the sum of 2, 5, 1, and 4. (Hint: The
stringToIntegerlibrary function can be used to convert a single character to an
integer.)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processing___04.Sum_of_Digits_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string of digits:");
            var digits = Console.ReadLine();
            var sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += Convert.ToInt32(digits[i] - '0');
            }
            Console.WriteLine("The sum of the digits is {0}", sum);

        }
    }
}
