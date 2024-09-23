namespace Forma.Formas
{
     class Rectangulo: FormaGeometrica
    {
        public double Longitud { get; set; }
        public double Ancho { get; set; }

        protected override double CalcularArea()
        {
            return Longitud * Ancho;
        }
        protected override double CalcularPerimetro()
        {
            return 2*(Longitud+Ancho);
        }


    }
}
