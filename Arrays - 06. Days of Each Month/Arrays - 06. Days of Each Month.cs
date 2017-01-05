/*
6. Days of Each Month
Design a program that displays the number of days in each month. The program’s
output should be similar to this:
January has 31 days.
February has 28 days.
March has 31 days.
April has 30 days.
May has 31 days.
June has 30 days.
July has 31 days.
August has 31 days.
September has 30 days.
October has 31 days.
November has 30 days.
December has 31 days.
The program should have two parallel arrays: a 12-element Stringarray that is
initialized with the names of the months, and a 12-element Integerarray that is
initialized with the number of days in each month. To produce the output specified, use a loop to step through the arrays getting the name of a month and the
number of days in that month.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___06.Days_of_Each_Month
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 12;
            var numberOfDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            var months = new string[]{"January","February","March", "April", "May", "June", "July","August",
                 "September",  "October","November", "December"  };

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0} has {1}.", months[i], numberOfDays[i]);
            }

        }
    }
}
