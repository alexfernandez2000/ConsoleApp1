using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Paciente:Persona
    {
        public Medico Medico { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Paciente del medico: {Medico.Name}";
        }

    }
}
