/*
2. Calories Burned
Running on a particular treadmill you burn 3.9 calories per minute. Design a program that uses a loop to display the number of calories burned after 10, 15, 20, 25,
and 30 minutes.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Burned
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalMinutes = 30;
            var caloriesPerMinute = 3.9;
            var totalCalories = 0.0;

            for (int minutes = 1; minutes <= totalMinutes; minutes++)
            {
                totalCalories += caloriesPerMinute;
                if (minutes % 5 == 0 && minutes != 5)
                {
                    Console.WriteLine("{0:F2}", totalCalories);
                }
            }

        }
    }
}
