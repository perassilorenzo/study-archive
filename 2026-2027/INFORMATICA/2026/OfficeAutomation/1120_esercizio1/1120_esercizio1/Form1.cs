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
                    lstDatiDoc.Items.Add($"Paragrafo {document.Paragraphs.IndexOf(line)}: {line.Text}");
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
            using (DocX document = DocX.Load(docName))
            {
                Paragraph p = document.Paragraphs[3];

                if (p != null)
                {
                    // sostituzione
                    p.ReplaceText("Questo testo", "Testo sostituito");

                    // aggiungere
                    p.Append(" Testo aggiunto").
                        Bold().
                        FontSize(15);
                }

                p.RemoveText(0, p.Text.Length, false, false);
                p.Append("Questo è il testo sostituito completamente con eliminazione del precedente");


                document.Save();
                Process.Start(docName) ;
            }

        }

        private void btnTabella_Click(object sender, EventArgs e)
        {
            using(DocX document = DocX.Load(docName))
            {
                // step 1
                Table t = document.AddTable(3, 3);

                // step 2
                t.Alignment = Alignment.center;
                t.Design = TableDesign.TableGrid;

                // step 3
                Row headerRow = t.Rows[0];
                foreach (Cell cell in headerRow.Cells)
                {
                    cell.FillColor = Xceed.Drawing.Color.LightBlue;
                    cell.VerticalAlignment = VerticalAlignment.Center;

                    var p = cell.Paragraphs[0];
                    p.Append("Instazione").
                        Bold().
                        Font("Verdana").
                        FontSize(14).
                        Color(Xceed.Drawing.Color.Red);
                }

                t.Rows[1].Cells[0].Paragraphs[0].Append("Dato 1");
                t.Rows[2].Cells[1].Paragraphs[1].Append("Dato 2");
                t.Rows[3].Cells[2].Paragraphs[2].Append("Dato 3");

                t.Rows[2].Cells[0].FillColor = Xceed.Drawing.Color.LightBlue;
                t.Rows[2].Cells[0].Paragraphs[0].Append("Evidenziato");

                Border b = new Border(Xceed.Document.NET.BorderStyle.Tcbs_single, BorderSize.three, 0, Xceed.Drawing.Color.Black);

                t.SetBorder(TableBorderType.InsideH, b);


                document.Save();
                Process.Start(docName);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

        }
    }
}
