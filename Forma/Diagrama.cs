using System.Collections.Generic;
using Forma.Formas;

namespace Forma
{
    class Diagrama
    {
        public List<Forma2D> Formas { get; set; }
        public Diagrama()
        {
            Formas = new List<Forma2D>();
        }
        public double CalcularAreaTotal()
        {
            double total=0;
            foreach (Forma2D item in Formas)
            {
                total += item.CalculateArea();
            }            
            return total;
        }
    }
}
