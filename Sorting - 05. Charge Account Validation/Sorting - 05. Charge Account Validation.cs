/*
5. Charge Account Validation
Recall that Programming Exercise 5 in Chapter 8 asked you to design a program
that asks the user to enter a charge account number. The program should determine whether the number is valid by comparing it to a list of valid charge account
numbers. Modify the program so it uses the binary search algorithm instead of the
sequential search algorithm.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting___05.Charge_Account_Validation
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] accounts = new long[]{ 5658845, 4520125, 7895122, 8777541, 8451277, 1302850,
                8080152, 4562555, 5552012, 5050552, 7825877, 1250255,
                1005231, 6545231, 3852085, 7576651, 7881200, 4581002 };

            var scan = 0;
            long unsortedValue = 0;


            for (int index = 1; index < accounts.Length; index++)
            {
                unsortedValue = accounts[index];
                scan = index;

                while (scan > 0 && accounts[scan - 1] > accounts[scan])
                {
                    Swap(ref accounts[scan - 1], ref accounts[scan]);
                    scan--;
                }
                accounts[scan] = unsortedValue;
            }
            Console.WriteLine("Please enter your account number:");
            var account = long.Parse(Console.ReadLine());

            
            var first = 0;
            var last = accounts.Length - 1;
            var middle = 0;
            bool found = false;
            var pos = -1;

            while (found == false && first <= last)
            {
                middle = (first + last) / 2;

                if (accounts[middle] == account)
                {
                    found = true;
                    pos = middle;
                }
                else if (accounts[middle] > account)
                {
                    last = middle - 1;
                }
                else
                {
                    first = middle + 1;
                }

            }
            if (pos == -1)
            {
                Console.WriteLine("Account {0} doesn't exist.", account);
            }
            else
            {
                Console.WriteLine("Account {0} verified.", account);
            }


        }
        static void Swap(ref long a, ref long b)
        {
            var temp = a;
            a = b;
            b = temp;
        }


    }
}