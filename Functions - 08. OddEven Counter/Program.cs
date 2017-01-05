using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function___08.OddEven_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var oddCount = 0;
            var evenCount = 0;

            for (int i = 1; i <= 100; i++)
            {
                var randNum = random.Next(1, 1000);
                Console.WriteLine(randNum);
                if (oddEven(randNum))
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;    
                }
            }
            Console.WriteLine("{0} number are even.", evenCount);
            Console.WriteLine("{0} number are odd.", oddCount);
        }
        static bool oddEven (int number)
        {
            bool flag;
            if (number % 2 == 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;

        }
    }
}
