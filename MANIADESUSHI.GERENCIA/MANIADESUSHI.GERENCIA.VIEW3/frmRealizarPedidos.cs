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

        private double prixTotal = 0;

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

                dgv_produtos.Columns[5].Visible = false;
                
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

           dgv_carrinho.Rows.Add(dgv_produtos.CurrentRow.Cells[0].Value.ToString(), dgv_produtos.CurrentRow.Cells[1].Value.ToString(), dgv_produtos.CurrentRow.Cells[4].Value.ToString(), dgv_produtos.CurrentRow.Cells[5].Value.ToString());
           dgv_carrinho.Refresh();

           prixTotal = prixTotal + Convert.ToDouble(dgv_produtos.CurrentRow.Cells[4].Value.ToString());
           lbl_vvalorTotal.Text = string.Format("{0:C}", prixTotal); 
            
        }
        
       private void dgv_carrinho_CellClick(object sender, DataGridViewCellEventArgs e)
       {

           try
           {
               if (dgv_carrinho.Columns[e.ColumnIndex].Name == "col_excluir")
               {
                   prixTotal = prixTotal - Convert.ToDouble(dgv_carrinho.CurrentRow.Cells[2].Value);
                   lbl_vvalorTotal.Text = string.Format("{0:C}", prixTotal);

                   dgv_carrinho.Rows.Remove(dgv_carrinho.CurrentRow);


                   
               }
           }
           catch (Exception)
           {
               //faz algo se der erro
           }
       }

       private void btn_registrarPedido_Click(object sender, EventArgs e)
       {
           string codProduto;
           
           try
           {
               objConectar.ouvertConnexion();

               for (int i = 0; i < dgv_carrinho.Rows.Count; i++)
               {
                   codProduto = dgv_carrinho[3,i].Value.ToString();
                   objConectar.enregistreProduit(codProduto);                    
               }
               

               dgv_produtos.Columns[5].Visible = false;

               dgv_produtos.Refresh();

               objConectar.fermerLaConnexion();

           }
           catch (Exception)
           {
               MessageBox.Show("Contacte o administrador");
               throw;
           }
           
       }


    }
}
