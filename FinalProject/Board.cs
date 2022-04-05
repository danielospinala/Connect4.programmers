using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class BoardConnect4
    {

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

        public bool winner(Player name, char simbol)
        {
            int count;
            bool Horizontal()
            {
                for (int i = 0; i < 6; i++)
                {
                    count = 0;
                    for (int j = 0; j < 6; j++)
                    {
                        if (Board[i, j] == simbol)
                        {
                            count++;
                            if (count == 4) return true;
                        }
                    }

                }
                return true;
            }

            if (Horizontal() /*|| Vertical() || Diagonal()*/)
            {
                return true;
            }
            else
            {
                return false;
            }





        }

        public bool FilloutBoard(int col, char simbol)
        {
            bool status = false;
            for (int row = 5; row >= 0; row--)
            {
                if (Board[row, col-1] == '#')
                {
                    Board[row, col-1] = simbol;
                    status = true;
                    break;
                }

            }
            return status;
        }


    }

}

