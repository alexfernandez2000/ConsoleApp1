
using Forma.Formas;
using System;

namespace Forma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diagrama diagrama = new Diagrama();
            Circulo circulo = new Circulo() { Radio=10};
            Triangulo triangulo = new Triangulo() { Ancho = 2, Plano = 2 };
            Rectangulo rectangulo = new Rectangulo() { Longitud = 2, Ancho = 2 };
            Poligono poligono = new Poligono() {Lados=5,LongitudLados=3};
            diagrama.Formas.Add(rectangulo);
            Console.WriteLine($"Area diagrama {diagrama.CalcularAreaTotal()}");
            Console.WriteLine($"Perimetro diagrama {diagrama.CalcularPerimetroTotal()}");
            diagrama.Formas.Add(circulo);
            diagrama.Formas.Add(triangulo);
            diagrama.Formas.Add(poligono);
            Console.WriteLine($"Area diagrama {diagrama.CalcularAreaTotal()}");
            Console.WriteLine($"Perimetro diagrama {diagrama.CalcularPerimetroTotal()}");

            Console.ReadLine();
        }

    }
}
