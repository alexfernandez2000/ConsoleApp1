using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Medico: Personal
    {
        public List<Paciente>ListaPacientes { get; set; }
        public string Especialidad { get; set; }
        public int Muertes { get; set; }
        public Medico():base()
        {
            ListaPacientes = new List<Paciente>();
        }
        public override string ToString()
        {
            string pacientes = "";
            ListaPacientes.ForEach(x => pacientes += x.ToString());
            return base.ToString() + $"\n Personal Medico";
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
    }
}
