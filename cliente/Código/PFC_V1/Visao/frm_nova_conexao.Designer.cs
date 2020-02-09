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
            this.ckb_ativo_conexao = new System.Windows.Forms.CheckBox();
            this.txb_descricao_conexao = new System.Windows.Forms.TextBox();
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
            this.gpb_nova_conexao.Location = new System.Drawing.Point(6, 65);
            this.gpb_nova_conexao.Name = "gpb_nova_conexao";
            this.gpb_nova_conexao.Size = new System.Drawing.Size(382, 237);
            this.gpb_nova_conexao.TabIndex = 21;
            this.gpb_nova_conexao.TabStop = false;
            this.gpb_nova_conexao.Text = "Cadastro de nova Conexão";
            // 
            // lbl_descricao_conexao
            // 
            this.lbl_descricao_conexao.AutoSize = true;
            this.lbl_descricao_conexao.Location = new System.Drawing.Point(8, 135);
            this.lbl_descricao_conexao.Name = "lbl_descricao_conexao";
            this.lbl_descricao_conexao.Size = new System.Drawing.Size(114, 17);
            this.lbl_descricao_conexao.TabIndex = 16;
            this.lbl_descricao_conexao.Text = "Breve descrição:";
            // 
            // lbl_ativo_conexao
            // 
            this.lbl_ativo_conexao.AutoSize = true;
            this.lbl_ativo_conexao.Location = new System.Drawing.Point(193, 30);
            this.lbl_ativo_conexao.Name = "lbl_ativo_conexao";
            this.lbl_ativo_conexao.Size = new System.Drawing.Size(43, 17);
            this.lbl_ativo_conexao.TabIndex = 14;
            this.lbl_ativo_conexao.Text = "Ativo:";
            // 
            // txb_chave_conexao
            // 
            this.txb_chave_conexao.Location = new System.Drawing.Point(11, 98);
            this.txb_chave_conexao.Name = "txb_chave_conexao";
            this.txb_chave_conexao.Size = new System.Drawing.Size(176, 22);
            this.txb_chave_conexao.TabIndex = 13;
            // 
            // lbl_chave_conexao
            // 
            this.lbl_chave_conexao.AutoSize = true;
            this.lbl_chave_conexao.Location = new System.Drawing.Point(8, 78);
            this.lbl_chave_conexao.Name = "lbl_chave_conexao";
            this.lbl_chave_conexao.Size = new System.Drawing.Size(52, 17);
            this.lbl_chave_conexao.TabIndex = 12;
            this.lbl_chave_conexao.Text = "Chave:";
            // 
            // btn_cadastrar_novo
            // 
            this.btn_cadastrar_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_cadastrar_novo.Location = new System.Drawing.Point(11, 194);
            this.btn_cadastrar_novo.Name = "btn_cadastrar_novo";
            this.btn_cadastrar_novo.Size = new System.Drawing.Size(78, 32);
            this.btn_cadastrar_novo.TabIndex = 11;
            this.btn_cadastrar_novo.Text = "Cadastrar";
            this.btn_cadastrar_novo.UseVisualStyleBackColor = true;
            this.btn_cadastrar_novo.Click += new System.EventHandler(this.btn_cadastrar_novo_Click);
            // 
            // btn_sair_cadastro
            // 
            this.btn_sair_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_sair_cadastro.Location = new System.Drawing.Point(291, 194);
            this.btn_sair_cadastro.Name = "btn_sair_cadastro";
            this.btn_sair_cadastro.Size = new System.Drawing.Size(78, 32);
            this.btn_sair_cadastro.TabIndex = 10;
            this.btn_sair_cadastro.Text = "Sair";
            this.btn_sair_cadastro.UseVisualStyleBackColor = true;
            this.btn_sair_cadastro.Click += new System.EventHandler(this.btn_sair_cadastro_Click);
            // 
            // txb_host_conexao
            // 
            this.txb_host_conexao.Location = new System.Drawing.Point(11, 50);
            this.txb_host_conexao.Name = "txb_host_conexao";
            this.txb_host_conexao.Size = new System.Drawing.Size(176, 22);
            this.txb_host_conexao.TabIndex = 3;
            // 
            // lbl_host_conexao
            // 
            this.lbl_host_conexao.AutoSize = true;
            this.lbl_host_conexao.Location = new System.Drawing.Point(8, 30);
            this.lbl_host_conexao.Name = "lbl_host_conexao";
            this.lbl_host_conexao.Size = new System.Drawing.Size(41, 17);
            this.lbl_host_conexao.TabIndex = 2;
            this.lbl_host_conexao.Text = "Host:";
            // 
            // lbl_memch2
            // 
            this.lbl_memch2.AutoSize = true;
            this.lbl_memch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.lbl_memch2.Location = new System.Drawing.Point(70, 32);
            this.lbl_memch2.Name = "lbl_memch2";
            this.lbl_memch2.Size = new System.Drawing.Size(259, 12);
            this.lbl_memch2.TabIndex = 20;
            this.lbl_memch2.Text = "Monitoramento de Estado de Metragem Cúbica de Hidrômetro";
            this.lbl_memch2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_memch
            // 
            this.lbl_memch.AutoSize = true;
            this.lbl_memch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_memch.Location = new System.Drawing.Point(155, 7);
            this.lbl_memch.Name = "lbl_memch";
            this.lbl_memch.Size = new System.Drawing.Size(88, 25);
            this.lbl_memch.TabIndex = 19;
            this.lbl_memch.Text = "MEMCH";
            this.lbl_memch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckb_ativo_conexao
            // 
            this.ckb_ativo_conexao.AutoSize = true;
            this.ckb_ativo_conexao.Location = new System.Drawing.Point(196, 51);
            this.ckb_ativo_conexao.Name = "ckb_ativo_conexao";
            this.ckb_ativo_conexao.Size = new System.Drawing.Size(61, 21);
            this.ckb_ativo_conexao.TabIndex = 24;
            this.ckb_ativo_conexao.Text = "Ativo";
            this.ckb_ativo_conexao.UseVisualStyleBackColor = true;
            // 
            // txb_descricao_conexao
            // 
            this.txb_descricao_conexao.BackColor = System.Drawing.SystemColors.Control;
            this.txb_descricao_conexao.Location = new System.Drawing.Point(11, 155);
            this.txb_descricao_conexao.Name = "txb_descricao_conexao";
            this.txb_descricao_conexao.Size = new System.Drawing.Size(358, 22);
            this.txb_descricao_conexao.TabIndex = 26;
            // 
            // frm_nova_conexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(396, 309);
            this.Controls.Add(this.gpb_nova_conexao);
            this.Controls.Add(this.lbl_memch2);
            this.Controls.Add(this.lbl_memch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_nova_conexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEMCH - NOVA CONEXÃO";
            this.gpb_nova_conexao.ResumeLayout(false);
            this.gpb_nova_conexao.PerformLayout();
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
        private System.Windows.Forms.CheckBox ckb_ativo_conexao;
        private System.Windows.Forms.TextBox txb_descricao_conexao;
    }
}