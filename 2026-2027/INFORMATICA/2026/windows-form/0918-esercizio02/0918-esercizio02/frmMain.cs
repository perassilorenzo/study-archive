using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0918_esercizio02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void caso1VarGlobaleStaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            Program.s1 = "sono S1 essagnata in frmMain";
            MessageBox.Show($"S1 = \"{Program.s1}\"");

            f2.ShowDialog();
        
            MessageBox.Show($"S1 = \"{Program.s1}\"");


        }

        private void caso2VarPublicForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            MessageBox.Show($"frmMain - S2 = \"{f3.s2}\"");

            f3.s2 = "sono S2 variata in frmMain";
            MessageBox.Show($"frmMain - S2 = \"{f3.s2}\"");

            f3.ShowDialog();

            f3.cambia("sono S2 cambiata in frmMain");
            MessageBox.Show($"frmMain - S2 = \"{f3.s2}\"");

            f3.ShowDialog();
            MessageBox.Show($"frmMain - S2 = \"{f3.s2}\"");

        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
