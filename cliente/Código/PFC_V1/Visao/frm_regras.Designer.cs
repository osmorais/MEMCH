namespace PFC_V1.Visao
{
	partial class frm_regras
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
			this.dgwConexao = new System.Windows.Forms.DataGridView();
			this.btn_deletar_hidro = new System.Windows.Forms.Button();
			this.btn_editar_hidro = new System.Windows.Forms.Button();
			this.btn_nova_conexao = new System.Windows.Forms.Button();
			this.btn_sair_dashboard = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwConexao)).BeginInit();
			this.SuspendLayout();
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
			this.dgwConexao.Location = new System.Drawing.Point(9, 53);
			this.dgwConexao.Margin = new System.Windows.Forms.Padding(2);
			this.dgwConexao.MultiSelect = false;
			this.dgwConexao.Name = "dgwConexao";
			this.dgwConexao.ReadOnly = true;
			this.dgwConexao.RowHeadersVisible = false;
			this.dgwConexao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgwConexao.RowTemplate.Height = 24;
			this.dgwConexao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwConexao.Size = new System.Drawing.Size(356, 125);
			this.dgwConexao.TabIndex = 5;
			// 
			// btn_deletar_hidro
			// 
			this.btn_deletar_hidro.Location = new System.Drawing.Point(279, 11);
			this.btn_deletar_hidro.Margin = new System.Windows.Forms.Padding(2);
			this.btn_deletar_hidro.Name = "btn_deletar_hidro";
			this.btn_deletar_hidro.Size = new System.Drawing.Size(86, 25);
			this.btn_deletar_hidro.TabIndex = 8;
			this.btn_deletar_hidro.Text = "Deletar";
			this.btn_deletar_hidro.UseVisualStyleBackColor = true;
			// 
			// btn_editar_hidro
			// 
			this.btn_editar_hidro.Location = new System.Drawing.Point(144, 11);
			this.btn_editar_hidro.Margin = new System.Windows.Forms.Padding(2);
			this.btn_editar_hidro.Name = "btn_editar_hidro";
			this.btn_editar_hidro.Size = new System.Drawing.Size(86, 25);
			this.btn_editar_hidro.TabIndex = 7;
			this.btn_editar_hidro.Text = "Editar";
			this.btn_editar_hidro.UseVisualStyleBackColor = true;
			// 
			// btn_nova_conexao
			// 
			this.btn_nova_conexao.Location = new System.Drawing.Point(9, 11);
			this.btn_nova_conexao.Margin = new System.Windows.Forms.Padding(2);
			this.btn_nova_conexao.Name = "btn_nova_conexao";
			this.btn_nova_conexao.Size = new System.Drawing.Size(86, 25);
			this.btn_nova_conexao.TabIndex = 6;
			this.btn_nova_conexao.Text = "Novo";
			this.btn_nova_conexao.UseVisualStyleBackColor = true;
			// 
			// btn_sair_dashboard
			// 
			this.btn_sair_dashboard.Location = new System.Drawing.Point(279, 194);
			this.btn_sair_dashboard.Margin = new System.Windows.Forms.Padding(2);
			this.btn_sair_dashboard.Name = "btn_sair_dashboard";
			this.btn_sair_dashboard.Size = new System.Drawing.Size(86, 25);
			this.btn_sair_dashboard.TabIndex = 9;
			this.btn_sair_dashboard.Text = "Sair";
			this.btn_sair_dashboard.UseVisualStyleBackColor = true;
			this.btn_sair_dashboard.Click += new System.EventHandler(this.btn_sair_dashboard_Click);
			// 
			// frm_regras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(374, 230);
			this.Controls.Add(this.btn_sair_dashboard);
			this.Controls.Add(this.btn_deletar_hidro);
			this.Controls.Add(this.btn_editar_hidro);
			this.Controls.Add(this.btn_nova_conexao);
			this.Controls.Add(this.dgwConexao);
			this.Name = "frm_regras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_regras";
			this.Load += new System.EventHandler(this.frm_regras_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwConexao)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwConexao;
		private System.Windows.Forms.Button btn_deletar_hidro;
		private System.Windows.Forms.Button btn_editar_hidro;
		private System.Windows.Forms.Button btn_nova_conexao;
		private System.Windows.Forms.Button btn_sair_dashboard;
	}
}