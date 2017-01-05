using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___12.Slot_Machine_Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = "";
            Random random = new Random();
            var sum = 0;
            var total = 0;

            do
            {
                Console.WriteLine("Enter the amount of money you want to insert:");
                var money = int.Parse(Console.ReadLine());
                var temp = "";
                var secondTemp = "";
                var countSymbols = 0;
                total += money;
                
                for (int i = 1; i <= 3; i++)
                {
                    var computerChoice = random.Next(1, 7);
                    var newChoice = NewSymbol(computerChoice);
                    Console.WriteLine(newChoice);
                    if (temp == newChoice || newChoice == secondTemp)
                    {
                        countSymbols++;

                    }
                    if (i == 1)
                    {
                        temp = newChoice;
                    }
                    if (i == 2)
                    {
                        secondTemp = newChoice;
                    }
                   
                  
                }
                if (countSymbols == 1)
                {
                    sum += money * 2;
                }
                else if (countSymbols == 2)
                {
                    sum += money * 3;
                }
                Console.WriteLine("Do you want to play again?");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            Console.WriteLine("The total amount you've entered is: {0}", total);
            Console.WriteLine("The amount you've won is: {0}", sum);
        }

       static string NewSymbol (int choice)
        {
            var symbol = "";
            if (choice == 1)
            {
                symbol = "cherrie";
            }
            else if (choice == 2)
            {
                symbol = "orange";
            }
            else if (choice == 3)
            {
                symbol = "plum";
            }
            else if (choice == 4)
            {
                symbol = "bell";
            }
            else if (choice == 5)
            {
                symbol = "melon";
            }
            else if (choice == 6)
            {
                symbol = "bar";
            }
            return symbol;
        }

    }
}
