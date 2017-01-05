/*
9. Pennies for Pay
Design a program that calculates the amount of money a person would earn over a
period of time if his or her salary is one penny the first day, two pennies the second
day, and continues to double each day. The program should ask the user for the
number of days. Display a table showing what the salary was for each day, and
then show the total pay at the end of the period. The output should be displayed in
a dollar amount, not the number of pennies.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pennies_for_Pay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of days you've worked:");
            var days = int.Parse(Console.ReadLine());
            var salary = 0;
            Console.WriteLine("Day                 Salary");
            Console.WriteLine("___________________________________");

            for (int day = 1; day <= days; day++)
            {
                if (day == 1)
                {
                    salary = 1;
                }
                else
                {
                    salary += salary * 2;
                }
                decimal dollars = salary / 100m;
                Console.WriteLine(" {0}                  {1:F2}$", day, dollars);
            }

        }
    }
}
