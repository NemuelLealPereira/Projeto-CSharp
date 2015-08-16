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

        string[] aNomeCliente = new string[15];
        string[] aContato = new string[15];
        string[] aCPF = new string[15];
        string[] aCEP = new string[15];
        string[] aBairro = new string[15];
        string[] aRua = new string[15];
        string[] aNumero = new string[15];
        string[] aPontoReferencia = new string[15];
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

            arqStreamReader.Close();
        }

        private void dgvDadosClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (modo != "Alterar")
            {
                int indiceDaLinhaSelecionada = dgvDadosClientes.CurrentRow.Index;
                string nomeCliente = Convert.ToString(dgvDadosClientes[0, indiceDaLinhaSelecionada].Value);
                setDadosClientesCampos(nomeCliente);
                desabilitarDados();
            }
        }

        private void setDadosClientesCampos(string nomeCliente)
        {
            int i;
            for (i = 0; (i < aNomeCliente.Length) && (aNomeCliente[i] != nomeCliente); i++) ;
            
                txtNome.Text = aNomeCliente[i];
                mtxtContato.Text = aContato[i];
                mtxtCPF.Text = aCPF[i];
                mtxtCEP.Text = aCEP[i];
                txtBairro.Text = aBairro[i];
                txtRua.Text = aRua[i];
                txtNumero.Text = aNumero[i];
                txtPR.Text = aPontoReferencia[i];


            
        }

        private void setDadosClientesArray(int linhadgvDadosClientes)
        {
            //aNomeCliente[linhadgvDadosClientes] = txtNome.Text;
            mtxtContato.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            aContato[linhadgvDadosClientes] = mtxtContato.Text; //texto não formatado
            mtxtContato.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

            mtxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            aCPF[linhadgvDadosClientes] = mtxtCPF.Text; //texto não formatado
            mtxtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

            mtxtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            aCEP[linhadgvDadosClientes] = mtxtCEP.Text; //texto não formatado
            mtxtCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação
            
            aBairro[linhadgvDadosClientes] = txtBairro.Text;
            aRua[linhadgvDadosClientes] = txtRua.Text;
            aNumero[linhadgvDadosClientes] = txtNumero.Text;
            aPontoReferencia[linhadgvDadosClientes] = txtPR.Text;
        }

        private void adicionarCliente(int ultimalinha)
        {
            aNomeCliente[ultimalinha] = txtNome.Text;
            
            mtxtContato.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            aContato[ultimalinha] = mtxtContato.Text; //texto não formatado
            mtxtContato.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

            mtxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            aCPF[ultimalinha] = mtxtCPF.Text; //texto não formatado
            mtxtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

            mtxtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            aCEP[ultimalinha] = mtxtCEP.Text; //texto não formatado
            mtxtCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

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
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnRemover.Enabled = true;

            if (!txtNome.Text.Equals(""))
            {
             
            this.modo = "Alterar";
            this.toolStripStatusLabel1.Text = "Modo de Alteração";
            habilitarDados();   
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
            switch (this.modo)
            {
                case "Alterar":

                    int armazenaIndice = 0;
                    dgvDadosClientes.Rows.Clear();

                    for (int i = 0; (i < aNomeCliente.Length) && (aNomeCliente[i] != null); i++)
                    {
                        if (aNomeCliente[i] == txtNome.Text)
                        {
                            setDadosClientesArray(i);
                            armazenaIndice = i;
                        }

                        dgvDadosClientes.Rows.Add(aNomeCliente[i], aContato[i], aCEP[i], aBairro[i], aRua[i]);

                    }
                    dgvDadosClientes.Rows[armazenaIndice].Selected = true;

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


            btnRemover.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;

            this.modo = "";
            toolStripStatusLabel1.Text = "Operação Realizada com Sucesso!";
            desabilitarDados();


            }
        }


        private void atualizarGrid(int indice)
        {
            dgvDadosClientes.Rows.Add(aNomeCliente[indice], aContato[indice], aCEP[indice], aBairro[indice], aRua[indice]);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.modo = "Inserir";
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
            btnRemover.Enabled = true;

            this.toolStripStatusLabel1.Text = "Modo de Inserção";
            limparCampos();
            this.txtNome.Enabled = true;
            habilitarDados();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            desabilitarDados();
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            btnRemover.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            desabilitarDados();

        }

        private void frmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            string linhaArqStreamWriter = "";
            StreamWriter arqStreamWriter = new StreamWriter(@"C:\Projeto-CSharp\dados_clientes.txt");
            for (int i = 0; i < aNomeCliente.Length && (aNomeCliente[i] != null); i++)
            {                
                linhaArqStreamWriter += string.Format("{0}                              ", aNomeCliente[i]).Substring(0, 30);
                linhaArqStreamWriter += string.Format("{0}               ", aContato[i]).Substring(0, 15);
                linhaArqStreamWriter += string.Format("{0}               ", aCPF[i]).Substring(0, 15);
                linhaArqStreamWriter += string.Format("{0}          ", aCEP[i]).Substring(0, 10);
                linhaArqStreamWriter += string.Format("{0}                         ", aBairro[i]).Substring(0, 25);
                linhaArqStreamWriter += string.Format("{0}                                        ", aRua[i]).Substring(0, 40);
                linhaArqStreamWriter += string.Format("{0}          ", aNumero[i]).Substring(0, 10);
                linhaArqStreamWriter += string.Format("{0}                                        ", aPontoReferencia[i]).Substring(0, 40);

                arqStreamWriter.WriteLine(linhaArqStreamWriter);
                linhaArqStreamWriter = "";
                
                
            }
            arqStreamWriter.Close();
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
