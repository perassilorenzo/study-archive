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
        private object btnVisualizza_Click;

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
            nuovaIMG.Name = $"picDuplica{prgImmagine++}";

            nuovaIMG.Location = new Point(picVallauri.Location.X + Diff, picVallauri.Location.Y + Diff);

            Diff += 20;
        }

        private void btnDuplica2_Click(object sender, EventArgs e)
        {
            PictureBox nuovaIMG = new PictureBox();
            nuovaIMG.Size = new Size(200, 100);

            this.Controls.Add(nuovaIMG);

            Bitmap bmp = new Bitmap(200, 100);
            Graphics bmpGraphics = Graphics.FromImage(bmp);

            bmpGraphics.FillRectangle(Brushes.Blue, 0, 0, 200, 100);
            nuovaIMG.Image = bmp;

            nuovaIMG.Name = $"picDuplica2{prgImmagine++}";


            nuovaIMG.Location = new Point(picVallauri.Location.X + Diff, picVallauri.Location.Y + Diff);

            Diff += 50;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            TextBox nuovoTXT = new TextBox();

            nuovoTXT.Size = new Size(200, 20);
            nuovoTXT.Name = "txtInput";

            this.Controls.Add(nuovoTXT);

            nuovoTXT.Location = new Point(btnDuplica.Location.X, btnDuplica.Location.Y + btnDuplica.Size.Height + 25);

            Button nuovoBTN = new Button()
            {
                Size = new Size(btnAggiungi.Size.Width, btnAggiungi().Size.Height),
                Name = "Visualizza",
                Text = "Visualizza",
                Location = new Point(btnAggiungi.Location.X, btnAggiungi.Location.Y + btnAggiungi.Size.Height + 25),
            };

            // Evento CLICK
            nuovoBTN.Click += btnVisualizza_Click;

            this.Controls.Add(nuovoBTN);

            btnAggiungi.Enabled = false;
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;

            MessageBox.Show($"Evento creato da [{control.Name}] : {Controls["txtInput"].Text}");
        }
    }
}
