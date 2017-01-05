/*
5. Charge Account Validation
Design a program that asks the user to enter a charge account number. The program should determine whether the number is valid by comparing it to the following list of valid charge account numbers:
5658845 4520125 7895122 8777541 8451277 1302850
8080152 4562555 5552012 5050552 7825877 1250255
1005231 6545231 3852085 7576651 7881200 4581002
These numbers should be stored in an array. Use the sequential search algorithm to
locate the number entered by the user. If the number is in the array, the program
should display a message indicating the number is valid. If the number is not in the
array, the program should display a message indicating the number is invalid.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___05.Charge_Account_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int rows = 3;
            var cols = 6;
            long[][] accounts = new long[rows][]{new long[] { 5658845, 4520125, 7895122, 8777541, 8451277, 1302850 },
                new long[]{ 8080152, 4562555, 5552012, 5050552, 7825877, 1250255},
                new long[]{ 1005231, 6545231, 3852085, 7576651, 7881200, 4581002 } };

            Console.WriteLine("Please enter the account you're searcing for: ");
            var account = long.Parse(Console.ReadLine());
            var found = false;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (account == accounts[row][col])
                    {
                        found = true;
                    }
                }
            }

            if (found)
            {
                Console.WriteLine("The number {0} is valid.", account);
            }
            else
            {
                Console.WriteLine("The number {0} is not valid.", account);
            }
             
              


        }
    }
}
