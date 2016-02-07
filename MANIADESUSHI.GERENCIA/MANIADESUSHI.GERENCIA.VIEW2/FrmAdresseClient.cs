using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANIADESUSHI.GERENCIA.VIEW2
{

    /// <summary>
    /// Il affiche les adresses du client courant
    /// </summary>
    public partial class frmAdresseClient : Form
    {
        /// <summary>
        /// il contient les adresses
        /// </summary>
        private DataTable dt;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="dt"></param>
        public frmAdresseClient(DataTable dt)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.dt = dt;

          

        }

        /// <summary>
        /// Il Charge le dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdresseClient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
