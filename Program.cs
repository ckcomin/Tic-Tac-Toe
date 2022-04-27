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
            string player = next_player("");
            List<string> board = create_board();
            while  (!(has_winner(board, player) || is_a_draw(board)))
            {
                display_board(board);
                make_move(player,  board);
                player = next_player(player);
            }
            display_board(board);
            Console.WriteLine("Thanks for playing!");
        }

        static List<string> create_board()
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

        static void display_board(List<string> board)
        {
            Console.WriteLine();
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine();
        }
                
        static bool is_a_draw(List<string> board)
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
                
        static bool has_winner(List<string> board, string symbol)
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

        static void make_move(string player, List<string> board)
        {
            Console.Write($"{player}'s turn to choose a square (1-9): ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
                // square = int(input(f"{player}'s turn to choose a square (1-9): "))
            board[number - 1] = player;
        }

        static string next_player(string current)
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

        // if (__name__ == "__main__")
        // {
        //     main();
        // }
    }
}