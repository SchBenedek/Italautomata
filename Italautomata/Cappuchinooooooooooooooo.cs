using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italautomata
{
    internal class Cappuchinooooooooooooooo: Kave
    {
        private bool tejszinhab;
        public Cappuchinooooooooooooooo(string nev, int ar, int cukor, string tej, bool tejszinhab):base(nev, ar, cukor, tej)
        {
            this.tejszinhab = tejszinhab;
        }
        public override string ToString()
        {
            return base.ToString() + (this.tejszinhab? " tejszínhabbal":" tejszínhab nélkül");
        }
    }
}
