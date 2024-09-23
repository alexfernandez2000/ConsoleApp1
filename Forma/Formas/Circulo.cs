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
        protected override double CalcularPerimetro()
        {
            return 2*Math.PI*Radio;
        }


    }
}
