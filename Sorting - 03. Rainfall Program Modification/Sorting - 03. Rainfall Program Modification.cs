/*
3. Rainfall Program Modification
Recall that Programming Exercise 3 in Chapter 8 asked you to design a program
that lets the user enter the total rainfall for each of 12 months into an array. The
program should calculate and display the total rainfall for the year, the average
monthly rainfall, and the months with the highest and lowest amounts. Enhance the
program so it sorts the array in ascending order and displays the values it contains.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting___03.Rainfall_Program_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 12;
            var monthlyRainfall = new double[length];

            var total = 0.0;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Please enter the amount of rainfall for month {0}:", i + 1);
                var month = double.Parse(Console.ReadLine());
                monthlyRainfall[i] = month;
                total += month;

            }

            Console.WriteLine("The total rainfall for the year is: {0} cubic inches.", total);
            Console.WriteLine("The average monthly rainfall for the year is: {0} cubic inches.", total / length);
            var highest = monthlyRainfall[0];
            var lowest = monthlyRainfall[0];
            for (int i = 1; i < length; i++)
            {
                if (highest < monthlyRainfall[i])
                {
                    highest = monthlyRainfall[i];
                }

                if (lowest > monthlyRainfall[i])
                {
                    highest = monthlyRainfall[i];
                }

            }
            Console.WriteLine("The maximum monthly rainfall for the year is: {0} cubic inches.", highest);
            Console.WriteLine("The minimum monthly rainfall for the year is: {0} cubic inches.", lowest);

            for (int startScan = 0; startScan < monthlyRainfall.Length - 2; startScan++)
            {
                var minIndex = startScan;
                var minValue = monthlyRainfall[startScan];

                for (int index = startScan + 1; index < monthlyRainfall.Length - 1; index++)
                {
                    if (monthlyRainfall[index] < minValue)
                    {
                        minValue = monthlyRainfall[index];
                        minIndex = index;
                    }
                }
                Swap(ref monthlyRainfall[minIndex], ref monthlyRainfall[startScan]);


            }

            Console.WriteLine();
            Console.WriteLine("The sorted values are:");

            for (int i = 0; i < monthlyRainfall.Length; i++)
            {
                Console.WriteLine(monthlyRainfall[i]);
            }

        }

        static void Swap(ref double a, ref double b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

    }
}