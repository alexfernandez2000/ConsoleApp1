﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Snake
{
    internal class Program
    {
        private const int _starterBodySize = 1;

        private enum eCellStatus
        {
            Empty,
            Head,
            Body,
            Fruit,
        }
        private static (int Column, int Line) _currentHeadPosition;

        private class Cell
        {
            public int Column { get; set; }
            public int Line { get; set; }
            public eCellStatus CellStatus { get; set; }

        }

        private static List<Cell> _snake = new List<Cell>();
        private static eCellStatus[,] _board = new eCellStatus[4, 4];
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            InsertSnake();
            GenerateFruit();
            bool? status = null;
            while (status == null)
            {
                ShowBoard();
                Movement();
                status = ProcessNewPosition();
                Console.Clear();
            }
            Console.WriteLine((bool)status ? "Congratulations you win" : "!!Congratulations you lose NOOOOOB!!");
            ShowBoard();
            Console.ReadKey();
        }

        private static void Movement()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                (int, int) oldHeadPosition = _currentHeadPosition;
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        _currentHeadPosition.Line--;
                        break;
                    case ConsoleKey.A:
                        _currentHeadPosition.Column--;
                        break;
                    case ConsoleKey.S:
                        _currentHeadPosition.Line++;
                        break;
                    case ConsoleKey.D:
                        _currentHeadPosition.Column++;
                        break;
                    default:
                        Console.WriteLine("Tecla no asignada.");
                        break;
                }

                if (_currentHeadPosition != oldHeadPosition)
                    break;

                Console.WriteLine("Invalid key, use wasd");
            }
        }

        private static bool? ProcessNewPosition()
        {
            try
            {
                switch (_board[_currentHeadPosition.Line, _currentHeadPosition.Column])
                {
                    case eCellStatus.Body:
                        return false;
                    case eCellStatus.Fruit:
                        AddBody();
                        MoveSnake();
                        if (Array.Exists(_board.Cast<eCellStatus>().ToArray(), x => x == eCellStatus.Empty))
                            GenerateFruit();
                        else
                            return true;
                        break;
                    default:
                        MoveSnake();
                        break;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                return false;
            }
            return null;
        }

        private static void GenerateFruit()
        {
            Random random = new Random();
            while (true)
            {
                int randomLine = random.Next(_board.GetLength(0));
                int randomColumn = random.Next(_board.GetLength(1));
                if (_board[randomLine, randomColumn] == eCellStatus.Empty)
                {
                    _board[randomLine, randomColumn] = eCellStatus.Fruit;
                    break;
                }
            }
        }

        private static void MoveSnake()
        {
            for (int i = _snake.Count - 1; i >= 0; i--)
            {
                Cell cell = _snake[i];
                (int Line, int Column) oldPosition = (cell.Line, cell.Column);
                if (cell.CellStatus == eCellStatus.Head)
                {
                    cell.Column = _currentHeadPosition.Column;
                    cell.Line = _currentHeadPosition.Line;
                }
                else
                {
                    cell.Column = _snake[i - 1].Column;
                    cell.Line = _snake[i - 1].Line;
                }
                _board[cell.Line, cell.Column] = cell.CellStatus;
                if (i == _snake.Count - 1 && (cell.Column != oldPosition.Column || cell.Line != oldPosition.Line))
                    _board[oldPosition.Line, oldPosition.Column] = eCellStatus.Empty;
            }
        }
        private static void AddBody()
        {
            Cell cell = new Cell();
            Cell tail = _snake.Last();

            cell.Column = tail.Column;
            cell.Line = tail.Line;
            cell.CellStatus = eCellStatus.Body;
            _snake.Add(cell);
        }

        private static void End(bool win)
        {
            Console.WriteLine(win ? "Congratulations you win" : "!!Congratulations you lose NOOOOOB!!");
        }
        private static void InsertSnake()
        {
            int startPosition = _board.GetLength(0) / 2;
            Cell cell = new Cell();

            _currentHeadPosition = (startPosition, startPosition);
            cell.CellStatus = eCellStatus.Head;
            cell.Line = _currentHeadPosition.Line;
            cell.Column = _currentHeadPosition.Column;
            _snake.Add(cell);
            _board[cell.Line, cell.Column] = cell.CellStatus;
            for (int i = 0; i < _starterBodySize; i++)
            {
                cell = new Cell();

                cell.CellStatus = eCellStatus.Body;
                cell.Line = _currentHeadPosition.Line + 1 + i;
                cell.Column = _currentHeadPosition.Column;
                _snake.Add(cell);
                _board[cell.Line, cell.Column] = cell.CellStatus;
            }
        }
        private static void ShowBoard()
        {
            ShowBoardLines();
            for (int line = 0; line < _board.GetLength(0); line++)
            {
                string stringLine = "";

                for (int column = 0; column < _board.GetLength(1); column++)
                {
                    switch (_board[line, column])
                    {
                        case eCellStatus.Empty:
                            stringLine += " ";
                            break;
                        case eCellStatus.Head:
                            stringLine += "D";
                            break;
                        case eCellStatus.Body:
                            stringLine += "=";
                            break;
                        case eCellStatus.Fruit:
                            stringLine += "F";
                            break;
                        default:
                            stringLine += " ";
                            break;
                    }
                }
                Console.WriteLine($"|{stringLine}|");
                ShowBoardLines();
            }
        }

        private static void ShowBoardLines()
        {
            for (int i = 0; i < _board.GetLength(0); i++)
                Console.Write("_");
            Console.WriteLine("__");
        }
    }
}
