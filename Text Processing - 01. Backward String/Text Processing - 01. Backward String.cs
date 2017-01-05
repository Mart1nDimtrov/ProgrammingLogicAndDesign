
/*
 1. Backward String
    Design a program that prompts the user to enter a string and then displays the
    string contents backward. For instance, if the user enters “gravity” the program
    should display “ytivarg.”
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processing___01.Backward_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            var word = Console.ReadLine();
            var wordReversed = ""; // create a new string to hold the characters

            for (int i = word.Length - 1; i >= 0; i--) // go through the string in reverse
            {
                wordReversed += word[i]; // get every letter in the new string
            }

            Console.WriteLine();
            Console.WriteLine(wordReversed);

            
        }
    }
}
