using Baraja;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalModel.Clases
{
    public class Hospital
    {
        private List<Persona> _personas = new List<Persona>();
        public Hospital()
        {
            
        }
        public T GetPersona<T>(string nombre) where T : Persona
        {
            return (T)_personas.FirstOrDefault(x => nombre == x.Name && x is T); ;
        }

        public List<T> GetPersonas<T>() where T : Persona
        {
            var test= _personas.OfType<T>().ToList();
            return test;
        }
        public void AddMedico()
        {
            _personas.Add(new Medico());
        }
        public void EliminarMedico(Medico medico)
        {
            _personas.Remove(medico);
        }

    }
}
