/*
4. Sum of Numbers
Design a program with a loop that asks the user to enter a series of positive numbers. 
The user should enter a negative number to signal the end of the series. After
all the positive numbers have been entered, the program should display their sum.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = true;
            var total = 0;

            Console.WriteLine("Please enter a series of positive numbers:");

            while (flag)
            {
                var number = int.Parse(Console.ReadLine());

                if (number > -1)
                {
                    total += number;
                }
                else
                {
                    flag = false; 
                }


            }

            Console.WriteLine("The total is: {0}", total);


        }
    }
}
