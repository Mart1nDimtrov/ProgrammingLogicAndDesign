/*
8. Pig Latin
Design a program that reads a sentence as input and converts each word to “Pig
Latin.” In one version of Pig Latin you convert a word by removing the first letter,
placing that letter at the end of the word, and then appending “ay” to the word.
Here is an example:
English:  I SLEPT MOST OF THE NIGHT
Pig Latin:  IAY LEPTSAY OSTMAY FOAY HETAY IGHTNAY
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processing___08.Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence to be converted to 'Pig Latin':");
            var sentence = Console.ReadLine().ToUpper() + " ";
            
            var letter = sentence[0] + "";
            sentence = sentence.Remove(0, 1);
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    if (i == sentence.Length - 1)
                    {
                        sentence = sentence.Insert(i, letter + "AY");
                        break;
                    }
                    else
                    {
                        var temp = sentence[i + 1] + "";
                        sentence = sentence.Remove(i + 1, 1);
                        sentence = sentence.Insert(i, letter + "AY");
                        letter = temp;
                        i += 3; // update the index
                    }
                   
                }
                Console.WriteLine(sentence);
            }


            Console.WriteLine(sentence);
        }
    }
}
