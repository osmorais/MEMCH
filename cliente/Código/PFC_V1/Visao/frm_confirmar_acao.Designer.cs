namespace PFC_V1.Visao
{
    partial class frm_confirmar_acao
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
			this.lbl_memch2 = new System.Windows.Forms.Label();
			this.lbl_memch = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txb_senha_confirmacao = new System.Windows.Forms.TextBox();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_confirmar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_memch2
			// 
			this.lbl_memch2.AutoSize = true;
			this.lbl_memch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
			this.lbl_memch2.Location = new System.Drawing.Point(13, 29);
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
			this.lbl_memch.Location = new System.Drawing.Point(78, 9);
			this.lbl_memch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_memch.Name = "lbl_memch";
			this.lbl_memch.Size = new System.Drawing.Size(69, 20);
			this.lbl_memch.TabIndex = 8;
			this.lbl_memch.Text = "MEMCH";
			this.lbl_memch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Deseja confirmar a ação?";
			// 
			// txb_senha_confirmacao
			// 
			this.txb_senha_confirmacao.Location = new System.Drawing.Point(62, 70);
			this.txb_senha_confirmacao.Name = "txb_senha_confirmacao";
			this.txb_senha_confirmacao.Size = new System.Drawing.Size(100, 20);
			this.txb_senha_confirmacao.TabIndex = 11;
			this.txb_senha_confirmacao.UseSystemPasswordChar = true;
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.btn_cancelar.Location = new System.Drawing.Point(118, 96);
			this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(58, 26);
			this.btn_cancelar.TabIndex = 13;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_confirmar
			// 
			this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
			this.btn_confirmar.Location = new System.Drawing.Point(51, 96);
			this.btn_confirmar.Margin = new System.Windows.Forms.Padding(2);
			this.btn_confirmar.Name = "btn_confirmar";
			this.btn_confirmar.Size = new System.Drawing.Size(63, 26);
			this.btn_confirmar.TabIndex = 12;
			this.btn_confirmar.Text = "Confirmar";
			this.btn_confirmar.UseVisualStyleBackColor = true;
			this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
			// 
			// frm_confirmar_acao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(229, 135);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_confirmar);
			this.Controls.Add(this.txb_senha_confirmacao);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_memch2);
			this.Controls.Add(this.lbl_memch);
			this.Name = "frm_confirmar_acao";
			this.Text = "MEMCH - CONFIRMAR AÇÃO";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_memch2;
        private System.Windows.Forms.Label lbl_memch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_senha_confirmacao;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
    }
}