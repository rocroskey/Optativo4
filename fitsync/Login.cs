﻿using System;
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
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            
            Inicio form = new Inicio();
            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            this.Show();

        }
    }
}
