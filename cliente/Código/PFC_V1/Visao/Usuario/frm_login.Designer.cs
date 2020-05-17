namespace PFC_V1
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.lbl_nome_usuario = new System.Windows.Forms.Label();
            this.txb_nome_usuario = new System.Windows.Forms.TextBox();
            this.txb_senha_acesso = new System.Windows.Forms.TextBox();
            this.lbl_senha_acesso = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cadastrar_login = new System.Windows.Forms.Button();
            this.lbl_memch = new System.Windows.Forms.Label();
            this.lbl_memch2 = new System.Windows.Forms.Label();
            this.btn_sair_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome_usuario
            // 
            this.lbl_nome_usuario.AutoSize = true;
            this.lbl_nome_usuario.Location = new System.Drawing.Point(40, 59);
            this.lbl_nome_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome_usuario.Name = "lbl_nome_usuario";
            this.lbl_nome_usuario.Size = new System.Drawing.Size(92, 13);
            this.lbl_nome_usuario.TabIndex = 0;
            this.lbl_nome_usuario.Text = "Nome de Usuário:";
            // 
            // txb_nome_usuario
            // 
            this.txb_nome_usuario.Location = new System.Drawing.Point(42, 76);
            this.txb_nome_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txb_nome_usuario.Name = "txb_nome_usuario";
            this.txb_nome_usuario.Size = new System.Drawing.Size(133, 20);
            this.txb_nome_usuario.TabIndex = 1;
            // 
            // txb_senha_acesso
            // 
            this.txb_senha_acesso.Location = new System.Drawing.Point(42, 123);
            this.txb_senha_acesso.Margin = new System.Windows.Forms.Padding(2);
            this.txb_senha_acesso.Name = "txb_senha_acesso";
            this.txb_senha_acesso.Size = new System.Drawing.Size(133, 20);
            this.txb_senha_acesso.TabIndex = 3;
            this.txb_senha_acesso.UseSystemPasswordChar = true;
            // 
            // lbl_senha_acesso
            // 
            this.lbl_senha_acesso.AutoSize = true;
            this.lbl_senha_acesso.Location = new System.Drawing.Point(40, 106);
            this.lbl_senha_acesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_senha_acesso.Name = "lbl_senha_acesso";
            this.lbl_senha_acesso.Size = new System.Drawing.Size(94, 13);
            this.lbl_senha_acesso.TabIndex = 2;
            this.lbl_senha_acesso.Text = "Senha de Acesso:";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_login.Location = new System.Drawing.Point(42, 153);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(58, 26);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cadastrar_login
            // 
            this.btn_cadastrar_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btn_cadastrar_login.Location = new System.Drawing.Point(117, 153);
            this.btn_cadastrar_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cadastrar_login.Name = "btn_cadastrar_login";
            this.btn_cadastrar_login.Size = new System.Drawing.Size(58, 26);
            this.btn_cadastrar_login.TabIndex = 5;
            this.btn_cadastrar_login.Text = "Cadastro";
            this.btn_cadastrar_login.UseVisualStyleBackColor = true;
            this.btn_cadastrar_login.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // lbl_memch
            // 
            this.lbl_memch.AutoSize = true;
            this.lbl_memch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_memch.Location = new System.Drawing.Point(73, 10);
            this.lbl_memch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_memch.Name = "lbl_memch";
            this.lbl_memch.Size = new System.Drawing.Size(69, 20);
            this.lbl_memch.TabIndex = 6;
            this.lbl_memch.Text = "MEMCH";
            this.lbl_memch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_memch2
            // 
            this.lbl_memch2.AutoSize = true;
            this.lbl_memch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.lbl_memch2.Location = new System.Drawing.Point(8, 30);
            this.lbl_memch2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_memch2.Name = "lbl_memch2";
            this.lbl_memch2.Size = new System.Drawing.Size(203, 7);
            this.lbl_memch2.TabIndex = 7;
            this.lbl_memch2.Text = "Monitoramento de Estado de Metragem Cúbica de Hidrômetro";
            this.lbl_memch2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_sair_login
            // 
            this.btn_sair_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_sair_login.Location = new System.Drawing.Point(77, 183);
            this.btn_sair_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sair_login.Name = "btn_sair_login";
            this.btn_sair_login.Size = new System.Drawing.Size(58, 26);
            this.btn_sair_login.TabIndex = 8;
            this.btn_sair_login.Text = "Sair";
            this.btn_sair_login.UseVisualStyleBackColor = true;
            this.btn_sair_login.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(218, 214);
            this.Controls.Add(this.btn_sair_login);
            this.Controls.Add(this.lbl_memch2);
            this.Controls.Add(this.lbl_memch);
            this.Controls.Add(this.btn_cadastrar_login);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txb_senha_acesso);
            this.Controls.Add(this.lbl_senha_acesso);
            this.Controls.Add(this.txb_nome_usuario);
            this.Controls.Add(this.lbl_nome_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEMCH - LOGIN";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome_usuario;
        private System.Windows.Forms.TextBox txb_nome_usuario;
        private System.Windows.Forms.TextBox txb_senha_acesso;
        private System.Windows.Forms.Label lbl_senha_acesso;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cadastrar_login;
        private System.Windows.Forms.Label lbl_memch;
        private System.Windows.Forms.Label lbl_memch2;
        private System.Windows.Forms.Button btn_sair_login;
    }
}

