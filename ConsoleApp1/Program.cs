using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;

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
6: Word comparer");
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
        #region Word Comparer
        private static void WordComparer()
        {
            while (true)
            {
                if (ReadConsoleWord("Continue? Insert n to leave") == "n")
                    break;
                else
                {
                    string word = ReadConsoleWord("Word to compare");
                    string comparedWord = ReadConsoleWord("Word to be compared");
                    if (CompareWords(word,comparedWord))
                        Console.WriteLine($"Word {word} is bigger or equals than {comparedWord}");
                    else
                        Console.WriteLine($"Word {comparedWord} is bigger than {word}");
                }
            }
        }
        private static bool CompareWords(string word, string comparedWord)
        {
            //Tiene en cuenta si es mayuscula o minuscula.
                for (int index = 0; index < word.Length; index++)
                {
                    if (word[index] > comparedWord[index])
                        return false;
                }
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
                else
                {
                    int number = int.Parse(ReadConsoleWord("Write the number you want to pow."));
                    int pow = int.Parse(ReadConsoleWord("Write the pow value"));
                    Console.WriteLine($"The number {number} to the pow of {pow} is {calculatePow(number,pow)}");
                }
            }
        }
        private static int calculatePow(int number,int pow)
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
                    @bool comparation = CompareDate(date, dateToComparte);
                    if (comparation == @bool.IsBigger)
                        Console.WriteLine($"Date {date} is bigger than {dateToComparte}");
                    else if (comparation == @bool.IsLower)
                        Console.WriteLine($"Date {date} is lower than {dateToComparte}");
                    else if (comparation == @bool.IsEquals)
                        Console.WriteLine($"Date {date} is equals than {dateToComparte}");
                }
            }
        }
        private static @bool CompareDate(DateTime date, DateTime dateToCompare)
        {
            @bool result = CompareInt(date.Year, dateToCompare.Year);

            if (result == @bool.IsEquals)
            {
                result = CompareInt(date.Month, dateToCompare.Month);
                if (result == @bool.IsEquals)
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
        public enum @bool
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
        private static @bool CompareInt(int value, int valueToCompare)
        {
            if (value > valueToCompare)
                return @bool.IsBigger;
            else
            {
                if (value == valueToCompare)
                    return @bool.IsEquals;
                else
                    return @bool.IsLower;
            }
        }

        #endregion
    }
}