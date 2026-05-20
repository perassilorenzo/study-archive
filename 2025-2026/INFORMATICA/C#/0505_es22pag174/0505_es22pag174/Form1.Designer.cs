namespace _0505_es22pag174
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvgCalciatori = new System.Windows.Forms.DataGridView();
            this.btnCerca = new System.Windows.Forms.Button();
            this.lblDati = new System.Windows.Forms.Label();
            this.lstDatiCaricati = new System.Windows.Forms.ListBox();
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCalciatori)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCalciatori
            // 
            this.dvgCalciatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCalciatori.Location = new System.Drawing.Point(319, 35);
            this.dvgCalciatori.Name = "dvgCalciatori";
            this.dvgCalciatori.Size = new System.Drawing.Size(354, 183);
            this.dvgCalciatori.TabIndex = 33;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(598, 6);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 32;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // lblDati
            // 
            this.lblDati.AutoSize = true;
            this.lblDati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDati.Location = new System.Drawing.Point(9, 16);
            this.lblDati.Name = "lblDati";
            this.lblDati.Size = new System.Drawing.Size(111, 13);
            this.lblDati.TabIndex = 31;
            this.lblDati.Text = "Calciatori Caricati:";
            // 
            // lstDatiCaricati
            // 
            this.lstDatiCaricati.FormattingEnabled = true;
            this.lstDatiCaricati.Location = new System.Drawing.Point(12, 32);
            this.lstDatiCaricati.Name = "lstDatiCaricati";
            this.lstDatiCaricati.Size = new System.Drawing.Size(301, 186);
            this.lstDatiCaricati.TabIndex = 30;
            // 
            // txtCerca
            // 
            this.txtCerca.Location = new System.Drawing.Point(472, 6);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(120, 20);
            this.txtCerca.TabIndex = 29;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(416, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 13);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "N Goal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 248);
            this.Controls.Add(this.dvgCalciatori);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.lblDati);
            this.Controls.Add(this.lstDatiCaricati);
            this.Controls.Add(this.txtCerca);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCalciatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCalciatori;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label lblDati;
        private System.Windows.Forms.ListBox lstDatiCaricati;
        private System.Windows.Forms.TextBox txtCerca;
        private System.Windows.Forms.Label lblNome;
    }
}
