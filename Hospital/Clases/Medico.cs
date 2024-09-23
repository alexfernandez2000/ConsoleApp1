using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Medico: Personal
    {
        public List<Paciente>ListaPacientes { get; set; }
        public Medico()
        {
            ListaPacientes = new List<Paciente>();
        }
        public override string ToString()
        {
            string pacientes = "";
            ListaPacientes.ForEach(x => pacientes += x.ToString());
            return base.ToString() + $@"
Personal Medico
Lista de pacientes :
{pacientes}";
        }

    }
}
