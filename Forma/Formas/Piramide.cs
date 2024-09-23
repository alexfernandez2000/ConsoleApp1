using System;

namespace Forma.Formas
{
    class Piramide : Forma3D
    {
        public double Lado { get; set; }
        public double Altura { get; set; }
        public override double CalcularArea ()
        {
            double areaBase = AreaBase(Lado);
            double areaLateral = AreaLateral(Lado, Altura);
            return areaBase + areaLateral;
        }
        public static double AreaBase(double Lado)
        {
            return Lado * Lado;
        }
        public static double AreaLateral(double Lado, double Altura)
        {
            double alturaTriangulo = Math.Sqrt((Altura * Altura) + (Lado / 2) * (Lado / 2));
            double areaTriangulo = 0.5 * Lado * alturaTriangulo; 
            return 4 * areaTriangulo;
        }




    }
}
