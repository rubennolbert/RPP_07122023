using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tomate : Mermelada
    {
        public string receta;

        public string Receta
        {
            get { return receta; }
            set { receta = string.IsNullOrEmpty(value) ? "Indefinida" : value; }

        }
        public override string Tipo
        {
            get { return "Mermelada de tomate."; }
        }

        public Tomate(string receta) : base(Aditivos.Mascabo)
        {
            this.receta = receta;
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetInfo());
            sb.Append($"Receta: {this.Receta}");

            return sb.ToString();
        }
    }
}
