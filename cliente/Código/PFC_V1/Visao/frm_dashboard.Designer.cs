namespace PFC_V1
{
    partial class frm_dashboard
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
            this.btn_nova_conexao = new System.Windows.Forms.Button();
            this.btn_editar_hidro = new System.Windows.Forms.Button();
            this.btn_deletar_hidro = new System.Windows.Forms.Button();
            this.dgwConexao = new System.Windows.Forms.DataGridView();
            this.btn_acessar_dashboard = new System.Windows.Forms.Button();
            this.btn_sair_dashboard = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_alterar_usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_excluir_usuario = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConexao)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_nova_conexao
            // 
            this.btn_nova_conexao.Location = new System.Drawing.Point(9, 36);
            this.btn_nova_conexao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nova_conexao.Name = "btn_nova_conexao";
            this.btn_nova_conexao.Size = new System.Drawing.Size(86, 25);
            this.btn_nova_conexao.TabIndex = 1;
            this.btn_nova_conexao.Text = "Novo";
            this.btn_nova_conexao.UseVisualStyleBackColor = true;
            this.btn_nova_conexao.Click += new System.EventHandler(this.btn_nova_conexao_Click);
            // 
            // btn_editar_hidro
            // 
            this.btn_editar_hidro.Location = new System.Drawing.Point(144, 36);
            this.btn_editar_hidro.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editar_hidro.Name = "btn_editar_hidro";
            this.btn_editar_hidro.Size = new System.Drawing.Size(86, 25);
            this.btn_editar_hidro.TabIndex = 2;
            this.btn_editar_hidro.Text = "Editar";
            this.btn_editar_hidro.UseVisualStyleBackColor = true;
            this.btn_editar_hidro.Click += new System.EventHandler(this.btn_editar_conexao_Click);
            // 
            // btn_deletar_hidro
            // 
            this.btn_deletar_hidro.Location = new System.Drawing.Point(279, 36);
            this.btn_deletar_hidro.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deletar_hidro.Name = "btn_deletar_hidro";
            this.btn_deletar_hidro.Size = new System.Drawing.Size(86, 25);
            this.btn_deletar_hidro.TabIndex = 3;
            this.btn_deletar_hidro.Text = "Deletar";
            this.btn_deletar_hidro.UseVisualStyleBackColor = true;
            this.btn_deletar_hidro.Click += new System.EventHandler(this.btn_deletar_conexao_Click);
            // 
            // dgwConexao
            // 
            this.dgwConexao.AllowUserToAddRows = false;
            this.dgwConexao.AllowUserToDeleteRows = false;
            this.dgwConexao.AllowUserToResizeColumns = false;
            this.dgwConexao.AllowUserToResizeRows = false;
            this.dgwConexao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwConexao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwConexao.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dgwConexao.Location = new System.Drawing.Point(9, 65);
            this.dgwConexao.Margin = new System.Windows.Forms.Padding(2);
            this.dgwConexao.MultiSelect = false;
            this.dgwConexao.Name = "dgwConexao";
            this.dgwConexao.ReadOnly = true;
            this.dgwConexao.RowHeadersVisible = false;
            this.dgwConexao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwConexao.RowTemplate.Height = 24;
            this.dgwConexao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwConexao.Size = new System.Drawing.Size(356, 125);
            this.dgwConexao.TabIndex = 4;
            // 
            // btn_acessar_dashboard
            // 
            this.btn_acessar_dashboard.Location = new System.Drawing.Point(9, 197);
            this.btn_acessar_dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_acessar_dashboard.Name = "btn_acessar_dashboard";
            this.btn_acessar_dashboard.Size = new System.Drawing.Size(86, 25);
            this.btn_acessar_dashboard.TabIndex = 5;
            this.btn_acessar_dashboard.Text = "Acessar";
            this.btn_acessar_dashboard.UseVisualStyleBackColor = true;
            this.btn_acessar_dashboard.Click += new System.EventHandler(this.btn_acessar_registros_Click);
            // 
            // btn_sair_dashboard
            // 
            this.btn_sair_dashboard.Location = new System.Drawing.Point(279, 197);
            this.btn_sair_dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sair_dashboard.Name = "btn_sair_dashboard";
            this.btn_sair_dashboard.Size = new System.Drawing.Size(86, 25);
            this.btn_sair_dashboard.TabIndex = 6;
            this.btn_sair_dashboard.Text = "Sair";
            this.btn_sair_dashboard.UseVisualStyleBackColor = true;
            this.btn_sair_dashboard.Click += new System.EventHandler(this.btn_sair_dashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_alterar_usuario,
            this.tsm_excluir_usuario});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "Usuario";
            // 
            // tsm_alterar_usuario
            // 
            this.tsm_alterar_usuario.Name = "tsm_alterar_usuario";
            this.tsm_alterar_usuario.Size = new System.Drawing.Size(157, 22);
            this.tsm_alterar_usuario.Text = "Alterar cadastro";
            this.tsm_alterar_usuario.Click += new System.EventHandler(this.tsm_alterar_usuario_Click);
            // 
            // tsm_excluir_usuario
            // 
            this.tsm_excluir_usuario.Name = "tsm_excluir_usuario";
            this.tsm_excluir_usuario.Size = new System.Drawing.Size(157, 22);
            this.tsm_excluir_usuario.Text = "Excluir cadastro";
            this.tsm_excluir_usuario.Click += new System.EventHandler(this.tsm_excluir_usuario_Click);
            // 
            // frm_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(374, 230);
            this.Controls.Add(this.btn_sair_dashboard);
            this.Controls.Add(this.btn_acessar_dashboard);
            this.Controls.Add(this.dgwConexao);
            this.Controls.Add(this.btn_deletar_hidro);
            this.Controls.Add(this.btn_editar_hidro);
            this.Controls.Add(this.btn_nova_conexao);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEMCH - ";
            this.Load += new System.EventHandler(this.frm_dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwConexao)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_nova_conexao;
        private System.Windows.Forms.Button btn_editar_hidro;
        private System.Windows.Forms.Button btn_deletar_hidro;
        private System.Windows.Forms.DataGridView dgwConexao;
        private System.Windows.Forms.Button btn_acessar_dashboard;
        private System.Windows.Forms.Button btn_sair_dashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsm_alterar_usuario;
        private System.Windows.Forms.ToolStripMenuItem tsm_excluir_usuario;
    }
}