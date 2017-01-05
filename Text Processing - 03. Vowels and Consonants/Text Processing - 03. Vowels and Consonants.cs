/*
3. Vowels and Consonants
Design a program that prompts the user to enter a string. The program should then
display the number of vowels and the number of consonants in the string.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processing___03.Vowels_and_Consonants
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowels = new char [] { 'a', 'o', 'u', 'i', 'e' };
            var consonants = new List<char>();
            var vowelCount = 0;
            var consonantCount = 0;
            Console.WriteLine("Please enter a string:");
            var sentence = Console.ReadLine().ToLower();


            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!vowels.Contains(c) && Char.IsLetter(c))
                {
                    consonants.Add(c);
                }
               
            }

          //Console.WriteLine(string.Join(" ", consonants));

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    vowelCount++;
                }
                else if (consonants.Contains(sentence[i]))
                {
                    consonantCount++;
                }
            }

            Console.WriteLine("You have {0} vowels and {1} consonants.", vowelCount, consonantCount);

        }
    }
}
