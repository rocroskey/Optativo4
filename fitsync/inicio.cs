using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitsync
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.Text = "Gustavo";
            textBox2.Text = "Sosa";
            textBox3.Text = "26";

            PanelCliente.Visible = true;
            PanelSuscripcion.Visible = false;
        }

        private void suscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox4.Text = "Activo";
            textBox5.Text = "Nivel 2";
            textBox6.Text = "05/12/2024";

            PanelSuscripcion.Visible = true;
            PanelCliente.Visible = false;

        }
    }
}
