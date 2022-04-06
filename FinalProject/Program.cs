﻿using System;

namespace FinalProject
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Do you want to play a new Game? 1 = Yes, 0 = No");
                Console.Write("Your answer: ");
                int newGame = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Test");
                if (newGame == 0)
                {
                    break;
                }

                Control newBoard = new Control();
                Player one = new Player();
                Player two = new Player();

                // Set Player 1 Info
                Console.Write("Player 1 name: ");
                string name1 = Console.ReadLine();
                newBoard.SetPlayerInfo(one, 0, name1, "Player 1", 'O');

                //Set player1 for first player (Current Player)
                newBoard.currentPlayer = one;

                Console.WriteLine("do you want to play again the Computer or a Person? 0= Person, 1 = Computer ");
                Console.Write("Your answer: ");
                int Player2 = Int32.Parse(Console.ReadLine());
                if (Player2 == 0)
                {
                    //SetPlayer 2 Info
                    Console.Write("Player 2 name: ");
                    string name2 = Console.ReadLine();
                    newBoard.SetPlayerInfo(two, 1, name2, "Player 2", 'X');
                }

                // Add player inplayer list
                newBoard.PlayerList.Add(one);
                newBoard.PlayerList.Add(two);

                newBoard.autoPopulateBoard();
                string ans;

                do
                {
                    // Display game message
                    Console.WriteLine("\n-----------------------------------------");
                    Console.WriteLine($"Conect 4 Game. {one.Name} Vs {two.Name}");
                    Console.WriteLine("-----------------------------------------\n");
                    one.DisplayPlayer();
                    two.DisplayPlayer();
                    Console.WriteLine();

                    // Display Board
                    newBoard.displayBoard();

                    // Get player column number
                    Console.WriteLine($"\n( {newBoard.currentPlayer.Name} ) please Enter a column number for putting your symbol: ");
                    Console.Write("Your answer: ");
                    int ColNumber = int.Parse(Console.ReadLine());

                    // Putting player symbol and check right column
                    bool ActStatus = newBoard.FilloutBoard(ColNumber, newBoard.currentPlayer.Symbol);

                    // Add player action count
                    if (ActStatus == true)
                        newBoard.currentPlayer.ActCount++;
                    //else
                    //    Console.WriteLine("Please, enter number between 1 to 7");

                    // Checking current player winning status
                    bool result = false;
                    if (newBoard.currentPlayer.ActCount >= 4)
                    {
                        result = newBoard.CheckWinner(newBoard.currentPlayer.Symbol);
                        if (result == true)
                        {
                            Console.WriteLine(newBoard.currentPlayer.DisplayName + " is a winner!!!");
                            break;
                        }
                    }
                   
                    // Change Turn
                    newBoard.ChangeTurn(newBoard.currentPlayer.ID);

                    //Console.WriteLine("\nPress Enter for countiue or type exit for ending game !!!");
                    //Console.Write("Your answer: ");
                    //ans = Console.ReadLine();
                    //if (ans == "exit")
                    //{
                    //    break;
                    //}

                    // Clear Display
                    Console.Clear();
                    

                } while (true);

            } while (true);

        }
    }
}
