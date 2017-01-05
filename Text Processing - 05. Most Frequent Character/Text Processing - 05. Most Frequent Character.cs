/*
5. Most Frequent Character
Design a program that prompts the user to enter a string, and displays the character
that appears most frequently in the string.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processing___05.Most_Frequent_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            var sentence = Console.ReadLine().ToLower();
            var histogram = new int[26];

            for (int i = 0; i < sentence.Length; i++)
            {
                if (Char.IsLetter(sentence[i]))
                {
                    histogram[Convert.ToInt32(sentence[i] - 'a')]++;
                }
            }
            //  Console.WriteLine(string.Join(" ", histogram));
            var mostCommon = histogram.Max(); // get the count of the most common letter
            int index = Array.IndexOf(histogram, mostCommon); // get the index of MCL in the array
            var bestLetter = Convert.ToChar(index + 'a'); // convert the index to char

            Console.WriteLine("The most common letter in the string is: {0}", bestLetter);


        }
    }
}
