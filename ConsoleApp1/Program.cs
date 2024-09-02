using System;
using System.Globalization;

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
3: Palindrome");
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
                    eCompare comparation = CompareDate(date, dateToComparte);
                    if (comparation == eCompare.IsBigger)
                        Console.WriteLine($"Date {date} is bigger than {dateToComparte}");
                    else if (comparation == eCompare.IsLower)
                        Console.WriteLine($"Date {date} is lower than {dateToComparte}");
                    else if (comparation == eCompare.IsEquals)
                        Console.WriteLine($"Date {date} is equals than {dateToComparte}");
                }
            }
        }
        private static eCompare CompareDate(DateTime date, DateTime dateToCompare)
        {
            eCompare result = CompareInt(date.Year, dateToCompare.Year);

            if (result == eCompare.IsEquals)
            {
                result = CompareInt(date.Month, dateToCompare.Month);
                if (result == eCompare.IsEquals)
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
        public enum eCompare
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
        private static eCompare CompareInt(int value, int valueToCompare)
        {
            if (value > valueToCompare)
                return eCompare.IsBigger;
            else
            {
                if (value == valueToCompare)
                    return eCompare.IsEquals;
                else
                    return eCompare.IsLower;
            }
        }

        #endregion
    }
}