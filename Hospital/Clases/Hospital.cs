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
        public void AddPersona<T>(T persona)where T : Persona
        {
            _personas.Add(persona);
        }
        public void EliminarPersona<T>(T persona) where T : Persona
        {
            _personas.Remove(persona);
        }
        //Add a lisa y eliminar por persona en generico.
    }
}
