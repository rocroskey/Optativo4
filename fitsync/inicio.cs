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

            PanelCliente.Visible = true;
            PanelSuscripcion.Visible = false;
        }

        private void suscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelSuscripcion.Visible = true;
            PanelCliente.Visible = false;

        }
    }
}
