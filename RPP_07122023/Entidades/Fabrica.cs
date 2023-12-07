using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Mermelada> frasco;

        public List<Mermelada> Frasco
        {
            get { return this.frasco; }
        }

        private Fabrica()
        {
            this.frasco = new List<Mermelada>();
        }

        public Fabrica(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public static Fabrica operator + (Fabrica f, Mermelada m)
        {
            if(f.frasco.Count < f.capacidad)
            {
                f.frasco.Add(m); 
            }
            return f;
        }

        public static Fabrica operator -(Fabrica f, Mermelada m)
        {
            foreach(Mermelada mer  in f.frasco)
            {
                if(mer == m)
                {
                    f.frasco.Remove(mer);
                    return f;
                }
            }
            return f;
        }

    }
}
