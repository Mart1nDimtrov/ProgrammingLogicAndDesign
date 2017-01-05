/*
2. Sorted Names
Design a program that allows the user to enter 20 names into a Stringarray. Sort
the array in ascending (alphabetical) order and display its contents.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting___02.Sorted_Names
{
    class Program
    {
        static void Main(string[] args)
        {
       
                Console.WriteLine("Please enter the names to be sorted seperated by spaces:");
                var names = Console.ReadLine().Split(' ').ToArray();

                for (int maxElement = names.Length - 1; maxElement >= 0; maxElement--)
                {
                    for (int index = 0; index <= maxElement - 1; index++)
                    {
                        if (names[index][0] > names[index + 1][0])
                        {
                            Swap(ref names[index], ref names[index + 1]);
                            // Console.WriteLine(string.Join("", golfScores));
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("The names are:");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }

            }
            static void Swap(ref string a, ref string b)
            {
                var temp = a;
                a = b;
                b = temp;
            }


        }
    }

