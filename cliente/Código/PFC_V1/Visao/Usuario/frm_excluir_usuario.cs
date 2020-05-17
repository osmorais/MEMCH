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
    public partial class frm_excluir_usuario : Form
    {
        private Usuario usuario;
        public frm_excluir_usuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void frm_excluir_usuario_Load(object sender, EventArgs e)
        {
            iniciarCampos();
        }
        private void btn_excluir_usuario_Click(object sender, EventArgs e)
        {
            frm_confirmar_acao formulario = new frm_confirmar_acao(usuario.senha);
            DialogResult = formulario.ShowDialog();
            Close();
        }
        private void btn_sair_formulario_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void iniciarCampos()
        {
            txb_nome_usuario.Text = usuario.pessoa.nome;
            txb_cpf_usuario.Text = usuario.pessoa.cpf;
            txb_login_usuario.Text = usuario.login;
        }
    }
}
