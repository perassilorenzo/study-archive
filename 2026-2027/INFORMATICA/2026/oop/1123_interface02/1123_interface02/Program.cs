using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1123_interface02
{
    internal class Program
    {
        static List<IFormaGeometrica> lstForme = new List<IFormaGeometrica>();
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio(3);
            Rettangolo r = new Rettangolo(10, 5);
            Triangolo t = new Triangolo(10, 5);

            lstForme.Add(c);
            lstForme.Add(r);
            lstForme.Add(t);

            foreach (var item in lstForme)
                Console.WriteLine($"Il perimetro e l'area del {item.GetType().Name} sono {item.CalcolaPerimetro()} e {item.CalcolaArea()}");
        }
    }
}
