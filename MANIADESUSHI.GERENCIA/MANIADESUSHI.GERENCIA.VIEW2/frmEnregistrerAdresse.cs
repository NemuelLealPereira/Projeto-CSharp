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
        public frmEnregistrerAdresse()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ensererAdresse();
        }

        private void ensererAdresse()
        {

            mtxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // Supprimer le formatage
            string vmtxtCep = mtxtCep.Text; //Le texte n'est pas formatage
            mtxtCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retourner le formatage
            
            Adresse objAdresse = new Adresse(vmtxtCep, cmbCidade.SelectedItem, cmbUF.SelectedItem, txtBairro.Text, txtTipoLogradouro.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text);

            LaConnexion objConectar = new LaConnexion(Properties.Settings.Default.ManiaDeSushiConnectionString);

            try
            {
                objConectar.ouvertConnexion();

                objConectar.inserer("tb_logradouro","tb_endereco", objAdresse);

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
