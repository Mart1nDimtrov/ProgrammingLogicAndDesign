using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___11.Rock__Paper__Scissors_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                var computerChoice = random.Next(1, 4);
                
                var computer = "";
                if (computerChoice == 1)
                {
                    computer = "rock";
                }
                else if (computerChoice == 2)
                {
                    computer = "paper";
                }
                else if (computerChoice == 3)
                {
                    computer = "scissors";
                }

                Console.WriteLine("Make your choice:");
                var choice = Console.ReadLine();
                Console.WriteLine("The computer's choice is {0}!", computer);
                var result = compareChoices(computer, choice);
                Console.WriteLine(result);
                if (result != "You'll have to play again!")
                {
                    break;
                }
            }
          


        }
        static string compareChoices (string computer, string choice)
        {
            var result = "";
            if (choice.ToLower() == computer)
            {
                result = "You'll have to play again!";
            }
            else if (choice.ToLower() == "rock" && computer == "scissors")
            {
                result = "You win!";
            }
        
            else if (choice.ToLower() == "scissors" && computer == "rock")
            {
                result = "You lose!";
            }
            else if (choice.ToLower() == "scissors" && computer == "paper")
            {
                result = "You lose!";
            }
            else if (choice.ToLower() == "paper" && computer == "scissors")
            {
                result = "You win!";
            }
            else if (choice.ToLower() == "paper" && computer == "rock")
            {
                result = "You win!";
            }
            else if (choice.ToLower() == "rock" && computer == "paper")
            {
                result = "You lose!";
            }

            return result;
        }

    }
}
