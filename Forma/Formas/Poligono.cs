using System;

namespace Forma.Formas
{
     class Poligono: FormaGeometrica
    {
        public double Lados { get; set; }
        public double LongitudLados { get; set; }

        protected override double CalcularArea() { 
            return GetPerimetro() * GetApotema() / 2; 
        }
        private double GetPerimetro() => Lados * LongitudLados;
        private double GetApotema()=> LongitudLados / (2 * Math.Tan(Math.PI / Lados));
    }
}
