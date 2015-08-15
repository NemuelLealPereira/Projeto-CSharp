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
        string modo;

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

            this.modo = "";
            getDadosClientes();
            limparCampos();

        }


        private void getDadosClientes()
        {

            StreamReader arqStreamReader = new StreamReader(@"C:\Projeto-CSharp\dados_clientes.txt");
            int i = 0;
            while (!arqStreamReader.EndOfStream)
            {

                string registro = arqStreamReader.ReadLine();

                aNomeCliente[i] = registro.Substring(0, 30).Trim();
                aContato[i] = registro.Substring(30, 15).Trim();
                aCPF[i] = registro.Substring(45, 15).Trim();
                aCEP[i] = registro.Substring(60, 10).Trim();
                aBairro[i] = registro.Substring(70, 25).Trim();
                aRua[i] = registro.Substring(95, 40).Trim();
                aNumero[i] = registro.Substring(135, 10).Trim();
                aPontoReferencia[i] = registro.Substring(145, 40).Trim();

                dgvDadosClientes.Rows.Add(aNomeCliente[i], aContato[i], aCEP[i], aBairro[i], aRua[i]);
                i++;
            }
        }

        private void dgvDadosClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (modo != "Alterar")
            {
                int linhadgvDadosClientes = dgvDadosClientes.CurrentRow.Index;
                setDadosClientesCampos(linhadgvDadosClientes);
                desabilitarDados();
            }
        }

        private void setDadosClientesCampos(int linhadgvDadosClientes)
        {
            txtNome.Text = aNomeCliente[linhadgvDadosClientes];
            mtxtContato.Text = aContato[linhadgvDadosClientes];
            mtxtCPF.Text = aCPF[linhadgvDadosClientes];
            mtxtCEP.Text = aCEP[linhadgvDadosClientes];
            txtBairro.Text = aBairro[linhadgvDadosClientes];
            txtRua.Text = aRua[linhadgvDadosClientes];
            txtNumero.Text = aNumero[linhadgvDadosClientes];
            txtPR.Text = aPontoReferencia[linhadgvDadosClientes];
        }

        private void setDadosClientesArray(int linhadgvDadosClientes)
        {
            //aNomeCliente[linhadgvDadosClientes] = txtNome.Text;
            aContato[linhadgvDadosClientes] = mtxtContato.Text;
            aCPF[linhadgvDadosClientes] = mtxtCPF.Text;
            aCEP[linhadgvDadosClientes] = mtxtCEP.Text;
            aBairro[linhadgvDadosClientes] = txtBairro.Text;
            aRua[linhadgvDadosClientes] = txtRua.Text;
            aNumero[linhadgvDadosClientes] = txtNumero.Text;
            aPontoReferencia[linhadgvDadosClientes] = txtPR.Text;
        }

        private void adicionarCliente(int ultimalinha)
        {
            aNomeCliente[ultimalinha] = txtNome.Text;
            aContato[ultimalinha] = mtxtContato.Text;
            aCPF[ultimalinha] = mtxtCPF.Text;
            aCEP[ultimalinha] = mtxtCEP.Text;
            aBairro[ultimalinha] = txtBairro.Text;
            aRua[ultimalinha] = txtRua.Text;
            aNumero[ultimalinha] = txtNumero.Text;
            aPontoReferencia[ultimalinha] = txtPR.Text;
        }

        private void desabilitarDados()
        {
            txtNome.Enabled = false;
            mtxtContato.Enabled = false;
            mtxtCPF.Enabled = false;
            mtxtCEP.Enabled = false;
            txtBairro.Enabled = false;
            txtRua.Enabled = false;
            txtNumero.Enabled = false;
            txtPR.Enabled = false;
        }

        private void habilitarDados()
        {
            //txtNome.Enabled = true;
            mtxtContato.Enabled = true;
            mtxtCPF.Enabled = true;
            mtxtCEP.Enabled = true;
            txtBairro.Enabled = true;
            txtRua.Enabled = true;
            txtNumero.Enabled = true;
            txtPR.Enabled = true;
            txtNome.Focus();
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            mtxtContato.Text = "";
            mtxtCPF.Text = "";
            mtxtCEP.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtPR.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.modo = "Alterar";
            this.toolStripStatusLabel1.Text = "Modo de Alteração";
            habilitarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (this.modo)
            {
                case "Alterar":

                    dgvDadosClientes.Rows.Clear();

                    for (int i = 0; (i < aNomeCliente.Length) && (aNomeCliente[i] != null); i++)
                    {
                        if (aNomeCliente[i] == txtNome.Text)
                            setDadosClientesArray(i);

                        dgvDadosClientes.Rows.Add(aNomeCliente[i], aContato[i], aCEP[i], aBairro[i], aRua[i]);
                        this.modo = "";
                        toolStripStatusLabel1.Text = "Operação Realizada com Sucesso!";
                        desabilitarDados();
                    }
                    break;

                case "Inserir":

                    int ultimalinha = dgvDadosClientes.Rows.Count;

                    adicionarCliente(ultimalinha);
                    dgvDadosClientes.Rows.Add(aNomeCliente[ultimalinha], aContato[ultimalinha], aCEP[ultimalinha], aBairro[ultimalinha], aRua[ultimalinha]);

                    dgvDadosClientes[0, ultimalinha].Selected = true;

                    break;

                case "Excluir":
                    break;

                default:
                    break;
            }
        }


        private void atualizarGrid(int indice)
        {
            dgvDadosClientes.Rows.Add(aNomeCliente[indice], aContato[indice], aCEP[indice], aBairro[indice], aRua[indice]);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.modo = "Inserir";
            this.toolStripStatusLabel1.Text = "Modo de Inserção";
            limparCampos();
            this.txtNome.Enabled = true;
            habilitarDados();
        }

    }




    //private void button1_Click(object sender, EventArgs e)
    //{
    //    toolStripStatusLabel1.Visible = false;
    //    toolStripProgressBar1.Visible = true;

    //    for (int i = 0; i < 100000; i++)
    //    {

    //        toolStripProgressBar1.Value = i;
    //    }

    //    toolStripStatusLabel1.Visible = true;
    //    toolStripStatusLabel1.Text = "Pronto";


    //    toolStripProgressBar1.Visible = false;
    //}




    //private void clienteVipToolStripMenuItem_Click(object sender, EventArgs e)
    //{
    //    if (clienteVipToolStripMenuItem.Checked)
    //    {
    //        clienteVipToolStripMenuItem.Checked = false;
    //    }
    //    else
    //    {
    //        clienteVipToolStripMenuItem.Checked = true;
    //    }



    //}
}
