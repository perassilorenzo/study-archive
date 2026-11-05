using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1104_oop2_ereditarietà
{
    public class Mostro
    {
        public string nome;
        public Mostro() : this ("Mostro")
        {
        }

        public Mostro(string nome)
        {
            this.nome = nome;
        }

        public void Rivela()
        {
            MessageBox.Show(nome);  
        }
    }
}
