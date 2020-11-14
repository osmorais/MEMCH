using PFC_V1.Controle;
using PFC_V1.Operador;
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
        private void btn_atualizar_usuario_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrWhiteSpace(txb_nome_usuario.Text)) txb_nome_usuario.Text = "Usuario";
			if (!string.IsNullOrWhiteSpace(txb_login_usuario.Text) &&
                !string.IsNullOrWhiteSpace(txb_senha_acesso.Text) &&
				!string.IsNullOrWhiteSpace(txb_email.Text) &&
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
					usuario.email = txb_email.Text;

					usuario.senha = SHA.GenerateSHA512String(usuario.senha);

					IOperadorREST op = new OperadorJson();
					CtrlUsuario controle = new CtrlUsuario();
					Conexao conexao = new Conexao()
					{
						host = "10.1.1.3"
					};

					usuario = controle.alterar<Usuario>(usuario, op, conexao);

					MessageBox.Show("Alteração realizada com Sucesso!");

					Close();
                }
            }
        }
        private void btn_sair_formulario_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void frm_atualizar_usuario_Load(object sender, EventArgs e)
		{
			txb_nome_usuario.Text = this.usuario.pessoa.nome;
			txb_cpf_usuario.Text = this.usuario.pessoa.cpf;
			txb_login_usuario.Text = this.usuario.login;
			txb_email.Text = this.usuario.email;
		}
	}
}
