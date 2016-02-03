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

    /// <summary>
    /// Form pour enregistrer les adress des clients
    /// </summary>
    public partial class frmEnregistrerAdresse : Form
    {

        /// <summary>
        /// codeClient est passé par paramètre pour indentifier uniquement le client courant
        /// </summary>
        private int codeClient;

        /// <summary>
        /// Pour faire la connexion
        /// </summary>
        LaConnexion objConectar = new LaConnexion(Properties.Settings.Default.ManiaDeSushiConnectionString);

        /// <summary>
        /// Pour mémoriser le logradouro complet
        /// </summary>
        List<string> registerLogradouro = new List<string>();
             


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="codeClient"></param>
        public frmEnregistrerAdresse(int codeClient)
        {
            InitializeComponent();

            this.codeClient = codeClient;
            
            this.cmbUF.SelectedItem = "BA";
            this.cmbUF.Enabled = false;

            this.cmbCidade.SelectedItem = "Salvador";
            this.cmbCidade.Enabled = false;
        }



        /// <summary>
        /// Ce methode rempli le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtCep_Leave(object sender, EventArgs e)
        {

            mtxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // Supprimer le formatage 
            string vmtxtCep = mtxtCep.Text; //Le texte n'est pas formaté
            mtxtCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retourner le formatage

            if (vmtxtCep.Equals(""))
            {
                MessageBox.Show("Favor inserir o CEP.");
                mtxtCep.Focus();
                return;
            }


            try
            {
                objConectar.ouvertConnexion();

                // reourner tout les valeurs camps de la table logradouro
                registerLogradouro = objConectar.returnerLogradouro("tb_logradouro", vmtxtCep);

                objConectar.fermerLaConnexion();                

            }
            catch (Exception)
            {
                MessageBox.Show("Impossível Inserir este Endereço!. Contate o Desenvolvedor");
                throw;
            }

            //si il y a logradouro le focus va pour le camp txtNumero
            if (!remplirFormulaire())
            {

                if (!txtLogradouro.Enabled)
                {
                    permettreChamps();
                    nettoyerFormulaire();
                }
            }


            this.Show();

        }




        /// <summary>
        /// Il rempli le Formulaire
        /// </summary>
        /// <returns>Il retourne vrai ou faux</returns>
        private bool remplirFormulaire()
        {
            if (!registerLogradouro.Count.Equals(0))
            {
                //cmbUF.SelectedItem = registerLogradouro[2];

                //cmbCidade.SelectedItem = registerLogradouro[3];

                txtTipoLogradouro.Text = registerLogradouro[4];
                txtTipoLogradouro.Enabled = false;

                txtLogradouro.Text = registerLogradouro[5];
                txtLogradouro.Enabled = false;

                txtBairro.Text = registerLogradouro[6];
                txtBairro.Enabled = false;

                return true;
            }
            return false;
        }
        
        
        
        /// <summary>
        /// il permet les camps
        /// </summary>
        private void permettreChamps()
        {
            this.txtTipoLogradouro.Enabled = true;
            this.txtLogradouro.Enabled = true;
            this.txtBairro.Enabled = true;
        }
        


        /// <summary>
        /// Il nettoye le Formulaire
        /// </summary>
        private void nettoyerFormulaire()
        {
            this.txtTipoLogradouro.Text = "";
            this.txtLogradouro.Text = "";
            this.txtBairro.Text = "";
        }



        /// <summary>
        /// Il enregistre le adress du client courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ensererAdresse();

            this.Close();

        }



        /// <summary>
        /// Il enregistre le adress du client courant
        /// </summary>
        private void ensererAdresse()
        {
            mtxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // Supprimer le formatage
            string vmtxtCep = mtxtCep.Text; //Le texte n'est pas formatage
            mtxtCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retourner le formatage

            Adresse objAdresse = new Adresse(vmtxtCep, cmbCidade.SelectedItem, cmbUF.SelectedItem, txtBairro.Text, txtTipoLogradouro.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, codeClient);


            if (!txtLogradouro.Enabled)
            {
                try
                {
                    objConectar.ouvertConnexion();

                    objConectar.insererAdresse("tb_endereco", objAdresse, Convert.ToInt32(registerLogradouro[0]));

                    objConectar.fermerLaConnexion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Impossível Inserir este Endereço!. Contate o Desenvolvedor: {0}", ex.Message));
                    throw;
                }

            }
            else
            {

                int codeLogradouro;

                try
                {
                    objConectar.ouvertConnexion();

                    objConectar.insererLogradouro("tb_logradouro", objAdresse);

                    codeLogradouro = objConectar.retounerCodeLogradouro("tb_logradouro", objAdresse);

                    objConectar.insererAdresse("tb_endereco", objAdresse, codeLogradouro);

                    objConectar.fermerLaConnexion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Impossível Inserir este Endereço!. Contate o Desenvolvedor: {0}", ex.Message));
                    throw;
                }
            }
        }
        
    }
}
