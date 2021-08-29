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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mensaje aceptar", "Aceptar");
        }

        private void menu4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 NewMDIChild = new Form2();
            NewMDIChild.MdiParent = this;
            NewMDIChild.Show();
        }
    }
}