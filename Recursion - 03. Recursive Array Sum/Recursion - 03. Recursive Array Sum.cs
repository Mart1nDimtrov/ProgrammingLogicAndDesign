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

namespace Recursion___03.Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var length = arr.Length - 1;
            Console.WriteLine("The sum of the elements is: {0}", SumArr(arr, length));

        }
      public static int SumArr (int [] arr, int length)
        {
            if (length == 0)
            {
                return arr[0];
            }

            var sum = arr[length] + SumArr(arr, length - 1);
            return sum;

        }
    }
}
