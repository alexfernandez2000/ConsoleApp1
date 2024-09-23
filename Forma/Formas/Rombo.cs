using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma.Formas
{
    internal class Rombo : Cuadrado
    {
        public int diagonal1 { get; set; }
        public int diagonal2 { get; set; }
        public override double CalcularArea()
        {
            return diagonal1*diagonal2/2;
        }
        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
