using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pera : Mermelada
    {
        public override string Tipo
        {
            get { return "Mermelada de Pera."; }
        }

        public Pera(Aditivos aditivos) : base(aditivos, true) { }
    }
}
