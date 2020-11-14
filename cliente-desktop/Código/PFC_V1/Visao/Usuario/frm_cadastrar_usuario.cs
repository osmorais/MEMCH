using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using PFC_V1.Controle;
using PFC_V1.DAO;
using PFC_V1.Operador;
using PFC_V1.Util;

namespace PFC_V1
{
    public partial class frm_cadastrar : Form
    {
        public frm_cadastrar()
        {
            InitializeComponent();
        }
        private void btn_cadastrar_novo_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrWhiteSpace(txb_nome_usuario.Text)) txb_nome_usuario.Text = "Usuario";
			if (!string.IsNullOrWhiteSpace(txb_login_usuario.Text) &&
                !string.IsNullOrWhiteSpace(txb_senha_acesso.Text) &&
				!string.IsNullOrWhiteSpace(txb_email.Text) &&
				txb_senha_acesso.Text == txb_confirmar_senha.Text)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = txb_nome_usuario.Text;
                pessoa.cpf = txb_cpf_usuario.Text;

                Usuario usuario = new Usuario();
                usuario.pessoa = pessoa;
                usuario.senha = txb_senha_acesso.Text;
                usuario.login = txb_login_usuario.Text;
				usuario.email = txb_email.Text;

                usuario.senha = SHA.GenerateSHA512String(usuario.senha);
				try
				{
					//ControleInterno controle = new ControleInterno();
					//controle.criarUsuario(usuario);

					IOperadorREST op = new OperadorJson();
					CtrlUsuario controle = new CtrlUsuario();
					Conexao conexao = new Conexao()
					{
						host = "10.1.1.3"
					};

					usuario = controle.cadastrar<Usuario>(usuario, op, conexao);

					MessageBox.Show("Cadastro realizado com Sucesso!");
					Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
            }
            else
            {
                MessageBox.Show("Por favor, tente novamente!");
            }
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
	}
}
