using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma.Formas
{
     class Cubo : Forma3D
    {
        public double Lado { get; set; }
        protected override double CalcularArea()
        {
            return 6 * Math.Pow(Lado, 2);
        }
    }
}
