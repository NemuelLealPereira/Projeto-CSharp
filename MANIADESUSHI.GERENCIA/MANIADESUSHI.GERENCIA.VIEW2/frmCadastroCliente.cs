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

        private int codeClient;
        private string vmtxtContato1;



        public frmCadastroCliente()
        {
            InitializeComponent();
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ilEstRempli())
            {
                insererClient();
                insererAdress(); 
                //nettoyerFormulaire();
            }
            else
                MessageBox.Show("Campos Obrigatórios: Nome, Email, Contato 1");
        }



        public void insererClient()
        {
            //mtxtContato1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
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

                objConectar.insererClient("tb_cliente", objCliente);
                
                this.codeClient = objConectar.retounerCodeClient("tb_cliente", objCliente);

                objConectar.fermerLaConnexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossível Inserir este Cliente!. Verifique os dados");
                throw;
            }
        }

        
        
        private void insererAdress()
        {
            Form objfrmEnregistreAdresse = new frmEnregistrerAdresse(this.codeClient);
            objfrmEnregistreAdresse.Show();

        }

        

        private void nettoyerFormulaire()
        {
            this.txtNom.Text = "";
            this.txtEmail.Text = "";
            this.mtxtContato1.Text = "";
            this.mtxtContato2.Text = "";
            this.mtxtContato3.Text = "";
        }



        private bool ilEstRempli()
        {
            mtxtContato1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // Supprimer le formatage
            string vmtxtContato1 = mtxtContato1.Text; //Le texte n'est pas formatage

            if (txtNom.Text.Equals("") || txtEmail.Text.Equals("") || vmtxtContato1.Equals(""))
                return true;
            return false;


        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            LaConnexion objConectar = new LaConnexion(Properties.Settings.Default.ManiaDeSushiConnectionString);

            try
            {
                objConectar.ouvertConnexion();
                                
                DataTable dt = new DataTable();
                dt = objConectar.selectionnerTable("tb_cliente");
                //dgvCliente = new DataGridView(); il ne peut pas utilizer new
                dgvCliente.DataSource = dt;
                dgvCliente.Refresh();

                    

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
