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
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string CodigoPostal { get; set; }
        public Persona()
        {
            Name=Tools.ReadConsoleWord("Nombre de la persona: ");
            Telefono = Tools.GetRandomInt(1000000000, 999999999).ToString();
            CorreoElectronico = $"{Name}@hotmail.com";
            CodigoPostal= Tools.GetRandomInt(10000, 99999).ToString();
        }
        public override string ToString()
        {
            return $"Humano llamado {Name}";
        }

    }
}
