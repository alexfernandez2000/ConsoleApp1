using Baraja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Persona
    {
        public string Name { get; set; }
        public Persona()
        {
            Name=Tools.ReadConsoleWord("Nombre de la persona: ");
        }
        public override string ToString()
        {
            return $"Humano llamado {Name}";
        }

    }
}
