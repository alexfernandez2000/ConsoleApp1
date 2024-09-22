using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma.Formas
{
     class Esfera:Forma3D
    {
        public double RadioEsfera { get; set; }
        protected override double CalcularArea() 
        { 
            return 4 * Math.PI * Math.Pow(RadioEsfera, 2);
        }
    }
}
