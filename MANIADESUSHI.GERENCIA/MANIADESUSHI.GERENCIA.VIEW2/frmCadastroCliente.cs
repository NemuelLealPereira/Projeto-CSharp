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
    /// <summary>
    /// Classe qui faire la manipulation du FORM frmCadastroCliente
    /// </summary>
    public partial class frmCadastroCliente : Form
    {

        /// <summary>
        /// Il est utilisé pour additionner le adresse du courant client
        /// </summary>
        private int codeClient;

        /// <summary>
        /// List qui contient tout les clients du DataGridView
        /// </summary>
        private List<string> client = new List<string>();
        
        /// <summary>
        /// Pour remplir la List: List<string> client
        /// </summary>
        private int qtdeClient = 0;

        /// <summary>
        /// Pour faire la connexion
        /// </summary>
        LaConnexion objConectar = new LaConnexion(Properties.Settings.Default.ManiaDeSushiConnectionString);



        /// <summary>
        /// Inicialization du composants
        /// </summary>
        public frmCadastroCliente()
        {
            InitializeComponent();
        }



        /// <summary>
        /// charger le DataGridView avec les données de touts les clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Il Regarde le événement</param>
        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {            
            // Pour mémoriser les données des clients
            DataTable dt = new DataTable();

            try
            {
                objConectar.ouvertConnexion();
             
                dt = objConectar.selectionnerTable("tb_cliente");
                
                objConectar.fermerLaConnexion();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Impossível Carregar os Clientes!.");
                throw;
            }

            dgvCliente.DataSource = dt;
            dgvCliente.Refresh();

            ChargerListClient();
        }



        /// <summary>
        /// Il enregistre le client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Il Regarde le événement</param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            if (!ilEstRempli())
            {
                enregistrerClient();

                enregistrerAdress();
            }
            else
                MessageBox.Show("Campos Obrigatórios: Nome, Email, Contato 1");
        }



        /// <summary>
        /// verifier si les champs de formulaire sont Rempli
        /// </summary>
        /// <returns>Il retourne vrai ou faux</returns>
        private bool ilEstRempli()
        {
            mtxtContato1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // Supprimer le formatage

            string vmtxtContato1 = mtxtContato1.Text; //valeur n'est pas formaté

            if (txtNom.Text.Equals("") || txtEmail.Text.Equals("") || vmtxtContato1.Equals(""))
                return true;
            return false;
        }



        /// <summary>
        /// Enregistrer client
        /// </summary>
        public void enregistrerClient()
        {
            mtxtContato2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // Il suprime le formatage
            string vmtxtContato2 = mtxtContato2.Text; //valeur n'est pas formaté
            mtxtContato2.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // Il retourne la formatation

            mtxtContato3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string vmtxtContato3 = mtxtContato3.Text;
            mtxtContato3.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            Cliente objCliente = new Cliente(txtNom.Text, txtEmail.Text, mtxtContato1.Text, vmtxtContato2, vmtxtContato3);

            try
            {
                objConectar.ouvertConnexion();

                objConectar.insererClient("tb_cliente", objCliente);
                
                this.codeClient = objConectar.retounerCodeClient("tb_cliente", objCliente);
                
                objConectar.fermerLaConnexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossível adicionar o Cliente: " + txtNom.Text + ". Contacte o administrador");
                throw;
            }
        }


        
        /// <summary>
        /// Enregistrer l'adress du client courant
        /// </summary>
        private void enregistrerAdress()
        {
            Form objfrmEnregistreAdresse = new frmEnregistrerAdresse(this.codeClient);
            objfrmEnregistreAdresse.Show();

        }



        /// <summary>
        /// Verifier touts les clients par une partie de son nom et après il modifie le DataGridview avec leur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_btn_pesquisarCliente_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Equals(""))
            {
                MessageBox.Show("Insira o nome do cliente!");
                return;
            }

            client.Clear();

            // Charger le DataGridView avec les données de touts les clients
            this.OnLoad(e);

            // verifier touts les clients par une partie de son nom et après il modifie le DataGridview avec leur.
            client.FindAll(match);

            dgvCliente.Refresh();

            if (qtdeClient == 0) 
            {
                MessageBox.Show("Cliente não cadastrado!");
            }

            qtdeClient = 0;
        
        }



        /// <summary>
        /// Mémoriser les données des clients dans la List client
        /// </summary>
        /// <returns> Il Retourne la list chargé des donées de tout les clients</returns>
        private List<string> ChargerListClient()
        {
            for (int i = 0; i < dgvCliente.Rows.Count; i++)
            {
                client.Add(Convert.ToString(dgvCliente[1, i].Value).ToLower());
            }

            // Il Retourne la list chargé des donées de tout les clients
            return client;
        }



        /// <summary>
        /// Verifier touts les clients par une partie de son nom
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Il retourne vrai ou faux</returns>
        private bool match(string obj)
        {
            if (obj.Contains(txtNom.Text.ToLower()))
            {
                qtdeClient++;
                return true;
            }
            else
            {
                dgvCliente.Rows.Remove(dgvCliente.Rows[qtdeClient]);
                return false;
            }
        }



        /// <summary>
        /// Il nettoye le Formulaire
        /// </summary>
        private void nettoyerFormulaire()
        {
            this.txtNom.Text = "";
            this.txtEmail.Text = "";
            this.mtxtContato1.Text = "";
            this.mtxtContato2.Text = "";
            this.mtxtContato3.Text = "";
        }

    }
}
