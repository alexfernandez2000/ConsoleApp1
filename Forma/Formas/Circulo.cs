using System;

namespace Forma.Formas
{
     class Circulo: FormaGeometrica
    {
        public double Radio { get; set; }

        protected override double CalcularArea()
        {
            return Math.PI * (Radio * Radio);
        }

    }
}
