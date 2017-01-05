/*
1. Total Sales
Design a program that asks the user to enter a store’s sales for each day of the
week. The amounts should be stored in an array. Use a loop to calculate the total
sales for the week and display the result.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___01.Total_Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 7;
            var sales = new int[length];
            var total = 0;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Please enter the sales for day {0}:", i + 1);
                var sale = int.Parse(Console.ReadLine());
                sales[0] = sale;
                total += sale;
            }
            Console.WriteLine("The total of your sales is: {0}", total);

        }
    }
}
