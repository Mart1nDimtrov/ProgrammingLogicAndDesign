/*
6. Distance Traveled
The distance a vehicle travels can be calculated as follows:
Distance= Speed×Time
For example, if a train travels 40 miles per hour for three hours, the distance traveled is 120 miles. Design a program that asks the user for the speed of a vehicle (in
miles per hour) and how many hours it has traveled. It should then use a loop to
display the distance the vehicle has traveled for each hour of that time period. Here
is an example of the output:
What is the speed of the vehicle in mph? 40 [Enter]
How many hours has it traveled? 3 [Enter]
Hour Distance Traveled
——————————————————————————————
1                           40  
2                           80
3                          120
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Traveled
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = 0;
            Console.WriteLine("What is the speed of the vehicle in mph?");
            var speed = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours has it traveled?");
            var hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Hour             Distance Traveled");
            Console.WriteLine("____________________________________");

            for (int hour = 1; hour <= hours; hour++)
            {
                distance = hour * speed;
                Console.WriteLine(" {0}                 {1}", hour, distance);
            }

        }
    }
}
