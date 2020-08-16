using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class EightQueen
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Eight Queen problem....");
            int QueenCount = 8;
            int BoardSize = 8;
            PlaceQueensInBoard(QueenCount, BoardSize);
        }

        private static void PlaceQueensInBoard(int queenCount, int boardSize)
        {
            bool[,] Board = new bool[boardSize, boardSize];
            int placeQueens = 1;
            int totalPossiblity = 0;
            for (int x = 0; x < queenCount; x++)
                for (int y = 0; y < queenCount; y++)
                {
                    Board[x, y] = true;
                    for (int q = 1; q < queenCount ; q++)
                    {
                        for (int i = 0; i < boardSize; i++)
                            for (int j = 0; j < boardSize; j++)
                                if (PlaceQueenInSafeSquare(ref Board, i,j, boardSize))
                                {
                                    Board[i, j] = true;
                                    placeQueens++;
                                    goto foo;
                                }
                        foo:;
                    }
                    if (placeQueens == 8)
                    {
                        totalPossiblity++;
                        Console.WriteLine("Queens placed : " + placeQueens.ToString() + "\n\n");
                        DisplayQueens(Board, boardSize);
                    }
            placeQueens = 1;
                    Board = new bool[boardSize, boardSize];
                }
            Console.WriteLine("\n\n Total possiblities : " + totalPossiblity.ToString() + "\n\n");
        }

        private static void DisplayQueens(bool[,] board, int boardSize)
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                    if (board[i, j])
                        Console.Write("\t1");
                    else
                        Console.Write("\t0");
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("\n\n\n\n\n");
        }

        private static bool PlaceQueenInSafeSquare(ref bool[,] board, int posx, int posy, int size)
        {
            var cposx = posx;
            var cposy = posy;
            var rupx = 0;
            var rupy = 0;

            #region check row and col is safe
            for (int i = 0; i < size; i++)
                if (board[posx, i] || board[i, posy])
                    return false;
            #endregion
            #region check diagnal squares are safe

            #region check left lower diagnal squares are safe
            rupx = posx; rupy = posy;
                while (true)
                {
                    rupx--;rupy++;
                    if (rupx < 0 || rupy >= size)
                        break;
                    else
                        if (board[rupx, rupy])
                            return false;
                }
                #endregion
            #region check right upper diagnal squares are safe
            rupx = posx; rupy = posy;
            while (true)
            {
                rupx++; rupy--;
                if (rupx >= size || rupy < 0)
                    break;
                else
                    if (board[rupx, rupy])
                        return false;
            }
            #endregion
            #region check left upper diagnal squares are safe
            rupx = posx; rupy = posy;
            while (true)
            {
                rupx--; rupy--;
                if (rupx < 0 || rupy < 0)
                    break;
                else
                    if (board[rupx, rupy])
                        return false;
            }
            #endregion
            #region check right lower diagnal squares are safe
            rupx = posx; rupy = posy;
            while (true)
            {
                rupx++; rupy++;
                if (rupx >= size || rupy >= size)
                    break;
                else
                    if (board[rupx, rupy])
                        return false;
            }
        #endregion

            #endregion
            return true;

        }
    }
}
