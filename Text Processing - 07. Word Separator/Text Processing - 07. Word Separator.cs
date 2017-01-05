/*
7. Word Separator
Design a program that accepts as input a sentence in which all of the words are run
together, but the first character of each word is uppercase. Convert the sentence to
a string in which the words are separated by spaces and only the first word starts
with an uppercase letter. For example, the string “StopAndSmellTheRoses.” would
be converted to “Stop and smell the roses.” (Hint: ThetoLowerlibrary function
can be used to convert a single character to lowercase.)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processing___07.Word_Separator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = Console.ReadLine();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (i == 0) 
                {
                    // we skip the first word
                }
                else
                {
                    if (Char.IsUpper(sentence[i]))
                    {
                        var letter = Convert.ToChar(Convert.ToInt32(sentence[i]) + 32) + ""; // turn the letter to lower case
                                                                                             // using the ASCII table
                        sentence = sentence.Remove(i, 1);       // remove the upper case
                        sentence = sentence.Insert(i, letter); // insert the lower case
                        sentence = sentence.Insert(i, " "); 
                    }
                    
                }
            }

            Console.WriteLine();
            Console.WriteLine(sentence);
        }
    }
}
