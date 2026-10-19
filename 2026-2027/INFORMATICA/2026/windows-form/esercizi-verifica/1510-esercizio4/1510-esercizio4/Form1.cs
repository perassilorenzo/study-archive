using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1510_esercizio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int schede = 1;
        private void aggiungiSchedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupBox groupbox = new GroupBox();
            TextBox textBox = new TextBox();
            Button button = new Button();
            Label label = new Label();

            this.Controls.Add(groupbox);
            groupbox.Controls.Add(textBox);
            groupbox.Controls.Add(button);
            groupbox.Controls.Add(label);

            groupbox.Size = new Size(200, 120);
            groupbox.Location = new Point(20, 20 + schede * groupbox.Height);
            schede++;

            textBox.Location = new Point(10, 25);
            button.Location = new Point(10, 55);
            label.Location = new Point(10, 85);

            button.Text = "Visualizza";
            button.Click += visualizza;
        }


        private void visualizza(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            GroupBox groupbox = (GroupBox)button.Parent;

            TextBox textBox = groupbox.Controls.OfType<TextBox>().FirstOrDefault();

            MessageBox.Show(textBox.Text);
        }
    }
}
