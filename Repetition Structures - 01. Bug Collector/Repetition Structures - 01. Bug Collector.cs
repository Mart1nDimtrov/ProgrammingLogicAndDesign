/*
1. Bug Collector
A bug collector collects bugs every day for seven days. Design a program that
keeps a running total of the number of bugs collected during the seven days. The
loop should ask for the number of bugs collected for each day, and when the loop
is finished, the program should display the total number of bugs collected.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = 7;
            var sumBugs = 0;

            for (int i = 0; i < days; i++)
            {
                Console.WriteLine("Please enter the number of bugs you've had today:");
                sumBugs += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Here's the total number of bugs collected: {0}", sumBugs);
            
        }
    }
}
