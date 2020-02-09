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
    public partial class frm_atualizar_usuario : Form
    {
        private Usuario usuario;
        public frm_atualizar_usuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void frm_atualizar_pessoa_Load(object sender, EventArgs e)
        {
            iniciarCampos();
        }
        private void btn_atualizar_usuario_Click(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrWhiteSpace(txb_nome_usuario.Text) &&
                !string.IsNullOrWhiteSpace(txb_login_usuario.Text) &&
                !string.IsNullOrWhiteSpace(txb_senha_acesso.Text) &&
                txb_senha_acesso.Text == txb_confirmar_senha.Text)
            {
                frm_confirmar_acao formulario = new frm_confirmar_acao(usuario.senha);
                DialogResult resultado = formulario.ShowDialog();

                if(resultado == DialogResult.OK)
                {
                    usuario.pessoa.nome = txb_nome_usuario.Text;
                    usuario.pessoa.cpf = txb_cpf_usuario.Text;
                    usuario.login = txb_login_usuario.Text;
                    usuario.senha = txb_senha_acesso.Text;

                    usuario.senha = SHA.GenerateSHA512String(usuario.senha);

                    Close();
                }
            }
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
