using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italautomata
{
    internal class Forroital
    {
        protected string nev;
        protected int ar;
        protected int cukor;
        public Forroital(string nev, int ar, int cukor)
        {
            this.nev = nev;
            this.ar = ar;
            this.cukor = cukor;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Cukor { get => cukor; set => cukor = value; }

        public virtual void Aremeles()
        {
            this.ar += 100;
        }
        public override string ToString()
        {
            return $"{this.nev} {this.ar} Ft {this.cukor} cukorral";

        }

    }
}
