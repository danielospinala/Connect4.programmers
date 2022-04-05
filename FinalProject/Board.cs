using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class BoardConnect4
    {
        public List<Player> PlayerList = new List<Player>();
        public Player currentPlayer;

        public char[,] Board { get; set; }
        public BoardConnect4()
        {

            Board = new char[6, 7];
        }


        public void autoPopulateBoard()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Board[i, j] = '#';
                }
            }
        }


        public void displayBoard()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write(" | ");
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(Board[i, j]);
                    Console.Write(' ');
                }
                Console.Write("| ");
                Console.WriteLine();
            }
            Console.WriteLine(" | 1 2 3 4 5 6 7 |");
        }


        public bool FilloutBoard(int col, char simbol)
        {
            bool status = false;
            for (int row = 5; row >= 0; row--)
            {
                if (Board[row, col - 1] == '#')
                {
                    Board[row, col - 1] = simbol;
                    status = true;
                    break;
                }
            }
            return status;
        }


        public void ChangeTurn(int PlayerID)
        {
            if (PlayerID == 0)
                currentPlayer = PlayerList[1];
            else
                currentPlayer = PlayerList[0];
        }


        public bool CheckWinner(char symbol)
        {
            bool result = false;

            bool HR_result = false;
            bool VR_result = false;
            bool DG_result = false;

            HR_result = CheckWinnerHorizentally(symbol);
            VR_result = CheckWinnerVertically(symbol);
            DG_result = CheckWinnerDiagonlly(symbol);

            if (HR_result || VR_result || DG_result)
                result = true;

            return result;
        }


        public bool CheckWinnerHorizentally(char symbol)
        {
           int count = 0;

            for (int row = 5; row >= 0; row--)
            {
                count = 0;
                for (int col = 6; col >= 0; col--)
                {
                    if (Board[row, col] == symbol)
                    {
                        count++;
                        if (count >= 4)
                        {
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

            return false;
        }


        public bool CheckWinnerVertically(char symbol)
        {
            int count = 0;

            for (int col = 6; col >= 0; col--)
            {
                count = 0;
                for (int row = 5; row >= 0; row--)
                {
                    if (Board[row, col] == symbol)
                    {
                        count++;
                        if (count >= 4)
                        {
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

            return false;
        }


        public bool CheckWinnerDiagonlly(char symbol)
        {
            int count = 0;

            //for (int row = 0; row < 6; row++)
            //{
            //    count = 0;
            //    for (int col = 6; col >= 0; col--)
            //    {
            //        if (Board[row, col] == symbol)
            //        {
            //            count++;
            //            if (count >= 4)
            //            {
            //                return true;
            //            }
            //            else
            //            {
            //                continue;
            //            }
            //        }
            //        else
            //        {
            //            count = 0;
            //        }
            //    }
            //}

            return false;
        }


    }

}

