using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1125_inteface_03
{
    internal class NotificaEmail : INotifica
    {
        private string serverSMTP;
        private int porta;

        public NotificaEmail(string serverSMTP = "smpt.example.com", int porta = 587)
        {
            this.serverSMTP = serverSMTP;
            this.porta = porta;
        }
        public void InviaNotifica(string messaggio, string destinatario)
        {
            throw new NotImplementedException();
        }

        public bool VerificaDisponibilità()
        {
            throw new NotImplementedException();
        }
    }
}
