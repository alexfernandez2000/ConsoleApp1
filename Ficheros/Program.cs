using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros
{
    internal class Program
    {
        Dictionary<string,int>_teams=new Dictionary<string,int>();
        static void Main(string[] args)
        {
            while (true)
            {
                switch (expression)
                {
                    
                }
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

    }
}
