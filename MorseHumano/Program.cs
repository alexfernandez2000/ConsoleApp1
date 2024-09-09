using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseHumano
{
    internal class Program
    {
       public static Dictionary<string, char> morseToChar = new Dictionary<string, char>
        {
            { ".-", 'A' },      { "-...", 'B' },   { "-.-.", 'C' },  { "-..", 'D' },
            { ".", 'E' },       { "..-.", 'F' },   { "--.", 'G' },   { "....", 'H' },
            { "..", 'I' },      { ".---", 'J' },   { "-.-", 'K' },   { ".-..", 'L' },
            { "--", 'M' },      { "-.", 'N' },     { "---", 'O' },   { ".--.", 'P' },
            { "--.-", 'Q' },    { ".-.", 'R' },    { "...", 'S' },   { "-", 'T' },
            { "..-", 'U' },     { "...-", 'V' },   { ".--", 'W' },   { "-..-", 'X' },
            { "-.--", 'Y' },    { "--..", 'Z' },   { "-----", '0' }, { ".----", '1' },
            { "..---", '2' },   { "...--", '3' },  { "....-", '4' }, { ".....", '5' },
            { "-....", '6' },   { "--...", '7' },  { "---..", '8' }, { "----.", '9' },
            { ".-.-.-", '.' },  { "--..--", ',' }, { "..--..", '?' },{ ".----.", '\'' },
            { "-.-.--", '!' },  { "-..-.", '/' },  { "-.--.", '(' }, { "-.--.-", ')' },
            { ".-...", '&' },   { "---...", ':' }, { "-.-.-.", ';' },{ "-...-", '=' },
            { ".-.-.", '+' },   { "-....-", '-' }, { "..--.-", '_' }, { ".-..-.", '"' },
            { "...-..-", '$' }, { ".--.-.", '@' },
            { "/", ' ' },
        };

        public static Dictionary<string, int> test = new Dictionary<string, int>
            {{"1", 1}};
        static void Main(string[] args)
        {
            string word = "";
            string result = "";
            string option = "";
            while (true)
            {
                if (ReadConsoleWord("Continue? Write n to leave") == "n")
                    break;
                option = ReadConsoleWord(@"
1: Translate from human to morse.
2: From morse to human."); 
                word = ReadConsoleWord("Write a word to translate");
                switch (option)
                {
                    case "1": 
                        result=Translator(word,true);
                        break;
                    case "2":
                        result=Translator(word,false);
                        break;
                }
                Console.WriteLine(result);
            }
        }
        private static string Translator(string word,bool toMorse)
        {
            string translation = "";
            if (toMorse)
                foreach (char charecter in word)
                    translation += $"{morseToChar.Where(x => x.Value == char.ToUpper(charecter)).Select(x => x.Key).FirstOrDefault()} ";
            else
                foreach (string morseChar in word.Split(' '))
                    translation += $"{morseToChar.Where(x => x.Key == morseChar).Select(x => x.Value).FirstOrDefault()}";

            return translation;

        }
        private static string ReadConsoleWord(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

    }
}
