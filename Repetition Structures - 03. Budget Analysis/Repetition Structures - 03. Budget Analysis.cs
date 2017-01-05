/*
3. Budget Analysis
Design a program that asks the user to enter the amount that he or she has budgeted for a month. 
A loop should then prompt the user to enter each of his or her
expenses for the month, and keep a running total. 
When the loop finishes, the program should display the amount that the user is over or under budget.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your budget for this month: ");
            var budget = int.Parse(Console.ReadLine());
            var expense = 0;


            Console.WriteLine("Please enter your months expenses one by one or 0 to end: ");

            do
            {
                expense = int.Parse(Console.ReadLine());
                budget -= expense;


            } while (expense != 0);

            if (budget > 0 )
            {
                Console.WriteLine("You're {0}$ under budget.", budget);
            }
            else if (budget < 0)
            {
                Console.WriteLine("You're {0}$ over budget.", budget * -1);
            }
            else
            {
                Console.WriteLine("You're on track");
            }


        }
    }
}
