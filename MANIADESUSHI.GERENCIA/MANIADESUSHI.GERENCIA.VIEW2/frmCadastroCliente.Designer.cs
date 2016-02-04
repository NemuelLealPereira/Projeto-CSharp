namespace MANIADESUSHI.GERENCIA.VIEW2
{
    partial class frmCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                //components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maniaDeSushiDataSet = new MANIADESUSHI.GERENCIA.VIEW2.ManiaDeSushiDataSet();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.mtxtContato3 = new System.Windows.Forms.MaskedTextBox();
            this.lbContato3 = new System.Windows.Forms.Label();
            this.mtxtContato2 = new System.Windows.Forms.MaskedTextBox();
            this.lbContato2 = new System.Windows.Forms.Label();
            this.mtxtContato1 = new System.Windows.Forms.MaskedTextBox();
            this.lbContato1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btn_pesquisarCliente = new System.Windows.Forms.Button();
            this.tb_clienteTableAdapter = new MANIADESUSHI.GERENCIA.VIEW2.ManiaDeSushiDataSetTableAdapters.tb_clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maniaDeSushiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 92);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(115, 31);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(285, 20);
            this.txtNom.TabIndex = 21;
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "tb_cliente";
            this.tbclienteBindingSource.DataSource = this.maniaDeSushiDataSet;
            // 
            // maniaDeSushiDataSet
            // 
            this.maniaDeSushiDataSet.DataSetName = "ManiaDeSushiDataSet";
            this.maniaDeSushiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbEmail.Location = new System.Drawing.Point(31, 93);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 26;
            this.lbEmail.Text = "Email";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbNome.Location = new System.Drawing.Point(28, 34);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 17);
            this.lbNome.TabIndex = 22;
            this.lbNome.Text = "Nome";
            // 
            // mtxtContato3
            // 
            this.mtxtContato3.Location = new System.Drawing.Point(115, 176);
            this.mtxtContato3.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtContato3.Mask = "(999) 0000-0000";
            this.mtxtContato3.Name = "mtxtContato3";
            this.mtxtContato3.Size = new System.Drawing.Size(120, 20);
            this.mtxtContato3.TabIndex = 44;
            // 
            // lbContato3
            // 
            this.lbContato3.AutoSize = true;
            this.lbContato3.BackColor = System.Drawing.Color.Transparent;
            this.lbContato3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContato3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbContato3.Location = new System.Drawing.Point(28, 177);
            this.lbContato3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContato3.Name = "lbContato3";
            this.lbContato3.Size = new System.Drawing.Size(69, 17);
            this.lbContato3.TabIndex = 43;
            this.lbContato3.Text = "Contato 3";
            // 
            // mtxtContato2
            // 
            this.mtxtContato2.Location = new System.Drawing.Point(115, 148);
            this.mtxtContato2.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtContato2.Mask = "(999) 0000-0000";
            this.mtxtContato2.Name = "mtxtContato2";
            this.mtxtContato2.Size = new System.Drawing.Size(120, 20);
            this.mtxtContato2.TabIndex = 42;
            // 
            // lbContato2
            // 
            this.lbContato2.AutoSize = true;
            this.lbContato2.BackColor = System.Drawing.Color.Transparent;
            this.lbContato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContato2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbContato2.Location = new System.Drawing.Point(28, 151);
            this.lbContato2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContato2.Name = "lbContato2";
            this.lbContato2.Size = new System.Drawing.Size(69, 17);
            this.lbContato2.TabIndex = 41;
            this.lbContato2.Text = "Contato 2";
            // 
            // mtxtContato1
            // 
            this.mtxtContato1.Location = new System.Drawing.Point(115, 120);
            this.mtxtContato1.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtContato1.Mask = "(999) 0000-0000";
            this.mtxtContato1.Name = "mtxtContato1";
            this.mtxtContato1.Size = new System.Drawing.Size(120, 20);
            this.mtxtContato1.TabIndex = 40;
            // 
            // lbContato1
            // 
            this.lbContato1.AutoSize = true;
            this.lbContato1.BackColor = System.Drawing.Color.Transparent;
            this.lbContato1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContato1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbContato1.Location = new System.Drawing.Point(28, 123);
            this.lbContato1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContato1.Name = "lbContato1";
            this.lbContato1.Size = new System.Drawing.Size(69, 17);
            this.lbContato1.TabIndex = 39;
            this.lbContato1.Text = "Contato 1";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(435, 171);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 45;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 222);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(780, 238);
            this.dgvCliente.TabIndex = 46;
            this.dgvCliente.SelectionChanged += new System.EventHandler(this.dgvCliente_SelectionChanged);
            // 
            // btn_pesquisarCliente
            // 
            this.btn_pesquisarCliente.Location = new System.Drawing.Point(435, 31);
            this.btn_pesquisarCliente.Name = "btn_pesquisarCliente";
            this.btn_pesquisarCliente.Size = new System.Drawing.Size(147, 23);
            this.btn_pesquisarCliente.TabIndex = 47;
            this.btn_pesquisarCliente.Text = "Pesquisar Cliente";
            this.btn_pesquisarCliente.UseVisualStyleBackColor = true;
            this.btn_pesquisarCliente.Click += new System.EventHandler(this.btn_btn_pesquisarCliente_Click);
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 472);
            this.Controls.Add(this.btn_pesquisarCliente);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mtxtContato3);
            this.Controls.Add(this.lbContato3);
            this.Controls.Add(this.mtxtContato2);
            this.Controls.Add(this.lbContato2);
            this.Controls.Add(this.mtxtContato1);
            this.Controls.Add(this.lbContato1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNome);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maniaDeSushiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.MaskedTextBox mtxtContato3;
        private System.Windows.Forms.Label lbContato3;
        private System.Windows.Forms.MaskedTextBox mtxtContato2;
        private System.Windows.Forms.Label lbContato2;
        private System.Windows.Forms.MaskedTextBox mtxtContato1;
        private System.Windows.Forms.Label lbContato1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btn_pesquisarCliente;
        private ManiaDeSushiDataSet maniaDeSushiDataSet;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private ManiaDeSushiDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
    }
}

