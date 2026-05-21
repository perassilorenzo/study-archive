namespace _0520_es29pag174
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
            label1 = new Label();
            dgvElencoProf = new DataGridView();
            label2 = new Label();
            txtScuola = new TextBox();
            dgvCercaProf = new DataGridView();
            btnCerca = new Button();
            txtMateria = new TextBox();
            label3 = new Label();
            btnContaMateria = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvElencoProf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCercaProf).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Elenco Docenti";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 479);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 2;
            label2.Text = "Nome scuola:";
            // 
            // txtScuola
            // 
            txtScuola.Location = new Point(184, 484);
            txtScuola.Margin = new Padding(3, 4, 3, 4);
            txtScuola.Name = "txtScuola";
            txtScuola.Size = new Size(182, 27);
            txtScuola.TabIndex = 3;
            // 
            // dgvCercaProf
            // 
            dgvCercaProf.AllowUserToAddRows = false;
            dgvCercaProf.AllowUserToDeleteRows = false;
            dgvCercaProf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCercaProf.Location = new Point(792, 52);
            dgvCercaProf.Margin = new Padding(3, 4, 3, 4);
            dgvCercaProf.Name = "dgvCercaProf";
            dgvCercaProf.ReadOnly = true;
            dgvCercaProf.RowHeadersVisible = false;
            dgvCercaProf.RowHeadersWidth = 51;
            dgvCercaProf.RowTemplate.Height = 24;
            dgvCercaProf.Size = new Size(738, 200);
            dgvCercaProf.TabIndex = 4;
            // 
            // btnCerca
            // 
            btnCerca.Location = new Point(400, 484);
            btnCerca.Margin = new Padding(3, 4, 3, 4);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(136, 29);
            btnCerca.TabIndex = 5;
            btnCerca.Text = "Esegui ricerca";
            btnCerca.UseVisualStyleBackColor = true;
            btnCerca.Click += btnCerca_Click;
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(958, 278);
            txtMateria.Margin = new Padding(3, 4, 3, 4);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(182, 27);
            txtMateria.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(787, 272);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 8;
            label3.Text = "Nome materia:";
            // 
            // btnContaMateria
            // 
            btnContaMateria.Location = new Point(1174, 278);
            btnContaMateria.Margin = new Padding(3, 4, 3, 4);
            btnContaMateria.Name = "btnContaMateria";
            btnContaMateria.Size = new Size(136, 29);
            btnContaMateria.TabIndex = 7;
            btnContaMateria.Text = "Conta per materia";
            btnContaMateria.UseVisualStyleBackColor = true;
            btnContaMateria.Click += btnCercaInsegnantiPerMateria_Click;
            // 
            // button1
            // 
            button1.Location = new Point(792, 342);
            button1.Name = "button1";
            button1.Size = new Size(518, 29);
            button1.TabIndex = 9;
            button1.Text = "Cerca la scuola che ha il numero maggiore di insegnanti";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(792, 377);
            button2.Name = "button2";
            button2.Size = new Size(518, 29);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 905);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCerca);
            Controls.Add(dgvCercaProf);
            Controls.Add(txtScuola);
            Controls.Add(label2);
            Controls.Add(dgvElencoProf);
            Controls.Add(label1);
            Controls.Add(btnContaMateria);
            Controls.Add(txtMateria);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvElencoProf).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCercaProf).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion
        // dichiara i campi in fondo al Designer
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button btnContaMateria;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvElencoProf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScuola;
        private System.Windows.Forms.DataGridView dgvCercaProf;
        private System.Windows.Forms.Button btnCerca;
        private Button button1;
        private Button button2;
    }
}