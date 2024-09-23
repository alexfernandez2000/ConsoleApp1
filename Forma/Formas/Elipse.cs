using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma.Formas
{
    internal class Elipse : Forma2D
    {
        public int EjeMenor { get; set; }
        public int EjeMayor { get; set; }

        public override double CalcularArea()
        {
            return Math.PI*EjeMayor*EjeMenor;
        }
        public override double CalcularPerimetro()
        {
            return Math.PI * (3 * (EjeMayor + EjeMenor) - Math.Sqrt((3 * EjeMayor + EjeMenor) * (EjeMayor + 3 * EjeMenor))); ;
        }

    }
}
