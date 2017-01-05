using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function___05.Falling_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("The distance is: {0}", FallingDistance(i));
            }

        }
        static string FallingDistance (int time)
        {
            double distance = 0.5 * 9.8 * (time * time);
            return Convert.ToString(distance);

        }
    }
}
