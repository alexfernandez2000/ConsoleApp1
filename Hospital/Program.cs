using Baraja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        private readonly string _hospitalName = "Shiro";
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
                        _personas.Add(new Paciente(BuscarPersona<Medico>()));
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
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        private static T BuscarPersona<T>() where T : Persona
        {
            while (true)
            {
                string name = Tools.ReadConsoleWord($"Nombre del {typeof(T)}");
                T persona =  (T)_personas.FirstOrDefault(x => name == x.Name && x is T);
                if (persona != null)
                    return persona;
            }
        }
        private static void ListarPersonas<T>() where T :Persona
        {
            foreach (var persona1 in _personas.Where(x=> x is T))
            {
                var persona = (T)persona1;
                Console.WriteLine(persona.ToString());
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
            paciente.DarDeBaja();
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
7: ListarPersonasHospital
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
            ListarPersonasHospital
        }
    }
}
