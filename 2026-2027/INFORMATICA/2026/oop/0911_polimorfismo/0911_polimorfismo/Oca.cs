using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0911_polimorfismo
{
    public class Oca : Uccello
    {
        public override void Verso()
        {
            MessageBox.Show("qua qua", "Oca");
        }
    }
}
