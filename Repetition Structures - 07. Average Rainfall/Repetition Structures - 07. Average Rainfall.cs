/*
7. Average Rainfall
Design a program that uses nested loops to collect data and calculate the average
rainfall over a period of years. The program should first ask for the number of
years. The outer loop will iterate once for each year. The inner loop will iterate
twelve times, once for each month. Each iteration of the inner loop will ask the
user for the inches of rainfall for that month. After all iterations, the program
should display the number of months, the total inches of rainfall, and the average
rainfall per month for the entire period.
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Rainfall
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalMonths = 0;
            var totalInches = 0.0;
            Console.WriteLine("Please enter the number of years:");
            var years = int.Parse(Console.ReadLine());
            var rainfallPerMonth = 0.0;
            

            for (int year = 0; year < years; year++)
            {
                for (int month = 0; month < 12; month++)
                {
                    Console.WriteLine("Please enter the number of inches for this month:");
                    totalInches += double.Parse(Console.ReadLine());
                    totalMonths++;
                }
            }
            rainfallPerMonth = totalInches / totalMonths;
            Console.WriteLine("The number of months is: {0}", totalMonths);
            Console.WriteLine("The total inches of rainfall is: {0}", totalInches);
            Console.WriteLine("The average rainfall per months is: {0:F2}", rainfallPerMonth);

        }
    }
}
