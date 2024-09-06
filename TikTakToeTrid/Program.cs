using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToeTrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;
                TikTakToe();
            }

            
        }
        #region TikTakToe

        //Las fichas de los jugadores se representan como una bool player donde true es jugador 1 y false es jugador 2
        private static bool?[,,] board;
        private static void TikTakToe()
        {
            bool player = true;

            board = new bool?[3, 3, 3];
            while (true)
            {
                ShowTridimentionalBoard();
                (int layer,int column, int line) tokenPosition = AskPosition(player);
                board[tokenPosition.layer,tokenPosition.line, tokenPosition.column] = player;
                if (PlayerWin(player))
                {
                    ShowResult(player);
                    break;
                }
                //if (isDraw())
                //{
                //    ShowResult(null);
                //    break;
                //}
                player = !player;
            }
            ShowTridimentionalBoard();
        }

        private static void ShowResult(bool? winner)
        {
            if (winner == null)
                Console.WriteLine("Draw");
            else if ((bool)winner)
                Console.WriteLine($"Player 1 win");
            else
                Console.WriteLine($"Player 2 win");
        }

        //private static bool isDraw()
        //{
        //    for (int line = 0; line < board.GetLength(0); line++)
        //        for (int column = 0; column < board.GetLength(1); column++)
        //            if (board[line, column] == null)
        //                return false;
        //    return true;
        //}


        private static bool PlayerWin(bool player)
        {
            if (!IsLineWin(player) && !IsDiagonalWin(player))
                return false;
            return true;
        }

        private static bool IsDiagonalWin(bool player)
        {
            bool firstDiagonal = true;
            bool secondDiagonal = true;
            bool terceraDiagona = true;
            bool cuartaDiagonal = true;
            int tableLenght = board.GetLength(0) - 1;
            for (int layer = 0; layer < tableLenght+1; layer++)
            {
                for (int line = 0; line < tableLenght + 1; line++)
                {
                    if (board[layer,line, line] != player)
                        firstDiagonal = false;
                    if (board[layer,tableLenght - line, line] != player)
                        secondDiagonal = false;
                    if (board[line, tableLenght - line, layer] != player)
                        terceraDiagona = false;
                    if (board[line, line, layer] != player)
                        cuartaDiagonal = false;
                }

                if (firstDiagonal || secondDiagonal || terceraDiagona || cuartaDiagonal)
                    return true;
            }
            return false;
        }

        private static bool IsLineWin(bool player)
        {
            bool isHorizontalWin;
            bool isVerticalWin;
            bool isLayerWin;
            for (int layer = 0; layer < board.GetLength(0); layer++)
                for (int line = 0; line < board.GetLength(1); line++)
                {
                    isHorizontalWin = true;
                    isVerticalWin = true;
                    isLayerWin = true;
                    for (int column = 0; column < board.GetLength(2); column++)
                    {
                        if (board[layer,line, column] != player)
                        {
                            isHorizontalWin = false;
                        }
                        if (board[layer,column, line] != player)
                        {
                            isVerticalWin = false;
                        }
                        if (board[column, line, layer] != player)
                        {
                            isLayerWin = false;
                        }
                    }
                    if (isHorizontalWin || isVerticalWin || isLayerWin)
                        return true;
                }
            return false;
        }

        private static void ShowTridimentionalBoard()
        {
            int layerToShow=0;
            while (layerToShow != -1)
            {
                ShowBoard(layerToShow);
                while (true)
                {
                    Console.WriteLine("Insert layer to show or -1 to continue");
                    layerToShow = GetInt();
                    if (board.GetLength(0) > layerToShow && layerToShow >= 0 || layerToShow == -1)
                        break;
                    Console.WriteLine("Insert valid range");
                }
            }
        }
        private static void ShowBoard(int layer)
        {
            Console.WriteLine($"Layer: {layer}.");
            ShowIntermediateLine(board.GetLength(0));

            for (int line = 0; line < board.GetLength(0); line++)
            {
                string textBoard = "";
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    if (column == 0)
                        textBoard += "|";
                    textBoard += board[layer,line, column] == null ? " " : board[layer,line, column] == true ? "O" : "X";
                    textBoard += "|";
                }
                Console.WriteLine(textBoard);
                ShowIntermediateLine(board.GetLength(0));
            }
        }

        private static void ShowIntermediateLine(int lenght)
        {
            for (int i = 0; i < lenght * 2 + 1; i++)
                Console.Write("-");
            Console.WriteLine();
        }
        private static (int layer,int column, int line) AskPosition(bool player)
        {
            int column;
            int line;
            int layer;
            while (true)
            {
                Console.WriteLine("Turn player {0}", player ? 1 : 2);
                Console.WriteLine("Insert layer value");
                layer = GetInt();
                Console.WriteLine("Insert column value");
                column = GetInt();
                Console.WriteLine("Insert line value");
                line = GetInt();
                if (IsInsideBoard(layer,column, line) && board[layer,line, column] == null)
                    return (layer,column, line);
                Console.WriteLine("Invalid position");
            }
        }

        private static bool IsInsideBoard(int layer,int column, int line)
        {
            if ((board.GetLength(1) > line && line >= 0) && (board.GetLength(2) > column && column >= 0) && (board.GetLength(0) > layer && layer >= 0))
                return true;
            return false;
        }
        #endregion
        #region Tools
        public enum ECompare
        {
            IsLower = 1,
            IsBigger = 2,
            IsEquals = 0
        }
        private static string ReadConsoleWord(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
        private static int GetInt()
        {
            int number;
            while (true)
            {
                if (int.TryParse(ReadConsoleWord("Insert number"), out number))
                    return number;
                Console.WriteLine("Invalid number");
            }
        }

        #endregion

    }
}
