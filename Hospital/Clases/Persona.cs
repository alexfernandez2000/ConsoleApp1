using Baraja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModel
{
    abstract class Persona
    {
        public string Name { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public int Edad { get; set; }

        protected Persona()
        {
            Name=Tools.ReadConsoleWord("Nombre de la persona: ");
            Telefono = Tools.GetRandomInt(100000000, 999999999).ToString();
            CorreoElectronico = $"{Name}@hotmail.com";
            Edad= Tools.GetRandomInt(20,100);
        }

         public virtual void ModificarDatos()
        {
            Name = Tools.ReadConsoleWord("Nombre de la persona: ");
            Telefono = Tools.GetInt("Numero de telefono").ToString();
            CorreoElectronico = Tools.ReadConsoleWord("Correo electronico: ");
            Edad = Tools.GetInt("Edad: ");
        }
        public override string ToString()
        {
            return $@"
Humano llamado: {Name}
Edad: {Edad}
Telefono: {Telefono}
Correo Electronico: {CorreoElectronico}";
        }

    }
}
