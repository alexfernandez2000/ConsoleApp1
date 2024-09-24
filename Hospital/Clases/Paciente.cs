namespace Hospital
{
    internal class Paciente:Persona
    {
        public Medico Medico { get; set; }
        public Paciente(Medico medico):base()
        {
            Medico = medico;
            Medico.ListaPacientes.Add(this);
        }
        public override string ToString()
        {
            return base.ToString() + $"Paciente del medico: {Medico.Name}";
        }
        public void DarDeBaja()
        {
            Medico.ListaPacientes.Remove(this);
        }
    }
}
