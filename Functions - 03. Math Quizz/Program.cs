using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___03.Math_Quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var firstNum = random.Next(1, 1000);
            var secondNum = random.Next(1, 1000);

            Console.WriteLine("Guess what's the result of the equation:");
            Console.WriteLine(firstNum);
            Console.WriteLine("+ {0}", secondNum);
            Console.WriteLine(TestAnswer(firstNum, secondNum)); 



        }
        static string TestAnswer (int first, int second)
        {
            var answer = int.Parse(Console.ReadLine());
            var sum = first + second;
            var sumString = "Wrong! The correct answer is " + Convert.ToString(first + second);
            if (sum == answer)
            {
                return "Congratulations, your answer is correct!";
            }
            else
            {
                return sumString;
            }
        }
    }
}
