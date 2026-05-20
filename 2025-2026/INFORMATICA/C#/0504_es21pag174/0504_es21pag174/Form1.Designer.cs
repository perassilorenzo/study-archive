namespace _0504_es21pag174
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtSquadra;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.ListBox lstGiocatori;
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
            this.txtSquadra = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.lstGiocatori = new System.Windows.Forms.ListBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSquadra
            // 
            this.txtSquadra.Location = new System.Drawing.Point(33, 49);
            this.txtSquadra.Name = "txtSquadra";
            this.txtSquadra.Size = new System.Drawing.Size(200, 22);
            this.txtSquadra.TabIndex = 1;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(260, 43);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(200, 28);
            this.btnCerca.TabIndex = 2;
            this.btnCerca.Text = "Cerca giocatori";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // lstGiocatori
            // 
            this.lstGiocatori.FormattingEnabled = true;
            this.lstGiocatori.ItemHeight = 16;
            this.lstGiocatori.Location = new System.Drawing.Point(33, 94);
            this.lstGiocatori.Name = "lstGiocatori";
            this.lstGiocatori.Size = new System.Drawing.Size(357, 180);
            this.lstGiocatori.TabIndex = 3;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(30, 20);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(194, 16);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Inserisci la squadra da cercare:";
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(257, 24);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(113, 16);
            this.lblRisultato.TabIndex = 4;
            this.lblRisultato.Text = "Giocatori trovati: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 549);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.txtSquadra);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.lstGiocatori);
            this.Controls.Add(this.lblRisultato);
            this.Name = "Form1";
            this.Text = "Calciatori Serie A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}