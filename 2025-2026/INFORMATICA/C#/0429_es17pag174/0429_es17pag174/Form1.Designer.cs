namespace _0429_es17pag174
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private System.Windows.Forms.TextBox txtReparto;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Label lblTitolo;

        private void InitializeComponent()
        {
            this.txtReparto = new System.Windows.Forms.TextBox();
            this.btnConta = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReparto
            // 
            this.txtReparto.Location = new System.Drawing.Point(15, 52);
            this.txtReparto.Name = "txtReparto";
            this.txtReparto.Size = new System.Drawing.Size(200, 22);
            this.txtReparto.TabIndex = 1;
            // 
            // btnConta
            // 
            this.btnConta.Location = new System.Drawing.Point(240, 52);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(200, 30);
            this.btnConta.TabIndex = 2;
            this.btnConta.Text = "Conta pazienti";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(237, 22);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(134, 16);
            this.lblRisultato.TabIndex = 3;
            this.lblRisultato.Text = "Pazienti nel reparto: 0";
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(12, 22);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(182, 16);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Inserisci il reparto da cercare:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 357);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.txtReparto);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.lblRisultato);
            this.Name = "Form1";
            this.Text = "Conteggio Pazienti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}