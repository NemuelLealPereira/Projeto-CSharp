using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MANIADESUSHI.GERENCIA
{
    public partial class frmClientes : Form
    {

        string nomeUsuario;

        string[] aNomeCliente = new string[10];
        string[] aContato = new string[10];
        string[] aCPF = new string[10];
        string[] aCEP = new string[10];
        string[] aBairro = new string[10];
        string[] aRua = new string[10];
        string[] aNumero = new string[10];
        string[] aPontoReferencia = new string[10];

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

            lerDadosClientes();

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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lerDadosClientes()
        {

            StreamReader arqStreamReader = new StreamReader(@"C:\Projeto-CSharp\dados_clientes.txt");
            int i = 0;
            while (!arqStreamReader.EndOfStream)
            {
                
                string registro = arqStreamReader.ReadLine();

                aNomeCliente[i] = registro.Substring(0, 30);
                aContato[i] = registro.Substring(30, 15);
                aCPF[i] = registro.Substring(45, 15);
                aCEP[i] = registro.Substring(60, 10);
                aBairro[i] = registro.Substring(70, 25);
                aRua[i] = registro.Substring(95, 40);
                aNumero[i] = registro.Substring(135, 10);
                aPontoReferencia[i] = registro.Substring(145, 40);

                dgvDadosClientes.Rows.Add(aNomeCliente[i].Trim(), aContato[i].Trim(), aCEP[i].Trim(), aBairro[i].Trim(), aRua[i].Trim());
                i++;
            }
        }

        private void dgvDadosClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
