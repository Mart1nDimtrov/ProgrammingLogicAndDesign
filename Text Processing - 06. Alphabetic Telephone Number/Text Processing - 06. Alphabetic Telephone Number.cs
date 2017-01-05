/*
6. Alphabetic Telephone Number Translator
Many companies use telephone numbers like 555-GET-FOOD so the number is
easier for their customers to remember. On a standard telephone, the alphabetic
letters are mapped to numbers in the following fashion:
A, B, and C = 2
D, E, and F = 3
G, H, and I = 4
J, K, and L = 5
M, N, and O = 6
P, Q, R, and S = 7
T, U, and V = 8
W, X, Y, and Z = 9
Design a program that asks the user to enter a 10-character telephone number in
the format XXX-XXX-XXXX. The program should display the telephone number
with any alphabetic characters that appeared in the original translated to their numeric equivalent. For example, if the user enters 555-GET-FOOD the program
should display 555-438-3663.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processing___06.Alphabetic_Telephone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the telephone number:");
            var telNum = Console.ReadLine().ToUpper();

            for (int i = 0; i < telNum.Length; i++)
            {
                if (telNum[i] >= 'A' && telNum[i] <= 'C')
                {
                    telNum = telNum.Remove(i, 1);
                    telNum = telNum.Insert(i, "2");
                }
                else if (telNum[i] >= 'D' && telNum[i] <= 'F')
                {
                    telNum = telNum.Remove(i, 1);
                    telNum = telNum.Insert(i, "3");
                }
                else if (telNum[i] >= 'G' && telNum[i] <= 'I')
                {
                    telNum = telNum.Remove(i, 1);
                    telNum = telNum.Insert(i, "4");
                }
                else if (telNum[i] >= 'J' && telNum[i] <= 'L')
                {
                    telNum = telNum.Remove(i, 1);
                    telNum = telNum.Insert(i, "5");
                }
                else if (telNum[i] >= 'M' && telNum[i] <= 'O')
                {
                    telNum = telNum.Remove(i, 1);
                    telNum = telNum.Insert(i, "6");
                }
                else if (telNum[i] >= 'P' && telNum[i] <= 'S')
                {
                    telNum = telNum.Remove(i, 1);
                    telNum = telNum.Insert(i, "7");
                }
                else if (telNum[i] >= 'T' && telNum[i] <= 'V')
                {
                    telNum = telNum.Remove(i, 1);
                    telNum = telNum.Insert(i, "8");
                }
                  else if (telNum[i] >= 'W' && telNum[i] <= 'Z')
                {
                    telNum = telNum.Remove(i, 1);
                    telNum = telNum.Insert(i, "9");
                }
            }
            Console.WriteLine("The number is:");
            Console.WriteLine(telNum);
        }
    }
}
