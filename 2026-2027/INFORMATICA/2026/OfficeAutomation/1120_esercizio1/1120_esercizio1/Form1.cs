using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Xceed.Document.NET;
using Xceed.Words.NET;

namespace _1120_esercizio1
{
    public partial class Form1 : Form
    {
        string docName = "NuovoDocumento.docx";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaDoc_Click(object sender, EventArgs e)
        {
            using (DocX document = DocX.Create(docName))
            {
                // aggiungi titolo
                document.InsertParagraph("Esempio Documento WORD")
                    .FontSize(20)
                    .Bold()
                    .Color(Xceed.Drawing.Color.Blue)
                    .Alignment = Alignment.center;

                document.InsertParagraph("Questo Documento è stato creato automaticamente con C# e DocX").
                    FontSize(12).
                    Italic().
                    SpacingAfter(20);

                // salvare il file
                document.Save();
                
                Process.Start(docName);
            }
        }

        private void btnLeggeDoc_Click(object sender, EventArgs e)
        {
            lstDatiDoc.Items.Clear();

            using (DocX document = DocX.Load(docName))
            {
                // leggo tutto il documento word riga per riga
                foreach(var line in document.Paragraphs)
                {
                    lstDatiDoc.Items.Add($"Paragrafo trovato: {line.Text}");
                }
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            string nameImg = "ImgVallauri.jpg";

            using (DocX document = DocX.Create(docName))
            {
                // aggiungi titolo
                document.InsertParagraph("Documento WORD con immgine")
                    .FontSize(20)
                    .Bold()
                    .Color(Xceed.Drawing.Color.Blue)
                    .Alignment = Alignment.center;

                // gestione immagine
                var img = document.AddImage(nameImg);
                Picture pic = img.CreatePicture();
                pic.Width = 200; // pixel
                pic.Height = 100;

                var p = document.InsertParagraph("Immagine caricata");
                p.AppendPicture(pic);
                p.Alignment = Alignment.center;

                // salvare il file
                document.Save();

                Process.Start(docName);

            }
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            using(DocX document = DocX.Load(docName))
            {
                // aggiungi font arial
                document.InsertParagraph("Arial")
                    .FontSize(20)
                    .Font("Arial")
                    .Alignment = Alignment.left;

                // aggiungi paragrafo vuoto
                document.InsertParagraph();

                // aggiungi times new roman
                document.InsertParagraph("times new roman")
                    .FontSize(20)
                    .Font("Times New Roman")
                    .Alignment = Alignment.right;


                // aggiungi paragrafo vuoto
                document.InsertParagraph();

                // aggiungo un paragrafo con font diversi
                var p = document.InsertParagraph();

                p.Append("Testo in grassetto arial 12").
                    Bold().
                    Font("Arial").
                    FontSize(12);

                p.Append("Testo grassetto blu verdana 18").
                    Bold().
                    Font("Verdana").
                    Color(Xceed.Drawing.Color.Blue).
                    FontSize(18);


                // salvo
                document.Save();
                Process.Start(docName) ;

            }
        }

        private void btnModificaParagrafo_Click(object sender, EventArgs e)
        {

        }
    }
}
