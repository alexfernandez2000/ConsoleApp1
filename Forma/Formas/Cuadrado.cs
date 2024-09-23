using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma.Formas
{
    internal class Cuadrado : Forma2D
    {
        public int Lado { get; set; }
        public override double CalcularArea()
        {
            return Lado*Lado;
        }
        public override double CalcularPerimetro()
        {
            return 4*Lado;
        }

    }
}
