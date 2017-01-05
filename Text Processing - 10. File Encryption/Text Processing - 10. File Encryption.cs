/*
10. File Encryption
File encryption is the science of writing the contents of a file in a secret code. For
this assignment you will design a program that opens a file and encrypts its contents. Assume the file that you are encrypting contains a list of strings. 
The program should open the file and read its contents, one string at a time. As the
program reads a string from the file, it substitutes each character of the string for
an alternate character. It then writes the encoded string out to a second file. When
the program is finished, the second file will be a version of the first file, but written
in a secret code.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Processing___10.File_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\martin\Desktop\text.txt");

            System.IO.StreamWriter encryptedText =
            new System.IO.StreamWriter(@"C:\Users\martin\Desktop\textEncrypted.txt", true);

            foreach (string line in lines)
            {
                var sentence = "";
                for (int j = 0; j < line.Length; j++)
                {
                    sentence += Convert.ToChar(Convert.ToInt32(line[j] - 2));
                }
                Console.WriteLine(sentence);
                encryptedText.WriteLine(sentence);
            }

            encryptedText.Close(); // you must close the stream for the contents to be saved to the file

        }
    }
}
