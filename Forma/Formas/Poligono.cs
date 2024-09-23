using System;

namespace Forma.Formas
{
     class Poligono: FormaGeometrica
    {
        public double Lados { get; set; }
        public double LongitudLados { get; set; }

        protected override double CalcularArea() { 
            return CalcularPerimetro() * GetApotema() / 2; 
        }
        protected override double CalcularPerimetro()
        {
            return Lados * LongitudLados;
        }
        private double GetApotema()=> LongitudLados / (2 * Math.Tan(Math.PI / Lados));
    }
}
