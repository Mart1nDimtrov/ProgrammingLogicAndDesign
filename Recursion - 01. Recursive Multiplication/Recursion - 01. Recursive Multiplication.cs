/*
1. Recursive Multiplication
Design a recursive function that accepts two arguments into the parameters xand
y. The function should return the value of xtimes y. Remember, multiplication can
be performed as repeated addition as follows:
7 ×4 = 4 + 4 + 4 + 4 + 4 + 4 + 4
(To keep the function simple, assume that xand ywill always hold positive
nonzero integers.)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion___01.Recursive_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            Console.WriteLine(multiply(x, y));


        }
        public static int multiply(int x, int y)
        {

            if (y == 1)
            {
                return x;
            }
            var sum = x + multiply(x, y - 1);
            return sum;
        }
    }
}
