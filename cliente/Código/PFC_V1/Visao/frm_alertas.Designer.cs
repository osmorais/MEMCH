namespace PFC_V1.Visao
{
	partial class frm_alertas
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
			this.dgvAlerta = new System.Windows.Forms.DataGridView();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.lblAlertas = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvAlerta)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAlerta
			// 
			this.dgvAlerta.AllowUserToAddRows = false;
			this.dgvAlerta.AllowUserToDeleteRows = false;
			this.dgvAlerta.AllowUserToResizeColumns = false;
			this.dgvAlerta.AllowUserToResizeRows = false;
			this.dgvAlerta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAlerta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAlerta.Cursor = System.Windows.Forms.Cursors.Cross;
			this.dgvAlerta.Location = new System.Drawing.Point(15, 43);
			this.dgvAlerta.Margin = new System.Windows.Forms.Padding(2);
			this.dgvAlerta.MultiSelect = false;
			this.dgvAlerta.Name = "dgvAlerta";
			this.dgvAlerta.ReadOnly = true;
			this.dgvAlerta.RowHeadersVisible = false;
			this.dgvAlerta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvAlerta.RowTemplate.Height = 24;
			this.dgvAlerta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAlerta.Size = new System.Drawing.Size(356, 125);
			this.dgvAlerta.TabIndex = 8;
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(296, 173);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(75, 23);
			this.btnVoltar.TabIndex = 7;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// lblAlertas
			// 
			this.lblAlertas.AutoSize = true;
			this.lblAlertas.Location = new System.Drawing.Point(11, 11);
			this.lblAlertas.Name = "lblAlertas";
			this.lblAlertas.Size = new System.Drawing.Size(75, 13);
			this.lblAlertas.TabIndex = 6;
			this.lblAlertas.Text = "Log de Alertas";
			// 
			// frm_alertas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 206);
			this.Controls.Add(this.dgvAlerta);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.lblAlertas);
			this.Name = "frm_alertas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_alertas";
			this.Load += new System.EventHandler(this.frm_alertas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAlerta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAlerta;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Label lblAlertas;
	}
}