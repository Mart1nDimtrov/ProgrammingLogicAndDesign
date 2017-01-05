using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___10.Prime_Number_List
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; number++)
            {
                
                if (isPrime(number))
                {
                    Console.WriteLine("The number {0} is prime!", number);
                }
                else
                {
                    Console.WriteLine("The number {0} is not a prime!", number);
                }
            }
           

      
    }
    static bool isPrime(int number)
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
