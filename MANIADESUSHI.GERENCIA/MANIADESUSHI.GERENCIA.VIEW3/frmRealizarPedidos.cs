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
           bool contem = false;
           for (int i = 0; i < dgv_carrinho.Rows.Count; i++)
           {
               if (dgv_carrinho[6,i].Value.ToString() == dgv_produtos.CurrentRow.Cells[5].Value.ToString())
               {
                    contem =true;
                   
               }
           }

           if ((!contem)||(dgv_carrinho.Rows.Count == 0)) 
           {
               dgv_carrinho.Rows.Add(null, dgv_produtos.CurrentRow.Cells[0].Value.ToString(), dgv_produtos.CurrentRow.Cells[1].Value.ToString(), dgv_produtos.CurrentRow.Cells[3].Value.ToString(), dgv_produtos.CurrentRow.Cells[4].Value.ToString(), null, dgv_produtos.CurrentRow.Cells[5].Value.ToString());
               
           }
           else
           {
                MessageBox.Show("Já existe este produto. Favor aumentar a sua Quantidade");
           }
           
           
       }
        
       private void dgv_carrinho_CellClick(object sender, DataGridViewCellEventArgs e)
       {

           try
           {
               if (dgv_carrinho.Columns[e.ColumnIndex].Name == "col_excluir")
               {
                   prixTotal = prixTotal - Convert.ToDouble(dgv_carrinho.CurrentRow.Cells[5].Value);
                   lbl_vvalorTotal.Text = string.Format("{0:C}", prixTotal);

                   dgv_carrinho.Rows.Remove(dgv_carrinho.CurrentRow);
                   dgv_carrinho.Refresh();


                   
               }
           }
           catch (Exception)
           {
               //faz algo se der erro
           }
       }

       private void btn_registrarPedido_Click(object sender, EventArgs e)
       {
           int codProduit;
           DateTime horaireDuPedido;
           Dictionary<int, int> dicCodProduit = new Dictionary<int,int>();

           horaireDuPedido = DateTime.Now; 
           
           for (int i = 0; i < dgv_carrinho.Rows.Count; i++)
           {
               codProduit = Convert.ToInt32(dgv_carrinho[3, i].Value.ToString());

               if (dicCodProduit.ContainsKey(codProduit))
               {
                   dicCodProduit[codProduit] = dicCodProduit[codProduit] + 1;
               }
               else
               {
                   dicCodProduit.Add(codProduit, 1);
               }


           }

           try
           {
               objConectar.ouvertConnexion();

               

               //objConectar.enregistreProduit(codProduit);                    

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

       private void dgv_carrinho_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
       {
           dgv_carrinho.Rows[e.RowIndex].Selected = true;
           dgv_carrinho[0, e.RowIndex].Value = "1";
           
           double valorUnitario = Convert.ToDouble( dgv_carrinho[4, e.RowIndex].Value);
           int qtde = Convert.ToInt32(dgv_carrinho[0, e.RowIndex].Value);

           dgv_carrinho[5, e.RowIndex].Value = string.Format("{0:00.00}",valorUnitario * qtde);
           
           prixTotal = prixTotal + Convert.ToDouble(dgv_carrinho[5, e.RowIndex].Value);
           lbl_vvalorTotal.Text = string.Format("{0:C}", prixTotal);
       }

       private void dgv_carrinho_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
       {

           if (e.Control is ComboBox)
           {
               ComboBox comboBox = e.Control as ComboBox;
               comboBox.SelectedIndexChanged += ValeurChoisi;
           }


       }

       private void ValeurChoisi(object sender, EventArgs e)
       {
           var couranteCell = dgv_carrinho.CurrentCellAddress;
           var sendingCB = sender as DataGridViewComboBoxEditingControl;
           DataGridViewTextBoxCell cellvaleurTotale = (DataGridViewTextBoxCell)dgv_carrinho.Rows[couranteCell.Y].Cells[5];
           DataGridViewTextBoxCell cellvaleurUnitaire = (DataGridViewTextBoxCell)dgv_carrinho.Rows[couranteCell.Y].Cells[4];

           prixTotal = prixTotal - Convert.ToDouble(cellvaleurTotale.Value);

           cellvaleurTotale.Value = string.Format("{0:00.00}",
               Convert.ToInt32(sendingCB.EditingControlFormattedValue.ToString()) *
               Convert.ToDouble(cellvaleurUnitaire.Value)
               );


           prixTotal = prixTotal + Convert.ToDouble(cellvaleurTotale.Value);
           lbl_vvalorTotal.Text = string.Format("{0:C}", prixTotal);



       }




    }

       
}
