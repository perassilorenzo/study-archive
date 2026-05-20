namespace _0504_es19pag174
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.ListBox lstPazienti;
        private System.Windows.Forms.Label lblTitolo;
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
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.lstPazienti = new System.Windows.Forms.ListBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitolo
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(37, 22);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(168, 16);
            this.lblTitolo.Text = "Inserisci la città da cercare:";

            // txtCitta
            this.txtCitta.Location = new System.Drawing.Point(40, 41);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(200, 22);

            // btnVisualizza
            this.btnVisualizza.Location = new System.Drawing.Point(261, 41);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(200, 30);
            this.btnVisualizza.Text = "Visualizza pazienti";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);

            // lstPazienti
            this.lstPazienti.ItemHeight = 16;
            this.lstPazienti.Location = new System.Drawing.Point(43, 77);
            this.lstPazienti.Name = "lstPazienti";
            this.lstPazienti.Size = new System.Drawing.Size(300, 148);

            // lblRisultato
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(258, 9);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(106, 16);
            this.lblRisultato.Text = "Pazienti trovati: 0";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 474);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.lstPazienti);
            this.Controls.Add(this.lblRisultato);
            this.Name = "Form1";
            this.Text = "Pazienti per città";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}