/*
5. Tuition Increase
At one college, the tuition for a full-time student is $6,000 per semester. It has been
announced that the tuition will increase by 2 percent each year for the next five
years. Design a program with a loop that displays the projected semester tuition
amount for the next five years.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuition_Increase
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = 5;
            var tuition = 6000.0;
            var amount = 0.0;

            for (int semester = 1; semester < years * 2 + 1; semester++)
            {
                if (semester % 2 == 0)
                {
                    tuition = tuition * 1.02;
                    amount += tuition;
                    Console.WriteLine(amount);
                }
                else
                {
                    amount += tuition;
                    Console.WriteLine(amount);
                }
            }
        }
    }
}
