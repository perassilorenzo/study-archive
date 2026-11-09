
namespace _1104_gestione_libreria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblAutore;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Label lblRicerca;

        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.TextBox txtRicerca;

        private System.Windows.Forms.ComboBox cmbTipo;

        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnPrezzoMedio;

        private System.Windows.Forms.ListBox lstCatalogo;

        private System.Windows.Forms.Label lblRisultato;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblAutore = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.lblRicerca = new System.Windows.Forms.Label();

            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.txtRicerca = new System.Windows.Forms.TextBox();

            this.cmbTipo = new System.Windows.Forms.ComboBox();

            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnPrezzoMedio = new System.Windows.Forms.Button();

            this.lstCatalogo = new System.Windows.Forms.ListBox();
            this.lblRisultato = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Form
            this.Text = "Gestione Libreria";
            this.ClientSize = new System.Drawing.Size(650, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Titolo
            this.lblTitolo.Text = "Titolo:";
            this.lblTitolo.Location = new System.Drawing.Point(30, 30);
            this.lblTitolo.AutoSize = true;

            this.txtTitolo.Location = new System.Drawing.Point(140, 27);
            this.txtTitolo.Size = new System.Drawing.Size(180, 22);

            // Autore
            this.lblAutore.Text = "Autore:";
            this.lblAutore.Location = new System.Drawing.Point(30, 70);
            this.lblAutore.AutoSize = true;

            this.txtAutore.Location = new System.Drawing.Point(140, 67);
            this.txtAutore.Size = new System.Drawing.Size(180, 22);

            // Prezzo
            this.lblPrezzo.Text = "Prezzo:";
            this.lblPrezzo.Location = new System.Drawing.Point(30, 110);
            this.lblPrezzo.AutoSize = true;

            this.txtPrezzo.Location = new System.Drawing.Point(140, 107);
            this.txtPrezzo.Size = new System.Drawing.Size(180, 22);

            // Tipo
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.Location = new System.Drawing.Point(30, 150);
            this.lblTipo.AutoSize = true;

            this.cmbTipo.Location = new System.Drawing.Point(140, 147);
            this.cmbTipo.Size = new System.Drawing.Size(180, 24);
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Items.AddRange(new object[] { "Libro", "Rivista" });
            this.cmbTipo.SelectedIndex = 0;

            // Numero pagine / edizione
            this.lblExtra.Text = "Numero pagine:";
            this.lblExtra.Location = new System.Drawing.Point(30, 190);
            this.lblExtra.AutoSize = true;

            this.txtExtra.Location = new System.Drawing.Point(140, 187);
            this.txtExtra.Size = new System.Drawing.Size(180, 22);

            // Pulsante aggiungi
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.Location = new System.Drawing.Point(140, 230);
            this.btnAggiungi.Size = new System.Drawing.Size(180, 35);
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);

            // Catalogo
            this.lblCatalogo.Text = "Catalogo:";
            this.lblCatalogo.Location = new System.Drawing.Point(370, 30);
            this.lblCatalogo.AutoSize = true;

            this.lstCatalogo.Location = new System.Drawing.Point(370, 60);
            this.lstCatalogo.Size = new System.Drawing.Size(240, 204);

            // Ricerca
            this.lblRicerca.Text = "Cerca titolo:";
            this.lblRicerca.Location = new System.Drawing.Point(30, 310);
            this.lblRicerca.AutoSize = true;

            this.txtRicerca.Location = new System.Drawing.Point(140, 307);
            this.txtRicerca.Size = new System.Drawing.Size(180, 22);

            this.btnCerca.Text = "Cerca";
            this.btnCerca.Location = new System.Drawing.Point(330, 305);
            this.btnCerca.Size = new System.Drawing.Size(90, 30);
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);

            // Prezzo medio
            this.btnPrezzoMedio.Text = "Calcola prezzo medio";
            this.btnPrezzoMedio.Location = new System.Drawing.Point(30, 370);
            this.btnPrezzoMedio.Size = new System.Drawing.Size(200, 35);
            this.btnPrezzoMedio.Click += new System.EventHandler(this.btnPrezzoMedio_Click);

            // Risultato
            this.lblRisultato.Text = "Risultato:";
            this.lblRisultato.Location = new System.Drawing.Point(30, 430);
            this.lblRisultato.Size = new System.Drawing.Size(580, 50);

            // Aggiunta controlli
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.txtTitolo);

            this.Controls.Add(this.lblAutore);
            this.Controls.Add(this.txtAutore);

            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.txtPrezzo);

            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);

            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.txtExtra);

            this.Controls.Add(this.btnAggiungi);

            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.lstCatalogo);

            this.Controls.Add(this.lblRicerca);
            this.Controls.Add(this.txtRicerca);
            this.Controls.Add(this.btnCerca);

            this.Controls.Add(this.btnPrezzoMedio);
            this.Controls.Add(this.lblRisultato);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
