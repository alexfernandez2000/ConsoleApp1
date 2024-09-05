using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            while (true)
            {
                option = ReadConsoleWord(@"Write the number of the exercice you want to execute:
1: Lower/camel case
2: Date comparation
3: Palindrome
4: Pow
5: Enter number division
6: Word comparer
7: Text Inversor
8: Tic Tac Toe
9: Number Inversor
10: Find the number
11: Even numbers");
                switch (option)
                {
                    case "1":
                        StartExerciceLowerCamelCase();
                        break;
                    case "2":
                        StartingCompareDataExercice();
                        break;
                    case "3":
                        StartingPalindromeExcercice();
                        break;
                    case "4":
                        CalculatePowExercice();
                        break;
                    case "5":
                        EnterNumberDivision();
                        break;
                    case "6":
                        WordComparer();
                        break;
                    case "7":
                        TextInversor();
                        break;
                    case "8":
                        TikTakToe();
                        break;
                    case "9":
                        NumberInversor();
                        break;
                    case "10":
                        FindTheNumber();
                        break;
                    case "11":
                        EvenNumbers();
                        break;
                    default:
                        option = "end";
                        break;
                }
                if (option.Equals("end"))
                {
                    break;
                }

            }
        }
        private static void EvenNumbers()
        {
            Console.WriteLine($"For result:{ EvenNumbersFor(20)}");
            Console.WriteLine($"While result:{EvenNumbersWhile(20)}");
            Console.WriteLine($"DoWhile result:{EvenNumbersDoWhile(20)}");
        }

        private static IEnumerable<int> EvenNumbersFor(int maxRange)
        {
            List<int> numbers = new List<int>();
            for (int index = 0; index < maxRange; index++)
                if (index%2==0)
                    numbers.Add(index);
            return numbers;
        }
        private static IEnumerable<int> EvenNumbersWhile(int maxRange)
        {
            int count=0;
            List<int> numbers = new List<int>();

            while (count<maxRange)
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

        #region EvenNumbers

        #endregion
        #region FindTheNumeber
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
            #endregion
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
        #region Tres en raya

        //Las fichas del los jugadores se representan como una bool player donde true es jugador 1 y false es jugador 2
        private static bool?[,] board;
        private static void TikTakToe()
        {
            board= new bool?[3,3];
            bool player = true;
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
                if (isDraw())
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

        private static bool isDraw()
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
            bool firstDiagona = true; 
            bool secondDiagonal = true;
            int tableLenght = board.GetLength(0)-1;
            for (int line = 0; line < tableLenght+1; line++)
            {
                if (board[line, line] != player)
                    firstDiagona = false;
                int result = tableLenght - line;
                if (board[tableLenght - line,line]!=player)
                    secondDiagonal=false;
            }
            
            if (!firstDiagona && !secondDiagonal)
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
            ShowIntermediateLine(board.GetLength(0));
            for (int line = 0; line < board.GetLength(0); line++)
            {
                string text = "";
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    if (column==0)
                        text += "|";
                    text += board[line, column] == null ? " " : board[line, column] == true ? "O" : "X";
                    text += "|";
                }
                Console.WriteLine(text);
                ShowIntermediateLine(board.GetLength(0));
            }
        }

        private static void ShowIntermediateLine(int lenght)
        {
            for (int i = 0; i < lenght*2+1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
        private static (int column, int line) AskPosition()
        {
            while (true)
            {
                Console.WriteLine("Insert column value");
                int column = GetInt();
                Console.WriteLine("Insert line value");
                int line = GetInt();
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
            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;

                string word = ReadConsoleWord("Write a word");
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
            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;
                
                string word = ReadConsoleWord("Word to compare");
                string comparedWord = ReadConsoleWord("Word to be compared");

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
            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;
                else
                {
                    int dividend = int.Parse(ReadConsoleWord("Insert dividend"));
                    int divisior = int.Parse(ReadConsoleWord("Insert divisor"));
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
            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;
                Console.WriteLine("Write the base number.");
                int number = GetInt();
                Console.WriteLine("Write the exponent value.");
                int pow = GetInt();
                Console.WriteLine($"The number {number} to the pow of {pow} is {CalculatePow(number,pow)}");
            }
        }
        private static int CalculatePow(int number,int pow)
        {
            int result = 1;
            for (int index = 0; index < pow; index++)
            {
                result=result*number;
            }        
            return result;
        }
        #endregion
        #region Palindrome
        private static void StartingPalindromeExcercice()
        {
            while (true)
            {
                if (ReadConsoleWord("Write n to leave or a different one to continue.") == "n")
                    break;
                else
                {
                    string word = ReadConsoleWord("Insert word");
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
            bool end = true;
            while (end)
            {
                Console.WriteLine("Escriba una palabra o end para finalizar");
                string word = Console.ReadLine();
                if (word != "end")
                {
                    Console.WriteLine("Escriba c para CamelCase otro caracter para LowerCase");
                    string camelOrLower = Console.ReadLine();
                    string convertedWord;
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
                        if (isCamel)
                            isUppercase = true;
                        else
                            isUppercase = false;

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
            while (true)
            {
                if (int.TryParse(ReadConsoleWord("Insert number"), out int number))
                    return number;
                Console.WriteLine("Invalid number");
            }
        }

        #endregion
    }
}