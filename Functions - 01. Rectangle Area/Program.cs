using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___01.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the rectangle's width and length on seperate lines:");
            var width = int.Parse(Console.ReadLine());
            var length = int.Parse(Console.ReadLine());
            var area = CalcArea(width, length);
            Console.WriteLine("The area is: {0}", area);


        }
        static int CalcArea(int width, int length)
        {
            var area = width * length;
            return area;
        }
    }
}
