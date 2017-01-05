using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___02.Feet_to_Inches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the nuber of feet:");
            var feet = int.Parse(Console.ReadLine());
            Console.WriteLine("There are {0} inches in {1} feet", CalcInches(feet), feet);

        }
        static int CalcInches (int feet)
        {
            var inches = feet * 12;
            return inches;
        }
    }
}
