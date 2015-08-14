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
    public partial class frmRealizarPedido : Form
    {
        String nomeUsuario;
        Boolean PrimeiraLeitura = true;

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
            lerArquivo();

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

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            
            //char v_txtNomeCliente = txtNomeCliente.Text[txtNomeCliente.Text.Length - 1];

            //if (v_txtNomeCliente == ' ')
            //{
            //    cmbTipoProduto.Focus();
            //    txtNomeCliente.Enabled = false;
            //}
        }



        private void cmbTipoProduto_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("c " + cmbTipoProduto.SelectedItem);
        }

        private void lerArquivo()
        {
            StreamReader arqStreamReader = new StreamReader(@"C:\Projeto-CSharp\Pedido.txt");

            //Dados do Cliente:

            //Nome Cliente:

            //Dados do Produto:

            //Tipo Produto:
            //Nome Produto:


            if (PrimeiraLeitura)
            {
                PrimeiraLeitura = false;

                while (!arqStreamReader.EndOfStream)
                {

                    String linhaArqStreamReader = arqStreamReader.ReadLine();

                    switch (linhaArqStreamReader)
                    {
                        case "Nome Cliente:":

                            richTextBox1.Text += "Nome Cliente:" + " " + txtNomeCliente.Text + "\r\n";
                            break;

                        case "Tipo Produto:":
                            richTextBox1.Text += "Tipo Produto:" + " " + cmbTipoProduto.Text + "\r\n";
                            break;
                        case "Nome Produto:":
                            richTextBox1.Text += "Nome Produto:" + " " + txtNomeProduto.Text + "\r\n" + "\r\n" + "Tipo Produto:" + "\r\n" + "Nome Produto:" + "\r\n";
                            break;

                        default:
                            richTextBox1.Text += linhaArqStreamReader + "\r\n";
                            break;
                    }

                    
                }
            }
            else
            {
                richTextBox1.Text = "";
                while (!arqStreamReader.EndOfStream)
                {
                    String linhaArqStreamReader = arqStreamReader.ReadLine();

                    switch (linhaArqStreamReader)
                    {
                        case "Tipo Produto:":
                            richTextBox1.Text += "Tipo Produto:" + " " + cmbTipoProduto.Text + "\r\n";
                            break;
                        case "Nome Produto:":
                            richTextBox1.Text += "Nome Produto:" + " " + txtNomeProduto.Text + "\r\n" + "\r\n" + "Tipo Produto:" + "\r\n" + "Nome Produto:" + "\r\n";
                            break;

                        default:
                            richTextBox1.Text += linhaArqStreamReader + "\r\n";
                            break;
                    }


                }
 
            }

            
            arqStreamReader.Close();

            StreamWriter arqStreamWriter = new StreamWriter(@"C:\Projeto-CSharp\Pedido.txt");
            arqStreamWriter.Write(richTextBox1.Text);            
            arqStreamWriter.Close();
            //richTextBox1.Text = "";


        }


    }
}
