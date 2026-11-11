
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
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(30, 30);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(44, 16);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Titolo:";
            // 
            // lblAutore
            // 
            this.lblAutore.AutoSize = true;
            this.lblAutore.Location = new System.Drawing.Point(30, 70);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(49, 16);
            this.lblAutore.TabIndex = 2;
            this.lblAutore.Text = "Autore:";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(30, 110);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(51, 16);
            this.lblPrezzo.TabIndex = 4;
            this.lblPrezzo.Text = "Prezzo:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(30, 150);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 16);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(30, 190);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(103, 16);
            this.lblExtra.TabIndex = 8;
            this.lblExtra.Text = "Numero pagine:";
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Location = new System.Drawing.Point(370, 30);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(65, 16);
            this.lblCatalogo.TabIndex = 11;
            this.lblCatalogo.Text = "Catalogo:";
            // 
            // lblRicerca
            // 
            this.lblRicerca.AutoSize = true;
            this.lblRicerca.Location = new System.Drawing.Point(663, 33);
            this.lblRicerca.Name = "lblRicerca";
            this.lblRicerca.Size = new System.Drawing.Size(77, 16);
            this.lblRicerca.TabIndex = 13;
            this.lblRicerca.Text = "Cerca titolo:";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(140, 27);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(180, 22);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(140, 67);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(180, 22);
            this.txtAutore.TabIndex = 3;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(140, 107);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(180, 22);
            this.txtPrezzo.TabIndex = 5;
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(140, 187);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(180, 22);
            this.txtExtra.TabIndex = 9;
            // 
            // txtRicerca
            // 
            this.txtRicerca.Location = new System.Drawing.Point(773, 30);
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(180, 22);
            this.txtRicerca.TabIndex = 14;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Items.AddRange(new object[] {
            "Libro",
            "Rivista"});
            this.cmbTipo.Location = new System.Drawing.Point(140, 147);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(180, 24);
            this.cmbTipo.TabIndex = 7;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(140, 230);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(180, 35);
            this.btnAggiungi.TabIndex = 10;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(963, 28);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(90, 30);
            this.btnCerca.TabIndex = 15;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnPrezzoMedio
            // 
            this.btnPrezzoMedio.Location = new System.Drawing.Point(666, 70);
            this.btnPrezzoMedio.Name = "btnPrezzoMedio";
            this.btnPrezzoMedio.Size = new System.Drawing.Size(200, 35);
            this.btnPrezzoMedio.TabIndex = 16;
            this.btnPrezzoMedio.Text = "Calcola prezzo medio";
            this.btnPrezzoMedio.Click += new System.EventHandler(this.btnPrezzoMedio_Click);
            // 
            // lstCatalogo
            // 
            this.lstCatalogo.ItemHeight = 16;
            this.lstCatalogo.Location = new System.Drawing.Point(370, 60);
            this.lstCatalogo.Name = "lstCatalogo";
            this.lstCatalogo.Size = new System.Drawing.Size(240, 196);
            this.lstCatalogo.TabIndex = 12;
            // 
            // lblRisultato
            // 
            this.lblRisultato.Location = new System.Drawing.Point(666, 130);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(580, 50);
            this.lblRisultato.TabIndex = 17;
            this.lblRisultato.Text = "Risultato:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1079, 710);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Libreria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
