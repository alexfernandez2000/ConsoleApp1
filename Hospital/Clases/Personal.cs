using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Personal:Persona
    {
        public string Hospital {  get; set; }
        public override string ToString()
        {
            return base.ToString()+$"\nPersonal del hospital:{Hospital}";
        }
    }
}
