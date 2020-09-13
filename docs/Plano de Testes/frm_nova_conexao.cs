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

namespace PFC_V1
{
    public partial class frm_nova_conexao : Form
    {
        private Conexao conexao = new Conexao();
		private Usuario usuario;
        public frm_nova_conexao(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }
        private void btn_sair_cadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_cadastrar_novo_Click(object sender, EventArgs e)
        {
			conexao.host = txb_host_conexao.Text;
			conexao.chave = txb_chave_conexao.Text;
			conexao.descricao = txb_descricao_conexao.Text;
			conexao.ativo = ckb_ativo_conexao.Checked;

			if (!String.IsNullOrEmpty(conexao.host) || !String.IsNullOrEmpty(conexao.chave) ||
				!String.IsNullOrEmpty(conexao.descricao))
			{
				if (usuario.conexoes == null) usuario.conexoes = new List<Conexao>();
				usuario.conexoes.Add(conexao);

				ControleInterno controle = new ControleInterno();

				controle.atualizarConexoes(ref usuario);

				MessageBox.Show("Nova conexao adicionada com Sucesso!!!");
			}
			else {
				throw new System.InvalidOperationException("Necessário preencimento de todos os campos.");
			}
            Close();
        }
    }
}
