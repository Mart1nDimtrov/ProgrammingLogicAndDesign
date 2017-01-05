/*
8. Sorting Benchmarks
Modify the modules presented in this chapter that perform the bubble sort, selection sort, and insertion sort algorithms on an Integerarray, such that each module keeps a count of the number of swaps it makes.
Then, design an application that uses three identical arrays of at least 20 integers.
It should call each module on a different array, and display the number of swaps
made by each algorithm.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting___08.Sorting_Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = new int[] { 2, 15, 20, 1, 6, 10, 5, 18, 7, 12, 13, 17, 3, 11, 9, 8, 14, 19, 4, 16 };
            var secondArr = new int[] { 2, 15, 20, 1, 6, 10, 5, 18, 7, 12, 13, 17, 3, 11, 9, 8, 14, 19, 4, 16 };
            var thirdArr = new int[] { 2, 15, 20, 1, 6, 10, 5, 18, 7, 12, 13, 17, 3, 11, 9, 8, 14, 19, 4, 16 };

            var bubbleCount = 0;
            var selectionCount = 0;
            var insertionCount = 0;

            BubbleSort(ref firstArr, ref bubbleCount);
            SelectionSort(ref secondArr, ref selectionCount);
            InsertionSort(ref thirdArr, ref insertionCount);

            //Console.WriteLine(string.Join(" ", firstArr));
            //Console.WriteLine(string.Join(" ", secondArr));
            //Console.WriteLine(string.Join(" ", thirdArr));

            Console.WriteLine("Number of Bubble Sort swaps: {0}", bubbleCount);
            Console.WriteLine("Number of Selection Sort swaps: {0}", selectionCount);
            Console.WriteLine("Number of Insertion Sort swaps: {0}", insertionCount);
        }

        static void BubbleSort(ref int[] array, ref int bubbleCount)
        {
            for (int maxElement = array.Length - 1; maxElement >= 0; maxElement--)
            {
                for (int index = 0; index <= maxElement - 1; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        SwapBubbleSort(ref array[index], ref array[index + 1], ref bubbleCount);
                        
                    }
                }
            }
        }

       static void SwapBubbleSort (ref int a, ref int b, ref int bubbleCount)
        {
            bubbleCount++;
            var temp = a;
            a = b;
            b = temp;

        }

        static void InsertionSort (ref int[] array, ref int insertionCount)
        {
            var scan = 0;
            int unsortedValue = 0;
            for (int index = 1; index < array.Length; index++)
            {
                unsortedValue = array[index];
                scan = index;

                while (scan > 0 && array[scan - 1] > array[scan])
                {
                    InsertionSwap(ref array[scan - 1], ref array[scan], ref insertionCount);
                    scan--;
                }
                array[scan] = unsortedValue;
            }
        }
        static void InsertionSwap(ref int a, ref int b, ref int insertionCount)
        {
            insertionCount++;
            var temp = a;
            a = b;
            b = temp;

        }
        static void SelectionSort (ref int[]array, ref int selectionCount)
        {
            var minIndex = 0;
            var minValue = 0;

            for (int startScan = 0; startScan <= array.Length - 2; startScan++)
            {
                minIndex = startScan;
                minValue = array[startScan];
                for (int index = startScan + 1; index <= array.Length - 1; index++)
                {
                    if (array[index] < minValue)
                    {
                        minValue = array[index];
                        minIndex = index;
                    }
                }
                SelectionSwap(ref array[minIndex], ref array[startScan], ref selectionCount);
            }

        }
        static void SelectionSwap(ref int a, ref int b, ref int selectionCount)
        {
            selectionCount++;
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
