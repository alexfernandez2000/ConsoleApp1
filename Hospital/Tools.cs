using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Baraja
{
    internal class Tools
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\bbddTemporal.txt";
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
        public static object LoadObject<T>()
        {
            if (File.Exists(_path))
            {
                string jsonString = File.ReadAllText(_path);
                return JsonSerializer.Deserialize<T>(jsonString);
            }

            return null;
        }
        public static void SaveObject<T>(T objects)
        {
            string jsonString = JsonSerializer.Serialize(objects);
            File.WriteAllText(_path, jsonString);
        }
    }
}
