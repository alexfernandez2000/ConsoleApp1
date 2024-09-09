using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        public enum eExercices
        {
            LowerCamelCase,
            DateComparation,
            Palindrome,
            Pow,
            EnterNumberDivision,
            WordComparer,
            TextInversor,
            TicTacToe,
            NumberInversor,
            FindTheNumber,
            EvenNumbers,
            DayOfWeek
        }

        static void Main(string[] args)
        {
            string option;

            while (true)
            {
                option = ReadConsoleWord(@"Write the number of the exercice you want to execute:
0: Lower/camel case
1: Date comparation
2: Palindrome
3: Pow
4: Enter number division
5: Word comparer
6: Text Inversor
7: Tic Tac Toe
8: Number Inversor
9: Find the number
10: Even numbers
11: Day of week");
                switch ((eExercices)int.Parse(option))
                {
                    case eExercices.LowerCamelCase:
                        StartExerciceLowerCamelCase();
                        break;
                    case eExercices.DateComparation:
                        StartingCompareDataExercice();
                        break;
                    case eExercices.Palindrome:
                        StartingPalindromeExcercice();
                        break;
                    case eExercices.Pow:
                        CalculatePowExercice();
                        break;
                    case eExercices.EnterNumberDivision:
                        EnterNumberDivision();
                        break;
                    case eExercices.WordComparer:
                        WordComparer();
                        break;
                    case eExercices.TextInversor:
                        TextInversor();
                        break;
                    case eExercices.TicTacToe:
                        TikTakToe();
                        break;
                    case eExercices.NumberInversor:
                        NumberInversor();
                        break;
                    case eExercices.FindTheNumber:
                        FindTheNumber();
                        break;
                    case eExercices.EvenNumbers:
                        EvenNumbers();
                        break;
                    case eExercices.DayOfWeek:
                        DayOfWeek();
                        break;
                    default:
                        option = "end";
                        break;
                }
                if (option.Equals("end"))
                    break;

            }
        }
        private static void DayOfWeek()
        {
            while (true)
            {
                string option = ReadConsoleWord("Write the day of week or n to leave");
                if (option == "n") 
                    break;
                if (!Enum.TryParse(option, out eWeek day))
                    Console.WriteLine("Invalid option");
                else
                    Console.WriteLine($"Day: {day.ToString()} int result : {(int)day}");
            }
        }
        #region EvenNumbers
        private static void EvenNumbers()
        {
            EvenNumbersFor(20);
            EvenNumbersWhile(20);
            EvenNumbersDoWhile(20);
        }
        private static IEnumerable<int> EvenNumbersFor(int maxRange)
        {
            List<int> numbers = new List<int>();

            for (int index = 0; index < maxRange; index++)
                if (index % 2 == 0)
                    numbers.Add(index);

            return numbers;
        }
        private static IEnumerable<int> EvenNumbersWhile(int maxRange)
        {
            int count = 0;
            List<int> numbers = new List<int>();

            while (count < maxRange)
            {
                if (count % 2 == 0)
                    numbers.Add(count);
                count++;
            }

            return numbers;
        }
        private static IEnumerable<int> EvenNumbersDoWhile(int maxRange)
        {
            int count = 0;
            List<int> numbers = new List<int>();

            do
            {
                if (count % 2 == 0)
                    numbers.Add(count);
                count++;
            } while (count < maxRange);

            return numbers;
        }
        #endregion
        private static void FindTheNumber()
        {
            Random random = new Random();
            int winerNuber =random.Next(1,21);
            int insertedValue;

            while (true)
            {
                Console.WriteLine("Insert a value between 1 an 20");
                insertedValue = GetInt();
                if (insertedValue == winerNuber)
                {
                    Console.WriteLine("Congratulations you found the winner number.");
                    break;
                }
                else if (insertedValue > winerNuber)
                    Console.WriteLine("Your number is bigger than winner number");
                else
                    Console.WriteLine("Your number is lower than winner number");
            }
        }
        #region Number Inversor
        private static void NumberInversor()
        {
            int value;

            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;
                value = GetInt();
                Console.WriteLine($"Inverse value from {value} is {InverseNumber(value)}");
            }
        }
        private static int InverseNumber(int number)
        {
            int invertedNumber=0;
            int lastDigit;
            while (number>0)
            {
                lastDigit = number % 10;
                invertedNumber= invertedNumber * 10 + lastDigit;
                number = number / 10;
            }
            return invertedNumber;
        }
        #endregion
        #region TikTakToe

        //Las fichas de los jugadores se representan como una bool player donde true es jugador 1 y false es jugador 2
        private static bool?[,] board;
        private static void TikTakToe()
        {
            bool player = true;

            board = new bool?[4, 4];
            ShowBoard();
            while (true)
            {
                (int column,int line) tokenPosition = AskPosition();
                board[tokenPosition.line,tokenPosition.column] = player;
                ShowBoard();
                if (PlayerWin(player))
                {
                    ShowResult(player);
                    break;
                }
                if (IsDraw())
                {
                    ShowResult(null);
                    break;
                }
                player =!player;
            }
        }

        private static void ShowResult(bool? winner)
        {
            if (winner==null)
                Console.WriteLine("Draw");
            else if ((bool)winner)
                Console.WriteLine($"Player 1 win");
            else
                Console.WriteLine($"Player 2 win");
        }

        private static bool IsDraw()
        {
            for (int line = 0; line < board.GetLength(0); line++)
                for (int column = 0; column < board.GetLength(1); column++)
                    if (board[line, column] == null)
                        return false;
            return true;
        }


        private static bool PlayerWin(bool player)
        {
            if (!IsLineWin(player)&&!IsDiagonalWin(player))
                return false;
            return true;
        }

        private static bool IsDiagonalWin(bool player)
        {
            bool firstDiagonal = true; 
            bool secondDiagonal = true;
            int tableLenght = board.GetLength(0)-1;

            for (int line = 0; line < tableLenght+1; line++)
            {
                if (board[line, line] != player)
                    firstDiagonal = false;

                if (board[tableLenght - line,line]!=player)
                    secondDiagonal=false;
            }
            
            if (!firstDiagonal && !secondDiagonal)
                return false;
            return true;
        }

        private static bool IsLineWin(bool player)
        {
            bool isHorizontalWin;
            bool isVerticalWin;

            for (int line = 0; line < board.GetLength(0); line++)
            {
                 isHorizontalWin = true;
                 isVerticalWin = true;

                for (int column = 0; column < board.GetLength(1); column++)
                {
                    if (board[line, column] != player)
                    {
                        isHorizontalWin = false;
                    }
                    if (board[column, line] != player)
                    {
                        isVerticalWin = false;
                    }
                }
                if (isHorizontalWin || isVerticalWin)
                    return true;   
            }
            return false;
        }

        private static void ShowBoard()
        {
            string textBoard;
            ShowIntermediateLine(board.GetLength(0));
            for (int line = 0; line < board.GetLength(0); line++)
            {
                textBoard = "";
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    if (column==0)
                        textBoard += "|";
                    textBoard += board[line, column] == null ? " " : board[line, column] == true ? "O" : "X";
                    textBoard += "|";
                }
                Console.WriteLine(textBoard);
                ShowIntermediateLine(board.GetLength(0));
            }
        }

        private static void ShowIntermediateLine(int lenght)
        {
            for (int i = 0; i < lenght*2+1; i++)
                Console.Write("-");
            Console.WriteLine();
        }
        private static (int column, int line) AskPosition()
        {
            int column;
            int line;

            while (true)
            {
                Console.WriteLine("Insert column value");
                column = GetInt();
                Console.WriteLine("Insert line value");
                line = GetInt();
                if (IsInsideBoard(column, line) && board[line,column]==null)
                    return (column, line);
                Console.WriteLine("Invalid position");
            }
        }

        private static bool IsInsideBoard(int column,int line)
        {
            if ((board.GetLength(0) > line && line >= 0) && (board.GetLength(1) > column && column >= 0))
                return true;
            return false;
        }
        #endregion
        #region Text Inversion
        private static void TextInversor()
        {
            string word;

            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;
                word = ReadConsoleWord("Write a word");
                Console.WriteLine($@"Word : {word}
Inverted Word : {InverseText(word)}");

            }
        }

        private static string InverseText(string text)
        {
            string inversedText = "";

            foreach (char charecter in text)
            {
                inversedText = charecter + inversedText;
            }

            return inversedText;
        }

        #endregion
        #region Word Comparer
        private static void WordComparer()
        {
            string word;
            string comparedWord;

            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;
                
                word = ReadConsoleWord("Word to compare");
                comparedWord = ReadConsoleWord("Word to be compared");

                if (IsWordBiggerOrEqual(word,comparedWord))
                    Console.WriteLine($"Word {word} is bigger or equals than {comparedWord}");
                else
                    Console.WriteLine($"Word {comparedWord} is bigger than {word}");
            }
        }
        private static bool IsWordBiggerOrEqual(string word, string comparedWord)
        {
            if (word.Length <= comparedWord.Length) 
                return IsRangeWordBiggerOrEqual(word,comparedWord,word.Length);

            return !IsRangeWordBiggerOrEqual(word, comparedWord, comparedWord.Length);
        }

        private static bool IsRangeWordBiggerOrEqual(string word, string comparedWord,int range)
        {
            for (int i = 0; i < range; i++)
                if (word[i] > comparedWord[i])
                    return false;
            return true;
        }
        #endregion
        #region Enter number division
        private static void EnterNumberDivision()
        {
            int dividend;
            int divisior;

            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;
                else
                {
                    dividend = int.Parse(ReadConsoleWord("Insert dividend"));
                    divisior = int.Parse(ReadConsoleWord("Insert divisor"));
                    Console.WriteLine($"The result from the division {dividend} / {divisior} equals {EnterDivision(dividend,divisior)}");
                }
            }
        }
        private static int EnterDivision(int dividend, int divisor) 
        {
            int result=0;

            while (divisor <= dividend)
            {
                dividend = dividend - divisor;
                result++;
            }
            
            return result;
        }
        #endregion
        #region Calculate pow
        private static void CalculatePowExercice()
        {
            int number;
            int pow;
            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;
                Console.WriteLine("Write the base number.");
                number = GetInt();
                Console.WriteLine("Write the exponent value.");
                pow = GetInt();
                Console.WriteLine($"The number {number} to the pow of {pow} is {CalculatePow(number,pow)}");
            }
        }
        private static int CalculatePow(int number,int pow)
        {
            int result = 1;
            for (int index = 0; index < pow; index++)
                result=result*number;       
            return result;
        }
        #endregion
        #region Palindrome
        private static void StartingPalindromeExcercice()
        {
            string word;
            while (true)
            {
                if (ReadConsoleWord("Write n to leave or a different one to continue.") == "n")
                    break;
                else
                {
                    word = ReadConsoleWord("Insert word");
                    if (IsPalindrome(word))
                        Console.WriteLine($"Word: {word} is palindrome");
                    else
                        Console.WriteLine($"Word: {word} is not palindrome");

                }
            }
        }
        private static bool IsPalindrome(string word)
        {
            int startPosition=0;
            int lastPosition=word.Length-1;
            while (startPosition<lastPosition)
            {
                if (word[startPosition] == word[lastPosition])
                {
                    startPosition++;
                    lastPosition--;
                }
                else
                    return false;
            }
            return true;
        }
        #endregion
        #region DateComparation
        private static void StartingCompareDataExercice()
        {
            while (true)
            {
                if (ReadConsoleWord("Write n to leave or a different one to continue.") == "n")
                    break;
                else
                {
                    Console.WriteLine("Insert first date");
                    DateTime date = GetDate();
                    Console.WriteLine("Insert date to compare");
                    DateTime dateToComparte = GetDate();
                    ECompare comparation = CompareDate(date, dateToComparte);
                    if (comparation == ECompare.IsBigger)
                        Console.WriteLine($"Date {date} is bigger than {dateToComparte}");
                    else if (comparation == ECompare.IsLower)
                        Console.WriteLine($"Date {date} is lower than {dateToComparte}");
                    else if (comparation == ECompare.IsEquals)
                        Console.WriteLine($"Date {date} is equals than {dateToComparte}");
                }
            }
        }
        private static ECompare CompareDate(DateTime date, DateTime dateToCompare)
        {
            ECompare result = CompareInt(date.Year, dateToCompare.Year);

            if (result == ECompare.IsEquals)
            {
                result = CompareInt(date.Month, dateToCompare.Month);
                if (result == ECompare.IsEquals)
                    result = CompareInt(date.Day, dateToCompare.Day);
            }

            return result;
        }
        private static DateTime GetDate()
        {
            bool isValidDate = false;
            DateTime date = DateTime.MinValue;
            while (!isValidDate)
            {
                isValidDate = DateTime.TryParseExact(ReadConsoleWord("Insert Date format dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            }
            return date;
        }
        #endregion
        #region EjercicioLowerCamel
        private static void StartExerciceLowerCamelCase()
        {
            string camelOrLower;
            string convertedWord;
            bool end = true;
            while (end)
            {
                Console.WriteLine("Escriba una palabra o end para finalizar");
                string word = Console.ReadLine();
                if (word != "end")
                {
                    Console.WriteLine("Escriba c para CamelCase otro caracter para LowerCase");
                    camelOrLower = Console.ReadLine();
                    if (camelOrLower == "c")
                        convertedWord = ConvertStringToCamelCase(word, true);
                    else
                        convertedWord = ConvertStringToCamelCase(word, false);
                    Console.WriteLine(convertedWord);
                }
                else
                    end = false;
            }
        }
        private static string ConvertStringToCamelCase(string word, bool isCamel)
        {
            bool isUppercase = false;
            string wordCamelCase = "";
            int index = 0;
            foreach (char charecter in word)
            {

                if (charecter == ' ')
                    isUppercase = true;
                else
                {
                    if (index == 0)
                    {
                        isUppercase = isCamel;
                    }
                    if (isUppercase)
                    {
                        wordCamelCase = wordCamelCase + char.ToUpper(charecter);
                        isUppercase = false;
                    }
                    else
                        wordCamelCase = wordCamelCase + char.ToLower(charecter);
                }
                index++;
            }
            return wordCamelCase;
        }
        #endregion
        #region Tools
        enum eWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        public enum ECompare
        {
            IsLower=1,
            IsBigger=2,
            IsEquals=0
        }
        private static string ReadConsoleWord(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
        private static ECompare CompareInt(int value, int valueToCompare)
        {
            if (value > valueToCompare)
                return ECompare.IsBigger;
            else
            {
                if (value == valueToCompare)
                    return ECompare.IsEquals;
                else
                    return ECompare.IsLower;
            }
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