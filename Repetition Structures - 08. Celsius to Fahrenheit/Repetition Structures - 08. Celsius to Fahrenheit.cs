/*
8. Celsius to Fahrenheit Table
Design a program that displays a table of the Celsius temperatures 0 through 20
and their Fahrenheit equivalents. The formula for converting a temperature from
Celsius to Fahrenheit is: F = (9 / 5 ) * C + 32;
where F is the Fahrenheit temperature and C is the Celsius temperature. Your
program must use a loop to display the table.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsius                 Fahrenheit");
            Console.WriteLine("___________________________________");

            for (int i = 1; i <= 20; i++)
            {
                var fahrenheit = 1.8 * i + 32;
                Console.WriteLine(" {0}                       {1}", i, fahrenheit);
            }

        }
    }
}
