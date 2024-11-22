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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            
            string usuarioPredeterminado = "5410258";
            string contraseñaPredeterminada = "Gustavo05";

            
            if (txtUser.Text == usuarioPredeterminado && txtPassword.Text == contraseñaPredeterminada)
            {
                
                Inicio form = new Inicio();
                form.Show();
                this.Hide();

                
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {

            txtUser.Text = "";
            txtPassword.Text = "";
            this.Show();
        }
    }
}
