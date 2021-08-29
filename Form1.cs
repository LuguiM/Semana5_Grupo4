using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana5_Grupo4_controles_de_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Si/No", "Opcion Si/No", MessageBoxButtons.YesNo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mensaje aceptar", "Aceptar");
        }

        private void menu4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 AcercaDe = new Form2();
            _ = AcercaDe.ShowDialog();
        }

        private void menu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Exclamacion", "Opcion Exclamacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Interrogacion", "Opcion Interrogacion", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Error", "Opcion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Aceptar/Cancelar", "Opcion Aceptar/Cancelar", MessageBoxButtons.OKCancel);

        }
    }
}