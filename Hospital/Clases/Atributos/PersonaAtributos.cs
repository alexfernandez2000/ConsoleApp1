using System;

    [AttributeUsage(AttributeTargets.Property)]
    public class PersonaAtributos : Attribute
    {
        public bool ShowForm { get; }

        public PersonaAtributos(bool descripcion)
        {
            ShowForm = descripcion;
        }
    }
