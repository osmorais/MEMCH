using PFC_V1.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC_V1.Visao
{
    public partial class frm_confirmar_acao : Form
    {
        private string senha;
        public frm_confirmar_acao(string senha)
        {
            InitializeComponent();
            this.senha = senha;
        }
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string inserida = SHA.GenerateSHA512String(txb_senha_confirmacao.Text);

            if(inserida == senha)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Senha incorreta!");
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
