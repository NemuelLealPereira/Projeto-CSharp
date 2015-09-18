using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MANIADESUSHI.GERENCIA.MODEL;

namespace MANIADESUSHI.GERENCIA.VIEW2
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            insererClient();
        }
      

        private void insererAdress()
        {
            Form objfrmEnregistreAdresse = new frmEnregistrerAdresse();
            objfrmEnregistreAdresse.Show();
        }

        public void insererClient()
        {
            mtxtContato1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            string vmtxtContato1 = mtxtContato1.Text; //texto não formatado
            mtxtContato1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

            mtxtContato2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            string vmtxtContato2 = mtxtContato2.Text; //texto não formatado
            mtxtContato2.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

            mtxtContato3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            string vmtxtContato3 = mtxtContato3.Text; //texto não formatado
            mtxtContato3.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

            Cliente objCliente = new Cliente(txtNom.Text, txtEmail.Text, vmtxtContato1, vmtxtContato2, vmtxtContato3);

            LaConnexion objConectar = new LaConnexion(Properties.Settings.Default.ManiaDeSushiConnectionString);

            try
            {
                objConectar.ouvertConnexion();

                objConectar.inserer("tb_cliente", objCliente);

                objConectar.fermerLaConnexion();

            }
            catch (Exception)
            {
                MessageBox.Show("Impossível Inserir este Cliente!. Verifique os dados");
                throw;
            }
        }



    }
}
