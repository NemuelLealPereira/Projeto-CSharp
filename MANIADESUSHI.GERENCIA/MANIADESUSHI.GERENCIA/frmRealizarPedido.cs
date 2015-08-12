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
        public frmRealizarPedido()
        {
            InitializeComponent();
        }

        private void frmRealizarPedido_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Esse é o Sabor que vai virar Mania!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmbTipoProduto.Text = "";
            txtNomeProduto.Text = "";
            cmbTipoProduto.Focus();

        }
    }
}
