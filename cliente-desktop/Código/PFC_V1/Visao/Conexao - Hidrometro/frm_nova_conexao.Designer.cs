namespace PFC_V1
{
    partial class frm_nova_conexao
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
			this.gpb_nova_conexao = new System.Windows.Forms.GroupBox();
			this.txb_descricao_conexao = new System.Windows.Forms.TextBox();
			this.ckb_conexao_ativa = new System.Windows.Forms.CheckBox();
			this.lbl_descricao_conexao = new System.Windows.Forms.Label();
			this.lbl_ativo_conexao = new System.Windows.Forms.Label();
			this.txb_chave_conexao = new System.Windows.Forms.TextBox();
			this.lbl_chave_conexao = new System.Windows.Forms.Label();
			this.txb_host_conexao = new System.Windows.Forms.TextBox();
			this.lbl_host_conexao = new System.Windows.Forms.Label();
			this.btn_cadastrar_novo = new System.Windows.Forms.Button();
			this.btn_sair_cadastro = new System.Windows.Forms.Button();
			this.lbl_memch2 = new System.Windows.Forms.Label();
			this.lbl_memch = new System.Windows.Forms.Label();
			this.gpb_hidrometro = new System.Windows.Forms.GroupBox();
			this.ckb_hidrometro_ativo = new System.Windows.Forms.CheckBox();
			this.txb_descricao_hidrometro = new System.Windows.Forms.TextBox();
			this.lbl_ativo = new System.Windows.Forms.Label();
			this.lbl_descricao = new System.Windows.Forms.Label();
			this.txb_modelo_hidrometro = new System.Windows.Forms.TextBox();
			this.lbl_modelo = new System.Windows.Forms.Label();
			this.txb_identificador_hidrometro = new System.Windows.Forms.TextBox();
			this.lbl_identificador = new System.Windows.Forms.Label();
			this.gpb_nova_conexao.SuspendLayout();
			this.gpb_hidrometro.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpb_nova_conexao
			// 
			this.gpb_nova_conexao.Controls.Add(this.txb_descricao_conexao);
			this.gpb_nova_conexao.Controls.Add(this.ckb_conexao_ativa);
			this.gpb_nova_conexao.Controls.Add(this.lbl_descricao_conexao);
			this.gpb_nova_conexao.Controls.Add(this.lbl_ativo_conexao);
			this.gpb_nova_conexao.Controls.Add(this.txb_chave_conexao);
			this.gpb_nova_conexao.Controls.Add(this.lbl_chave_conexao);
			this.gpb_nova_conexao.Controls.Add(this.txb_host_conexao);
			this.gpb_nova_conexao.Controls.Add(this.lbl_host_conexao);
			this.gpb_nova_conexao.Location = new System.Drawing.Point(4, 53);
			this.gpb_nova_conexao.Margin = new System.Windows.Forms.Padding(2);
			this.gpb_nova_conexao.Name = "gpb_nova_conexao";
			this.gpb_nova_conexao.Padding = new System.Windows.Forms.Padding(2);
			this.gpb_nova_conexao.Size = new System.Drawing.Size(383, 110);
			this.gpb_nova_conexao.TabIndex = 21;
			this.gpb_nova_conexao.TabStop = false;
			this.gpb_nova_conexao.Text = "Cadastro de nova Conexão";
			// 
			// txb_descricao_conexao
			// 
			this.txb_descricao_conexao.BackColor = System.Drawing.SystemColors.Control;
			this.txb_descricao_conexao.Location = new System.Drawing.Point(148, 80);
			this.txb_descricao_conexao.Margin = new System.Windows.Forms.Padding(2);
			this.txb_descricao_conexao.Name = "txb_descricao_conexao";
			this.txb_descricao_conexao.Size = new System.Drawing.Size(231, 20);
			this.txb_descricao_conexao.TabIndex = 26;
			// 
			// ckb_conexao_ativa
			// 
			this.ckb_conexao_ativa.AutoSize = true;
			this.ckb_conexao_ativa.Location = new System.Drawing.Point(147, 41);
			this.ckb_conexao_ativa.Margin = new System.Windows.Forms.Padding(2);
			this.ckb_conexao_ativa.Name = "ckb_conexao_ativa";
			this.ckb_conexao_ativa.Size = new System.Drawing.Size(50, 17);
			this.ckb_conexao_ativa.TabIndex = 24;
			this.ckb_conexao_ativa.Text = "Ativo";
			this.ckb_conexao_ativa.UseVisualStyleBackColor = true;
			// 
			// lbl_descricao_conexao
			// 
			this.lbl_descricao_conexao.AutoSize = true;
			this.lbl_descricao_conexao.Location = new System.Drawing.Point(145, 63);
			this.lbl_descricao_conexao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_descricao_conexao.Name = "lbl_descricao_conexao";
			this.lbl_descricao_conexao.Size = new System.Drawing.Size(87, 13);
			this.lbl_descricao_conexao.TabIndex = 16;
			this.lbl_descricao_conexao.Text = "Breve descrição:";
			// 
			// lbl_ativo_conexao
			// 
			this.lbl_ativo_conexao.AutoSize = true;
			this.lbl_ativo_conexao.Location = new System.Drawing.Point(145, 24);
			this.lbl_ativo_conexao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_ativo_conexao.Name = "lbl_ativo_conexao";
			this.lbl_ativo_conexao.Size = new System.Drawing.Size(34, 13);
			this.lbl_ativo_conexao.TabIndex = 14;
			this.lbl_ativo_conexao.Text = "Ativo:";
			// 
			// txb_chave_conexao
			// 
			this.txb_chave_conexao.Location = new System.Drawing.Point(8, 80);
			this.txb_chave_conexao.Margin = new System.Windows.Forms.Padding(2);
			this.txb_chave_conexao.Name = "txb_chave_conexao";
			this.txb_chave_conexao.Size = new System.Drawing.Size(133, 20);
			this.txb_chave_conexao.TabIndex = 13;
			// 
			// lbl_chave_conexao
			// 
			this.lbl_chave_conexao.AutoSize = true;
			this.lbl_chave_conexao.Location = new System.Drawing.Point(6, 63);
			this.lbl_chave_conexao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_chave_conexao.Name = "lbl_chave_conexao";
			this.lbl_chave_conexao.Size = new System.Drawing.Size(41, 13);
			this.lbl_chave_conexao.TabIndex = 12;
			this.lbl_chave_conexao.Text = "Chave:";
			// 
			// txb_host_conexao
			// 
			this.txb_host_conexao.Location = new System.Drawing.Point(8, 41);
			this.txb_host_conexao.Margin = new System.Windows.Forms.Padding(2);
			this.txb_host_conexao.Name = "txb_host_conexao";
			this.txb_host_conexao.Size = new System.Drawing.Size(133, 20);
			this.txb_host_conexao.TabIndex = 3;
			// 
			// lbl_host_conexao
			// 
			this.lbl_host_conexao.AutoSize = true;
			this.lbl_host_conexao.Location = new System.Drawing.Point(6, 24);
			this.lbl_host_conexao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_host_conexao.Name = "lbl_host_conexao";
			this.lbl_host_conexao.Size = new System.Drawing.Size(32, 13);
			this.lbl_host_conexao.TabIndex = 2;
			this.lbl_host_conexao.Text = "Host:";
			// 
			// btn_cadastrar_novo
			// 
			this.btn_cadastrar_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
			this.btn_cadastrar_novo.Location = new System.Drawing.Point(322, 302);
			this.btn_cadastrar_novo.Margin = new System.Windows.Forms.Padding(2);
			this.btn_cadastrar_novo.Name = "btn_cadastrar_novo";
			this.btn_cadastrar_novo.Size = new System.Drawing.Size(65, 26);
			this.btn_cadastrar_novo.TabIndex = 11;
			this.btn_cadastrar_novo.Text = "Cadastrar";
			this.btn_cadastrar_novo.UseVisualStyleBackColor = true;
			this.btn_cadastrar_novo.Click += new System.EventHandler(this.btn_cadastrar_novo_Click);
			// 
			// btn_sair_cadastro
			// 
			this.btn_sair_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
			this.btn_sair_cadastro.Location = new System.Drawing.Point(4, 302);
			this.btn_sair_cadastro.Margin = new System.Windows.Forms.Padding(2);
			this.btn_sair_cadastro.Name = "btn_sair_cadastro";
			this.btn_sair_cadastro.Size = new System.Drawing.Size(58, 26);
			this.btn_sair_cadastro.TabIndex = 10;
			this.btn_sair_cadastro.Text = "Sair";
			this.btn_sair_cadastro.UseVisualStyleBackColor = true;
			this.btn_sair_cadastro.Click += new System.EventHandler(this.btn_sair_cadastro_Click);
			// 
			// lbl_memch2
			// 
			this.lbl_memch2.AutoSize = true;
			this.lbl_memch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
			this.lbl_memch2.Location = new System.Drawing.Point(103, 29);
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
			this.lbl_memch.Location = new System.Drawing.Point(167, 9);
			this.lbl_memch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_memch.Name = "lbl_memch";
			this.lbl_memch.Size = new System.Drawing.Size(69, 20);
			this.lbl_memch.TabIndex = 19;
			this.lbl_memch.Text = "MEMCH";
			this.lbl_memch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// gpb_hidrometro
			// 
			this.gpb_hidrometro.Controls.Add(this.ckb_hidrometro_ativo);
			this.gpb_hidrometro.Controls.Add(this.txb_descricao_hidrometro);
			this.gpb_hidrometro.Controls.Add(this.lbl_ativo);
			this.gpb_hidrometro.Controls.Add(this.lbl_descricao);
			this.gpb_hidrometro.Controls.Add(this.txb_modelo_hidrometro);
			this.gpb_hidrometro.Controls.Add(this.lbl_modelo);
			this.gpb_hidrometro.Controls.Add(this.txb_identificador_hidrometro);
			this.gpb_hidrometro.Controls.Add(this.lbl_identificador);
			this.gpb_hidrometro.Location = new System.Drawing.Point(4, 177);
			this.gpb_hidrometro.Margin = new System.Windows.Forms.Padding(2);
			this.gpb_hidrometro.Name = "gpb_hidrometro";
			this.gpb_hidrometro.Padding = new System.Windows.Forms.Padding(2);
			this.gpb_hidrometro.Size = new System.Drawing.Size(383, 110);
			this.gpb_hidrometro.TabIndex = 22;
			this.gpb_hidrometro.TabStop = false;
			this.gpb_hidrometro.Text = "Cadastro de novo Hidrometro";
			// 
			// ckb_hidrometro_ativo
			// 
			this.ckb_hidrometro_ativo.AutoSize = true;
			this.ckb_hidrometro_ativo.Location = new System.Drawing.Point(147, 41);
			this.ckb_hidrometro_ativo.Margin = new System.Windows.Forms.Padding(2);
			this.ckb_hidrometro_ativo.Name = "ckb_hidrometro_ativo";
			this.ckb_hidrometro_ativo.Size = new System.Drawing.Size(50, 17);
			this.ckb_hidrometro_ativo.TabIndex = 28;
			this.ckb_hidrometro_ativo.Text = "Ativo";
			this.ckb_hidrometro_ativo.UseVisualStyleBackColor = true;
			// 
			// txb_descricao_hidrometro
			// 
			this.txb_descricao_hidrometro.BackColor = System.Drawing.SystemColors.Control;
			this.txb_descricao_hidrometro.Location = new System.Drawing.Point(148, 80);
			this.txb_descricao_hidrometro.Margin = new System.Windows.Forms.Padding(2);
			this.txb_descricao_hidrometro.Name = "txb_descricao_hidrometro";
			this.txb_descricao_hidrometro.Size = new System.Drawing.Size(231, 20);
			this.txb_descricao_hidrometro.TabIndex = 26;
			// 
			// lbl_ativo
			// 
			this.lbl_ativo.AutoSize = true;
			this.lbl_ativo.Location = new System.Drawing.Point(145, 24);
			this.lbl_ativo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_ativo.Name = "lbl_ativo";
			this.lbl_ativo.Size = new System.Drawing.Size(34, 13);
			this.lbl_ativo.TabIndex = 27;
			this.lbl_ativo.Text = "Ativo:";
			// 
			// lbl_descricao
			// 
			this.lbl_descricao.AutoSize = true;
			this.lbl_descricao.Location = new System.Drawing.Point(145, 63);
			this.lbl_descricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_descricao.Name = "lbl_descricao";
			this.lbl_descricao.Size = new System.Drawing.Size(87, 13);
			this.lbl_descricao.TabIndex = 16;
			this.lbl_descricao.Text = "Breve descrição:";
			// 
			// txb_modelo_hidrometro
			// 
			this.txb_modelo_hidrometro.Location = new System.Drawing.Point(8, 80);
			this.txb_modelo_hidrometro.Margin = new System.Windows.Forms.Padding(2);
			this.txb_modelo_hidrometro.Name = "txb_modelo_hidrometro";
			this.txb_modelo_hidrometro.Size = new System.Drawing.Size(133, 20);
			this.txb_modelo_hidrometro.TabIndex = 13;
			// 
			// lbl_modelo
			// 
			this.lbl_modelo.AutoSize = true;
			this.lbl_modelo.Location = new System.Drawing.Point(6, 63);
			this.lbl_modelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_modelo.Name = "lbl_modelo";
			this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
			this.lbl_modelo.TabIndex = 12;
			this.lbl_modelo.Text = "Modelo:";
			// 
			// txb_identificador_hidrometro
			// 
			this.txb_identificador_hidrometro.Location = new System.Drawing.Point(8, 41);
			this.txb_identificador_hidrometro.Margin = new System.Windows.Forms.Padding(2);
			this.txb_identificador_hidrometro.Name = "txb_identificador_hidrometro";
			this.txb_identificador_hidrometro.Size = new System.Drawing.Size(133, 20);
			this.txb_identificador_hidrometro.TabIndex = 3;
			// 
			// lbl_identificador
			// 
			this.lbl_identificador.AutoSize = true;
			this.lbl_identificador.Location = new System.Drawing.Point(6, 24);
			this.lbl_identificador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_identificador.Name = "lbl_identificador";
			this.lbl_identificador.Size = new System.Drawing.Size(68, 13);
			this.lbl_identificador.TabIndex = 2;
			this.lbl_identificador.Text = "Identificador:";
			// 
			// frm_nova_conexao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(391, 334);
			this.Controls.Add(this.gpb_hidrometro);
			this.Controls.Add(this.gpb_nova_conexao);
			this.Controls.Add(this.lbl_memch2);
			this.Controls.Add(this.lbl_memch);
			this.Controls.Add(this.btn_sair_cadastro);
			this.Controls.Add(this.btn_cadastrar_novo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frm_nova_conexao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MEMCH - NOVA CONEXÃO";
			this.gpb_nova_conexao.ResumeLayout(false);
			this.gpb_nova_conexao.PerformLayout();
			this.gpb_hidrometro.ResumeLayout(false);
			this.gpb_hidrometro.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_nova_conexao;
        private System.Windows.Forms.Label lbl_descricao_conexao;
        private System.Windows.Forms.Label lbl_ativo_conexao;
        private System.Windows.Forms.TextBox txb_chave_conexao;
        private System.Windows.Forms.Label lbl_chave_conexao;
        private System.Windows.Forms.Button btn_cadastrar_novo;
        private System.Windows.Forms.Button btn_sair_cadastro;
        private System.Windows.Forms.TextBox txb_host_conexao;
        private System.Windows.Forms.Label lbl_host_conexao;
        private System.Windows.Forms.Label lbl_memch2;
        private System.Windows.Forms.Label lbl_memch;
        private System.Windows.Forms.CheckBox ckb_conexao_ativa;
        private System.Windows.Forms.TextBox txb_descricao_conexao;
		private System.Windows.Forms.GroupBox gpb_hidrometro;
		private System.Windows.Forms.TextBox txb_descricao_hidrometro;
		private System.Windows.Forms.Label lbl_descricao;
		private System.Windows.Forms.TextBox txb_modelo_hidrometro;
		private System.Windows.Forms.Label lbl_modelo;
		private System.Windows.Forms.TextBox txb_identificador_hidrometro;
		private System.Windows.Forms.Label lbl_identificador;
		private System.Windows.Forms.CheckBox ckb_hidrometro_ativo;
		private System.Windows.Forms.Label lbl_ativo;
	}
}