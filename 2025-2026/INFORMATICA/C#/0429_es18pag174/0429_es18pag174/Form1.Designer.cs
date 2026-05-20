namespace _0429_es18pag174
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
            this.dgvPazientiRicoverati = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPazientiPerReparto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazientiRicoverati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazientiPerReparto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPazientiRicoverati
            // 
            this.dgvPazientiRicoverati.AllowUserToAddRows = false;
            this.dgvPazientiRicoverati.AllowUserToDeleteRows = false;
            this.dgvPazientiRicoverati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPazientiRicoverati.Location = new System.Drawing.Point(13, 105);
            this.dgvPazientiRicoverati.Name = "dgvPazientiRicoverati";
            this.dgvPazientiRicoverati.ReadOnly = true;
            this.dgvPazientiRicoverati.RowHeadersVisible = false;
            this.dgvPazientiRicoverati.RowHeadersWidth = 51;
            this.dgvPazientiRicoverati.RowTemplate.Height = 24;
            this.dgvPazientiRicoverati.Size = new System.Drawing.Size(957, 227);
            this.dgvPazientiRicoverati.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pazienti ricoverati:";
            // 
            // dgvPazientiPerReparto
            // 
            this.dgvPazientiPerReparto.AllowUserToAddRows = false;
            this.dgvPazientiPerReparto.AllowUserToDeleteRows = false;
            this.dgvPazientiPerReparto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPazientiPerReparto.Location = new System.Drawing.Point(13, 412);
            this.dgvPazientiPerReparto.Name = "dgvPazientiPerReparto";
            this.dgvPazientiPerReparto.ReadOnly = true;
            this.dgvPazientiPerReparto.RowHeadersVisible = false;
            this.dgvPazientiPerReparto.RowHeadersWidth = 51;
            this.dgvPazientiPerReparto.RowTemplate.Height = 24;
            this.dgvPazientiPerReparto.Size = new System.Drawing.Size(517, 142);
            this.dgvPazientiPerReparto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pazienti per reparto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPazientiPerReparto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPazientiRicoverati);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazientiRicoverati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazientiPerReparto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPazientiRicoverati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPazientiPerReparto;
        private System.Windows.Forms.Label label2;
    }
}