using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{
    internal class Tools
    {
        public static int GetInt()
        {
            while (true)
            {
                if (int.TryParse(ReadConsoleWord("Insert number"), out int number))
                    return number;
                Console.WriteLine("Invalid number");
            }
        }
        public static string ReadConsoleWord(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

    }
}
