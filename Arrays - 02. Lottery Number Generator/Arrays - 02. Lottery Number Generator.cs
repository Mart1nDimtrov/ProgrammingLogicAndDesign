/*
2. Lottery Number Generator
Design a program that generates a 7-digit lottery number. The program should
have an Integerarray with 7 elements. Write a loop that steps through the array,
randomly generating a number in the range of 0 through 9 for each element. (Use
the randomfunction that was discussed in Chapter 6.) Then write another loop
that displays the contents of the array.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___02.Lottery_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 7;
            var lotteryNum = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                lotteryNum[i] = rnd.Next(0, 10);
            }

            Console.WriteLine("The lottery number is: {0}", string.Join("", lotteryNum));

        }
    }
}
