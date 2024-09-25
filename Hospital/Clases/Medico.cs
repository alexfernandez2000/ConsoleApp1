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
