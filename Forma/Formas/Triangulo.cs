
using System;

namespace Forma.Formas
{
     class Triangulo : Forma2D
    {
        //Base altura area
        private double lado1 { get; set; }
        public double Lado1
        {
            get { return lado1;}
            set { lado1 = value>0 ? value : 1; }
        }
        private double lado2 { get; set; }

        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value > 0 ? value : 1; }

        }
        private double lado3 { get; set; }
        public double Lado3
        {
            get { return lado3; }
            set { lado3 = value > 0 ? value : 1; }
        }

        public override double CalcularArea()
        {
            double semiperimetro = CalcularSemiperimetro();
            return  Math.Sqrt(semiperimetro*(semiperimetro*lado1)*(semiperimetro*lado2)*(semiperimetro*lado3));
        }
        public override double CalcularPerimetro()   
        {
            return lado1 +lado2 +lado3;
        }

        private double CalcularSemiperimetro()
        {
            return (lado1 + lado2 + lado3) / 2;
        }

    }
}
