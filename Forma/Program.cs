
using Forma.Formas;
using System;
using System.Collections.Generic;
using Baraja;

namespace Forma
{
    internal class Program
    {
        private static Random _random = new Random();
        static void Main(string[] args)
        {
            Diagrama diagrama = new Diagrama();
            diagrama.Formas = CrearFiguras2D();
            Console.WriteLine($"Area diagrama {diagrama.CalcularAreaTotal()}");
            Console.WriteLine($"Perimetro diagrama {diagrama.CalcularPerimetroTotal()}");

            Console.ReadLine();
        }

        private static List<Forma2D> CrearFiguras2D()
        {
            List<Forma2D> formas2d = new List<Forma2D>();
            while (true)
            {
                Console.WriteLine(@"
1: Añadir circulo random
2: Añadir Rectangulo
3: Añadir Triangulo
4: Añadir Rombo
5: Añadir Poligono
6: Añadir Eliplse");
                int Opcion = Tools.GetInt();
                switch (Opcion)
                {
                    case 1:
                        formas2d.Add(CirculoRandom());
                        break;
                    case 2:
                        formas2d.Add(RectanguloRandom());
                        break;
                    case 3:
                        formas2d.Add(TrianguloRandom());
                        break;
                    case 4:
                        formas2d.Add(RomboRandom());
                        break;
                    case 5:
                        formas2d.Add(PoligonoRandom());
                        break;
                    case 6:
                        formas2d.Add(ElipseRandom());
                        break;
                }

                if (Opcion == 0)
                    break;
            }
            return formas2d;
        }

        private static Forma2D TrianguloRandom()
        {
            var test=new Triangulo() { Lado1 = 0, Lado2 = 0, Lado3 = 0 };
            var area = test.CalcularArea();
            return new Triangulo() { Lado1 = _random.Next(1, 10), Lado2 = _random.Next(1, 10), Lado3 = _random.Next(1, 10) };
        }

        private static Forma2D RomboRandom()
        {
            return new Rombo() { Lado = _random.Next(1, 10) ,diagonal1 = _random.Next(1, 10) ,diagonal2 = _random.Next(1, 10) };
        }

        private static Forma2D PoligonoRandom()
        {
            return new Poligono() {  Lados= _random.Next(1, 10), LongitudLados = _random.Next(1, 10) };
        }

        private static Forma2D ElipseRandom()
        {
            return new Elipse(){EjeMayor = _random.Next(1, 10) ,EjeMenor = _random.Next(1, 10) };
        }

        private static Forma2D RectanguloRandom()
        {
           return new Rectangulo() { Longitud = _random.Next(1, 10), Ancho = _random.Next(1, 10) };
        }

        private static Circulo CirculoRandom()
        {
            return  new Circulo() { Radio = _random.Next(1,10) };
            ;
        }

    }
}
