/*
1. Sorted Golf Scores
Design a program that asks the user to enter 10 golf scores. The scores should be
stored in an Integerarray. Sort the array in ascending order and display its contents.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting___01.Sorted_Golf_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 golf scores seperated by spaces:");
            var golfScores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int maxElement = golfScores.Length - 1; maxElement >= 0; maxElement--)
            {
                for (int index = 0; index <= maxElement - 1; index++)
                {
                    if (golfScores[index] > golfScores[index + 1])
                    {
                        Swap(ref golfScores[index], ref golfScores[index + 1]);
                       // Console.WriteLine(string.Join("", golfScores));
                    }
                }
            }

            Console.WriteLine("The golf scores are:");
            Console.WriteLine(string.Join("", golfScores));

        }
        static void Swap (ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }


    }
}
