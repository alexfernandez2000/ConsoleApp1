using System;

namespace Forma.Formas
{
     class Poligono: Forma2D
    {
        public double Lados { get; set; }
        public double LongitudLados { get; set; }

        public override double CalcularArea() { 
            return CalcularPerimetro() * GetApotema() / 2; 
        }
        public override double CalcularPerimetro()
        {
            return Lados * LongitudLados;
        }
        private double GetApotema()=> LongitudLados / (2 * Math.Tan(Math.PI / Lados));
    }
}
