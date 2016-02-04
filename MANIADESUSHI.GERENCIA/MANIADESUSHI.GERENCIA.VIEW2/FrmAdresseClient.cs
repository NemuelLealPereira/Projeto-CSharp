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
    public partial class FrmAdresseClient : Form
    {
        private DataTable dt;


        public FrmAdresseClient(DataTable dt)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.dt = dt;

          

        }

        private void FrmAdresseClient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
