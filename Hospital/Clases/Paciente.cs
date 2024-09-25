using System.Net.Configuration;

namespace Hospital
{
    internal class Paciente:Persona
    {
        public Medico Medico { get; set; }

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
    }
}
