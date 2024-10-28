using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModel
{
    public class Administrativo:Personal
    {
        public Administrativo():base()
        {
            
        }
        public override string ToString()
        {
            return base.ToString() + $"\n Administrativo que administra cosas administrables";
        }

    }
}
