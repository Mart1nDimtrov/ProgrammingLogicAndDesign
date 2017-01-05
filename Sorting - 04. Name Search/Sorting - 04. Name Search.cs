/*
4. Name Search
Modify the Sorted Namesprogram that you wrote for exercise #2 so it allows you
to search the array for a specific name.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting___04.Name_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the names to be sorted seperated by spaces:");
            var names = Console.ReadLine().Split(' ').ToArray();

            for (int maxElement = names.Length - 1; maxElement >= 0; maxElement--)
            {
                for (int index = 0; index <= maxElement - 1; index++)
                {
                    if (names[index][0] > names[index + 1][0])
                    {
                        Swap(ref names[index], ref names[index + 1]);
                        // Console.WriteLine(string.Join("", golfScores));
                    }
                }
            }

            Console.WriteLine("Please enter the name you're looking for:");
            var name = Console.ReadLine();

            var namePos = -1;
            var first = 0;
            var last = names.Length - 1;
            var middle = 0;
            bool found = false;
            var pos = -1;

            while (found == false && first <= last)
            {
                middle = (first + last) / 2;

                if (names[middle] == name)
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
                Console.WriteLine("{0} is not in the list.", name);
            }
            else
            {
                Console.WriteLine("{0} is in the list at position {1}", name, pos);
            }


        }
        static void Swap(ref string a, ref string b)
        {
            var temp = a;
            a = b;
            b = temp;
        }


    }
}