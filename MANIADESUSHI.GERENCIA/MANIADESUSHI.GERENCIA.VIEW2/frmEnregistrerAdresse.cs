using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MANIADESUSHI.GERENCIA.MODEL;

namespace MANIADESUSHI.GERENCIA.VIEW2
{
    public partial class frmEnregistrerAdresse : Form
    {


        private int codeClient;
        private int codeLogradouro;
        LaConnexion objConectar = new LaConnexion(Properties.Settings.Default.ManiaDeSushiConnectionString);
        List<string> registerLogradouro = new List<string>();
        private string vmtxtCep;


        public frmEnregistrerAdresse(int codeClient)
        {
            InitializeComponent();

            this.codeClient = codeClient;
            
            this.cmbUF.SelectedItem = "BA";
            this.cmbUF.Enabled = false;

            this.cmbCidade.SelectedItem = "Salvador";
            this.cmbCidade.Enabled = false;
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            ensererAdresse();
        }



        private void ensererAdresse()
        {
            mtxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // Supprimer le formatage
            vmtxtCep = mtxtCep.Text; //Le texte n'est pas formatage
            mtxtCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retourner le formatage

            Adresse objAdresse = new Adresse(vmtxtCep, cmbCidade.SelectedItem, cmbUF.SelectedItem, txtBairro.Text, txtTipoLogradouro.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, codeClient);
            
            try
            {
                objConectar.ouvertConnexion();

                objConectar.insererLogradouro("tb_logradouro", objAdresse);
                
                this.codeLogradouro = objConectar.retounerCodeLogradouro("tb_logradouro", objAdresse);

                objConectar.insererAdresse("tb_endereco", objAdresse, this.codeLogradouro);

                objConectar.fermerLaConnexion();

            }
            catch (Exception)
            {
                MessageBox.Show("Impossível Inserir este Endereço!. Contate o Desenvolvedor");
                throw;
            }
        }



        private void mtxtCep_Leave(object sender, EventArgs e)
        {

            mtxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // Supprimer le formatage
            vmtxtCep = mtxtCep.Text; //Le texte n'est pas formatage
            mtxtCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retourner le formatage

            try
            {
                objConectar.ouvertConnexion();

                registerLogradouro = objConectar.returnerLogradouro("tb_logradouro", vmtxtCep);

                objConectar.fermerLaConnexion();

                if (!remplirFormulaire())
                {
                    if (!txtLogradouro.Enabled)
                    {
                        permettreChamps();
                        nettoyerFormulaire();
                    }

                    this.Show();

                   

                }

                

            }
            catch (Exception)
            {
                MessageBox.Show("Impossível Inserir este Endereço!. Contate o Desenvolvedor");
                throw;
            }

        }



        private bool remplirFormulaire()
        {
            if (!registerLogradouro.Count.Equals(0))
            {
                cmbUF.SelectedItem = registerLogradouro[1];
               
                cmbCidade.SelectedItem = registerLogradouro[2];
               
                txtTipoLogradouro.Text = registerLogradouro[3];
                txtTipoLogradouro.Enabled = false;

                txtLogradouro.Text = registerLogradouro[4];
                txtLogradouro.Enabled = false;

                txtBairro.Text = registerLogradouro[5];
                txtBairro.Enabled = false;

                return true;
            }
            return false;
        }

        private void permettreChamps()
        {

            this.txtTipoLogradouro.Enabled = true;
            this.txtLogradouro.Enabled = true;
            this.txtBairro.Enabled = true;
        }

        private void nettoyerFormulaire()
        {
            this.txtTipoLogradouro.Text = "";
            this.txtLogradouro.Text = "";
            this.txtBairro.Text = "";
        }
        



    }
}
