
using System;

namespace Forma.Formas
{
     class Triangulo : Forma2D
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public override double CalcularArea()
        {
            double semiperimetro = CalcularSemiperimetro();
            return  Math.Sqrt(semiperimetro*(semiperimetro*Lado1)*(semiperimetro*Lado2)*(semiperimetro*Lado3));
        }
        public override double CalcularPerimetro()   
        {
            return Lado1+Lado2+Lado3;
        }

        private double CalcularSemiperimetro()
        {
            return (Lado1 + Lado2 + Lado3) / 2;
        }

    }
}
