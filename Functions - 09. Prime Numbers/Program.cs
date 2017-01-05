using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___09.Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be checked:");
            var number = int.Parse(Console.ReadLine());
            if (isPrime(number))
            {
                Console.WriteLine("The number is prime!");
            }
            else
            {
                Console.WriteLine("The number is not a prime!");
            }

        }
        static bool isPrime (int number)
        {
            bool prime = true;
            for (int i = 1; i <= number; i++)
            {
                if (i != 1 && i != number && number % i == 0)
                {
                    prime = false;
                }
            }
            return prime;

        }
    }
}
