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
        private readonly string _hospitalName="Shiro";
        private static List<Persona>_personas = new List<Persona>();
        static void Main(string[] args)
        {
            Prueba();
        }

        private static void Prueba()
        {
            while (true)
            {
                switch (GetOption())
                {
                    case eOptions.AltaMedico:
                        _personas.Add(new Medico());
                        break;
                    case eOptions.AltaPaciente:
                        _personas.Add(new Paciente(BuscarMedico()));
                        break;
                    case eOptions.AltaAdministrativo:
                        _personas.Add(new Administrativo());
                        break;
                    case eOptions.ListarMedicos:
                        ListarMedicos();
                        break;
                    case eOptions.ListarPacientesMedico:
                        ListarPacientesMedico();
                        break;
                    case eOptions.EliminarPaciente:
                        EliminarPaciente();
                        break;
                    case eOptions.ListarPersonasHospital:
                        ListarPersonasHospital();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }

        }
        private static Medico BuscarMedico()
        {
            while (true)
            {
                string name = Tools.ReadConsoleWord("Nombre del medico");
                Medico medico = (Medico)_personas.Where(x => x.Name == name && x is Medico).FirstOrDefault();
                if (medico != null)
                    return medico;
            }
        }
        private static Paciente BuscarPaciente()
        {
            while (true)
            {
                string name = Tools.ReadConsoleWord("Nombre del paciente");
                Paciente paciente = (Paciente)_personas.Where(x => x.Name == name && x is Paciente).FirstOrDefault();
                if (paciente != null)
                    return paciente;
            }
        }
        //private static Persona BuscarPersona<T>(T persona)
        //{
        //    while (true)
        //    {
        //        string name = Tools.ReadConsoleWord($"Nombre del {persona.GetType()}");
        //        Persona personab = _personas.OfType<Persona>().Where(x=> name==x.Name);
        //        if (personab != null)
        //            return personab;
        //    }
        //}
        private static void ListarMedicos()
        {
            foreach (Medico medico in _personas)
                Console.WriteLine(medico.ToString());

        }
        private static void ListarPacientesMedico()
        {
            Medico medico=BuscarMedico();
            Console.WriteLine(medico.GetListaPacientes());
        }
        private static void EliminarPaciente()
        {
            Paciente paciente= BuscarPaciente();
            paciente.DarDeBaja();
            _personas.Remove(paciente);

        }
        private static void ListarPersonasHospital()
        {
            foreach (Persona persona in _personas)
                Console.WriteLine(persona.ToString());

        }
        private static eOptions GetOption()
        {
            while (true)
            {
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
