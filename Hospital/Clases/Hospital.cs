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
        //Add a lisa y eliminar por persona en generico.
        #region Medico
        public void AddMedico()
        {
            _personas.Add(new Medico());
        }
        public void EliminarMedico(Medico medico)
        {
            _personas.Remove(medico);
        }
        #endregion
        #region Administrativo
        public void AddAdministrativo(Administrativo administrativo)
        {
            _personas.Add(administrativo);
        }
        public void EliminarAdministrativo(Administrativo administrativo)
        {
            _personas.Remove(administrativo);
        }

        #endregion
    }
}
