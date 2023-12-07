using System.Diagnostics;
using System.Numerics;

namespace Entidades
{
    public abstract class Mermelada
    {
        private Aditivos aditivo;
        protected bool esOrganica;

        public Aditivos Aditivo { get { return this.aditivo; } }
        public abstract string Tipo {  get;}
        public bool EsOrganica { get { return this.esOrganica; } set { this.esOrganica = value; } }


        public Mermelada(Aditivos aditivos) : this(aditivos, false)
        {

        }
        public Mermelada (Aditivos aditivos, bool esOrganica)
        {
            this.aditivo = aditivos;
            this.esOrganica = esOrganica;
        }


        /// <summary>
        /// retorna toda la informacion de la mermelada, utilizando el metodo format  de string.
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            //"[Tipo] con aditivo [Aditivo], [SI/ NO] es orgánica."
            string s = "{0} con aditivo {1}, {2} es oganica.";
            string msg = string.Format(s, this.Tipo, this.Aditivo, this.esOrganica ? "SI" : "NO");
            return msg;
        }

        public static bool operator == (Mermelada m1, Mermelada m2)
        {
            return m1.GetType() == m2.GetType();
        }
        public static bool operator !=(Mermelada m1, Mermelada m2)
        {
            return !(m1 == m2);
        }

    }
}