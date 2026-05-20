namespace MatteoMontepeloso_Es17.Pag._116
{
    partial class FormCanzoni
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
            this.lstCantanti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCanzoni = new System.Windows.Forms.ListBox();
            this.btnCercaCanzoni = new System.Windows.Forms.Label();
            this.lstCanzoniCantanti = new System.Windows.Forms.ListBox();
            this.txtNomeCantante = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCantanti
            // 
            this.lstCantanti.FormattingEnabled = true;
            this.lstCantanti.ItemHeight = 16;
            this.lstCantanti.Location = new System.Drawing.Point(21, 43);
            this.lstCantanti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCantanti.Name = "lstCantanti";
            this.lstCantanti.Size = new System.Drawing.Size(200, 276);
            this.lstCantanti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantanti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Canzoni";
            // 
            // lstCanzoni
            // 
            this.lstCanzoni.FormattingEnabled = true;
            this.lstCanzoni.ItemHeight = 16;
            this.lstCanzoni.Location = new System.Drawing.Point(231, 43);
            this.lstCanzoni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCanzoni.Name = "lstCanzoni";
            this.lstCanzoni.Size = new System.Drawing.Size(209, 276);
            this.lstCanzoni.TabIndex = 2;
            // 
            // btnCercaCanzoni
            // 
            this.btnCercaCanzoni.AutoSize = true;
            this.btnCercaCanzoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaCanzoni.Location = new System.Drawing.Point(571, 43);
            this.btnCercaCanzoni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCercaCanzoni.Name = "btnCercaCanzoni";
            this.btnCercaCanzoni.Size = new System.Drawing.Size(209, 17);
            this.btnCercaCanzoni.TabIndex = 4;
            this.btnCercaCanzoni.Text = "Nome Cantante da Cercare:";
            // 
            // lstCanzoniCantanti
            // 
            this.lstCanzoniCantanti.FormattingEnabled = true;
            this.lstCanzoniCantanti.ItemHeight = 16;
            this.lstCanzoniCantanti.Location = new System.Drawing.Point(574, 98);
            this.lstCanzoniCantanti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCanzoniCantanti.Name = "lstCanzoniCantanti";
            this.lstCanzoniCantanti.Size = new System.Drawing.Size(319, 228);
            this.lstCanzoniCantanti.TabIndex = 5;
            // 
            // txtNomeCantante
            // 
            this.txtNomeCantante.Location = new System.Drawing.Point(574, 68);
            this.txtNomeCantante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeCantante.Name = "txtNomeCantante";
            this.txtNomeCantante.Size = new System.Drawing.Size(153, 22);
            this.txtNomeCantante.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cerca Canzoni";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormCanzoni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNomeCantante);
            this.Controls.Add(this.lstCanzoniCantanti);
            this.Controls.Add(this.btnCercaCanzoni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCanzoni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCantanti);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCanzoni";
            this.Text = "Canzoni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCantanti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCanzoni;
        private System.Windows.Forms.Label btnCercaCanzoni;
        private System.Windows.Forms.ListBox lstCanzoniCantanti;
        private System.Windows.Forms.TextBox txtNomeCantante;
        private System.Windows.Forms.Button button1;
    }
}

