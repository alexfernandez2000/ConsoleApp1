﻿
namespace Forma.Formas
{
     class Triangulo : FormaGeometrica
    {
        public double Plano { get; set; }
        public double Ancho { get; set; }

        protected override double CalcularArea()
        {
            return  Plano* Ancho / 2;
        }
    }
}
