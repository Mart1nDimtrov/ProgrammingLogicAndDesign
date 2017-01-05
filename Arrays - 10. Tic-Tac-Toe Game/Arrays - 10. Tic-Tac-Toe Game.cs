/*
10. Tic-Tac-Toe Game
Design a program that allows two players to play a game of tic-tac-toe. Use a twodimensional Stringarray with three rows and three columns as the game board.
Each element of the array should be initialized with an asterisk (*). The program
should run a loop that does the following:
a. Displays the contents of the board array.
b. Allows player 1 to select a location on the board for an X. The program 
should ask the user to enter the row and column number.
c. Allows player 2 to select a location on the board for an O. The program 
should ask the user to enter the row and column number.
d. Determines whether a player has won or if a tie has occurred. If a player has
won, the program should declare that player the winner and end. If a tie has 
occurred, the program should say so and end.
e. Player 1 wins when there are three Xs in a row on the game board. Player 2
wins when there are three Os in a row on the game board. The winning Xs or
Os can appear in a row, in a column, or diagonally across the board. A tie
occurs when all of the locations on the board are full, but there is no winner.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___10.Tic_Tac_Toe_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = new char []{ ',', ' ' };
            var rows = 3;
            var cols = 3;
            var matrix = new string[rows, cols];


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = "*";
                }
            }

          

            while (true)
            {

                Console.WriteLine("Player 1 please enter the two coordinates seperated by commas:");
                var coordinatesPlayerOne = Console.ReadLine().Split(chars, StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToArray();
                var rowPlayerOne = coordinatesPlayerOne[0];
                var colPlayerOne = coordinatesPlayerOne[1];
                matrix[rowPlayerOne, colPlayerOne] = "X";

                if (
                    matrix[0, 1] == "X" && matrix[0, 2] == "X" && matrix[0, 0] == "X" ||
                     matrix[1, 1] == "X" && matrix[1, 2] == "X" && matrix[1, 0] == "X" ||
                      matrix[2, 1] == "X" && matrix[2, 2] == "X" && matrix[2, 0] == "X" ||
                      matrix[0, 0] == "X" && matrix[1, 0] == "X" && matrix[2, 0] == "X" ||
                      matrix[0, 1] == "X" && matrix[1, 1] == "X" && matrix[2, 1] == "X" ||
                       matrix[0, 2] == "X" && matrix[1, 2] == "X" && matrix[2, 2] == "X" ||
                       matrix[0, 0] == "X" && matrix[1, 1] == "X" && matrix[2, 2] == "X" || 
                        matrix[0, 2] == "X" && matrix[1, 1] == "X" && matrix[2, 0] == "X"
                    )
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Player One Wins!");
                    break;
                }

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }

                var count = 0;
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row, col] != "*")
                        {
                            count++;
                        }

                    }
                }

                if (count >= 9)
                {
                    Console.WriteLine("The game is a tie!");
                    break;
                }

                Console.WriteLine();

                Console.WriteLine("Player 2 one please enter the two coordinates seperated by commas:");
                var coordinatesPlayerTwo = Console.ReadLine().Split(chars, StringSplitOptions.RemoveEmptyEntries).
                     Select(int.Parse).ToArray();
                var rowPlayerTwo = coordinatesPlayerTwo[0];
                var colPlayerTwo = coordinatesPlayerTwo[1];
                matrix[rowPlayerTwo, colPlayerTwo] = "O";
                if (
                 matrix[0, 1] == "O" && matrix[0, 2] == "O" && matrix[0, 0] == "O" ||
                matrix[1, 1] == "O" && matrix[1, 2] == "O" && matrix[1, 0] == "O" ||
                matrix[2, 1] == "O" && matrix[2, 2] == "O" && matrix[2, 0] == "O" ||
                matrix[0, 0] == "O" && matrix[1, 0] == "O" && matrix[2, 0] == "O" ||
                matrix[0, 1] == "O" && matrix[1, 1] == "O" && matrix[2, 1] == "O" ||
                matrix[0, 2] == "O" && matrix[1, 2] == "O" && matrix[2, 2] == "O" ||
                matrix[0, 0] == "O" && matrix[1, 1] == "O" && matrix[2, 2] == "O" ||
                matrix[0, 2] == "O" && matrix[1, 1] == "O" && matrix[2, 0] == "O" 
                    )
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Player Two Wins!");
                    break;
                }

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                
              
            }
        
        }
    }
}
