using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processing___11.File_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\martin\Desktop\textEncrypted.txt");

            System.IO.StreamWriter decryptedText = 
            new System.IO.StreamWriter(@"C:\Users\martin\Desktop\textDecrypted.txt", true);

            foreach (string line in lines)
            {
                var sentence = "";
                for (int j = 0; j < line.Length; j++)
                {
                    sentence += Convert.ToChar(Convert.ToInt32(line[j] + 2));
                }
                Console.WriteLine(sentence);
                decryptedText.WriteLine(sentence);
            }

            decryptedText.Close(); // you must close the stream for the contents to be saved to the file
        }
    }
}
