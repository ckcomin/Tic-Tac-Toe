// Tic-Tac-Toe
// Author: Caroline Comin

using System;
using System.Collections.Generic;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = NextPlayer("");
            List<string> board = CreateBoard();
            while  (!(HasWinner(board, player) || Draw(board)))
            {
                DisplayBoard(board);
                MakeMove(player,  board);
                player = NextPlayer(player);
            }
            DisplayBoard(board);
            Console.WriteLine("Thanks for playing!");
        }

        static List<string> CreateBoard()
        {
            List<string> board = new List<string>();
            // for (square in range(9))
            for (int square = 0; square < 10; square++)
            {
                // board.append(square + 1);
                string value = Convert.ToString(square + 1);
                board.Add(value);
            }
            return board;
        }

        static void DisplayBoard(List<string> board)
        {
            Console.WriteLine();
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine();
        }
                
        static bool Draw(List<string> board)
        {
            for (int square = 0; square < 10; square ++)
            {
                if (!(board[square] == "x" && board[square] == "o"))
                {
                    return false;
                }
            }
            return true;
        }
                
        static bool HasWinner(List<string> board, string symbol)
        {
            return (board[0] == symbol && board[1] == symbol && board[2] == symbol ||
                    board[3] == symbol && board[4] == symbol && board[5]== symbol ||
                    board[6] ==symbol && board[7] == symbol && board[8] == symbol ||
                    board[0] == symbol && board[3] == symbol && board[6] == symbol||
                    board[1] == symbol && board[4] == symbol && board[7] == symbol||
                    board[2] == symbol && board[5] == symbol && board[8] == symbol||
                    board[0] == symbol && board[4] == symbol && board[8] == symbol||
                    board[2] == symbol && board[4] == symbol && board[6]== symbol);
        }

        static void MakeMove(string player, List<string> board)
        {
            Console.Write($"{player}'s turn to choose a square (1-9): ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
                // square = int(input(f"{player}'s turn to choose a square (1-9): "))
            board[number - 1] = player;
        }
        
        static string NextPlayer(string current)
        {
            if (current == "" || current == "o")
            {
                return "x";
            }
            else 
            {
                return "o";
            }
        }
    }
}