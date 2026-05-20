namespace _0504_es4pag173
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.ListBox lstLibri;
        private System.Windows.Forms.Label lblTitolo;

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
            this.btnOrdina = new System.Windows.Forms.Button();
            this.lstLibri = new System.Windows.Forms.ListBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(70, 119);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(250, 40);
            this.btnOrdina.TabIndex = 1;
            this.btnOrdina.Text = "Ordina per prezzo";
            this.btnOrdina.UseVisualStyleBackColor = true;
            this.btnOrdina.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // lstLibri
            // 
            this.lstLibri.FormattingEnabled = true;
            this.lstLibri.ItemHeight = 16;
            this.lstLibri.Location = new System.Drawing.Point(388, 20);
            this.lstLibri.Name = "lstLibri";
            this.lstLibri.Size = new System.Drawing.Size(400, 180);
            this.lstLibri.TabIndex = 2;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(131, 80);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(145, 16);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Libri ordinati per prezzo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 451);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.lstLibri);
            this.Name = "Form1";
            this.Text = "Bubble Sort - Prezzo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}