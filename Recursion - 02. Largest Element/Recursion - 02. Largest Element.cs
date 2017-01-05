/*
2. Largest Element
Design a function that accepts an array and the array’s size as arguments, and returns the largest value in the array. The method should use recursion to find the
largest element.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion___02.Largest_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var length = arr.Length - 1;
            Console.WriteLine("The largest number in the array is: {0}", FindLargest(arr, length, arr[length]));

        }
        public static int FindLargest (int [] arr, int length, int max) // we need max to come from outside, so it doesn't change
        {
            if (length == 0)
            {
                return max;
            }
            if (arr[length] > max)
            {
                max = arr[length];
            }
            return FindLargest(arr, length - 1, max);
                
        }
    }
}
