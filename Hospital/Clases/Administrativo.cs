using Baraja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModel
{
    public class Administrativo:Personal
    {
        public string Sector { get; set; }

        public Administrativo():base()
        {
            Sector=Tools.GenerarCadenaAleatoria(10);
        }
        public override string ToString()
        {
            return base.ToString() + $"\n Administrativo que administra cosas administrables";
        }

    }
}
