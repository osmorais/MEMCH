namespace PFC_V1
{
    partial class frm_cadastrar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastrar));
			this.txb_nome_usuario = new System.Windows.Forms.TextBox();
			this.lbl_nome_usuario2 = new System.Windows.Forms.Label();
			this.lbl_memch2 = new System.Windows.Forms.Label();
			this.lbl_memch = new System.Windows.Forms.Label();
			this.btn_sair_cadastro = new System.Windows.Forms.Button();
			this.btn_cadastrar_novo = new System.Windows.Forms.Button();
			this.gpb_cadastro_usuario = new System.Windows.Forms.GroupBox();
			this.txb_confirmar_senha = new System.Windows.Forms.TextBox();
			this.lbl_confirmar_senha = new System.Windows.Forms.Label();
			this.txb_senha_acesso = new System.Windows.Forms.TextBox();
			this.lbl_senha_acesso = new System.Windows.Forms.Label();
			this.txb_login_usuario = new System.Windows.Forms.TextBox();
			this.lbl_login_usuario = new System.Windows.Forms.Label();
			this.txb_cpf_usuario = new System.Windows.Forms.TextBox();
			this.lbl_cpf_usuario = new System.Windows.Forms.Label();
			this.gpb_cadastro_usuario.SuspendLayout();
			this.SuspendLayout();
			// 
			// txb_nome_usuario
			// 
			this.txb_nome_usuario.Location = new System.Drawing.Point(8, 41);
			this.txb_nome_usuario.Margin = new System.Windows.Forms.Padding(2);
			this.txb_nome_usuario.Name = "txb_nome_usuario";
			this.txb_nome_usuario.Size = new System.Drawing.Size(133, 20);
			this.txb_nome_usuario.TabIndex = 3;
			// 
			// lbl_nome_usuario2
			// 
			this.lbl_nome_usuario2.AutoSize = true;
			this.lbl_nome_usuario2.Location = new System.Drawing.Point(6, 24);
			this.lbl_nome_usuario2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_nome_usuario2.Name = "lbl_nome_usuario2";
			this.lbl_nome_usuario2.Size = new System.Drawing.Size(38, 13);
			this.lbl_nome_usuario2.TabIndex = 2;
			this.lbl_nome_usuario2.Text = "Nome:";
			// 
			// lbl_memch2
			// 
			this.lbl_memch2.AutoSize = true;
			this.lbl_memch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
			this.lbl_memch2.Location = new System.Drawing.Point(50, 28);
			this.lbl_memch2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_memch2.Name = "lbl_memch2";
			this.lbl_memch2.Size = new System.Drawing.Size(203, 7);
			this.lbl_memch2.TabIndex = 9;
			this.lbl_memch2.Text = "Monitoramento de Estado de Metragem Cúbica de Hidrômetro";
			this.lbl_memch2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl_memch
			// 
			this.lbl_memch.AutoSize = true;
			this.lbl_memch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl_memch.Location = new System.Drawing.Point(113, 7);
			this.lbl_memch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_memch.Name = "lbl_memch";
			this.lbl_memch.Size = new System.Drawing.Size(69, 20);
			this.lbl_memch.TabIndex = 8;
			this.lbl_memch.Text = "MEMCH";
			this.lbl_memch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btn_sair_cadastro
			// 
			this.btn_sair_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
			this.btn_sair_cadastro.Location = new System.Drawing.Point(9, 151);
			this.btn_sair_cadastro.Margin = new System.Windows.Forms.Padding(2);
			this.btn_sair_cadastro.Name = "btn_sair_cadastro";
			this.btn_sair_cadastro.Size = new System.Drawing.Size(58, 26);
			this.btn_sair_cadastro.TabIndex = 10;
			this.btn_sair_cadastro.Text = "Sair";
			this.btn_sair_cadastro.UseVisualStyleBackColor = true;
			this.btn_sair_cadastro.Click += new System.EventHandler(this.btn_sair_Click);
			// 
			// btn_cadastrar_novo
			// 
			this.btn_cadastrar_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
			this.btn_cadastrar_novo.Location = new System.Drawing.Point(222, 151);
			this.btn_cadastrar_novo.Margin = new System.Windows.Forms.Padding(2);
			this.btn_cadastrar_novo.Name = "btn_cadastrar_novo";
			this.btn_cadastrar_novo.Size = new System.Drawing.Size(58, 26);
			this.btn_cadastrar_novo.TabIndex = 11;
			this.btn_cadastrar_novo.Text = "Cadastrar";
			this.btn_cadastrar_novo.UseVisualStyleBackColor = true;
			this.btn_cadastrar_novo.Click += new System.EventHandler(this.btn_cadastrar_novo_Click);
			// 
			// gpb_cadastro_usuario
			// 
			this.gpb_cadastro_usuario.Controls.Add(this.txb_confirmar_senha);
			this.gpb_cadastro_usuario.Controls.Add(this.lbl_confirmar_senha);
			this.gpb_cadastro_usuario.Controls.Add(this.txb_senha_acesso);
			this.gpb_cadastro_usuario.Controls.Add(this.lbl_senha_acesso);
			this.gpb_cadastro_usuario.Controls.Add(this.txb_login_usuario);
			this.gpb_cadastro_usuario.Controls.Add(this.lbl_login_usuario);
			this.gpb_cadastro_usuario.Controls.Add(this.txb_cpf_usuario);
			this.gpb_cadastro_usuario.Controls.Add(this.lbl_cpf_usuario);
			this.gpb_cadastro_usuario.Controls.Add(this.btn_cadastrar_novo);
			this.gpb_cadastro_usuario.Controls.Add(this.btn_sair_cadastro);
			this.gpb_cadastro_usuario.Controls.Add(this.txb_nome_usuario);
			this.gpb_cadastro_usuario.Controls.Add(this.lbl_nome_usuario2);
			this.gpb_cadastro_usuario.Location = new System.Drawing.Point(2, 54);
			this.gpb_cadastro_usuario.Margin = new System.Windows.Forms.Padding(2);
			this.gpb_cadastro_usuario.Name = "gpb_cadastro_usuario";
			this.gpb_cadastro_usuario.Padding = new System.Windows.Forms.Padding(2);
			this.gpb_cadastro_usuario.Size = new System.Drawing.Size(286, 185);
			this.gpb_cadastro_usuario.TabIndex = 18;
			this.gpb_cadastro_usuario.TabStop = false;
			this.gpb_cadastro_usuario.Text = "Cadastro de novo Usuário";
			// 
			// txb_confirmar_senha
			// 
			this.txb_confirmar_senha.Location = new System.Drawing.Point(147, 123);
			this.txb_confirmar_senha.Margin = new System.Windows.Forms.Padding(2);
			this.txb_confirmar_senha.Name = "txb_confirmar_senha";
			this.txb_confirmar_senha.Size = new System.Drawing.Size(133, 20);
			this.txb_confirmar_senha.TabIndex = 23;
			this.txb_confirmar_senha.UseSystemPasswordChar = true;
			// 
			// lbl_confirmar_senha
			// 
			this.lbl_confirmar_senha.AutoSize = true;
			this.lbl_confirmar_senha.Location = new System.Drawing.Point(145, 107);
			this.lbl_confirmar_senha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_confirmar_senha.Name = "lbl_confirmar_senha";
			this.lbl_confirmar_senha.Size = new System.Drawing.Size(88, 13);
			this.lbl_confirmar_senha.TabIndex = 22;
			this.lbl_confirmar_senha.Text = "Confirmar Senha:";
			// 
			// txb_senha_acesso
			// 
			this.txb_senha_acesso.Location = new System.Drawing.Point(147, 86);
			this.txb_senha_acesso.Margin = new System.Windows.Forms.Padding(2);
			this.txb_senha_acesso.Name = "txb_senha_acesso";
			this.txb_senha_acesso.Size = new System.Drawing.Size(133, 20);
			this.txb_senha_acesso.TabIndex = 21;
			this.txb_senha_acesso.UseSystemPasswordChar = true;
			// 
			// lbl_senha_acesso
			// 
			this.lbl_senha_acesso.AutoSize = true;
			this.lbl_senha_acesso.Location = new System.Drawing.Point(145, 70);
			this.lbl_senha_acesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_senha_acesso.Name = "lbl_senha_acesso";
			this.lbl_senha_acesso.Size = new System.Drawing.Size(94, 13);
			this.lbl_senha_acesso.TabIndex = 20;
			this.lbl_senha_acesso.Text = "Senha de Acesso:";
			// 
			// txb_login_usuario
			// 
			this.txb_login_usuario.Location = new System.Drawing.Point(8, 86);
			this.txb_login_usuario.Margin = new System.Windows.Forms.Padding(2);
			this.txb_login_usuario.Name = "txb_login_usuario";
			this.txb_login_usuario.Size = new System.Drawing.Size(133, 20);
			this.txb_login_usuario.TabIndex = 19;
			// 
			// lbl_login_usuario
			// 
			this.lbl_login_usuario.AutoSize = true;
			this.lbl_login_usuario.Location = new System.Drawing.Point(6, 70);
			this.lbl_login_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_login_usuario.Name = "lbl_login_usuario";
			this.lbl_login_usuario.Size = new System.Drawing.Size(90, 13);
			this.lbl_login_usuario.TabIndex = 18;
			this.lbl_login_usuario.Text = "Login de Usuário:";
			// 
			// txb_cpf_usuario
			// 
			this.txb_cpf_usuario.Location = new System.Drawing.Point(147, 41);
			this.txb_cpf_usuario.Margin = new System.Windows.Forms.Padding(2);
			this.txb_cpf_usuario.Name = "txb_cpf_usuario";
			this.txb_cpf_usuario.Size = new System.Drawing.Size(133, 20);
			this.txb_cpf_usuario.TabIndex = 17;
			// 
			// lbl_cpf_usuario
			// 
			this.lbl_cpf_usuario.AutoSize = true;
			this.lbl_cpf_usuario.Location = new System.Drawing.Point(145, 24);
			this.lbl_cpf_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_cpf_usuario.Name = "lbl_cpf_usuario";
			this.lbl_cpf_usuario.Size = new System.Drawing.Size(60, 13);
			this.lbl_cpf_usuario.TabIndex = 16;
			this.lbl_cpf_usuario.Text = "Nº do CPF:";
			// 
			// frm_cadastrar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(293, 245);
			this.Controls.Add(this.gpb_cadastro_usuario);
			this.Controls.Add(this.lbl_memch2);
			this.Controls.Add(this.lbl_memch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frm_cadastrar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MEMCH - CADASTRO PESSOA";
			this.gpb_cadastro_usuario.ResumeLayout(false);
			this.gpb_cadastro_usuario.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nome_usuario;
        private System.Windows.Forms.Label lbl_nome_usuario2;
        private System.Windows.Forms.Label lbl_memch2;
        private System.Windows.Forms.Label lbl_memch;
        private System.Windows.Forms.Button btn_sair_cadastro;
        private System.Windows.Forms.Button btn_cadastrar_novo;
        private System.Windows.Forms.GroupBox gpb_cadastro_usuario;
        private System.Windows.Forms.TextBox txb_senha_acesso;
        private System.Windows.Forms.Label lbl_senha_acesso;
        private System.Windows.Forms.TextBox txb_login_usuario;
        private System.Windows.Forms.Label lbl_login_usuario;
        private System.Windows.Forms.TextBox txb_confirmar_senha;
        private System.Windows.Forms.Label lbl_confirmar_senha;
        private System.Windows.Forms.TextBox txb_cpf_usuario;
        private System.Windows.Forms.Label lbl_cpf_usuario;
    }
}