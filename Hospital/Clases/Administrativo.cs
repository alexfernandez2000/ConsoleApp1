using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Administrativo:Personal
    {
        public override string ToString()
        {
            return base.ToString() + $"\n Administrativo que administra cosas administrables";
        }

    }
}
