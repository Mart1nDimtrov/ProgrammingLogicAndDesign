using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___04.Maximum_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two number to be compared ot seperate lines:");
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("The bigger number is: {0}", Max(firstNum, secondNum));

        }
        static int Max(int first, int second)
        {
            int biggerNum = 0;
            if (first > second)
            {
                biggerNum = first;
               
            }
            else if (second > first)
            {
                biggerNum = second;
                
            }
            return biggerNum;
        }
    }
}
