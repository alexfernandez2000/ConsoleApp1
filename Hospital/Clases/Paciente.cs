using Baraja;
using HospitalModel.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace HospitalModel
{
    public class Paciente:Persona
    {
        [Browsable(false)]
        public Medico Medico { get; set; }
        public List<Cita>ListaCitas { get; set; }
        public List<Cita> HistorialCitas { get; set; }

        public Paciente(Medico medico):base()
        {
            Medico = medico;
            HistorialCitas = new List<Cita>();
            ListaCitas = new List<Cita>();
        }
        public Paciente() : base()
        {
            HistorialCitas = new List<Cita>();
            ListaCitas = new List<Cita>();
        }
        public override string ToString()
        {
            return base.ToString() + $"Paciente del medico: {Medico.Name}";
        }
        public bool DarDeBaja()
        {
            return Medico.BajaPaciente(this);
        }

        public bool DarDeAlta(Medico medico)
        {
            return Medico.AltaPaciente(this);
        }
        public void ModificarCita()
        {
            Console.WriteLine("Listado de citas:");
            ListaCitas.ForEach(cita => Console.WriteLine($"{cita.ToString()}\n"));
            Console.WriteLine("Cita a modificar:");
            Guid id = Tools.GetGuid();
            Cita cita = ListaCitas.FirstOrDefault(c => c.Id == id);
            if (cita == null)
            {
                Console.WriteLine("Cita no encontrada");
                return;
            }
            Console.WriteLine("Desea modificarla(True) o cancelarla(False)");
            if (Tools.GetBool())
                cita.ModficarCita(Tools.GetDate(), Tools.GetBool(), Tools.ReadConsoleWord("Tratamiento:"), Tools.ReadConsoleWord("Diagnostico:"));
            else
                cita.CancelarCita();

        }
    }
}
