namespace _1127_esercizio2_excel
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnLeggiExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(201, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 356);
            this.listBox1.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(12, 12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 46);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Crea Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnLeggiExcel
            // 
            this.btnLeggiExcel.Location = new System.Drawing.Point(93, 12);
            this.btnLeggiExcel.Name = "btnLeggiExcel";
            this.btnLeggiExcel.Size = new System.Drawing.Size(75, 46);
            this.btnLeggiExcel.TabIndex = 2;
            this.btnLeggiExcel.Text = "Leggi Excel";
            this.btnLeggiExcel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeggiExcel);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnLeggiExcel;
    }
}

