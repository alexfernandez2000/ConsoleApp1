using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Baraja
{
    public class Tools
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\bbddTemporal.txt";
        private static Random _random = new Random();

        public static Guid GetGuid()
        {
            while (true)
            {
                if (Guid.TryParse(ReadConsoleWord("Insert ID?"), out Guid result))
                    return result;
            }
        }
        public static bool GetBool()
        {
            while (true)
            {
                if (bool.TryParse(ReadConsoleWord("True o False?").ToLower(), out bool result))
                    return result;
            }
        }
        public static DateTime GetDate()
        {
            while (true)
            {
                if (DateTime.TryParseExact(ReadConsoleWord("Insert Date format dd/MM/yyyy HH:mm"), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                    return date;
            }
        }
        public static string GenerarCadenaAleatoria(int longitud)
        {
            // Conjunto de caracteres que se usarán para el nombre de usuario
            const string caracteres = "abcdefghijklmnopqrstuvwxyz0123456789";

            char[] resultado = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                resultado[i] = caracteres[_random.Next(caracteres.Length)];
            }

            return new string(resultado);
        }

        public static int GetRandomInt(int min,int max)
        {
            return _random.Next(min, max);
        }
        public static int GetInt(string? text=null)
        {
            while (true)
            {
                if (int.TryParse(ReadConsoleWord(text??"Insert number"), out int number))
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
