/*
2. Sentence Capitalizer
Design a program that prompts the user to enter a string containing multiple sentences, and then displays the string with the first character of each sentence capitalized. For instance, if the user enters “hello. my name is Joe. what is your name?”
the program should display “Hello. My name is Joe. What is your name?” (Hint:
ThetoUpperlibrary function can be used to convert a single character to uppercase.)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processing___02.Sentence_Capitalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter multiple sentences on one line:");
            var sentences = Console.ReadLine();

            for (int i = 0; i < sentences.Length; i++)
            {
                if (i == 0)
                {
                    var letter = "" + Convert.ToChar(Convert.ToInt32(sentences[i] - 32)); // get the upper letter from the ASCII table
                    sentences = sentences.Remove(0, 1); // we have to assign the new instance of sentences
                    sentences = sentences.Insert(0, letter);
                    Console.WriteLine(letter);
                }
                if (sentences[i] == '.' || sentences[i] == '!' || sentences[i] == '?' && i != sentences.Length - 1)
                {
                    var letter = "" + Convert.ToChar(Convert.ToInt32(sentences[i + 2] - 32));
                    sentences = sentences.Remove(i + 2, 1);
                    sentences = sentences.Insert(i + 2, letter);
                    Console.WriteLine(letter);
                    
                    
                }
               
            }
            Console.WriteLine(sentences);

        }
    }
}
