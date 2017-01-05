/*
7. Phone Number Lookup
Design a program that has two parallel arrays: a Stringarray named people
that is initialized with the names of seven of your friends, and a Stringarray 
named phoneNumbersthat is initialized with your friends’ phone numbers. The
program should allow the user to enter a person’s name (or part of a person’s
name). It should then search for that person in the peoplearray. If the person is
found, it should get that person’s phone number from the phoneNumbersarray
and display it. If the person is not found in the peoplearray, the program should
display a message indicating so.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___07.Phone_Number_Lookup
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 7;
            var names = new string[] { "Deepjack", "Christina", "Aleah", "Tem", "Veselina", "Hale", "Chelle" };
            var phoneNums = new long[]
            {
                3598811713, 3598820312, 3598876523, 3598865312, 3598892333, 3598854228, 3598856765
            };

            Console.WriteLine("Please enter the person's name:");
            var name = Console.ReadLine();
            var found = false;
            for (int i = 0; i < length; i++)
            {
                if (names[i].ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine("The number of {0} is: +{1}", name, phoneNums[i]);
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("The contact doesn't exis.");
            }
        }
    }
}
