namespace PFC_V1.Visao
{
    partial class frm_atualizar_conexao
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
			this.ckb_ativo_conexao = new System.Windows.Forms.CheckBox();
			this.lbl_descricao_conexao = new System.Windows.Forms.Label();
			this.lbl_ativo_conexao = new System.Windows.Forms.Label();
			this.txb_chave_conexao = new System.Windows.Forms.TextBox();
			this.lbl_chave_conexao = new System.Windows.Forms.Label();
			this.btn_cadastrar_novo = new System.Windows.Forms.Button();
			this.btn_sair_cadastro = new System.Windows.Forms.Button();
			this.txb_host_conexao = new System.Windows.Forms.TextBox();
			this.lbl_host_conexao = new System.Windows.Forms.Label();
			this.lbl_memch2 = new System.Windows.Forms.Label();
			this.lbl_memch = new System.Windows.Forms.Label();
			this.gpb_nova_conexao.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpb_nova_conexao
			// 
			this.gpb_nova_conexao.Controls.Add(this.txb_descricao_conexao);
			this.gpb_nova_conexao.Controls.Add(this.ckb_ativo_conexao);
			this.gpb_nova_conexao.Controls.Add(this.lbl_descricao_conexao);
			this.gpb_nova_conexao.Controls.Add(this.lbl_ativo_conexao);
			this.gpb_nova_conexao.Controls.Add(this.txb_chave_conexao);
			this.gpb_nova_conexao.Controls.Add(this.lbl_chave_conexao);
			this.gpb_nova_conexao.Controls.Add(this.btn_cadastrar_novo);
			this.gpb_nova_conexao.Controls.Add(this.btn_sair_cadastro);
			this.gpb_nova_conexao.Controls.Add(this.txb_host_conexao);
			this.gpb_nova_conexao.Controls.Add(this.lbl_host_conexao);
			this.gpb_nova_conexao.Location = new System.Drawing.Point(6, 55);
			this.gpb_nova_conexao.Margin = new System.Windows.Forms.Padding(2);
			this.gpb_nova_conexao.Name = "gpb_nova_conexao";
			this.gpb_nova_conexao.Padding = new System.Windows.Forms.Padding(2);
			this.gpb_nova_conexao.Size = new System.Drawing.Size(286, 193);
			this.gpb_nova_conexao.TabIndex = 24;
			this.gpb_nova_conexao.TabStop = false;
			this.gpb_nova_conexao.Text = "Atualização de Conexão";
			// 
			// txb_descricao_conexao
			// 
			this.txb_descricao_conexao.BackColor = System.Drawing.SystemColors.Control;
			this.txb_descricao_conexao.Location = new System.Drawing.Point(8, 126);
			this.txb_descricao_conexao.Margin = new System.Windows.Forms.Padding(2);
			this.txb_descricao_conexao.Name = "txb_descricao_conexao";
			this.txb_descricao_conexao.Size = new System.Drawing.Size(270, 20);
			this.txb_descricao_conexao.TabIndex = 26;
			this.txb_descricao_conexao.TextChanged += new System.EventHandler(this.txb_descricao_conexao_TextChanged);
			// 
			// ckb_ativo_conexao
			// 
			this.ckb_ativo_conexao.AutoSize = true;
			this.ckb_ativo_conexao.Location = new System.Drawing.Point(147, 41);
			this.ckb_ativo_conexao.Margin = new System.Windows.Forms.Padding(2);
			this.ckb_ativo_conexao.Name = "ckb_ativo_conexao";
			this.ckb_ativo_conexao.Size = new System.Drawing.Size(50, 17);
			this.ckb_ativo_conexao.TabIndex = 24;
			this.ckb_ativo_conexao.Text = "Ativo";
			this.ckb_ativo_conexao.UseVisualStyleBackColor = true;
			this.ckb_ativo_conexao.CheckedChanged += new System.EventHandler(this.ckb_ativo_conexao_CheckedChanged);
			// 
			// lbl_descricao_conexao
			// 
			this.lbl_descricao_conexao.AutoSize = true;
			this.lbl_descricao_conexao.Location = new System.Drawing.Point(6, 110);
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
			this.txb_chave_conexao.TextChanged += new System.EventHandler(this.txb_chave_conexao_TextChanged);
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
			// btn_cadastrar_novo
			// 
			this.btn_cadastrar_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
			this.btn_cadastrar_novo.Location = new System.Drawing.Point(222, 159);
			this.btn_cadastrar_novo.Margin = new System.Windows.Forms.Padding(2);
			this.btn_cadastrar_novo.Name = "btn_cadastrar_novo";
			this.btn_cadastrar_novo.Size = new System.Drawing.Size(58, 26);
			this.btn_cadastrar_novo.TabIndex = 11;
			this.btn_cadastrar_novo.Text = "Atualizar";
			this.btn_cadastrar_novo.UseVisualStyleBackColor = true;
			this.btn_cadastrar_novo.Click += new System.EventHandler(this.btn_atualizar_conexao_Click);
			// 
			// btn_sair_cadastro
			// 
			this.btn_sair_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
			this.btn_sair_cadastro.Location = new System.Drawing.Point(5, 159);
			this.btn_sair_cadastro.Margin = new System.Windows.Forms.Padding(2);
			this.btn_sair_cadastro.Name = "btn_sair_cadastro";
			this.btn_sair_cadastro.Size = new System.Drawing.Size(58, 26);
			this.btn_sair_cadastro.TabIndex = 10;
			this.btn_sair_cadastro.Text = "Sair";
			this.btn_sair_cadastro.UseVisualStyleBackColor = true;
			this.btn_sair_cadastro.Click += new System.EventHandler(this.btn_sair_cadastro_Click);
			// 
			// txb_host_conexao
			// 
			this.txb_host_conexao.Location = new System.Drawing.Point(8, 41);
			this.txb_host_conexao.Margin = new System.Windows.Forms.Padding(2);
			this.txb_host_conexao.Name = "txb_host_conexao";
			this.txb_host_conexao.Size = new System.Drawing.Size(133, 20);
			this.txb_host_conexao.TabIndex = 3;
			this.txb_host_conexao.TextChanged += new System.EventHandler(this.txb_host_conexao_TextChanged);
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
			// lbl_memch2
			// 
			this.lbl_memch2.AutoSize = true;
			this.lbl_memch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
			this.lbl_memch2.Location = new System.Drawing.Point(47, 30);
			this.lbl_memch2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_memch2.Name = "lbl_memch2";
			this.lbl_memch2.Size = new System.Drawing.Size(203, 7);
			this.lbl_memch2.TabIndex = 23;
			this.lbl_memch2.Text = "Monitoramento de Estado de Metragem Cúbica de Hidrômetro";
			this.lbl_memch2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl_memch
			// 
			this.lbl_memch.AutoSize = true;
			this.lbl_memch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl_memch.Location = new System.Drawing.Point(111, 10);
			this.lbl_memch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_memch.Name = "lbl_memch";
			this.lbl_memch.Size = new System.Drawing.Size(69, 20);
			this.lbl_memch.TabIndex = 22;
			this.lbl_memch.Text = "MEMCH";
			this.lbl_memch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frm_atualizar_conexao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(297, 251);
			this.Controls.Add(this.gpb_nova_conexao);
			this.Controls.Add(this.lbl_memch2);
			this.Controls.Add(this.lbl_memch);
			this.Name = "frm_atualizar_conexao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MEMCH - ATUALIZAR CONEXÃO";
			this.Load += new System.EventHandler(this.frm_atualizar_conexao_Load);
			this.gpb_nova_conexao.ResumeLayout(false);
			this.gpb_nova_conexao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_nova_conexao;
        private System.Windows.Forms.TextBox txb_descricao_conexao;
        private System.Windows.Forms.CheckBox ckb_ativo_conexao;
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
    }
}