/*
4. Number Analysis Program
Design a program that asks the user to enter a series of 20 numbers. The program
should store the numbers in an array and then display the following data:
● The lowest number in the array
● The highest number in the array
● The total of the numbers in the array
● The average of the numbers in the array
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___04.Number_Analysis_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program takes 12 numbers and calculates their total, average,\nlowest and highest value.");
            var length = 12;
            var numbers = new double[length];

            var total = 0.0;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Please enter the next number of 12:");
                var number = double.Parse(Console.ReadLine());
                numbers[i] = number;
                total += number;

            }

            Console.WriteLine("The total is: {0}.", total);
            Console.WriteLine("The average is: {0}.", total / length);
            var highest = numbers[0];
            var lowest = numbers[0];
            for (int i = 1; i < length; i++)
            {
                if (highest < numbers[i])
                {
                    highest = numbers[i];
                }

                if (lowest > numbers[i])
                {
                    highest = numbers[i];
                }

            }
            Console.WriteLine("The highest number is: {0}.", highest);
            Console.WriteLine("The lowest number is: {0}.", lowest);
        }
    }
}