namespace _0504_es2pag173
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnCalcola;

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
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(259, 146);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(201, 39);
            this.btnCalcola.TabIndex = 0;
            this.btnCalcola.Text = "Trova autore con più libri";
            this.btnCalcola.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 388);
            this.Controls.Add(this.btnCalcola);
            this.Name = "Form1";
            this.Text = "Libri - Autore massimo";
            this.ResumeLayout(false);

        }
    }
}