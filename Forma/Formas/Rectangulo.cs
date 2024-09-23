namespace Forma.Formas
{
     class Rectangulo: Forma2D
    {
        public double Longitud { get; set; }
        public double Ancho { get; set; }

        public override double CalcularArea()
        {
            return Longitud * Ancho;
        }
        public override double CalcularPerimetro()
        {
            return 2*(Longitud+Ancho);
        }


    }
}
