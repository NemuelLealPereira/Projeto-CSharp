﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MANIADESUSHI.GERENCIA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if( (txtNome.Text == "Nemuel") && (txtSenha.Text == "admin") )
            {
                Form frmRealizarPedido = new frmRealizarPedido(txtNome.Text);
                frmRealizarPedido.Show();
            }
        }
    }
}
