namespace _61_Es24pag116
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstAnimali = new System.Windows.Forms.ListBox();
            this.lstSpecie = new System.Windows.Forms.ListBox();
            this.Specie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnimale = new System.Windows.Forms.TextBox();
            this.btnAnimale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animali";
            // 
            // lstAnimali
            // 
            this.lstAnimali.FormattingEnabled = true;
            this.lstAnimali.ItemHeight = 20;
            this.lstAnimali.Location = new System.Drawing.Point(15, 41);
            this.lstAnimali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAnimali.Name = "lstAnimali";
            this.lstAnimali.Size = new System.Drawing.Size(155, 364);
            this.lstAnimali.TabIndex = 1;
            // 
            // lstSpecie
            // 
            this.lstSpecie.FormattingEnabled = true;
            this.lstSpecie.ItemHeight = 20;
            this.lstSpecie.Location = new System.Drawing.Point(217, 41);
            this.lstSpecie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstSpecie.Name = "lstSpecie";
            this.lstSpecie.Size = new System.Drawing.Size(155, 364);
            this.lstSpecie.TabIndex = 3;
            // 
            // Specie
            // 
            this.Specie.AutoSize = true;
            this.Specie.Location = new System.Drawing.Point(217, 16);
            this.Specie.Name = "Specie";
            this.Specie.Size = new System.Drawing.Size(58, 20);
            this.Specie.TabIndex = 2;
            this.Specie.Text = "Specie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Animale:";
            // 
            // txtAnimale
            // 
            this.txtAnimale.Location = new System.Drawing.Point(548, 16);
            this.txtAnimale.Name = "txtAnimale";
            this.txtAnimale.Size = new System.Drawing.Size(179, 26);
            this.txtAnimale.TabIndex = 5;
            // 
            // btnAnimale
            // 
            this.btnAnimale.Location = new System.Drawing.Point(548, 74);
            this.btnAnimale.Name = "btnAnimale";
            this.btnAnimale.Size = new System.Drawing.Size(179, 37);
            this.btnAnimale.TabIndex = 6;
            this.btnAnimale.Text = "Cerca Specie";
            this.btnAnimale.UseVisualStyleBackColor = true;
            this.btnAnimale.Click += new System.EventHandler(this.btnAnimale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnAnimale);
            this.Controls.Add(this.txtAnimale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSpecie);
            this.Controls.Add(this.Specie);
            this.Controls.Add(this.lstAnimali);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAnimali;
        private System.Windows.Forms.ListBox lstSpecie;
        private System.Windows.Forms.Label Specie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnimale;
        private System.Windows.Forms.Button btnAnimale;
    }
}

