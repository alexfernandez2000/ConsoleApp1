using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma.Formas
{
    class Forma
    {
        public double CalculateArea()
        {
            return CalcularArea();
        }
        protected virtual double CalcularArea ()
        { return -1; }
        public double CalculatePerimetro()
        {
            return CalcularPerimetro();
        }
        protected virtual double CalcularPerimetro()
        { return -1; }


    }
}
