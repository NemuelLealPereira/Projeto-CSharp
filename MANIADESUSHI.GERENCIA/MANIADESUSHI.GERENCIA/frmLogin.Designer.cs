namespace MANIADESUSHI.GERENCIA
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.ctxmsLogin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ttLogin = new System.Windows.Forms.ToolTip(this.components);
            this.realizarPediddotsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbxLogin = new System.Windows.Forms.PictureBox();
            this.ctxmsLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(237, 87);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(146, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(212, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            this.ttLogin.SetToolTip(this.txtNome, "Informe o Nome");
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(212, 47);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 3;
            this.ttLogin.SetToolTip(this.txtSenha, "Informe a Senha");
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(146, 50);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // ctxmsLogin
            // 
            this.ctxmsLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarPediddotsmi});
            this.ctxmsLogin.Name = "contextMenuStrip1";
            this.ctxmsLogin.Size = new System.Drawing.Size(162, 26);
            // 
            // realizarPediddotsmi
            // 
            this.realizarPediddotsmi.Image = global::MANIADESUSHI.GERENCIA.Properties.Resources.RealizarPedido1;
            this.realizarPediddotsmi.Name = "realizarPediddotsmi";
            this.realizarPediddotsmi.Size = new System.Drawing.Size(161, 22);
            this.realizarPediddotsmi.Text = "Realizar Pediddo";
            this.realizarPediddotsmi.Click += new System.EventHandler(this.realizarPediddoToolStripMenuItem_Click);
            // 
            // pcbxLogin
            // 
            this.pcbxLogin.Image = global::MANIADESUSHI.GERENCIA.Properties.Resources.Login;
            this.pcbxLogin.Location = new System.Drawing.Point(26, 21);
            this.pcbxLogin.Name = "pcbxLogin";
            this.pcbxLogin.Size = new System.Drawing.Size(97, 89);
            this.pcbxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxLogin.TabIndex = 5;
            this.pcbxLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 131);
            this.ContextMenuStrip = this.ctxmsLogin;
            this.Controls.Add(this.pcbxLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login do Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ctxmsLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox pcbxLogin;
        private System.Windows.Forms.ContextMenuStrip ctxmsLogin;
        private System.Windows.Forms.ToolStripMenuItem realizarPediddotsmi;
        private System.Windows.Forms.ToolTip ttLogin;
    }
}