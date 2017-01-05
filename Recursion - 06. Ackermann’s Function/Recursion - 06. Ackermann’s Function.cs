/*
6. Ackermann’s Function
Ackermann’s Function is a recursive mathematical algorithm that can be used to
test how well a computer performs recursion. Design a function ackermann(m, n),
which solves Ackermann’s Function. Use the following logic in your function:
If m = 0 then return n + 1
If n = 0 then return ackermann(m – 1, 1)
Otherwise, return ackermann(m – 1, ackermann(m, n – 1))
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion___06.Ackermann_s_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter m:");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter n:");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("The result is: {0}", Ackermann(m, n));
        }
        public static int Ackermann(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }

    }
}
