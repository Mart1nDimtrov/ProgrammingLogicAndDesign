using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processing___09.Morse_Code_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            var punctuation = new string[] { "space", "--..--", ".-.-.-", "..--.." };
            var numbers = new string[] {  "-----",
             ".----",  "..---",  "...--",  "....-",
     ".....", "-....",  "--...",  "---..",
     "----." };
            var morse = new string [] {
        ".-", //morse code of letter A
        "-...", //morse code of letter B
        "-.-." , //morse code of letter C
        "-.." , //morse code of letter D
        "." , //morse code of letter E
        "..-." , //morse code of letter F
        "--." , //morse code of letter G
        "...." , //morse code of letter H
        ".." , //morse code of letter I
        ".---" , //morse code of letter J
        "-.-" , //morse code of letter K
        ".-.." , //morse code of letter L
        "--" , //morse code of letter M
        "-." , //morse code of letter N
        "---" , //morse code of letter O
        ".--." , //morse code of letter P
        "--.-" , //morse code of letter Q
        ".-." , //morse code of letter R
        "..." , //morse code of letter S
        "-" , //morse code of letter T
        "..-" , //morse code of letter U
        "...-" , //morse code of letter V
        ".--" ,  //morse code of letter W
        "-..-" ,  //morse code of letter X
        "-.--" , //morse code of letter Y
        "--.." //morse code of letter Z
    };
    
            Console.WriteLine("Please enter a message to be converted into morse:");
            var message = Console.ReadLine().ToUpper();
            var messageConverted = "";
           
            for (int i = 0; i < message.Length; i++)
            {
                if (Char.IsLetter(message[i]))
                {
                    var index = Convert.ToInt32(message[i]) - 65;
                    messageConverted += morse[index];
                }
                else if (Char.IsDigit(message[i]))
                {
                    var index = Convert.ToInt32(message[i] - '0');
                    messageConverted += numbers[index];
                }
                else
                {
                    if (message[i] == ' ')
                    {
                        messageConverted += punctuation[0];
                    }
                    else if (message[i] == ',')
                    {
                        messageConverted += punctuation[1];
                    }
                    else if (message[i] == '.')
                    {
                        messageConverted += punctuation[2];
                    }
                    else if (message[i] == '?')
                    {
                        messageConverted += punctuation[3];
                    }
                }
            }
            Console.WriteLine("The message is:");
            Console.WriteLine(messageConverted);


        }
    }
}
