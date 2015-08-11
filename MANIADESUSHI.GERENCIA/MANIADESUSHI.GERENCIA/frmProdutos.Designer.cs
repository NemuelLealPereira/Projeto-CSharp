namespace MANIADESUSHI.GERENCIA
{
    partial class frmProdutos
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
            this.lbTipoProduto = new System.Windows.Forms.Label();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.lbValorProduto = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTipoProduto
            // 
            this.lbTipoProduto.AutoSize = true;
            this.lbTipoProduto.Location = new System.Drawing.Point(83, 40);
            this.lbTipoProduto.Name = "lbTipoProduto";
            this.lbTipoProduto.Size = new System.Drawing.Size(44, 13);
            this.lbTipoProduto.TabIndex = 0;
            this.lbTipoProduto.Text = "Produto";
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Location = new System.Drawing.Point(83, 66);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(35, 13);
            this.lbNomeProduto.TabIndex = 1;
            this.lbNomeProduto.Text = "Nome";
            // 
            // lbValorProduto
            // 
            this.lbValorProduto.AutoSize = true;
            this.lbValorProduto.Location = new System.Drawing.Point(83, 92);
            this.lbValorProduto.Name = "lbValorProduto";
            this.lbValorProduto.Size = new System.Drawing.Size(31, 13);
            this.lbValorProduto.TabIndex = 2;
            this.lbValorProduto.Text = "Valor";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Items.AddRange(new object[] {
            "Barca",
            "Combinado",
            "Rolinho",
            "Temaki",
            "Yakissoba"});
            this.cmbProdutos.Location = new System.Drawing.Point(166, 32);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(100, 21);
            this.cmbProdutos.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MANIADESUSHI.GERENCIA.Properties.Resources.PlanoDeFundoProdutos;
            this.pictureBox1.Location = new System.Drawing.Point(86, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbValorProduto);
            this.Controls.Add(this.lbNomeProduto);
            this.Controls.Add(this.lbTipoProduto);
            this.Name = "frmProdutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTipoProduto;
        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.Label lbValorProduto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

