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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRealizarPedidos));
            this.lbl_pesquisarProduto = new System.Windows.Forms.Label();
            this.txtpesquisarPedido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_registrarPedido = new System.Windows.Forms.Button();
            this.lbl_vvalorTotal = new System.Windows.Forms.Label();
            this.lbl_valorTotal = new System.Windows.Forms.Label();
            this.dgv_carrinho = new System.Windows.Forms.DataGridView();
            this.col_qtde = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tpro_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spro_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpro_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pesquisarProduto
            // 
            this.lbl_pesquisarProduto.AutoSize = true;
            this.lbl_pesquisarProduto.Location = new System.Drawing.Point(12, 26);
            this.lbl_pesquisarProduto.Name = "lbl_pesquisarProduto";
            this.lbl_pesquisarProduto.Size = new System.Drawing.Size(99, 13);
            this.lbl_pesquisarProduto.TabIndex = 0;
            this.lbl_pesquisarProduto.Text = "Pesquisar Produto :";
            // 
            // txtpesquisarPedido
            // 
            this.txtpesquisarPedido.Location = new System.Drawing.Point(117, 23);
            this.txtpesquisarPedido.Name = "txtpesquisarPedido";
            this.txtpesquisarPedido.Size = new System.Drawing.Size(203, 20);
            this.txtpesquisarPedido.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_registrarPedido);
            this.groupBox1.Controls.Add(this.lbl_vvalorTotal);
            this.groupBox1.Controls.Add(this.lbl_valorTotal);
            this.groupBox1.Controls.Add(this.dgv_carrinho);
            this.groupBox1.Location = new System.Drawing.Point(384, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 205);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrinho";
            // 
            // btn_registrarPedido
            // 
            this.btn_registrarPedido.Location = new System.Drawing.Point(352, 177);
            this.btn_registrarPedido.Name = "btn_registrarPedido";
            this.btn_registrarPedido.Size = new System.Drawing.Size(101, 23);
            this.btn_registrarPedido.TabIndex = 3;
            this.btn_registrarPedido.Text = "Registrar Pedido";
            this.btn_registrarPedido.UseVisualStyleBackColor = true;
            this.btn_registrarPedido.Click += new System.EventHandler(this.btn_registrarPedido_Click);
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
            // lbl_valorTotal
            // 
            this.lbl_valorTotal.AutoSize = true;
            this.lbl_valorTotal.Location = new System.Drawing.Point(7, 178);
            this.lbl_valorTotal.Name = "lbl_valorTotal";
            this.lbl_valorTotal.Size = new System.Drawing.Size(64, 13);
            this.lbl_valorTotal.TabIndex = 1;
            this.lbl_valorTotal.Text = "Valor Total :";
            // 
            // dgv_carrinho
            // 
            this.dgv_carrinho.AllowUserToAddRows = false;
            this.dgv_carrinho.AllowUserToDeleteRows = false;
            this.dgv_carrinho.AllowUserToResizeColumns = false;
            this.dgv_carrinho.AllowUserToResizeRows = false;
            this.dgv_carrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_qtde,
            this.tpro_nome,
            this.spro_nome,
            this.col_tamanho,
            this.vpro_valor,
            this.col_valorTotal,
            this.vpro_id,
            this.col_excluir});
            this.dgv_carrinho.Location = new System.Drawing.Point(6, 31);
            this.dgv_carrinho.MultiSelect = false;
            this.dgv_carrinho.Name = "dgv_carrinho";
            this.dgv_carrinho.RowHeadersVisible = false;
            this.dgv_carrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_carrinho.Size = new System.Drawing.Size(447, 140);
            this.dgv_carrinho.TabIndex = 0;
            this.dgv_carrinho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_carrinho_CellClick);
            this.dgv_carrinho.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_carrinho_EditingControlShowing);
            this.dgv_carrinho.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_carrinho_RowsAdded);
            // 
            // col_qtde
            // 
            this.col_qtde.FillWeight = 82.03943F;
            this.col_qtde.HeaderText = "Qtde";
            this.col_qtde.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.col_qtde.Name = "col_qtde";
            this.col_qtde.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_qtde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tpro_nome
            // 
            this.tpro_nome.FillWeight = 118.6389F;
            this.tpro_nome.HeaderText = "Produto";
            this.tpro_nome.Name = "tpro_nome";
            this.tpro_nome.ReadOnly = true;
            // 
            // spro_nome
            // 
            this.spro_nome.FillWeight = 118.6389F;
            this.spro_nome.HeaderText = "Cod - Sabor";
            this.spro_nome.Name = "spro_nome";
            this.spro_nome.ReadOnly = true;
            // 
            // col_tamanho
            // 
            this.col_tamanho.FillWeight = 121.8274F;
            this.col_tamanho.HeaderText = "Tamanho";
            this.col_tamanho.Name = "col_tamanho";
            this.col_tamanho.ReadOnly = true;
            // 
            // vpro_valor
            // 
            this.vpro_valor.FillWeight = 118.6389F;
            this.vpro_valor.HeaderText = "Valor Unit";
            this.vpro_valor.Name = "vpro_valor";
            this.vpro_valor.ReadOnly = true;
            // 
            // col_valorTotal
            // 
            this.col_valorTotal.HeaderText = "Valor Total";
            this.col_valorTotal.Name = "col_valorTotal";
            // 
            // vpro_id
            // 
            this.vpro_id.HeaderText = "Código do Produto";
            this.vpro_id.Name = "vpro_id";
            this.vpro_id.ReadOnly = true;
            this.vpro_id.Visible = false;
            // 
            // col_excluir
            // 
            this.col_excluir.FillWeight = 40.21656F;
            this.col_excluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.col_excluir.HeaderText = "";
            this.col_excluir.MinimumWidth = 20;
            this.col_excluir.Name = "col_excluir";
            this.col_excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_excluir.Text = "X";
            this.col_excluir.ToolTipText = "Excluir";
            this.col_excluir.UseColumnTextForButtonValue = true;
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
            this.dgv_produtos.MultiSelect = false;
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.Size = new System.Drawing.Size(831, 227);
            this.dgv_produtos.TabIndex = 4;
            this.dgv_produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellDoubleClick);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lbl_vvalorTotal;
        private System.Windows.Forms.Label lbl_valorTotal;
        private System.Windows.Forms.Button btn_registrarPedido;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpro_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn spro_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn vpro_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn vpro_id;
        private System.Windows.Forms.DataGridViewButtonColumn col_excluir;

    }
}

