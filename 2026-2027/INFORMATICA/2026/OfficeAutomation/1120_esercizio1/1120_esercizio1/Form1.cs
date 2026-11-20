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
    }
}
