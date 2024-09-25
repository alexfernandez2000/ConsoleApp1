using Baraja;
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
        protected Personal():base()
        {
            Hospital = Tools.ReadConsoleWord("Nombre del hospital: ");
        }
        public override string ToString()
        {
            return base.ToString()+$"\n Personal del hospital: {Hospital}";
        }
    }
}
