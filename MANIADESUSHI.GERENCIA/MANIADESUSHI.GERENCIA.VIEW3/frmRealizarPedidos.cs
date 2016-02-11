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


namespace MANIADESUSHI.GERENCIA.VIEW3
{
    public partial class frmRealizarPedidos : Form
    {

        
        /// <summary>
        /// Pour faire la connexion
        /// </summary>
        LaConnexion objConectar = new LaConnexion(Properties.Settings.Default.ManiaDeSushiConnectionString);


        public frmRealizarPedidos()
        {
            InitializeComponent();
        }

        private void frmRealizarPedidos_Load(object sender, EventArgs e)
        {
            try
            {
                objConectar.ouvertConnexion();

                dgv_produtos.DataSource = objConectar.produit();

                dgv_produtos.Refresh();

                objConectar.fermerLaConnexion();

            }
            catch (Exception)
            {
                MessageBox.Show("Contacte o administrador");
                throw;
            }

        }

       private void dgv_produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_carrinho.Rows.Add(dgv_produtos.CurrentRow.Cells[0].Value.ToString(), dgv_produtos.CurrentRow.Cells[1].Value.ToString(), dgv_produtos.CurrentRow.Cells[4].Value.ToString());
            dgv_carrinho.Refresh();

           double prixTotal = 0;

            for (int i = 0; i < dgv_carrinho.Rows.Count; i++)
            {
                prixTotal = prixTotal + Convert.ToDouble(dgv_carrinho[2, i].Value);
            }

            lbl_vvalorTotal.Text = string.Format("{0:C}", prixTotal); 
            
        }
    }
}
