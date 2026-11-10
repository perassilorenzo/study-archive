using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1109_polimorfismo
{
    public class Corvo : Uccello
    {
        public override void Verso()
        {
            MessageBox.Show("cra cra", "Corvo");
        }
    }
}
