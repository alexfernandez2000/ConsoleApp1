using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Ficheros
{
    internal class Program
    {
       private static Dictionary<string,int>_teams=new Dictionary<string,int>();
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\teams.txt";
        static void Main(string[] args)
        {
            int option = -1;
            LoadTeams();
            while (option!=0)
            {
                Console.WriteLine(@"Opciones: 
1:Añadir equipo
2: Modificar puntuación
3: Eliminar equipo
4: Mostrar equipos
Otro: Salir");
                switch (GetInt())
                {
                    case 1:
                        CreateNewTeam();
                        SaveTeams();
                        break;
                    case 2:
                        UpdateTeam();
                        SaveTeams();
                        break;
                    case 3:
                        DeleteTeam();
                        SaveTeams();
                        break;
                    case 4:
                        ShowTeams();
                        break;
                        default:
                        option = 0;
                        break;
                }
            }
        }

        private static void ShowTeams()
        {
            foreach (var team in _teams)
                Console.WriteLine(team);
        }

        private static void DeleteTeam()
        {
            string teamName = ReadConsoleWord("Escriba el nombre del equipo a eliminar");

            if (_teams.ContainsKey(teamName))
                _teams.Remove(teamName);
            else
                Console.WriteLine("Team not found");
        }

        private static void UpdateTeam()
        {
            string teamName = ReadConsoleWord("Escriba el nombre del equipo a modificar");

            if (_teams.ContainsKey(teamName))
            {
                Console.WriteLine("Puntuación:");
                _teams[teamName] = GetInt();
            }
            else
                Console.WriteLine($"Team {teamName} not found");
        }

        private static void CreateNewTeam()
        {
            string teamName = ReadConsoleWord("Escribe nombre del equipo");
            Console.WriteLine("Puntuación:");
            int score = GetInt();

            _teams.Add(teamName,score);
        }
        private static string ReadConsoleWord(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
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
        private static void LoadTeams()
        {
            if (File.Exists(_path))
            {
                string jsonString = File.ReadAllText(_path);
                Dictionary<string, int> teams = JsonSerializer.Deserialize<Dictionary<string, int>>(jsonString);
                _teams = teams;
            }
        }
        private static void SaveTeams()
        {
            string jsonString = JsonSerializer.Serialize(_teams);
            File.WriteAllText(_path, jsonString);
        }
    }
}
