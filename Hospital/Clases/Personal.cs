using Baraja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModel
{
    abstract class Personal:Persona
    {
        public string Hospital {  get; set; }
        public string TelefonoTrabajo { get; set; }
        public int HorasTrabajadas { get; set; }
        public string Identificacion { get; set; }

        protected Personal():base()
        {
            Hospital = Tools.GenerarCadenaAleatoria(10);
            TelefonoTrabajo = Tools.GetRandomInt(100000000, 999999999).ToString();
            HorasTrabajadas = Tools.GetRandomInt(0,10);
            Identificacion = Tools.GenerarCadenaAleatoria(10);
        }

        public override void ModificarDatos()
        {
            base.ModificarDatos();
            Hospital= Tools.ReadConsoleWord("Nombre del hospital: ");
            Hospital = Tools.ReadConsoleWord("Telefono Trabajo: ");
            Hospital = Tools.ReadConsoleWord("Horas Trabajadas: ");
            Hospital = Tools.ReadConsoleWord("Identificacion: ");
        }
        public override string ToString()
        {
            return base.ToString()+$"\n Personal del hospital: {Hospital}";
        }
    }
}
