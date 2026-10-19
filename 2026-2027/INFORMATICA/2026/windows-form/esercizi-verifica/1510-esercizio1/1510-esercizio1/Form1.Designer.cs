namespace _1510_esercizio1
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
        private void InitializeComponent()
        {
            this.txtNomeProdotto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPrezzoIniziale = new System.Windows.Forms.NumericUpDown();
            this.cmbIva = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzoIniziale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeProdotto
            // 
            this.txtNomeProdotto.Location = new System.Drawing.Point(139, 58);
            this.txtNomeProdotto.Name = "txtNomeProdotto";
            this.txtNomeProdotto.Size = new System.Drawing.Size(100, 22);
            this.txtNomeProdotto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome prodotto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezzo iniziale:";
            // 
            // nudPrezzoIniziale
            // 
            this.nudPrezzoIniziale.Location = new System.Drawing.Point(139, 105);
            this.nudPrezzoIniziale.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrezzoIniziale.Name = "nudPrezzoIniziale";
            this.nudPrezzoIniziale.Size = new System.Drawing.Size(120, 22);
            this.nudPrezzoIniziale.TabIndex = 3;
            // 
            // cmbIva
            // 
            this.cmbIva.FormattingEnabled = true;
            this.cmbIva.Items.AddRange(new object[] {
            "0%",
            "10%",
            "22%"});
            this.cmbIva.Location = new System.Drawing.Point(139, 153);
            this.cmbIva.Name = "cmbIva";
            this.cmbIva.Size = new System.Drawing.Size(121, 24);
            this.cmbIva.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "IVA:";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(223, 229);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(75, 23);
            this.btnCalcola.TabIndex = 6;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(330, 232);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(0, 20);
            this.lblRisultato.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbIva);
            this.Controls.Add(this.nudPrezzoIniziale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProdotto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzoIniziale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProdotto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrezzoIniziale;
        private System.Windows.Forms.ComboBox cmbIva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Label lblRisultato;
    }
}

