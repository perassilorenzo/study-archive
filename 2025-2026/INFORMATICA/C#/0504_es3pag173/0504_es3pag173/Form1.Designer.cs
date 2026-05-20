namespace _0504_es3pag173
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.ListBox lstLibri;

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
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lstLibri = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(66, 95);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(250, 40);
            this.btnOrdina.TabIndex = 1;
            this.btnOrdina.Text = "Ordina libri";
            this.btnOrdina.UseVisualStyleBackColor = true;
            this.btnOrdina.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(52, 54);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(172, 16);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Ordinamento libri per autore";
            // 
            // lstLibri
            // 
            this.lstLibri.FormattingEnabled = true;
            this.lstLibri.ItemHeight = 16;
            this.lstLibri.Location = new System.Drawing.Point(333, 29);
            this.lstLibri.Name = "lstLibri";
            this.lstLibri.Size = new System.Drawing.Size(400, 180);
            this.lstLibri.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 488);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.lstLibri);
            this.Name = "Form1";
            this.Text = "Selection Sort Libri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}