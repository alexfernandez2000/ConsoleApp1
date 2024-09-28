using Baraja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Clases;

namespace Hospital
{
    internal class Program
    {
        private static List<Persona> _personas = new List<Persona>();

        static void Main(string[] args)
        {
            Prueba();
        }

        private static void Prueba()
        {
            bool continues = true;
            while (continues)
            {
                switch (GetOption())
                {
                    case eOptions.Finalizar:
                        continues=false;
                        break;
                    case eOptions.AltaMedico:
                        _personas.Add(new Medico());
                        break;
                    case eOptions.AltaPaciente:
                        AltaPaciente();
                        break;
                    case eOptions.AltaAdministrativo:
                        _personas.Add(new Administrativo());
                        break;
                    case eOptions.ListarMedicos:
                        ListarPersonas<Medico>();
                        break;
                    case eOptions.ListarPacientesMedico:
                        ListarPacientesMedico();
                        break;
                    case eOptions.EliminarPaciente:
                        EliminarPaciente();
                        break;
                    case eOptions.ListarPersonasHospital:
                        ListarPersonas<Persona>();
                        break;
                    case eOptions.ModificarPersona:
                        ModificarPersona();
                        break;
                    case eOptions.ConcretarCita:
                        ConcretarCita();
                        break;
                    case eOptions.ModificarCita:
                        ModificarCita();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        //TODO Unificar en una misma funcion la modificacion de cita.
        private static void ModificarCita()
        {
            Paciente paciente = BuscarPersona<Paciente>();
            if (paciente != null)
            {
                paciente.ModificarCita();
                return;
            }
            Medico medico = BuscarPersona<Medico>();
            if (medico != null)
                medico.ModificarCita();
        }

        private static void ConcretarCita()
        {
            Paciente paciente = BuscarPersona<Paciente>();
            if (paciente == null)
                return;
            Medico medico = BuscarPersona<Medico>();
            if (medico == null)
                return;
            DateTime fecha= Tools.GetDate();
            new Cita(medico,paciente,fecha,false);
        }
        private static void ModificarPersona()
        {
            Persona persona = BuscarPersona<Persona>();
            if (persona!=null)
                persona.ModificarDatos();
        }

        private static void AltaPaciente()
        {
            Paciente paciente = new Paciente();
            Medico medico = BuscarPersona<Medico>();
            if (medico != null)
                if (medico.AltaPaciente(paciente))
                    _personas.Add(paciente);
        }

        private static T BuscarPersona<T>() where T : Persona
        {
            string name = Tools.ReadConsoleWord($"Nombre del {typeof(T).Name}");
                T persona =  (T)_personas.FirstOrDefault(x => name == x.Name && x is T);
                if (persona == null)
                    Console.WriteLine($"No se ha encontrado la persona {name} del tipo {typeof(T).Name}");
                return persona;
        } 
        private static void ListarPersonas<T>() where T :Persona
        {
            foreach (var persona1 in _personas.Where(x=> x is T))
            {
                var persona = (T)persona1;
                Console.WriteLine(persona);
            }
        }
        private static void ListarPacientesMedico()
        {
            Medico medico = BuscarPersona<Medico>();
            Console.WriteLine(medico.GetListaPacientes());
        }
        private static void EliminarPaciente()
        {
            Paciente paciente = BuscarPersona<Paciente>();
            if (paciente.DarDeBaja())
                _personas.Remove(paciente);
        }
        private static eOptions GetOption()
        {
            while (true)
            {
                Console.WriteLine($@"Seleccione una opcion:
0: Finalizar,
1: AltaMedico,
2: AltaPaciente,
3: AltaAdministrativo,
4: ListarMedicos,
5: ListarPacientesMedico,
6: EliminarPaciente,
7: ListarPersonasHospital,
8: ModificarPersona
9: ConcretarCita
10: ModificarCita
");
                if (Enum.TryParse<eOptions>(Tools.GetInt().ToString(), out eOptions option))
                {
                    return option;
                }
                Console.WriteLine("Conversión fallida.");
            }
        }

        //Crear una aplicación de consola, con un menú, que permita: 
        //• Dar de alta un medico 
        //• Dar de alta un paciente, para un médico concreto
        //• Dar de alta personal administrativo
        //• Listar los médicos
        //• Listar los pacientes de un medico 
        //• Eliminar a un paciente 
        //• Ver la lista de personas del hospital
        //• Redefinir el método ToString() para cada clase, aprovechando el método de la superclase base.ToString(). 

        private enum eOptions
        {
            Finalizar,
            AltaMedico,
            AltaPaciente,
            AltaAdministrativo,
            ListarMedicos,
            ListarPacientesMedico,
            EliminarPaciente,
            ListarPersonasHospital,
            ModificarPersona,
            ConcretarCita,
            ModificarCita
        }
    }
}
