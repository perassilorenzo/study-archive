using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0916_ripasso
{
    public partial class Form1 : Form
    {
        int Diff = 20;
        int prgImmagine = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDuplica_Click(object sender, EventArgs e)
        {
            PictureBox nuovaIMG = new PictureBox();

            nuovaIMG.Size = new Size(picVallauri.Width, picVallauri.Height);

            // IMPORTANTE !!!!
            // controlli della nuova immagine
            this.Controls.Add(nuovaIMG);

            nuovaIMG.Image = picVallauri.Image;
            nuovaIMG.Name = $"picDuplica{++prgImmagine}";

            nuovaIMG.Location = new Point(picVallauri.Location.X + Diff, picVallauri.Location.Y + Diff);

            Diff += 20;
        }
    }
}
