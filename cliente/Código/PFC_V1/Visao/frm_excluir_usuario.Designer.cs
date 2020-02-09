namespace PFC_V1.Visao
{
    partial class frm_excluir_usuario
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
            this.gpb_cadastro_usuario = new System.Windows.Forms.GroupBox();
            this.txb_login_usuario = new System.Windows.Forms.TextBox();
            this.lbl_login_usuario = new System.Windows.Forms.Label();
            this.txb_cpf_usuario = new System.Windows.Forms.TextBox();
            this.lbl_cpf_usuario = new System.Windows.Forms.Label();
            this.btn_excluir_usuario = new System.Windows.Forms.Button();
            this.btn_sair_formulario = new System.Windows.Forms.Button();
            this.txb_nome_usuario = new System.Windows.Forms.TextBox();
            this.lbl_nome_usuario2 = new System.Windows.Forms.Label();
            this.lbl_memch2 = new System.Windows.Forms.Label();
            this.lbl_memch = new System.Windows.Forms.Label();
            this.gpb_cadastro_usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_cadastro_usuario
            // 
            this.gpb_cadastro_usuario.Controls.Add(this.txb_login_usuario);
            this.gpb_cadastro_usuario.Controls.Add(this.lbl_login_usuario);
            this.gpb_cadastro_usuario.Controls.Add(this.txb_cpf_usuario);
            this.gpb_cadastro_usuario.Controls.Add(this.lbl_cpf_usuario);
            this.gpb_cadastro_usuario.Controls.Add(this.btn_excluir_usuario);
            this.gpb_cadastro_usuario.Controls.Add(this.btn_sair_formulario);
            this.gpb_cadastro_usuario.Controls.Add(this.txb_nome_usuario);
            this.gpb_cadastro_usuario.Controls.Add(this.lbl_nome_usuario2);
            this.gpb_cadastro_usuario.Location = new System.Drawing.Point(3, 53);
            this.gpb_cadastro_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_cadastro_usuario.Name = "gpb_cadastro_usuario";
            this.gpb_cadastro_usuario.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_cadastro_usuario.Size = new System.Drawing.Size(286, 148);
            this.gpb_cadastro_usuario.TabIndex = 21;
            this.gpb_cadastro_usuario.TabStop = false;
            this.gpb_cadastro_usuario.Text = "Dados de Usuário";
            // 
            // txb_login_usuario
            // 
            this.txb_login_usuario.Enabled = false;
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
            this.txb_cpf_usuario.Enabled = false;
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
            // btn_excluir_usuario
            // 
            this.btn_excluir_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_excluir_usuario.Location = new System.Drawing.Point(8, 115);
            this.btn_excluir_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_excluir_usuario.Name = "btn_excluir_usuario";
            this.btn_excluir_usuario.Size = new System.Drawing.Size(58, 26);
            this.btn_excluir_usuario.TabIndex = 11;
            this.btn_excluir_usuario.Text = "Excluir";
            this.btn_excluir_usuario.UseVisualStyleBackColor = true;
            this.btn_excluir_usuario.Click += new System.EventHandler(this.btn_excluir_usuario_Click);
            // 
            // btn_sair_formulario
            // 
            this.btn_sair_formulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_sair_formulario.Location = new System.Drawing.Point(220, 115);
            this.btn_sair_formulario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sair_formulario.Name = "btn_sair_formulario";
            this.btn_sair_formulario.Size = new System.Drawing.Size(58, 26);
            this.btn_sair_formulario.TabIndex = 10;
            this.btn_sair_formulario.Text = "Sair";
            this.btn_sair_formulario.UseVisualStyleBackColor = true;
            this.btn_sair_formulario.Click += new System.EventHandler(this.btn_sair_formulario_Click);
            // 
            // txb_nome_usuario
            // 
            this.txb_nome_usuario.Enabled = false;
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
            this.lbl_memch2.Location = new System.Drawing.Point(51, 27);
            this.lbl_memch2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_memch2.Name = "lbl_memch2";
            this.lbl_memch2.Size = new System.Drawing.Size(203, 7);
            this.lbl_memch2.TabIndex = 20;
            this.lbl_memch2.Text = "Monitoramento de Estado de Metragem Cúbica de Hidrômetro";
            this.lbl_memch2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_memch
            // 
            this.lbl_memch.AutoSize = true;
            this.lbl_memch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_memch.Location = new System.Drawing.Point(114, 6);
            this.lbl_memch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_memch.Name = "lbl_memch";
            this.lbl_memch.Size = new System.Drawing.Size(69, 20);
            this.lbl_memch.TabIndex = 19;
            this.lbl_memch.Text = "MEMCH";
            this.lbl_memch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_excluir_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(293, 207);
            this.Controls.Add(this.gpb_cadastro_usuario);
            this.Controls.Add(this.lbl_memch2);
            this.Controls.Add(this.lbl_memch);
            this.Name = "frm_excluir_usuario";
            this.Text = "MEMCH - EXCLUIR USUÁRIO";
            this.Load += new System.EventHandler(this.frm_excluir_usuario_Load);
            this.gpb_cadastro_usuario.ResumeLayout(false);
            this.gpb_cadastro_usuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_cadastro_usuario;
        private System.Windows.Forms.TextBox txb_login_usuario;
        private System.Windows.Forms.Label lbl_login_usuario;
        private System.Windows.Forms.TextBox txb_cpf_usuario;
        private System.Windows.Forms.Label lbl_cpf_usuario;
        private System.Windows.Forms.Button btn_excluir_usuario;
        private System.Windows.Forms.Button btn_sair_formulario;
        private System.Windows.Forms.TextBox txb_nome_usuario;
        private System.Windows.Forms.Label lbl_nome_usuario2;
        private System.Windows.Forms.Label lbl_memch2;
        private System.Windows.Forms.Label lbl_memch;
    }
}