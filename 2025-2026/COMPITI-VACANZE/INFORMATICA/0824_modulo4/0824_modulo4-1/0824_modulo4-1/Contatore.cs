using _0824_modulo4_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _0824_modulo4_1
{
    public class Contatore
    {
        private int valore;
        private static int count = 0;

        private Contatore()
        {

        }

        public static Contatore CreaContatore()
        {
            return new Contatore();
            count++;
        }

        public void Incrementa()
        {
            valore++;
        }

        public static void ResetTotale()
        {
            count = 0;
        }
    }
}

//+-----------------------------+
//| Contatore                   |
//+-----------------------------+
//| - valore: int               |
//| - count: int                |
//+-----------------------------+
//| - Contatore()               |  
//| + CreaContatore(): Contatore|  
//| + Incrementa(): void        |
//| + Valore: int {get;}        |
//| * ResetTotale(): void       |
//+-----------------------------+
//