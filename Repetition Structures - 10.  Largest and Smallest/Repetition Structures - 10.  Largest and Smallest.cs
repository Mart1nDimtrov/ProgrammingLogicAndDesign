/*
10. Largest and Smallest
Design a program with a loop that lets the user enter a series of numbers. The user
should enter –99 to signal the end of the series. 
After all the numbers have been entered, the program should display the largest and smallest numbers entered.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_and_Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallestNum = 0;
            int biggestNum = 0;
            var counter = 0;
            Console.WriteLine("Please enter a series of numbers or -99 to exit:");

            while (true)
            {
                counter++;
                var number = int.Parse(Console.ReadLine());
                
                if (number != -99)
                {
                    if (counter == 1)
                    {
                        smallestNum = number;
                        biggestNum = number;
                    }
                   
                    if (smallestNum > number)
                    {
                        smallestNum = number;
                    }
                    if (biggestNum < number)
                    {
                        biggestNum = number;
                    }
                }
                else
                {
                 
                    break;
                }
            }
            Console.WriteLine("The smallest number is: {0}", smallestNum);
            Console.WriteLine("The biggest number is: {0}", biggestNum);


        }
    }
}
