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
            if (
                !string.IsNullOrWhiteSpace(txb_nome_usuario.Text) &&
                !string.IsNullOrWhiteSpace(txb_login_usuario.Text) &&
                !string.IsNullOrWhiteSpace(txb_senha_acesso.Text) &&
                txb_senha_acesso.Text == txb_confirmar_senha.Text)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = txb_nome_usuario.Text;
                pessoa.cpf = txb_cpf_usuario.Text;

                Usuario usuario = new Usuario();
                usuario.pessoa = pessoa;
                usuario.senha = txb_senha_acesso.Text;
                usuario.login = txb_login_usuario.Text;

                usuario.senha = SHA.GenerateSHA512String(usuario.senha);

                ControleInterno controle = new ControleInterno();
                controle.criarUsuario(usuario);

                MessageBox.Show("Cadastro realizado com Sucesso!");
                Close();
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
