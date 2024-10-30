using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModel.Clases
{
    public class Cita
    {
        public Guid Id { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        private bool asistencia;

        public bool? Asistencia
        {
            get { return asistencia;}
            set
            {

                if (value!=null)
                {
                    Medico.HistorialCitas.Add(this);
                    Paciente.HistorialCitas.Add(this);
                    Medico.ListaCitas.Remove(this);
                    Paciente.ListaCitas.Remove(this);
                    asistencia = (bool)value;
                }
            }
        }

        public Cita(Medico medico, Paciente paciente, DateTime fecha, bool asistencia)
        {
            Id = Guid.NewGuid();
            Medico = medico;
            Paciente = paciente;
            Fecha = fecha;
            Medico.ListaCitas.Add(this);
            Paciente.ListaCitas.Add(this);
        }
        public void CancelarCita()
        {
            Medico.ListaCitas.Remove(this);
            Paciente.ListaCitas.Remove(this);
        }

        public void ModficarCita(DateTime? nuevaFecha=null,bool? asistencia=null,string tratamiento=null,string diagnostico=null)
        {
            Fecha = nuevaFecha ?? Fecha;
            Asistencia = asistencia ?? Asistencia;
            Tratamiento = tratamiento ?? Tratamiento;
            Diagnostico = diagnostico ?? Diagnostico;
        }

        public override string ToString()
        {
            return $@"IdCita: {Id}
Paciente: {Paciente.Name}
Medico: {Medico.Name}
Fecha: {Fecha}
Asistencia: {Asistencia}";
        }
    }
}
