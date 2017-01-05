/*
6. Phone Number Lookup
Recall that Programming Exercise 7 in Chapter 8 asked you to design a program
with two parallel arrays: a Stringarray named peopleand a Stringarray
named phoneNumbers. The program allows you to search for a person’s name in
the peoplearray. If the name is found, it displays that person’s phone number.
Modify the program so it uses the binary search algorithm instead of the sequential
search algorithm.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting___06.Phone_Number_Lookup
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var names = new string[] { "Deepjack", "Christina", "Aleah", "Tem", "Veselina", "Hale", "Chelle" };
            var phoneNums = new long[]
            {
                3598811713, 3598820312, 3598876523, 3598865312, 3598892333, 3598854228, 3598856765
            };

          
            for (int maxElement = names.Length - 1; maxElement >= 0; maxElement--)
            {
                for (int index = 0; index <= maxElement - 1; index++)
                {
                    if (names[index][0] > names[index + 1][0])
                    {
                        Swap(ref names[index], ref names[index + 1]);
                        SwapPhones(ref phoneNums[index], ref phoneNums[index + 1]);
                        // Console.WriteLine(string.Join("", golfScores));
                    }
                }
            }

            Console.WriteLine("Please enter the name you're looking for:");
            var name = Console.ReadLine();

            
            var first = 0;
            var last = names.Length - 1;
            var middle = 0;
            bool found = false;
            var pos = -1;

            while (found == false && first <= last)
            {
                middle = (first + last) / 2;

                if (names[middle].ToLower().Contains(name.ToLower()))
                {
                    found = true;
                    pos = middle;
                }
                else if (names[middle][0] > name[0])
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
                Console.WriteLine("{0} is not in the phonebook.", name);
            }
            else
            {
                Console.WriteLine("{0} -> {1}", name, phoneNums[pos]);
            }
            


        }
        static void Swap(ref string a, ref string b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        static void SwapPhones(ref long a, ref long b)
        {
            var temp = a;
            a = b;
            b = temp;
        }


    }
}
