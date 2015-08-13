using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MANIADESUSHI.GERENCIA
{
    public partial class frmRealizarPedido : Form
    {
        String nomeUsuario;


        public frmRealizarPedido()
        {
            InitializeComponent();
        }

        public frmRealizarPedido(String nomeUsuario)
        {
            InitializeComponent();
            this.nomeUsuario = nomeUsuario;
        }

        private void frmRealizarPedido_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " + this.nomeUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmbTipoProduto.Text = "";
            txtNomeProduto.Text = "";
            cmbTipoProduto.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmCliente = new frmClientes(this.nomeUsuario);
            //frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void frmRealizarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
