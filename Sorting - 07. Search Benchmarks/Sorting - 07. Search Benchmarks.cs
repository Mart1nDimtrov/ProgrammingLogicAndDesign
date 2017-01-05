/*
7. Search Benchmarks
Design an application that has an array of at least 20 integers. It should call a
module that uses the sequential search algorithm to locate one of the values. The
module should keep a count of the number of comparisons it makes until it finds
the value. Then the program should call another module that uses the binary
search algorithm to locate the same value. It should also keep a count of the number of comparisons it makes. Display these values on the screen.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting___07.Search_Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = new char[] { ',', ' ' };
            var numbers = Console.ReadLine().Split(chars, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var countBinarySearch = 0;
            var countSequentialSearch = 0;

            Console.WriteLine("Please enter the number you're searching for:");
            var value = int.Parse(Console.ReadLine());

            for (int index = 0; index < numbers.Length; index++)
            {
                countSequentialSearch++;
                if (numbers[index] == value)
                {
                    break;
                }
            }

            

            for (int maxElement = numbers.Length - 1; maxElement >= 0; maxElement--)
            {
                for (int index = 0; index <= maxElement - 1; index++)
                {
                    if (numbers[index] > numbers[index + 1])
                    {
                        Swap(ref numbers[index], ref numbers[index + 1]);    
                    }
                }
            }


            var first = 0;
            var last = numbers.Length - 1;
            var middle = 0;
            bool found = false;
            var pos = -1;

            while (found == false && first <= last)
            {
                countBinarySearch++;
                middle = (first + last) / 2;

                if (numbers[middle] == value)
                {
                    found = true;
                    pos = middle;
                }
                else if (numbers[middle] > value)
                {
                    last = middle - 1;
                }
                else
                {
                    first = middle + 1;
                }

            }

            Console.WriteLine("The sequential search made {0} comparisons.", countSequentialSearch);
            Console.WriteLine("The binary search made {0} comparisons.", countBinarySearch);


        }
        static void Swap (ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
