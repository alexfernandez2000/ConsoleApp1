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
                        break;
                    case eOptions.AltaPaciente:
                        break;
                    case eOptions.AltaAdministrativo:
                        break;
                    case eOptions.ListarMedicos:
                        break;
                    case eOptions.ListarPacientesMedico:
                        break;
                    case eOptions.EliminarPaciente:
                        break;
                    case eOptions.ListarPersonasHospital:
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }

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
