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
			this.dgwRegras = new System.Windows.Forms.DataGridView();
			this.btn_deletar_regra = new System.Windows.Forms.Button();
			this.btn_editar_regra = new System.Windows.Forms.Button();
			this.btn_nova_regra = new System.Windows.Forms.Button();
			this.btn_sair_dashboard = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwRegras)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwRegras
			// 
			this.dgwRegras.AllowUserToAddRows = false;
			this.dgwRegras.AllowUserToDeleteRows = false;
			this.dgwRegras.AllowUserToResizeColumns = false;
			this.dgwRegras.AllowUserToResizeRows = false;
			this.dgwRegras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwRegras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwRegras.Cursor = System.Windows.Forms.Cursors.Cross;
			this.dgwRegras.Location = new System.Drawing.Point(9, 53);
			this.dgwRegras.Margin = new System.Windows.Forms.Padding(2);
			this.dgwRegras.MultiSelect = false;
			this.dgwRegras.Name = "dgwRegras";
			this.dgwRegras.ReadOnly = true;
			this.dgwRegras.RowHeadersVisible = false;
			this.dgwRegras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgwRegras.RowTemplate.Height = 24;
			this.dgwRegras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwRegras.Size = new System.Drawing.Size(578, 341);
			this.dgwRegras.TabIndex = 5;
			// 
			// btn_deletar_regra
			// 
			this.btn_deletar_regra.Location = new System.Drawing.Point(501, 11);
			this.btn_deletar_regra.Margin = new System.Windows.Forms.Padding(2);
			this.btn_deletar_regra.Name = "btn_deletar_regra";
			this.btn_deletar_regra.Size = new System.Drawing.Size(86, 25);
			this.btn_deletar_regra.TabIndex = 8;
			this.btn_deletar_regra.Text = "Deletar";
			this.btn_deletar_regra.UseVisualStyleBackColor = true;
			// 
			// btn_editar_regra
			// 
			this.btn_editar_regra.Location = new System.Drawing.Point(255, 11);
			this.btn_editar_regra.Margin = new System.Windows.Forms.Padding(2);
			this.btn_editar_regra.Name = "btn_editar_regra";
			this.btn_editar_regra.Size = new System.Drawing.Size(86, 25);
			this.btn_editar_regra.TabIndex = 7;
			this.btn_editar_regra.Text = "Editar";
			this.btn_editar_regra.UseVisualStyleBackColor = true;
			this.btn_editar_regra.Click += new System.EventHandler(this.btn_editar_regra_Click);
			// 
			// btn_nova_regra
			// 
			this.btn_nova_regra.Location = new System.Drawing.Point(9, 11);
			this.btn_nova_regra.Margin = new System.Windows.Forms.Padding(2);
			this.btn_nova_regra.Name = "btn_nova_regra";
			this.btn_nova_regra.Size = new System.Drawing.Size(86, 25);
			this.btn_nova_regra.TabIndex = 6;
			this.btn_nova_regra.Text = "Novo";
			this.btn_nova_regra.UseVisualStyleBackColor = true;
			// 
			// btn_sair_dashboard
			// 
			this.btn_sair_dashboard.Location = new System.Drawing.Point(501, 398);
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
			this.ClientSize = new System.Drawing.Size(598, 434);
			this.Controls.Add(this.btn_sair_dashboard);
			this.Controls.Add(this.btn_deletar_regra);
			this.Controls.Add(this.btn_editar_regra);
			this.Controls.Add(this.btn_nova_regra);
			this.Controls.Add(this.dgwRegras);
			this.Name = "frm_regras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_regras";
			this.Load += new System.EventHandler(this.frm_regras_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwRegras)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwRegras;
		private System.Windows.Forms.Button btn_deletar_regra;
		private System.Windows.Forms.Button btn_editar_regra;
		private System.Windows.Forms.Button btn_nova_regra;
		private System.Windows.Forms.Button btn_sair_dashboard;
	}
}