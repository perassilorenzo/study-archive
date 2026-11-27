using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1125_inteface_03
{
    internal interface INotifica
    {
        void InviaNotifica(string messaggio, string destinatario);
        bool VerificaDisponibilità();
    }
}
