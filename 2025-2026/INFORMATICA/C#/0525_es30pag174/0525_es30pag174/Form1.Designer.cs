using System.Drawing;
using System.Windows.Forms;

namespace _0525_es30pag174
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        private void InitializeComponent()
        {
            lblTitolo = new Label();
            dgvElencoProf = new DataGridView();
            lblScuola = new Label();
            txtScuola = new TextBox();
            lblMateria = new Label();
            txtMateria = new TextBox();
            btnConta = new Button();
            lblRisultato = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvElencoProf).BeginInit();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitolo.Location = new Point(13, 16);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "Elenco Docenti";
            // 
            // dgvElencoProf
            // 
            dgvElencoProf.AllowUserToAddRows = false;
            dgvElencoProf.AllowUserToDeleteRows = false;
            dgvElencoProf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElencoProf.Location = new Point(13, 52);
            dgvElencoProf.Margin = new Padding(3, 4, 3, 4);
            dgvElencoProf.Name = "dgvElencoProf";
            dgvElencoProf.ReadOnly = true;
            dgvElencoProf.RowHeadersVisible = false;
            dgvElencoProf.RowHeadersWidth = 51;
            dgvElencoProf.RowTemplate.Height = 24;
            dgvElencoProf.Size = new Size(743, 404);
            dgvElencoProf.TabIndex = 1;
            // 
            // lblScuola
            // 
            lblScuola.AutoSize = true;
            lblScuola.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScuola.Location = new Point(13, 475);
            lblScuola.Name = "lblScuola";
            lblScuola.TabIndex = 2;
            lblScuola.Text = "Nome scuola:";
            // 
            // txtScuola
            // 
            txtScuola.Location = new Point(160, 478);
            txtScuola.Margin = new Padding(3, 4, 3, 4);
            txtScuola.Name = "txtScuola";
            txtScuola.Size = new Size(200, 27);
            txtScuola.TabIndex = 3;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMateria.Location = new Point(13, 520);
            lblMateria.Name = "lblMateria";
            lblMateria.TabIndex = 4;
            lblMateria.Text = "Nome materia:";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(160, 523);
            txtMateria.Margin = new Padding(3, 4, 3, 4);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(200, 27);
            txtMateria.TabIndex = 5;
            // 
            // btnConta
            // 
            btnConta.Location = new Point(380, 495);
            btnConta.Margin = new Padding(3, 4, 3, 4);
            btnConta.Name = "btnConta";
            btnConta.Size = new Size(160, 29);
            btnConta.TabIndex = 6;
            btnConta.Text = "Conta professori";
            btnConta.UseVisualStyleBackColor = true;
            btnConta.Click += btnConta_Click;
            // 
            // lblRisultato
            // 
            lblRisultato.AutoSize = true;
            lblRisultato.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRisultato.Location = new Point(13, 565);
            lblRisultato.Name = "lblRisultato";
            lblRisultato.TabIndex = 7;
            lblRisultato.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 620);
            Controls.Add(lblTitolo);
            Controls.Add(dgvElencoProf);
            Controls.Add(lblScuola);
            Controls.Add(txtScuola);
            Controls.Add(lblMateria);
            Controls.Add(txtMateria);
            Controls.Add(btnConta);
            Controls.Add(lblRisultato);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Conta Professori per Scuola e Materia";
            ((System.ComponentModel.ISupportInitialize)dgvElencoProf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.DataGridView dgvElencoProf;
        private System.Windows.Forms.Label lblScuola;
        private System.Windows.Forms.TextBox txtScuola;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Label lblRisultato;
    }
}
