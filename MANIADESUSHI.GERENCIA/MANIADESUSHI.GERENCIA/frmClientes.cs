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
    public partial class frmClientes : Form
    {

        String nomeUsuario;

        public frmClientes()
        {
            InitializeComponent();
        }

        public frmClientes(String nomeUsuario)
        {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
        }
        

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " + this.nomeUsuario;

            if (this.nomeUsuario == "Administrador")
            {
                clienteVipToolStripMenuItem.Enabled = true;

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Visible = false;
            toolStripProgressBar1.Visible = true;           
            
            for (int i = 0; i < 100000; i++)
            {
                
                toolStripProgressBar1.Value = i;
            }

            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = "Pronto";
            

            toolStripProgressBar1.Visible = false;
        }

        private void clienteVipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clienteVipToolStripMenuItem.Checked)
            {
                clienteVipToolStripMenuItem.Checked = false;
            }
            else
            {
                clienteVipToolStripMenuItem.Checked = true;
            }
                    


        }
    }
}
