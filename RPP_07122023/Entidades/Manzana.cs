using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manzana : Mermelada
    {
        public override string Tipo
        {
            get { return "Mermelada de manzana.";  }
        }

        public Manzana(Aditivos aditivo) : base(aditivo)
        {

        }
    }
}
