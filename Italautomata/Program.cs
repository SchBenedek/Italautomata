using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italautomata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forroital f1 = new Forroital("Forrócsoki", 350, 3);
            Console.WriteLine(f1);
            Kave k1 = new Kave("Presso", 300, 1, "kis tej");
            Console.WriteLine(k1);

            Tea t1 = new Tea("gyumolcs", 200, 2, true);
            Console.WriteLine(t1);

            Console.WriteLine("Áremelés:");
            f1.Aremeles();
            k1.Aremeles();
            t1.Aremeles();

            Console.WriteLine(f1);
            Console.WriteLine(k1);
            Console.WriteLine(t1);

            Cappuchinooooooooooooooo c1 = new Cappuchinooooooooooooooo("Eljes", 7654321, 987654321, "nagyonnagyon sok", false);
            Console.WriteLine(c1);

            List<Forroital> lista=new List<Forroital>();
            lista.Add(f1);
            lista.Add(k1);
            lista.Add(t1);
            lista.Add(c1);
            lista.Add(new Kave("Kuksimuksi", 550, 4, "Sok tej"));

            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Kávék:");
            foreach(var item in lista)
            {
                if(item.GetType()==typeof(Kave))
                {
                    Console.WriteLine(item);
                }
            }

            int db = 0;
            foreach(var item in lista)
            {
                if(item.GetType()==typeof(Kave))
                {
                    if(((Kave)item).Tej=="Sok tej")
                    {
                        db++;
                    }
                }
            }
            Console.WriteLine(db);

            Console.ReadKey();
        }
    }
}
