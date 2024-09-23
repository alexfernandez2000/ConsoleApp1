using System;

namespace Forma.Formas
{
     class Circulo: Forma2D
    {
        public double Radio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * (Radio * Radio);
        }
        public override double CalcularPerimetro()
        {
            return 2*Math.PI*Radio;
        }


    }
}
