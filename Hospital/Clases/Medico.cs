using System;
using System.Collections.Generic;
using System.Linq;
using Baraja;
using Hospital.Clases;

namespace Hospital
{
    internal class Medico: Personal
    {
        public List<Paciente>ListaPacientes { get; set; }
        public List<Cita>ListaCitas { get; set; }
        public List<Cita> HistorialCitas { get; set; }
        public string Especialidad { get; set; }
        public int Muertes { get; set; }
        public Medico():base()
        {
            HistorialCitas = new List<Cita>();
            ListaPacientes = new List<Paciente>();
            ListaCitas = new List<Cita>();
            Especialidad = Tools.GenerarCadenaAleatoria(10);
            Muertes = Tools.GetRandomInt(0, 10);
        }
        public override void ModificarDatos()
        {
            base.ModificarDatos();
            Muertes = Tools.GetInt("Numero de muertes: ");
            Especialidad = Tools.ReadConsoleWord("Especialidad: ");
        }
        public bool AltaPaciente(Paciente paciente)
        {
            if (ListaPacientes.Contains(paciente))
            {
                Console.WriteLine($"No se ha podido dar de alta el paciente{paciente.Name} ya que ya figura como paciente");
                return false;
            }
            ListaPacientes.Add(paciente);
            paciente.Medico = this;
            return true;
        }
        public bool BajaPaciente(Paciente paciente)
        {
            if (ListaPacientes.Remove(paciente))
            {
             Console.WriteLine($"Paciente {paciente.Name} ha sido dado de baja");
             return true;
            }
            Console.WriteLine($"No se ha podido dar de baja al paciente {paciente.Name} debido a que no esta en la lista.");
            return false;
        }

        public string GetListaPacientes()
        {
            string pacientes = "";
            ListaPacientes.ForEach(x => pacientes += "\nPaciente: "+x.Name);
            pacientes = $@"Lista de pacientes:
            {pacientes}";
            return pacientes;
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
                cita.ModficarCita(Tools.GetDate(), Tools.GetBool());
            else
                cita.CancelarCita();
        }
        public override string ToString()
        {
            string pacientes = "";
            ListaPacientes.ForEach(x => pacientes += x.ToString());
            return base.ToString() + $"\n Personal Medico";
        }

    }
}
