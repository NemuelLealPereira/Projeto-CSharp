namespace MANIADESUSHI.GERENCIA.VIEW3
{
    partial class frmRealizarPedidos
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
                components.Dispose();
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
            this.lbl_pesquisarProduto = new System.Windows.Forms.Label();
            this.txtpesquisarPedido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_carrinho = new System.Windows.Forms.DataGridView();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.tpro_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spro_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpro_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_valorTotal = new System.Windows.Forms.Label();
            this.lbl_vvalorTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pesquisarProduto
            // 
            this.lbl_pesquisarProduto.AutoSize = true;
            this.lbl_pesquisarProduto.Location = new System.Drawing.Point(61, 43);
            this.lbl_pesquisarProduto.Name = "lbl_pesquisarProduto";
            this.lbl_pesquisarProduto.Size = new System.Drawing.Size(99, 13);
            this.lbl_pesquisarProduto.TabIndex = 0;
            this.lbl_pesquisarProduto.Text = "Pesquisar Produto :";
            // 
            // txtpesquisarPedido
            // 
            this.txtpesquisarPedido.Location = new System.Drawing.Point(166, 36);
            this.txtpesquisarPedido.Name = "txtpesquisarPedido";
            this.txtpesquisarPedido.Size = new System.Drawing.Size(317, 20);
            this.txtpesquisarPedido.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_vvalorTotal);
            this.groupBox1.Controls.Add(this.lbl_valorTotal);
            this.groupBox1.Controls.Add(this.dgv_carrinho);
            this.groupBox1.Location = new System.Drawing.Point(529, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 205);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrinho";
            // 
            // dgv_carrinho
            // 
            this.dgv_carrinho.AllowUserToAddRows = false;
            this.dgv_carrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tpro_nome,
            this.spro_nome,
            this.vpro_valor});
            this.dgv_carrinho.Location = new System.Drawing.Point(6, 31);
            this.dgv_carrinho.MultiSelect = false;
            this.dgv_carrinho.Name = "dgv_carrinho";
            this.dgv_carrinho.RowHeadersVisible = false;
            this.dgv_carrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_carrinho.Size = new System.Drawing.Size(302, 140);
            this.dgv_carrinho.TabIndex = 0;
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.AllowUserToResizeColumns = false;
            this.dgv_produtos.AllowUserToResizeRows = false;
            this.dgv_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Location = new System.Drawing.Point(12, 256);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.Size = new System.Drawing.Size(831, 227);
            this.dgv_produtos.TabIndex = 4;
            this.dgv_produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellDoubleClick);
            // 
            // tpro_nome
            // 
            this.tpro_nome.HeaderText = "Produto";
            this.tpro_nome.Name = "tpro_nome";
            // 
            // spro_nome
            // 
            this.spro_nome.HeaderText = "Cod - Sabor";
            this.spro_nome.Name = "spro_nome";
            // 
            // vpro_valor
            // 
            this.vpro_valor.HeaderText = "Valor";
            this.vpro_valor.Name = "vpro_valor";
            // 
            // lbl_valorTotal
            // 
            this.lbl_valorTotal.AutoSize = true;
            this.lbl_valorTotal.Location = new System.Drawing.Point(7, 178);
            this.lbl_valorTotal.Name = "lbl_valorTotal";
            this.lbl_valorTotal.Size = new System.Drawing.Size(64, 13);
            this.lbl_valorTotal.TabIndex = 1;
            this.lbl_valorTotal.Text = "Valor Total :";
            // 
            // lbl_vvalorTotal
            // 
            this.lbl_vvalorTotal.AutoSize = true;
            this.lbl_vvalorTotal.Location = new System.Drawing.Point(77, 178);
            this.lbl_vvalorTotal.Name = "lbl_vvalorTotal";
            this.lbl_vvalorTotal.Size = new System.Drawing.Size(10, 13);
            this.lbl_vvalorTotal.TabIndex = 2;
            this.lbl_vvalorTotal.Text = " ";
            // 
            // frmRealizarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 495);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpesquisarPedido);
            this.Controls.Add(this.lbl_pesquisarProduto);
            this.Name = "frmRealizarPedidos";
            this.Text = "Realizar Pedidos";
            this.Load += new System.EventHandler(this.frmRealizarPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pesquisarProduto;
        private System.Windows.Forms.TextBox txtpesquisarPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_carrinho;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpro_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn spro_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn vpro_valor;
        private System.Windows.Forms.Label lbl_vvalorTotal;
        private System.Windows.Forms.Label lbl_valorTotal;

    }
}

