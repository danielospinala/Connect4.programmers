using System;

namespace FinalProject
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {


                Console.WriteLine("Do you want to play a new Game? 1 = Yes, 0 = No");
                int newGame = Int32.Parse(Console.ReadLine());

                if (newGame == 0)
                {
                    break;
                }

                Control newBoard = new Control();
                Player one = new Player();
                Player two = new Player();
                Console.WriteLine("Player 1 name: ");
                string name1 = Console.ReadLine();
                newBoard.SetPlayerName(one, name1);
                one.Simbol = 'O';
                Console.WriteLine("do you want to play again the Computer or a Person? 0= Person, 1 = Computer ");
                int Player2 = Int32.Parse(Console.ReadLine());
                if (Player2 == 0)
                {
                    Console.WriteLine("Player 2 name: ");
                    string name2 = Console.ReadLine();
                    newBoard.SetPlayerName(two, name2);
                    two.Simbol = 'X';
                }





                newBoard.autoPopulateBoard();
                string ans;
                do
                {
                    //Console.WriteLine($"Conect 4 Game. {newBoard.Player1name} Vs {newBoard.Player2name}");
                    Console.WriteLine($"Conect 4 Game.");
                    one.DisplayPlayer("Player 1");
                    two.DisplayPlayer("Player 2");

                    newBoard.displayBoard();


                    if (newBoard.myTurn == true)
                    {
                        // Turno del Jugador uno
                        //one.;
                        Console.WriteLine($"{one.PlayerName}'s turn");
                        newBoard.whoIsThePlayer();
                        newBoard.changeTurn();
                    }
                    else
                    {
                        Console.WriteLine($"{two.PlayerName}'s turn");
                        //two
                        newBoard.whoIsThePlayer();
                        newBoard.changeTurn();
                    }

                    
                    Console.WriteLine("\nPlease Enter a column number:");
                    int ColNumber=int.Parse(Console.ReadLine());
                    newBoard.FilloutBoard(ColNumber, one.Simbol);
                    newBoard.displayBoard();




                    ans = Console.ReadLine();
                    if (ans == "exit")
                    {
                        break;

                    }


                    Console.Clear();

                } while (true);
            } while (true);
        }
    }
}
